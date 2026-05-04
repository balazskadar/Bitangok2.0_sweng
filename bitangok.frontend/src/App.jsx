import { useState } from 'react';
import './App.css';

function App() {
    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const [battleResult, setBattleResult] = useState(null);
    const [loading, setLoading] = useState(false);

    // Ez a függvény hívja meg a korábban megírt .NET API-t
    const startBattle = async () => {
        setLoading(true);
        try {
            // Itt a te API címedet használjuk (localhost:7221)
            const response = await fetch('https://localhost:7221/api/battle/quick-battle?p1Name=Leó&p2Name=Gandalf');
            if (!response.ok) throw new Error('API hiba');

            const data = await response.json();
            setBattleResult(data);
        } catch (error) {
            console.error("Hiba a harc során:", error);
            alert("Nem sikerült elérni a backendet! Fut az API?");
        } finally {
            setLoading(false);
        }
    };

    // 1. BEJELENTKEZŐ OLDAL
    if (!isLoggedIn) {
        return (
            <div className="login-screen">
                <div className="login-card">
                    <h1 className="medieval-font">Bejelentkezés</h1>
                    <div className="input-group">
                        <label>FELHASZNÁLÓNÉV:</label>
                        <input type="text" />
                    </div>
                    <div className="input-group">
                        <label>JELSZÓ:</label>
                        <input type="password" />
                    </div>
                    <button className="login-btn" onClick={() => setIsLoggedIn(true)}>
                        BEJELENTKEZÉS
                    </button>
                </div>
            </div>
        );
    }

    // 2. ARÉNA OLDAL (Harc)
    return (
        <div className="arena-screen">
            <div className="arena-content">
                <h1 className="medieval-font">A Bitangok Arénája</h1>

                <button
                    className="fight-btn"
                    onClick={startBattle}
                    disabled={loading}
                >
                    {loading ? 'Harc folyamatban...' : 'INDULJON A HARC!'}
                </button>

                {battleResult && (
                    <div className="scroll-container">
                        <div className="battle-paper">
                            <h2 className="winner-text">Győztes: {battleResult.winner}</h2>
                            <div className="log-list">
                                {battleResult.battleLog.map((line, index) => (
                                    <p key={index} className="log-line">{line}</p>
                                ))}
                            </div>
                        </div>
                    </div>
                )}
            </div>
        </div>
    );
}

export default App;
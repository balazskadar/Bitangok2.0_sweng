# Bitangok Arénája (The Arena of Rogues) - Szoftvertechnológia Projekt

## Projekt Áttekintés
Egy körökre osztott, automatikus harci szimulátor webes felülettel. A játékosok összeállítják és felszerelik karaktereiket, majd a backend motor a "Sors Kockája" (RNG) segítségével lejátssza a küzdelmet.

## Technikai Stack és Architektúra Terv

### Teljes Architektúra Áttekintés


A projekt egy modern, rétegelt webalkalmazás architektúrát követ, ahol a Frontend és a Backend élesen elkülönül.

---

### 1. Frontend (Megjelenítési Réteg)

* **Technológia:** **React** (TypeScripttel).
* **Feladata:** Egy Single Page Application (SPA), ahol a felhasználó interakcióba lép a játékkal.
* **Főbb Komponensek:**
    * **Aréna Nézet:** Megjeleníti a folyamatban lévő csatát.
    * **Karakter Készítő:** Felület a hősök összeállítására (pl. faj, osztály).
    * **Felszerelés Bolt:** A Decorator mintával megvalósított tárgyak ráadása a karakterre.
* **Kommunikáció:** REST API hívásokon keresztül (JSON formátumban) kommunikál a backenddel.

---

### 2. Backend (Logikai Réteg)

* **Technológia:** **ASP.NET Core Web API** (.NET 8).
* **Feladata:** Fogadja a frontend kéréseit, futtatja a játéklogikát és kezeli az adatbázist.

#### Belső Rétegek:

* **API Kontrollerek:** Kezelik a HTTP kéréseket (pl. `POST /api/battle/start`).
* **Core Logika (`Bitangok.Core`):** Ez a motor. Itt valósulnak meg a kért szoftvertechnológiai minták:
    * **Factory:** Karakterek (Warrior, Mage) létrehozása.
    * **Decorator:** Felszerelések (Kard, Pajzs) ráaggatása a karakterre (Open/Closed Principle).
    * **Strategy:** Harci stílusok futásidejű cseréje (pl. agresszív -> védekező).
    * **Observer:** Eseményvezérelt harci napló készítése.

---

### 3. Adatbázis (Adatkezelési Réteg)

* **Technológia:** **SQLite** (a féléves projekt egyszerűsége miatt).
* **ORM:** **Entity Framework Core (EF Core)**.
    * Az EF Core segítségével C# osztályokból (Code-First) generáljuk az adatbázis sémát, így elkerülve az SQL kód írását.
* **Mit tárolunk:**
    * Mentett karakterek (név, osztály, felszerelés).
    * Csata naplók (Battle Logs) és statisztikák.

---

## SOLID és Tiszta Kód Elvek

* **Separation of Concerns:** A frontend és backend különválasztása, valamint a logikai és API rétegek elkülönítése a backendben.
* **Open/Closed Principle:** A Decorator minta biztosítja, hogy új fegyvereket adhassunk hozzá a `BaseCharacter` osztály módosítása nélkül.
* **Dependency Injection:** Az interfészek használata (pl. `IRandomGenerator`) biztosítja a laza csatolást és a tesztelhetőséget.

---

## Fejlesztési Lépések (Roadmap)

1.  **Backend Alapok:** A `Bitangok.Core` logikájának (minták) befejezése.
2.  **Adatbázis Integráció:** EF Core és SQLite beállítása.
3.  **API Réteg:** REST végpontok kialakítása.
4.  **Frontend Alapok:** React projekt létrehozása.
5.  **Összekötés:** A React frontend és .NET Web API kommunikációjának megvalósítása.
6.  **CI/CD:** Automatizált build és test pipeline beállítása GitHub Actions-szel.

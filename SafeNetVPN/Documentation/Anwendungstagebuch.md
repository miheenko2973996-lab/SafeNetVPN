# Anwendungstagebuch – SafeNetVPN

## Projektname

SafeNetVPN

## Projektart

.NET MAUI Anwendung mit C#

## Ziel des Anwendungstagebuchs

Das Anwendungstagebuch dokumentiert die Entwicklungsschritte des Projekts SafeNetVPN. Es zeigt, welche Aufgaben durchgeführt wurden, welche Probleme aufgetreten sind und welche Lösungen gefunden wurden.

---

## Eintrag 1 – Projektidee und Thema festlegen

**Datum:** 18.05.2026  
**Aufgabe:** Projektidee auswählen und Projektziel definieren.

**Beschreibung:**  
Als Projekt wurde eine VPN-App mit dem Namen SafeNetVPN ausgewählt. Die App soll eine VPN-Verbindung aus Benutzersicht darstellen. Da eine echte VPN-Entwicklung sehr komplex ist, wurde entschieden, eine Simulation zu entwickeln.

**Ergebnis:**  
Das Projektziel wurde festgelegt: SafeNetVPN soll eine benutzerfreundliche App werden, mit der man eine VPN-Verbindung simuliert starten und beenden kann.

**Probleme:**  
Am Anfang war unklar, ob eine echte VPN-Verbindung umgesetzt werden soll.

**Lösung:**  
Nach Analyse des Projektumfangs wurde entschieden, eine Simulation zu erstellen.

---

## Eintrag 2 – Entwicklungsumgebung vorbereiten

**Datum:** 18.05.2026  
**Aufgabe:** Visual Studio vorbereiten und Projekt erstellen.

**Beschreibung:**  
Visual Studio wurde geöffnet und ein neues Projekt wurde erstellt. Als Technologie wurde .NET MAUI gewählt, damit die Anwendung modern aufgebaut werden kann.

**Ergebnis:**  
Das Projekt SafeNetVPN wurde erfolgreich in Visual Studio erstellt.

**Probleme:**  
Das MAUI-Template war am Anfang nicht direkt sichtbar.

**Lösung:**  
Die vorhandenen Projektvorlagen wurden geprüft. Danach wurde ein passendes .NET MAUI Projekt erstellt.

---

## Eintrag 3 – Projektstruktur ansehen

**Datum:** 18.05.2026  
**Aufgabe:** Projektordner und Dateien analysieren.

**Beschreibung:**  
Die automatisch erstellte Projektstruktur wurde angeschaut. Im Projekt befinden sich unter anderem die Ordner Data, Models, Pages, Services, Resources und Platforms.

**Ergebnis:**  
Die Grundstruktur des Projekts wurde verstanden.

**Wichtige Ordner:**

| Ordner        | Bedeutung                            |
|---------------|--------------------------------------|
| Models        | Datenklassen der App                 |
| Pages         | Benutzeroberflächen der App          |
| Services      | Logik und Funktionen der App         |
| Resources     | Bilder, Styles und andere Ressourcen |
| Platforms     | Plattformabhängige Dateien           |
| Documentation | Eigene Projektdokumentation          |

**Probleme:**  
Es war unklar, wo Dokumentationsdateien gespeichert werden sollen.

**Lösung:**  
Es wurde entschieden, einen neuen Ordner Documentation zu erstellen.

---

## Eintrag 4 – Dokumentationsordner erstellen

**Datum:** 19.05.2026  
**Aufgabe:** Ordner für Projektdokumentation erstellen.

**Beschreibung:**  
Im Projekt wurde ein neuer Ordner mit dem Namen Documentation erstellt. Dieser Ordner wird für Dokumentationsdateien verwendet.

**Ergebnis:**  
Die Dokumentation wird sauber vom Programmcode getrennt.

**Erstellte Struktur:**

```text
SafeNetVPN
└── Documentation
    ├── Anforderungsanalyse.md
    └── Anwendungstagebuch.md
```

** Probleme:**
Es gab keine Probleme bei der Erstellung des Ordners.

**Lösung:** 
Keine Lösung nötig, da keine Probleme aufgetreten sind.

---

## Eintrag 5 – Anforderungsanalyse erstellen

**Datum:** 19.05.2026  
**Aufgabe:** Anforderungen der App dokumentieren.

**Beschreibung:**  
Für SafeNetVPN wurde eine Anforderungsanalyse erstellt. Darin wurden funktionale und nicht-funktionale Anforderungen beschrieben.

**Ergebnis:**  
Die wichtigsten Funktionen der App wurden festgelegt.
Die Anforderungsanalyse ist in der Datei Anforderungsanalyse.md im Ordner Documentation zu finden.

**Probleme:**
Es musste entschieden werden, welche Funktionen wirklich wichtig sind.

**Lösung:**  
Die Anforderungen wurden nach Wichtigkeit sortiert.

---

## Eintrag 6 - Use Case Beschreibung erstellen.

**Datum:** 19.05.2026

**Aufgabe:** Use Case beschreiben.

**Beschreibung:**
Ein Use Case wurde erstellt, um die Interaktion eines Benutzers mit der App zu beschreiben. Use Case hat 3 Optionen: VPN-Verbindung starten, VPN-Verbindung trennen und Serverstandort auswählen.

**Ergebnis:**
Der Use Case 1 "VPN starten", Use Case 2 "VPN trennen" und Use Case 3 "Serverstandort auswählen" wurden beschrieben und als den Teil der Datei Anforderungsanalyse.md im Ordner Documentation gespeichert.

**Probleme:**
Es musste entschieden werden, welche Funktionen einfacher für Nutzer sind.

**Lösung:**
Die Funktionen wurden nach Benutzerfreundlichkeit bewertet und priorisiert.

---

## Eintrag 7 - Priorisierung nach MoSCoW

**Datum:** 19.05.2026

**Aufgabe:** Anforderungen priorisieren.

**Beschreibung:**
Die Anforderungen wurden nach der MoSCoW-Methode priorisiert. dadurch wurde festgelegt, welche Funktionen unbedingt umgesetzt werden müssen, welche Funktionen wünschenswert sind und welche Funktionen optional sind.

**Ergebnis:**
Die Anforderungen wurden in Muss, Sollte und Kann kategorisiert. Die Priorisierung ist in der Datei Anforderungsanalyse.md im Ordner Documentation zu finden.

**Probleme:**
Einige Funktionen wirkten am Anfang wichtig, waren aber eigentlich nur Zusatzfunktionen.

**Lösung:**
Die Funktionen wurden realistisch nach Projektumfang und Benutzerfreundlichkeit bewertet und entsprechend priorisiert.

---

## Eintrag 8 - Projektumfang abgrenzen

**Datum:** 19.05.2026

**Aufgabe:** Festlegen, was nicht Teil des Projekts ist.

**Beschreibung:**
Es wurde dokumentiert, dass SafeNetVPN keine echte VPN-Software wird. Das Projekt konzentriert sich auf die Simulation.

**Ergebnis:**
Der Projektumfang ist klar abgrenzt.
Nicht Teil des Projekts:
- Echter VPN-Tunnel
- Echte Verschlüsselung des Netzwerkverkehrs
- Eigener VPN-Server
- Änderung der echten öffentlichen IP-Adresse
- Eingriff in Netzwerkadapter

**Probleme:**
Eine echte VPN-App wäre technisch sehr anspruchvoll.

**Lösung:**
Die Simulation wurde als sinnvolle und realistische Lösung gewahlt.

---

## Eintrag 9 - Benutzeroberfläche

**Datum:** 20.05.2026

**Aufgabe:** Erste Ideen für die Benutzeroberfläche sammeln.

**Beschreibung:**
Es wurden erste Skizzen für die Benutzeroberfläche erstellt. Die App soll eine einfache Startseite mit einem Button zum Verbinden und Trennen der VPN-Verbindung haben. Außerdem soll es eine Seite für die Serverstandort-Auswahl geben.

**Ergebnis:**

Die wichtigsten Elemente der Benutzeroberfläche wurden geplant und in der Anforderungsanalyse.md im Ordner Documentation dokumentiert.

**Probleme:**
Die Oberfläche darf nicht zu überladen wirken.

**Lösung:**
Es wird ein einfaches desing mit klaren Anzeigen verwendet.

---



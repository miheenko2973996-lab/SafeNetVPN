# Anforderungsanalyse – SafeNetVPN

## 1. Projektbeschreibung

SafeNetVPN ist eine Anwendung, die die Grundidee einer VPN-App demonstriert. Die App soll zeigen, wie eine VPN-Verbindung aus Benutzersicht funktioniert. Dazu gehören das Starten und Beenden einer Verbindung, die Anzeige des aktuellen Verbindungsstatus und die Auswahl eines Serverstandorts.

Im Rahmen dieses Projekts wird keine vollständige echte VPN-Software entwickelt. Stattdessen wird eine realistische Simulation erstellt, da eine echte VPN-Implementierung sehr komplex ist und Kenntnisse über Netzwerkadapter, Verschlüsselung, Tunnelprotokolle und Serverinfrastruktur benötigt.

## 2. Ziel des Projekts

Ziel des Projekts ist die Entwicklung einer benutzerfreundlichen App, mit der ein Benutzer eine VPN-Verbindung simuliert starten und beenden kann. Die App soll außerdem anzeigen, ob der Benutzer geschützt oder nicht geschützt ist.

Zusätzlich soll der Benutzer einen Serverstandort auswählen können. Nach dem Verbinden soll eine simulierte IP-Adresse angezeigt werden.

## 3. Zielgruppe

Die Zielgruppe der App sind Benutzer, die eine einfache VPN-Oberfläche kennenlernen möchten. Außerdem richtet sich das Projekt an Lehrer, Prüfer und Mitschüler, die die Funktionen der App nachvollziehen und bewerten sollen.

## 4. Stakeholder

| Stakeholder    | Interesse                                                     |
|----------------|---------------------------------------------------------------|
|Entwicklerteam  | Erfolgreiche Umsetzung der App                                |
| Lehrer         | Bewertung von Planung, Umsetzung und Dokumentation            |

## 5. Funktionale Anforderungen

| Nr. | Anforderung                    | Beschreibung                                                  | Priorität |
|-----|--------------------------------|---------------------------------------------------------------|-----------|
| F1  | VPN-Verbindung starten         | Der Benutzer kann eine VPN-Verbindung simuliert starten.      | Muss      |
| F2  | VPN-Verbindung beenden         | Der Benutzer kann die Verbindung wieder trennen.              | Muss      |
| F3  | Status anzeigen                | Die App zeigt „Verbunden“ oder „Nicht verbunden“ an.          | Muss      |
| F4  | Server auswählen               | Der Benutzer kann einen Serverstandort auswählen.             | Muss      |
| F5  | Ausgewählten Server anzeigen   | Die App zeigt den aktuellen Serverstandort an.                | Sollte    |
| F6  | Simulierte IP-Adresse anzeigen | Nach dem Verbinden wird eine simulierte IP-Adresse angezeigt. | Sollte    |
| F7  | Verbindungszeit anzeigen       | Die App zeigt an, wie lange die Verbindung aktiv ist.         | Sollte    |
| F8  | Sicherheitsstatus anzeigen     | Die App zeigt „Geschützt“ oder „Nicht geschützt“ an.          | Sollte    |
| F9  | Einstellungsseite öffnen       | Der Benutzer kann eine einfache Einstellungsseite öffnen.     | Kann      |
| F10 | Benutzeroberfläche anzeigen    | Die App besitzt eine einfache und verständliche Oberfläche.   | Muss      |

## 6. Nicht-funktionale Anforderungen

| Nr. | Anforderung            | Beschreibung                                                         | Priorität |
|-----|------------------------|----------------------------------------------------------------------|-----------|
| NF1 | Benutzerfreundlichkeit | Die App soll einfach und verständlich zu bedienen sein.              | Muss      |
| NF2 | Übersichtliches Design | Wichtige Informationen sollen sofort sichtbar sein.                  | Muss      |
| NF3 | Stabilität             | Die App soll nicht abstürzen, wenn Buttons mehrfach geklickt werden. | Muss      |
| NF4 | Performance            | Die App soll schnell starten und flüssig reagieren.                  | Sollte    |
| NF5 | Erweiterbarkeit        | Die App soll später um weitere Funktionen erweitert werden können.   | Sollte    |
| NF6 | Sicherheit             | Es werden keine echten sensiblen Benutzerdaten gespeichert.          | Muss      |
| NF7 | Plattform              | Die App soll mit .NET MAUI entwickelt werden.                        | Muss      |
| NF8 | Wartbarkeit            | Der Code soll übersichtlich in passende Ordner aufgeteilt werden.    | Sollte    |

## 7. Systemanforderungen

| Bereich              | Anforderung                              |
|----------------------|------------------------------------------|
| Entwicklungsumgebung | Visual Studio                            |
| Programmiersprache   | C#                                       |
| Framework            | .NET MAUI                                |
| Zielplattform        | Windows und optional Android             |
| Dokumentation        | Markdown-Dateien im Ordner Documentation |
| Projektname          | SafeNetVPN                               |

## 8. Abgrenzung

SafeNetVPN ist keine vollständige echte VPN-Software.

Nicht umgesetzt werden:

| Nicht Teil des Projekts                     | Begründung                            |
|---------------------------------------------|---------------------------------------|
| Echter VPN-Tunnel                           | Zu komplex für den Projektumfang      |
| Echte Verschlüsselung des Netzwerkverkehrs  | Benötigt tiefe Netzwerkprogrammierung |
| Eigener VPN-Server                          | Zu hoher Aufwand                      |
| Änderung der echten öffentlichen IP-Adresse | Für die Simulation nicht notwendig    |
| Eingriff in Netzwerkadapter                 | Technisch riskant und komplex         |

Stattdessen wird eine Simulation umgesetzt, die den Ablauf einer VPN-App realistisch darstellt.

## 9. Use Cases

### Use Case 1: VPN verbinden

**Akteur:** Benutzer  
**Ziel:** Der Benutzer möchte eine sichere Verbindung aktivieren.

**Ablauf:**

1. Der Benutzer öffnet die App.
2. Der Benutzer wählt einen Serverstandort aus.
3. Der Benutzer klickt auf „Verbinden“.
4. Die App zeigt den Status „Verbunden“.
5. Die App zeigt den Sicherheitsstatus „Geschützt“.
6. Die App zeigt eine simulierte IP-Adresse.

**Ergebnis:**  
Die VPN-Verbindung wird simuliert und als aktiv angezeigt.

### Use Case 2: VPN trennen

**Akteur:** Benutzer  
**Ziel:** Der Benutzer möchte die Verbindung beenden.

**Ablauf:**

1. Der Benutzer klickt auf „Trennen“.
2. Die App beendet die Simulation.
3. Die App zeigt den Status „Nicht verbunden“.
4. Die App zeigt den Sicherheitsstatus „Nicht geschützt“.

**Ergebnis:**  
Die simulierte VPN-Verbindung ist beendet.

### Use Case 3: Server auswählen

**Akteur:** Benutzer  
**Ziel:** Der Benutzer möchte einen VPN-Serverstandort auswählen.

**Ablauf:**

1. Der Benutzer öffnet die Serverauswahl.
2. Der Benutzer wählt einen Standort aus.
3. Die App speichert die Auswahl.
4. Der ausgewählte Server wird angezeigt.

**Ergebnis:**  
Der gewählte Server wird für die nächste Verbindung verwendet.

## 10. Benutzeroberfläche

Die Benutzeroberfläche soll folgende Elemente enthalten:

| Element | Funktion |
|---|---|
| App-Name | Anzeige von „SafeNetVPN“ |
| Statusanzeige | Zeigt verbunden oder nicht verbunden |
| Verbinden-Button | Startet die VPN-Simulation |
| Trennen-Button | Beendet die VPN-Simulation |
| Serverauswahl | Auswahl eines Serverstandorts |
| IP-Anzeige | Anzeige einer simulierten IP-Adresse |
| Sicherheitsmeldung | Anzeige des Schutzstatus |
| Timer | Anzeige der Verbindungsdauer |

## 11. Priorisierung nach MoSCoW

### Must-have

- App starten
- VPN-Simulation starten
- VPN-Simulation beenden
- Status anzeigen
- Server auswählen
- Einfache Benutzeroberfläche

### Should-have

- Simulierte IP-Adresse anzeigen
- Sicherheitsstatus anzeigen
- Verbindungsdauer anzeigen
- Mehrere Serverstandorte anbieten

### Could-have

- Einstellungsseite
- Dark Mode
- Verbindungsverlauf
- Animation beim Verbinden

### Won’t-have

- Echter VPN-Tunnel
- Eigene VPN-Server
- Echte Verschlüsselung des Internetverkehrs
- Änderung der echten öffentlichen IP-Adresse

## 12. Risiken

| Risiko                          | Beschreibung                                    | Gegenmaßnahme                          |
|---------------------------------|-------------------------------------------------|----------------------------------------|
| Projekt wird zu komplex         | Echte VPN-Technik ist schwierig                 | Simulation verwenden                   |
| Zeit reicht nicht               | Zu viele Funktionen geplant                     | Must-have zuerst umsetzen              |
| Technische Probleme             | MAUI oder Visual Studio kann Fehler verursachen | Kleine Schritte testen                 |
| App-Design wird unübersichtlich | Zu viele Informationen auf einer Seite          | Einfaches Layout verwenden             |
| Anforderungen ändern sich       | Neue Wünsche während der Entwicklung            | Dokumentation regelmäßig aktualisieren |

## 13. Erfolgskriterien

Das Projekt gilt als erfolgreich, wenn:

- die App gestartet werden kann,
- der Benutzer einen Server auswählen kann,
- der Benutzer eine VPN-Verbindung simuliert starten kann,
- der Benutzer die Verbindung wieder trennen kann,
- der Status korrekt angezeigt wird,
- die Oberfläche verständlich ist,
- die Dokumentation die wichtigsten Anforderungen beschreibt.

## 14. Fazit

SafeNetVPN ist eine simulierte VPN-App, die den grundlegenden Ablauf einer VPN-Verbindung verständlich darstellt. Der Schwerpunkt liegt auf Benutzeroberfläche, Statusanzeige, Serverauswahl und einer realistischen Simulation.

Die Entscheidung für eine Simulation ist sinnvoll, da eine echte VPN-Entwicklung deutlich komplexer ist und den Rahmen des Projekts überschreiten würde.
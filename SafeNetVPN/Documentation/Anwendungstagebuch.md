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

## Eintrag 10 - UserCaseDiagramm

**Datum:** 21.05.2026 

**Aufgabe:** UserCaseDiagramm erstellen.

**Beschreibung:** Usercase zeigt die Interaktion eines Benutzers mit der App. Es gibt 3 Use Cases: VPN-Verbindung starten, VPN-Verbindung trennen und Serverstandort auswählen.

**Ergebnis:** Das UseCaseDiagramm wurde erstellt und im Ordner Documentation gespeichert.

**Probleme:** Es war unklar, wie die Interaktion genau aussehen soll.

**Lösung:** Es wurden einfache Use Cases definiert, die die wichtigsten Funktionen der App abdecken.

---

## Eintrag 11 - AktivitätenDiagramm

**Datum:** 21.05.2026

**Aufgabe:** AktivitätenDiagramm erstellen.

**Beschreibung:** Das AktivitätenDiagramm zeigt den Ablauf der VPN-Verbindung. Es beginnt mit dem Starten der App, dann kann der Benutzer die VPN-Verbindung starten oder trennen und den Serverstandort auswählen.

**Ergebnis:** Das AktivitätenDiagramm wurde erstellt und im Ordner Documentation gespeichert.

**Probleme:** Es war unklar, wie die Abläufe genau aussehen sollen. 

**Lösung:** Es wurden einfache Abläufe definiert, die die wichtigsten Funktionen der App abdecken.  

---

## Eintrag 12 - Klassendiagramm

**Datum:** 21.05.2026

**Aufgabe:** Klassendiagramm erstellen.

**Beschreibung:** Das Klassendiagramm zeigt die wichtigsten Klassen der App. Es gibt eine MainWindow-Klasse für die Benutzeroberfläche, eine VPNService-Klasse für die Logik der VPN-Verbindung, Settings-Klasse für App-Einstellungen,ConnectionStatus-Klasse und eine ServerLocation-Klasse für die Serverstandorte.

**Ergebnis:** Das Klassendiagramm wurde erstellt und im Ordner Documentation gespeichert.

**Probleme:** Es war unklar, welche Klassen genau benötigt werden.

**Lösung:** Es wurden die wichtigsten Klassen definiert, die für die Umsetzung der App notwendig sind.

---

## Eintrag 13 - Mockup der Benutzeroberfläche

**Datum:** 22.05.2026

**Aufgabe:** Mockup der Benutzeroberfläche erstellen.

**Beschreibung:** Es wurde ein Mockup der Benutzeroberfläche erstellt. Das Mockup zeigt die Zugangseite,Startseite,Connectionseite und Einstellungsseite.

**Ergebnis:** Das Mockup wurde erstellt und im Ordner Documentation gespeichert.

**Probleme:** Es war unklar, wie viel die Benutzeroberfläche ich möchte erstellen.

**Lösung:** Es wurde entschieden, ein einfaches Mockup zu erstellen, das die wichtigsten Elemente der Benutzeroberfläche zeigt.

---

## Eintrag 14 - Die Benutzeroberflächen umsetzen

**Datum:** 26.052026

**Aufgabe:** Die Benutzeroberflächen: Login, Main, Server, Einstellungen umsetzen.

**Beschreibung:** Es wurden die Benutzeroberflächen für die Loginseite, Mainseite, Serverseite und Einstellungsseite umgesetzt. Die Seiten wurden mit Buttons, Labels Grids anderen Steuerelementen gestaltet.

**Ergebnis:** Die Benutzeroberflächen wurden erfolgreich umgesetzt. Die Seiten sind in der Pages-Ordner zu finden.

**Probleme:** Es war unklar, wie die Seiten genau aussehen sollen.

**Lösung:** Es wurde entschieden, die Seiten einfach und übersichtlich zu gestalten, damit sie benutzerfreundlich sind.

---

## Eintrag 15 – Programmierung der Benutzeroberfläche

**Datum:** 27.05.2026 - 28.05.2026

**Aufgabe:** Die Benutzeroberflächen der App weiter programmieren und Funktionen hinzufügen.

**Beschreibung:**  
Heute wurden wichtige Teile der SafeNetVPN-App programmiert. Die Startseite wurde mit Logik erweitert: Der Button „Verbinden“ ändert den Status, die Farbe des Kreises, die IP-Adresse und den Verbindungstext. Außerdem wurde die Navigation zwischen Anmeldung, Startseite und Einstellungen umgesetzt.

Auf der Einstellungsseite wurde der Standardserver gespeichert. Wenn der Benutzer später auf der Startseite den Button „Server“ drückt, wird der gespeicherte Standardserver geladen.

**Wichtige Entscheidung:**  
Die separate ServerPage wurde nicht mehr weiter benutzt, weil die Serverauswahl bereits auf der Startseite funktioniert. Dadurch ist die App einfacher und übersichtlicher. Die ServerPage wurde aus der Navigation entfernt.

**Probleme:**  
Es gab mehrere Fehler durch alte Template-Dateien und alte Projektbestandteile. Diese Dateien wurden aus dem Projekt ausgeschlossen oder bereinigt.

**Lösung:**  
Die App wurde vereinfacht. Es bleiben nur die wichtigen Seiten: Anmeldung, Startseite und Einstellungen.

**Ergebnis:**  
Die App funktioniert jetzt besser. Der Benutzer kann sich anmelden, den VPN-Status ändern, einen Server auswählen und einen Standardserver speichern.

---

## Eintrag 16 – Verbesserung der Benutzerfreundlichkeit

**Datum:** 29.05.2026

**Aufgabe:** Funktionen für Wartezeit, Meldungen und Warnsymbol hinzufügen.

**Beschreibung:**  
Heute wurden weitere Verbesserungen in die SafeNetVPN-App eingebaut. Beim Verbinden und Trennen wurde eine kurze Wartezeit ergänzt, damit der Vorgang realistischer wirkt und der Benutzer besser versteht, dass die App gerade arbeitet.

Außerdem wurden Meldungen hinzugefügt. Wenn der Benutzer während einer aktiven Verbindung einen anderen Server auswählen möchte, bekommt er eine klare Nachricht. Die App zeigt dann, dass zuerst die alte Verbindung getrennt werden muss, bevor ein neuer Server gewählt werden kann.

Zusätzlich wurde ein gelbes Kreuz beziehungsweise Warnsymbol eingebaut. Dieses Symbol macht die Warnung sichtbarer und hilft dem Benutzer, die Situation schneller zu verstehen.

**Probleme:**  
Ohne Meldung war nicht sofort klar, warum der Server während einer aktiven Verbindung nicht direkt gewechselt werden kann.

**Lösung:**  
Es wurden Wartezeiten, Benutzer-Meldungen und ein gelbes Warnsymbol ergänzt. Dadurch bekommt der Benutzer eine bessere Rückmeldung über den aktuellen Zustand der App.

**Ergebnis:**  
Die App ist jetzt verständlicher und benutzerfreundlicher. Der Benutzer sieht klarer, wann die App verbindet oder trennt und warum bei einer aktiven Verbindung zuerst getrennt werden muss.

---

## Eintrag 17 – Testen der App

**Datum:** 01.06.2026

**Aufgabe:** Die wichtigsten Funktionen der SafeNetVPN-App testen und die Ergebnisse beschreiben.

**Beschreibung:**  
Heute wurden die Hauptfunktionen der App getestet. Dazu gehörten der App-Start, die Anmeldung, das Verbinden und Trennen der VPN-Simulation, die Serverauswahl und das Speichern eines Standardservers. Außerdem wurden die neuen Benutzerhinweise mit Wartezeit, Meldungen und gelbem Warnsymbol geprüft.

**Probleme:**  
Es musste geprüft werden, ob der Benutzer während einer aktiven Verbindung den Server wechseln kann. Dabei sollte die App nicht direkt den Server ändern, sondern eine klare Meldung anzeigen.

**Lösung:**  
Für jede wichtige Funktion wurde ein Testfall erstellt. Dabei wurde überprüft, welches Ergebnis erwartet wird und ob die App dieses Ergebnis wirklich zeigt.

**Ergebnis:**  
Alle wichtigen Funktionen wurden erfolgreich getestet. Die App startet korrekt, die Verbindung kann simuliert werden, der Server kann ausgewählt werden und die Einstellungen werden gespeichert. Die Meldung „Trenne zuerst alte Verbindung“ funktioniert ebenfalls. Dadurch ist die App stabiler und verständlicher für den Benutzer.

---

---

## Eintrag 18 – Use-Case-Beschreibung ergänzen

**Datum:** 01.06.2026

**Aufgabe:**  
Die Use Cases der SafeNetVPN-App beschreiben und die Dokumentation ergänzen.

**Beschreibung:**  
Heute wurde die Use-Case-Beschreibung für die SafeNetVPN-App ergänzt. Das Use-Case-Diagramm zeigt bereits, welche Funktionen der Benutzer in der App verwenden kann. Zusätzlich wurden die einzelnen Use Cases schriftlich erklärt, damit die Funktionen besser verständlich sind.

Beschrieben wurden zum Beispiel die Anmeldung, das Verbinden und Trennen der VPN-Simulation, die Serverauswahl, das Speichern eines Standardservers und die Meldung beim Serverwechsel während einer aktiven Verbindung.

**Probleme:**  
Das Use-Case-Diagramm allein zeigt nur kurz die Funktionen. Ohne Beschreibung ist nicht immer klar, wie der genaue Ablauf für den Benutzer ist.

**Lösung:**  
Zu jedem wichtigen Use Case wurde eine kurze Beschreibung erstellt. Dabei wurden der Ablauf und das Ergebnis beschrieben.

**Ergebnis:**  
Die Dokumentation ist jetzt vollständiger. Der Leser kann besser verstehen, welche Funktionen die App hat und wie der Benutzer mit der App arbeitet.

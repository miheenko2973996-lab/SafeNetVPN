# Testprotokoll__SafeNetVPN

## Ziel der Tests

Ziel der Tests war es zu prüfen, ob die wichtigsten Funktionen der SafeNetVPN-App korrekt funktionieren. Dabei wurde besonders auf Anmeldung, Verbindung, Trennung, Serverauswahl, Einstellungen und Benutzer-Meldungen geachtet.

---

## Test 1 – App startet

**Testschritt:**  
Die App wird in Visual Studio mit dem Android-Emulator gestartet.

**Erwartetes Ergebnis:**  
Die App öffnet sich ohne Fehler und zeigt die Login-Seite.

**Tatsächliches Ergebnis:**  
Die App startet erfolgreich und die Login-Seite wird angezeigt.

**Status:** Erfolgreich

---

## Test 2 – Anmeldung

**Testschritt:**  
Der Benutzer gibt Anmeldedaten ein und drückt den Login-Button.

**Erwartetes Ergebnis:**  
Nach dem Login wird die Hauptseite der App geöffnet.

**Tatsächliches Ergebnis:**  
Die Hauptseite wird nach dem Login korrekt angezeigt.

**Status:** Erfolgreich

---

## Test 3 – VPN-Verbindung herstellen

**Testschritt:**  
Auf der Hauptseite wird der Button „Verbinden“ gedrückt.

**Erwartetes Ergebnis:**  
Die App zeigt eine kurze Wartezeit. Danach ändert sich der Status auf „Verbunden“. Die Farbe wechselt auf Grün und Verbindungsdaten werden angezeigt.

**Tatsächliches Ergebnis:**  
Die Verbindung wird simuliert. Der Status, die Farbe und die Daten ändern sich korrekt.

**Status:** Erfolgreich

---

## Test 4 – VPN-Verbindung trennen

**Testschritt:**  
Wenn die App verbunden ist, wird der Button „Trennen“ gedrückt.

**Erwartetes Ergebnis:**  
Die App zeigt eine kurze Wartezeit. Danach ändert sich der Status auf „Nicht verbunden“. Die Verbindungsdaten werden geleert.

**Tatsächliches Ergebnis:**  
Die Verbindung wird korrekt getrennt und die Anzeige wird zurückgesetzt.

**Status:** Erfolgreich

---

## Test 5 – Server auswählen ohne aktive Verbindung

**Testschritt:**  
Der Benutzer ist nicht verbunden und wählt einen anderen Server aus der Serverliste.

**Erwartetes Ergebnis:**  
Der neue Server kann ausgewählt werden.

**Tatsächliches Ergebnis:**  
Der Server wird korrekt übernommen.

**Status:** Erfolgreich

---

## Test 6 – Server wechseln während aktiver Verbindung

**Testschritt:**  
Der Benutzer ist verbunden und versucht, einen anderen Server auszuwählen.

**Erwartetes Ergebnis:**  
Die App erlaubt den Serverwechsel nicht sofort. Es erscheint eine Meldung, dass zuerst die alte Verbindung getrennt werden muss.

**Tatsächliches Ergebnis:**  
Die Meldung „Trenne zuerst alte Verbindung“ wird angezeigt. Zusätzlich erscheint ein gelbes Warnsymbol.

**Status:** Erfolgreich

---

## Test 7 – Standardserver speichern

**Testschritt:**  
Auf der Einstellungsseite wird ein Standardserver ausgewählt und gespeichert.

**Erwartetes Ergebnis:**  
Der gespeicherte Standardserver wird später auf der Hauptseite übernommen.

**Tatsächliches Ergebnis:**  
Der Standardserver wird gespeichert und auf der Hauptseite korrekt angezeigt.

**Status:** Erfolgreich

---

## Test 8 – Benutzerfreundlichkeit prüfen

**Testschritt:**  
Die App wird normal benutzt: anmelden, verbinden, Server prüfen, trennen, Einstellungen ändern.

**Erwartetes Ergebnis:**  
Der Benutzer versteht durch Texte, Farben, Wartezeiten und Meldungen, was gerade passiert.

**Tatsächliches Ergebnis:**  
Die App ist verständlicher geworden. Warnungen und Statusanzeigen helfen dem Benutzer bei der Bedienung.

**Status:** Erfolgreich

---

## Zusammenfassung

Die wichtigsten Funktionen der SafeNetVPN-App wurden getestet. Die Anmeldung, Verbindung, Trennung, Serverauswahl und Einstellungen funktionieren korrekt. Auch die neuen Verbesserungen wie Wartezeit, Meldungen und gelbes Warnsymbol wurden erfolgreich geprüft.

Die App erfüllt damit die geplanten Grundfunktionen einer simulierten VPN-App.
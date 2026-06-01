# Use-Case-Beschreibung – SafeNetVPN

## Akteur

**Benutzer**  
Der Benutzer verwendet die SafeNetVPN-App, um eine VPN-Verbindung zu simulieren, einen Server auszuwählen und Einstellungen zu speichern.

---

## Use Case 1 – Anmelden

**Beschreibung:**  
Der Benutzer startet die App und meldet sich über die Login-Seite an.

**Ablauf:**  
1. Der Benutzer öffnet die App.  
2. Der Benutzer gibt seine Anmeldedaten ein.  
3. Der Benutzer drückt den Login-Button.  
4. Die App öffnet die Hauptseite.

**Ergebnis:**  
Der Benutzer gelangt zur Hauptseite der App.

---

## Use Case 2 – VPN verbinden

**Beschreibung:**  
Der Benutzer stellt eine simulierte VPN-Verbindung her.

**Ablauf:**  
1. Der Benutzer befindet sich auf der Hauptseite.
2. Der Benutzer wählt einen Server aus (optional).
3. Der Benutzer drückt den Button „Verbinden“.  
4. Die App zeigt eine kurze Wartezeit.  
5. Der Status ändert sich auf „Verbunden“.  
6. Die App zeigt IP-Adresse und Verbindungsstatus an.

**Ergebnis:**  
Die VPN-Verbindung wird simuliert und als verbunden angezeigt.

---

## Use Case 3 – VPN trennen

**Beschreibung:**  
Der Benutzer beendet die simulierte VPN-Verbindung.

**Ablauf:**  
1. Der Benutzer ist verbunden.  
2. Der Benutzer drückt den Button „Trennen“.   
3. Der Status ändert sich auf „Nicht verbunden“.  
4. Die Verbindungsdaten werden geleert.

**Ergebnis:**  
Die VPN-Verbindung wird getrennt angezeigt.

---

## Use Case 4 – Server auswählen

**Beschreibung:**  
Der Benutzer wählt einen VPN-Server aus einer Liste aus.

**Ablauf:**  
1. Der Benutzer öffnet die Serverauswahl auf der Hauptseite.  
2. Der Benutzer wählt ein Land beziehungsweise einen Server aus.  
3. Die App übernimmt den ausgewählten Server.

**Ergebnis:**  
Der neue Server ist ausgewählt.

---

## Use Case 5 – Serverwechsel bei aktiver Verbindung

**Beschreibung:**  
Der Benutzer versucht, während einer aktiven Verbindung einen anderen Server auszuwählen.

**Ablauf:**  
1. Der Benutzer ist mit einem Server verbunden.  
2. Der Benutzer wählt einen anderen Server aus.  
3. Die App verhindert den direkten Wechsel.  
4. Die App zeigt eine Meldung: „Trenne zuerst alte Verbindung“.  
5. Ein gelbes Warnsymbol wird angezeigt.

**Ergebnis:**  
Der Benutzer versteht, dass zuerst die Verbindung getrennt werden muss.

---

## Use Case 6 – Standardserver speichern

**Beschreibung:**  
Der Benutzer speichert einen bevorzugten Standardserver in den Einstellungen.

**Ablauf:**  
1. Der Benutzer öffnet die Einstellungsseite.  
2. Der Benutzer wählt einen Standardserver aus.  
3. Der Benutzer drückt „Einstellungen speichern“.  
4. Die App speichert den Standardserver.

**Ergebnis:**  
Der gespeicherte Standardserver wird später auf der Hauptseite verwendet.

---

## Use Case 7 – App bedienen und Status prüfen

**Beschreibung:**  
Der Benutzer sieht jederzeit den aktuellen Status der simulierten VPN-Verbindung.

**Ablauf:**  
1. Der Benutzer öffnet die Hauptseite.  
2. Die App zeigt den aktuellen Status an.  
3. Farben, Texte und Symbole zeigen, ob die App verbunden oder nicht verbunden ist.

**Ergebnis:**  
Der Benutzer erkennt den aktuellen Verbindungsstatus.
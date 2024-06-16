# Projekt-Dokumentation


Gruppe: Müllabfuhr
Mitglieder: Ben Linus Müller, Janick Thomas Hurschler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   10.01.2024    | 0.0.1   | Wir haben den Informieren-Teil abgeschlossen und den Planan-Teil angefangen. |
|   17.01.2024    | 0.1.0    |     Webapplikation ist erstellt und Login-Erstellung im Gange.         |


## 1 Informieren

### 1.1 Ihr Projekt

Eine Webapplikation namens Lachleitung, mitder man untereinander verschlüsselte Nachrichten schreiben kann.

✍️ Erklären Sie genauer in 50 bis 100 Wörtern, was genau Sie in diesem Projekt erreichen möchten, und was Sie dabei zu lernen hoffen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |        Muss         |   Funktional   | Als Benutzer möchte ich mich in der Webapplikation anmelden können, um meine persönlichen Daten zu schützen und auf meine verschlüsselten Nachrichten zugreifen zu können. |
|  2 |        Muss         |   Funktional   |     Als Benutzer möchte ich ein Verschlüsselungsverfahren nutzen, um die Sicherheit meiner Nachrichten zu erhöhen.    |
| 3  |        Muss         |  Funktional    | Als Benutzer möchte ich eine verschlüsselte Textnachricht an eine bestimmte Zieladresse senden können, um vertrauliche Informationen sicher zu übermitteln.  |
|  4 |        Kann         |   Funktional   |    Als Benutzer möchte ich die Möglichkeit haben, verschlüsselte Bilder hochzuladen und an andere Benutzer zu senden, um visuelle Informationen sicher zu teilen.  |
| 5  |      Muss           |  Funktional    | Als Benutzer möchte ich meine verschlüsselten Nachrichten entschlüsseln können, um den Inhalt zu lesen oder anzuzeigen.  |
|  6 |       Kann          |  Qualität   |   Als Benutzer möchte ich eine Liste meiner verschlüsselten Nachrichten und Bilder einsehen können, um den Überblick über meine sicher übermittelten Daten zu behalten.    |
| 7  |         Kann        |   Qualität   |   Als Benutzer möchte ich die Option haben, den Schlüssel für die Verschlüsselung zu ändern, um meine Kommunikation weiter zu schützen.    |
| 8  |  Kann               |  Qualität    |     Als Benutzer möchte ich eine Funktion haben, um meine gesamte Kommunikation zu löschen, um meine Privatsphäre zu wahren und alte Daten zu entfernen.                               |
| 9|Kann |Qualität |Als Benutzer möchte ich, dass meine Nachrichten und Verlauf in einer Datenbank gespeichert werden, um beim nächsten Login alle Daten noch zu haben. |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |    Nicht angemeldet.       |    versuchen, eine Nachricht zu senden.     |        melden Sie sich an, um Nachrichten zu senden und empfangen.           |
| 1.2  |       angemeldet       |    versuchen, eine Nachricht zu senden.     |        Nachricht wird verschickt.           |
| 2.1  |       1.2       |    In der Konsole versuchen, die Nachricht zu lesen     |        unlesbare Nachricht -> Verschlüsselt          |
|  3.1 |       1.2       |    einen Empfänger auswählen. Nachricht schicken.     |       Der Empfänger erhält die Nachricht.       |
| 4.1  |       1.2       |   Bild als Nachricht senden.    |       Der Empfänger erhält das Bild.          |
|  5.1 |       1.2       |   sich selber eine Nachricht schreiben.    |        Nachricht kommt an und kann gelesen werden.        |
|  6.1 |      4.1, 5.1     |    in die Übersicht navigieren.     |       Liste die alle Nachrichten anzeigt.         |
| 7.1 |      1.2      |  In den Einstellungen die Verschlüsselung ändern.  |    Verschlüsselung wurde erfolgreich geändert.|
|  8.1 |      6.1      |   auf Verlauf löschen clicken.    |    alle Nachrichten werden gelöscht.     |
|9.1 |6.1 |Applikation beenden. Applikation öffnen. | alle Daten sind noch vorhanden und einsehbar. |


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

<img width="201" alt="image" src="https://github.com/JaThHu/LA1303---Verschl-sselungsapp/assets/111045598/b4931d23-413e-4765-b68d-3567f3c22d5b">
<img width="285" alt="image" src="https://github.com/JaThHu/LA1303---Verschl-sselungsapp/assets/111045598/6878e2f6-42d2-4c25-be19-0c0109d7e499">
<img width="242" alt="image" src="https://github.com/JaThHu/LA1303---Verschl-sselungsapp/assets/111045598/378cd7df-88da-4108-8425-5f344806a503">
<img width="266" alt="image" src="https://github.com/JaThHu/LA1303---Verschl-sselungsapp/assets/111045598/d1280c7f-d29f-4a08-8219-03f9dae977a8">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   24.01.2024    |     Janick      |     Webapp erstellen und Login implementieren         |        3 * 45 min       |
|  2.A |   24.01.2024    |  Ben         |       Verschlüsselungsverfahren aussuchen und implementieren       |      5 * 45 min         |
| 3.A  |   14.02.2024    |    Ben, Janick       |      Chat-Funktion implementieren        |      5 * 45 min         |
| 4.A  |   21.02.2024    |     Ben, Janick      |       Funktion für Bilder schicken implementieren       |      2 * 45 min         |
|  5.A |    14.02.2024   |     Ben, Janick      |      Entschlüsselungsfunktion        |       5 * 45 min        |
|  6.A |   14.02.2024    |     Ben, Janick      |      Liste von Verlauf        |       3 * 45 min        |
| 7.A  |    14.02.2024   |     Ben, Janick      |      Funktion um Verschlüsselung zu ändern        |      4 * 45 min         |
|  8.A |    14.02.2024   |     Ben, Janick      |       Funktion um Verlauf zu löschen       |        3 * 45 min       |
|  9.A |    14.02.2024   |      Ben, Janick     |       Daten in Datenbank speichern       |       5 * 45 min        |

Total: 35 * 45 min

## 3 Entscheiden

Frontend (Benutzeroberfläche):

Anmeldeseite (optional): Falls Sie eine optionale Anmeldeseite hinzufügen möchten, könnte das Frontend eine Seite zum Anmelden und Erstellen von Benutzerkonten bereitstellen.
Hauptseite: Die Hauptseite sollte Funktionen zum Verfassen, Senden, Empfangen und Entschlüsseln von Nachrichten sowie zum Hochladen und Anzeigen von Bildern bieten.
Einstellungen: Hier können Benutzer ihre Verschlüsselungseinstellungen anpassen, Schlüssel ändern oder Kontakte verwalten.
Backend (Serverseite):

Authentifizierung (optional): Wenn Sie sich für eine Anmeldung entscheiden, benötigen Sie eine Authentifizierungsschicht, die Benutzerkonten verwaltet und Authentifizierungstoken generiert.
Verschlüsselungslogik: Hier wird die eigentliche Verschlüsselungs- und Entschlüsselungslogik implementiert. Sie können Bibliotheken wie OpenSSL oder CryptoJS verwenden.
Datenbank: Falls Sie Nachrichten und Bilder speichern möchten, benötigen Sie eine Datenbank, um diese sicher zu persistieren. Wenn Anonymität wichtig ist, könnte eine dezentrale Datenbank oder eine verschlüsselte Datenbank in Erwägung gezogen werden.
Kommunikation:

RESTful API: Eine API kann die Kommunikation zwischen Frontend und Backend erleichtern. Sie könnte Endpunkte für das Senden und Empfangen von Nachrichten, Verwalten von Kontakten, Ändern von Einstellungen usw. bereitstellen.
Websockets (optional): Für Echtzeitbenachrichtigungen über neue Nachrichten oder Bilder könnte die Verwendung von Websockets in Betracht gezogen werden.
Sicherheit:

HTTPS: Um die Daten während der Übertragung zu schützen, sollte die Webapplikation über HTTPS laufen.
Verschlüsselung auf Transportebene: Die Übertragung der Daten zwischen Frontend und Backend sollte verschlüsselt erfolgen.
Sichere Schlüsselverwaltung: Die Verwaltung der Verschlüsselungsschlüssel sollte sicher und robust sein.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihr Portfolio ein.

# Projekt-Dokumentation


Gruppe MüFreHu: Müller, Frey und Hurschler

| Datum  | Version | Zusammenfassung                                                |
| ------ | ------- | -------------------------------------------------------------- |
| 15.05  | 0.0.1   | Ideenfindung und erstellen der ReactApp, Grundgerüst der Webseite planen |
| 22.05  | 0.0.2   | Grundgerüst der Webseite implementieren     |
| 29.05  | 0.0.3   | Erstellen der gefordeten Seiten "Unternehmensgeschichte", "Dienstleistungen" und "Kontaktinformationen"    |
| 05.06  | 0.0.4   | Erstellen der Seite "Kundenrezensionen" und verbinden mit MonogDB als Backend |
| 12.06  | 0.0.5   |Implementieren der Produktseite |
|16.05|1.0.0|Verbessern der Produktseite, letzter Schliff|

## 1 Informieren

### 1.1 Ihr Projekt

Eine Webseite für unser Schuhunternehmen "xx", welche es Kunden ermöglicht, eine Rezension zu hinterlassen.

Wir haben eine Webseite für unser fiktives Schuhunternehmen "xxx" programmiert. Die Webseite enthält die Unterseiten "Unternehmensgeschichte", "Dienstleistungen" und "Kontaktinformationen". Zudem haben wir eine Hauptseite, auf der unsere angebotenen Schuhe zu sehen sind und eine Feedbackseite, auf der Kunden ihre Rezensionen hinterlassen können. Die Webseite ist in React implementiert und als Backend wir MongoDB verwendet.

### 1.2 User Stories

<response>
# füge noch eine hinzu, dass die daten in einer nosql datenbank gespeichert werden

| US-№ | Verbindlichkeit | Typ        | Beschreibung                                                      |
| ---- | --------------- | ---------- | ----------------------------------------------------------------- |
| 1    | Muss            | Funktional | Als ein Kunde möchte ich die Unternehmensgeschichte lesen können, damit ich mehr über die Marke erfahre. |
| 2    | Muss            | Funktional | Als ein Kunde möchte ich eine Liste der angebotenen Dienstleistungen sehen, damit ich weiß, welche Services verfügbar sind. |
| 3    | Muss            | Funktional | Als ein Kunde möchte ich die Kontaktinformationen leicht finden, damit ich das Unternehmen kontaktieren kann. |
| 4    | Muss            | Funktional | Als ein Kunde möchte ich auf der Produktseite Bewertungen hinterlassen können, damit ich meine Meinung teilen kann. |
| 5    | Muss            | Funktional | Als ein Kunde möchte ich Kundenrezensionen lesen können, damit ich fundierte Kaufentscheidungen treffen kann. |
| 6    | Muss            | Funktional | Als ein Entwickler möchte ich, dass die Kundenrezensionen in einer NoSQL-Datenbank gespeichert werden, damit die Daten flexibel und skalierbar verwaltet werden können. |


### 1.3 Testfälle

<response>
# Tabelle in Markdown

| US-№ | Verbindlichkeit | Typ          | Beschreibung                                                                                                                                 |
| ---- | --------------- | ------------ | -------------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional   | Als ein Kunde möchte ich eine Kundenrezension hinterlassen können, damit ich meine Meinung über die Produkte teilen kann.                     |
| 2    | Muss            | Funktional   | Als ein Webentwickler möchte ich, dass die Kundenrezensionen in einer NoSQL-Datenbank gespeichert werden, damit die Daten flexibel verwaltet werden können. |
| 3    | Kann            | Funktional   | Als ein Besucher der Webseite möchte ich die Unternehmensgeschichte sehen können, damit ich mehr über das Unternehmen erfahren kann.          |
| 4    | Muss            | Funktional   | Als ein Kunde möchte ich die Dienstleistungen des Unternehmens einsehen können, damit ich weiß, welche Services angeboten werden.            |
| 5    | Muss            | Funktional   | Als ein Kunde möchte ich die Kontaktinformationen des Unternehmens finden können, damit ich bei Fragen oder Problemen Kontakt aufnehmen kann. |



## 2 Planen



| AP-№ | Frist   | Zuständig | Beschreibung                              | geplante Zeit |
| ---- | ------- | --------- | ----------------------------------------- | ------------- |
| 1.A  | 15.05.  | Janick    | Setup der Entwicklungsumgebung            | 45 min        |
| 1.B  | 15.05.  | Ben       | Planen des Grundgerüsts | 2*45 min   |
| 2.A  | 22.05.  | Jan       | Implementieren des Grundgerüsts | 3*45 min  |
| 2.B  | 22.05.  | Janick    | Implementieren der geforderten Seiten  | 3*45 min      |
| 2.C  | 29.05.  | Ben       | Implementiereung der zusätzlichen Seiten | 2*45 min |
| 3.A  | 29.05.  | Ben       | Implementierung der Rezensionsfunktion | 3*45 min |
| 3.B  | 05.06.  | Jan       | Designen aller Seiten  | 3*45 min  |
| 3.C  | 05.06.  | Jan       | Schreiben einer Unternehmensgeschichte, Kontankangaben etc. | 2*45 min |
| 4.A  | 12.06.  | Ben       | Test des Gesamtsystems                    | 45 min        |
| 4.B  | 12.06.  | Janick    | Dokumentation der gesamten Entwicklung    | 2*45 min      |

Total: 22 Arbeitspakete

## Zusätzliche Hinweise

- **Gesamtanzahl der Arbeitspakete:** 3 Gruppenmitglieder × 4 Sitzungen × 4 Arbeitspakete = 24 Arbeitspakete.
- Es fehlen noch 4 Arbeitspakete. Diese sollten als "Kann"-User Stories für Kapitel 1.2 hinzugefügt werden.

## 🌐 Sources
1. [ejpd.admin.ch - Zustellung an Wochenenden und Feiertagen mit "A-Post Plus"](https://www.ejpd.admin.ch/ejpd/de/home/aktuell/mm.msg-id-100023.html)
2. [quanos.com - Quanos Connect 2024](https://quanos.com/connect/)
3. [strgzh.ch - Fristen und deren Einhaltung](https://www.strgzh.ch/verfahren/fristen-und-deren-einhaltung)
4. [bearingpoint.com - Nachhaltigkeitsberichtswesen als Live-Demo im SCT 2.0](https://www.bearingpoint.com/de-de/publikationen-and-events/veranstaltungen/cfo-40-webinarreihe-fruehjahrs-edition-2024-nachhaltigkeitsberichtswesen-als-live-demo-im-sct-20/)
5. [eur-lex.europa.eu - DURCHFÜHRUNGSVERORDNUNG (EU) 2015/2447](https://eur-lex.europa.eu/legal-content/DE/TXT/PDF/?uri=CELEX:02015R2447-20210315&from=EN)
6. [stackable.tech - Events](https://stackable.tech/de/events/)
</response>

Total: 22 Arbeitspakete

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

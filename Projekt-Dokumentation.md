# Quiz-Franz

# Projekt-Dokumentation

Cyril Lutziger, Agachan Atputharasa, Marek von Rogall

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 22.09 | 0.0.1   | Uns wurde heute das Projekt vorgestellt. Wir haben unser Projekt ausgewählt und angefangen es zu planen, und haben mit den PAP angefangen.|
| 29.09 | 0.0.1   | Heute haben wir richtig angefangen daran zu arbeiten und sind weit gekommen mit dem Code. Wir sind heute mit einigen von den Userstories fertig geworden.|
| 30.09 | 0.0.1   | Heute haben wir Frau Demenga eine E-Mail geschrieben und gefragt, ob die Userstories die Anforderungen erfüllt und Userstories ergänzt. |
| 17.10 | 0.0.1   | Heute haben wir die Grundlagen unseres Projekts programmiert.|
| 24.10 | 0.0.1   | Heute haben wir unseren Code verschönert und in einzelne Funktionen eingebaut.|
| 31.10 | 0.0.1   | Wir haben Heute neue Userstories eingeschrieben, und nach neuen Ideen gesucht welches wir noch in unserem Programm einbauen können|
| 7.11 | 0.0.1   | Wir haben heute unseren nochmals angeschaut und haben unnötigen Codes entfernt , sowie den Code gekürzt, damit wir es übersichtlicher haben.|
| 14.11 | 0.0.1   | Heute haben wir nochmals verschiedene Userstories geschrieben und umgesetzt|
| 21.11 | 0.0.1   |Wir sind heute mit unserem Programm fertig geworden. |
| 28.11 | 0.0.1   |Wir sind heute mit unserem Projektdokumentation fertig geworden.|
| 05.12 | 0.0.1   |   |

## 1 Informieren
Auftrag lesen und bei Fragen Chloé Demenga E-Mail schreiben.

### 1.1 Ihr Projekt

In unserem Projekt geht es darum das man ein Quiz erstellen sollten, welches gut und einfach verständlich zu benutzen ist.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      muss      |  F  | Als ein User möchte ich das ich eine meine Fragen Importieren oder auch schreiben kann, dazu auch noch die Lösungen. |
| 2    |     muss       |  f  |   Es sollte eine Warnung ausgeben, sobald etwas nicht erkannt wurde. |
| 3    |      kann      |  Q  |   Es kann ein bequemes Design haben, sodass es visuell gut aussieht. |
| 4    |     muss       |  f  |   Als ein User möchte ich, dass ich Quizes erstellen kann und entscheiden kann wo diese gespeichert werden. |
| 5    |     muss       |  F  |  Als ein User möchte ich, dass das Programm absturzssicher ist, sodass es nie Abstürzt |
| 6    |     muss       |  Q |   Als ein User möchte ich, dass meine und die Antworten des Programmes verschiedene Farben haben, sodass ich sehen kann ob es meine Antwort war, der die des Programmes.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm ist gestartet und ich kann auswählen obman eine Datei Importiert oder eine erstellen möchte |Datei Importieren|Den Dateipfad eingeben|
| 1.1  | Das Programm ist gestartet und ich kann meine Fragen und Antworten importieren. |  Baum / arbre      | richtig / falsch     |
| 2.1  | Das Programm ist gestartet und sagt mir, ob meine Eingabe richtig oder falsch ist.  |  Baum / arbre      |  richtig / falsch   |
| 2.2  | Ein richtig/falsch Schrift | arbre |   ihre antwort ist richtig|
| 3.1  | Eine Warnung mit welche besagt, dass man es erneut eingeben sollte, falls man etwas anderes eingibt als das erforderte.| ehe ehe aha | Ihre Eingabe wurde von dem Programm nicht erkannt.|



### 1.4 Diagramme

<img src="https://user-images.githubusercontent.com/110893288/205653238-e0c1795e-6a5d-46c3-9f44-25fda2e726f9.png" width="450">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A   |  22.09     |  Marek     |    Das Programm kann die Datei oder den Text in ein Quiz Umwandeln  |     90min       |
| 2.A   |    29.09   |  Cyril     |    Das Programm fragt den User um eine Eingabe    |    20min      |
| 3.A   |    29.09   |  Agachan   |    Das Programm nimmt die Text datei ein     |    45min      |
| 4.A   |    30.09   |  Agachan   |    Das E-Mail schreiben      |     45min      |
| 5.A   |    17.10   |  Marek     |    as Programm lässt den User die Wörter eintragen    |    90min      |
| 6.A   |   17.10    |  Marek     |    Das Programm gibt dem User ein Warnungsfeld falls etwas anderes als Buchstaben eingegeben wurden   |  45min  |
| 7.A   |    24.10   |  Agachan   |    Das Programm erkennt falsche Eingaben und fragt nach einer erneuten Eingaben      |    45min      |
| 8.A   |    24.10   |  Marek     |    Das Programm lässt den User die Lösungswörter schreiben      |  45min |
| 9.A   |    31.10   |  Cyril     |    Das Programm kann sehen, ob es eine Datei mit dem selbem name gibt     |    90min      |
| 10.A   |    31.10   |  Agachan   |    Das Programm kann dem User mehrere Auswahlmöglichkeiten hinzufügen lassen     |    45min      |
| 11.A   |    31.10   |  Marek     |    Das Programm lässt den User eine weitere Aufgabe hinzufügen     |    125min     |
| 12.A  |    7.11    |  Cyril     |    Das Programm erkennt ob es die angegebene Datei existiert     |    45min      |
| 13.A  |    7.11    |  Agachan   |    Das Programm erkennt ob die Eingabe des Users richtig ist.    |    90min      |
| 14.A  |    14.11   |  Marek     |    Das Programm kann einen Ungültigen Datenpfad erkennen     |    45min     |    45min      |
| 15.A  |    14.11   |  Agachan   |    Das Programm gibt den Punktestand des Users aus     |    45min      |
| 16.A  |    21.11   |  Marek     |    Problembehandlungen des Codes     |    90min      |
| 17.A  |    21.11   |  Cyril     |    Das Programm rechnet die Punkte zusammen    |    30min     |
| 18.A  |    28.11   |  Agachan   |    Das Programm kann sagen wieviel Punkte der User erreicht hat      |    45min      |
| 19.A  |    28.11   |  Marek     |    Das Programm gibt die Durchschnittsnote des Quizes an       |    45min      |
| 20.A  |    05.12   |  Marek     |    Problembehebungen + Cleanup des Codes           |    30min      |
| 20.A  |    05.12   |  Agachan     |    Problembehebungen + Cleanup des Codes           |    30min      |

Total: 


## 3 Entscheiden

Ich nehme an das der User ein Quiz erstellen will und somit auch fragen Importieren oder schreiben will.

Ich nehme an das der User der das Quiz spielt, das es falsch oder richtig anzeigt, sobald man etwas falsch oder richtig eingegben haben.

Ich nehme an das der User ein gutes design will, damit es angenehmer zu spielen ist.

Ich nehme an das der User nocheinmal spielen will und gebe ihnen die Entscheidung nochmals zu spielen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A   | 22.09 |  Marek   |      90min    |   70min      |
| 2.A   | 29.09 |  Cyril   |      20min    |   20min      |
| 3.A   | 29.09 |  Agachan |      45min    |   60min      |
| 4.A   | 30.09 |  Agachan |      45min    |   45min      |
| 5.A   | 17.10 |  Marek   |      90min    |    90min     |
| 6.A   | 17.10 |  Marek   |      45min    |    45min     |
| 7.A   | 24.10 |  Agachan |      45min    |    45min     |
| 8.A   | 24.10 |  Marek   |      45min    |    45min     |
| 9.A   | 31.10 |  Cyril   |      90min    |     90min    |
| 10.A  | 31.10 |  Agachan |      45min    |     45min    |
| 11.A  | 31.10 |  Marek   |      125min   |    120min    |
| 12.A  | 7.11  |  Cyril   |      45min    |    45min     |
| 13.A  | 7.11  |  Agachan |      90min    |      90min   |
| 14.A  | 14.11 |  Marek   |      45min    |     45min    |
| 15.A  | 14.11 |  Agachan |      45min    |    60min     |
| 16.A  | 21.11 |  Marek   |      90min    |     90min    |
| 17.A  | 21.11 |  Cyril   |      30min    |     30min    |
| 18.A  | 28.11 |  Agachan |      45min    |     60min    |
| 19.A  | 28.11 |  Marek   |      45min    |    60min     |
| 20.A  | 05.12 |  Marek   |      30min    |   20min      |
| 20.A  | 05.12 |  Agachan |      30min    |   40min      |
|
## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ----- | -------- | ------ | ------- |
|   1.1     |  30.09    |  Das System fragt nach der Datei und kann eine Datei erstellen. | Agachan      |
|   2.1     |  24.10   |   Das Programm fragt nach den Antwortmöglichkeiten.       | Cyril      |
|   3.1    |   31.10    |   Das System kann die Datei speichern       | Marek     |
|   4.1    |   07.11    |   Das System kann die Lösung erkennen und sagen ob es richtig ist      | Cyril     |
|   4.1    |   21.11    |   Das Programm gibt dem User einen Punkt für die richtige Antwort      | Agachan     |
|   4.1    |   05.12    |   Das Programm gibt eine Durchschnittsnote aus      | Marek     |

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| 1   | Aplikation ist gestartet |           |  Möchten Sie eine Datei erstellen oder importieren? [I/E]   |    Möchten Sie eine Datei erstellen oder importieren? [I/E]              | 
| 2   |Möchten Sie eine Datei erstellen oder importieren? [I/E]| E  |  Dateispeicherort:  |      Dateispeicherort:        |
| 3   |Dateispeicherort: | Pfad hier schreiben + Enter | Path is valid   |      Path is valid      |
| 4   |Path is valid | Enter  | Aufgabe 1: Typ auswählen: Muliplechoice [MC] / Einzelauswahl [SC] |  Aufgabe 1: Typ auswählen: Muliplechoice [MC] / Einzelauswahl [SC]         |
| 5   |   Aufgabe 1: Typ auswählen: Muliplechoice [MC] / Einzelauswahl [SC]| SC |  Aufgabe 1: Frage eingeben: |      Aufgabe 1: Frage eingeben:     |


## 6 Auswerten

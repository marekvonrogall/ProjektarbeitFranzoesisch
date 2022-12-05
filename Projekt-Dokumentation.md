# Quiz-Franz

# Projekt-Dokumentation

Cyril Lutziger

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 22.09 | 0.0.1   | Uns wurde heute das Projekt vorgestellt. Wir haben unser Projekt ausgewählt und angefangen es zu planen, und haben mit den PAP angefangen.|
| 29.09 | 0.0.1   | Heute haben wir richtig angefangen daran zu arbeiten und sind weit gekommen mit dem Code. Wir sind heute mit den Userstories fertig geworden.|
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
| 1    |      muss       |  F  | Als ein User möchte ich das ich eine meine Fragen Importieren oder auch schreiben kann, dazu auch noch die Lösungen. |
| 2    |      muss       |   F  |   Als ein User möchte ich, dass Programm die Ausgabe falsch und richtig ausgibt, sodass man weiss, ob man es falsch oder richtig hat. |
| 3    |     muss       |  f  |   Es sollte eine Warnung ausgeben, sobald etwas nicht erkannt wurde. |
| 4    |      kann       |  Q  |   Es kann ein bequemes Design haben, sodass es visuell gut aussieht. |
| 5    |     muss       |  f  |   Als ein User möchte ich, dass ich Quizes erstellen kann und entscheiden kann wo diese gespeichert werden. |
| 6    |     muss       |  F  |  Als ein User möchte ich, dass das Programm absturzssicher ist, sodass es nie Abstürzt |
| 7    |     muss       |  Q |   Als ein User möchte ich, dass meine und die Antworten des Programmes verschiedene Farben haben, sodass ich sehen kann ob es meine Antwort war, der die des Programmes.|



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
| 1.A  |  30.08     |  Marek      |     Das Programm kann die Datei oder den Text in ein Quiz Umwandeln  |     90min       |
| 2.A  |    06.09   |  Cyril      |      Das Programm fragt den User um eine Eingabe    |    20min      |
| 3.A  |    30.08   |  Agachan    |   Das Programm nimmt die Text datei ein     |    45min      |
| 4.A  |    30.08   |  Agachan    |     Das Programm erkennt ob die Engabe des Users falsch ist.      |     45min      |
| 5.A  |    06.09   |  Marek      |    Das Programm erkennt ob die Eingabe des Users richtig ist.     |    90min      |
| 6.A  |   06.09   |  Marek     |    Das Programm gibt dem User ein Warnungsfeld falls etwas anderes als Buchstaben eingegeben wurden   |     45min       |
| 7.A  |    6.09   |  Agachan     |    Das Programm erkennt falsche Eingaben und fragt nach einer erneuten Eingaben      |    45min      |

Total: 


## 3 Entscheiden

Ich nehme an das der User ein Quiz erstellen will und somit auch fragen Importieren oder schreiben will.

Ich nehme an das der User der das Quiz spielt, das es falsch oder richtig anzeigt, sobald man etwas falsch oder richtig eingegben haben.

Ich nehme an das der User ein gutes design will, damit es angenehmer zu spielen ist.

Ich nehme an das der User nocheinmal spielen will und gebe ihnen die Entscheidung nochmals zu spielen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   30.08    |   Marek        |     2x 45          |      135min    |
| 2.A  |   30.08    |    Cyril       |      45min         |      60min     |
| 3.A  |   30.08    |    Agachan     |      45min         |      30min     |
| 4.A  |   06.09    |    Agachan     |      45min         |      90min     |
| 5.A  |   06.09    |    Marek       |      20            |      45min     |
| 6.A  |   06.09    |    Marek       |      45            |     45min      |
| 7.A  |   06.09    |     Cyril      |      45            |    90+min      |
| 8.A  |   06.09    |     Cyril      |      45            |    90min       |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ----- | -------- | ------ | ------- |
|   1.1     |  30.08    |  Das System gibt aus ob die Zahl grösser oder kleiner ist          | Agachan      |
|   2.1     |  30.08   |   Das Programm kann sagen ob ddie Zahl grösser oder kleiner ist        | Cyril      |
|   3.1    |  6.09     |   Das Programm gibt einen gewinnerscreen raus und fragt ob man erneut spielen will.       | Marek     |



### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| 1   |  |    Aplikation gestartet        |      |                 |                   |

## 6 Auswerten

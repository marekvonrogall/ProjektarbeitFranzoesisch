# Quiz-Franz

# Projekt-Dokumentation

Cyril Lutziger

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 25.09 | 0.0.1   | Heute haben wir unser Projekt ausgewählt und angefangen daran zu arbeiten.   |
| 29.09 | 0.0.   | Heute haben wir richtig angefangen daran zu arbeiten und sind weit gekommen mit dem Code                                                        |
| 30.09 | 0.0.   |                                                      |

## 1 Informieren
Auftrag lesen und bei Fragen Chloé Demenga E-Mail schreiben.

### 1.1 Ihr Projekt

In unserem Projekt geht es darum das man ein Quiz erstellen sollten, welches gut und einfach verständlich zu benutzen ist.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      muss       |  F  | Als ein User möchte ich das ich eine meine Fragen Importieren oder auch schreiben kann, dazu auch noch die Lösungen. |
| 2   |      muss       |   F  |   Als ein User möchte ich, dass Programm die Ausgabe falsch und richtig ausgibt, sodass man weiss, ob man es falsch oder richtig hat. |
| 3  |     muss       |  f  |   Es sollte eine Warnung ausgeben, sobald etwas nicht erkannt wurde. |
| 4  |      kann       |  Q  |   Es kann ein bequemes Design haben, sodass es visuell gut aussieht. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm ist gestartet und ich kann meine Fragen und Antworten importieren. |  Baum / arbre      | richtig / falsch     |
| 2.1  | Das Programm ist gestartet und sagt mir, ob meine Eingabe richtig oder falsch ist.  |  Baum / arbre      |  richtig / falsch   |
| 2.2  | Ein richtig/falsch Schrift | arbre |   ihre antwort ist richtig|
| 3.1  | Eine Warnung mit welche besagt, dass man es erneut eingeben sollte, falls man etwas anderes eingibt als das erforderte.| ehe ehe aha | Ihre Eingabe wurde von dem Programm nicht erkannt.|



### 1.4 Diagramme



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  30.08     |    Marek, Agachan, Cyril    |     Das Programm kann die Datei oder den Text in ein Quiz Umwandeln  |     90min       |
| 2.A  |    06.09   | Marek, Agachan, Cyril      |      Das Programm fragt den User um eine Eingabe    |    20min      |
| 3.A  |    30.08   | Marek, Agachan, Cyril      |   Das Programm nimmt die Text datei ein     |    45min      |
| 4.A  |    30.08   | Marek, Agachan, Cyril      |     Das Programm erkennt ob die Engabe des Users falsch ist.      |     45min      |
| 5.A  |    06.09   | Marek, Agachan, Cyril      |    Das Programm erkennt ob die Eingabe des Users richtig ist.     |    90min      |
| 6.A  |   06.09   |  Marek, Agachan, Cyril     |    Das Programm gibt dem User ein Warnungsfeld falls etwas anderes als Buchstaben eingegeben wurden   |     45min       |
| 7.A  |    6.09   |  Marek, Agachan, Cyril     |    Das Programm erkennt falsche Eingaben und fragt nach einer erneuten Eingaben      |    45min      |

Total: 


## 3 Entscheiden

Ich nehme an das der User ein Quiz erstellen will und somit auch fragen Importieren oder schreiben will.

Ich nehme an das der User der das Quiz spielt, das es falsch oder richtig anzeigt, sobald man etwas falsch oder richtig eingegben haben.

Ich nehme an das der User ein gutes design will, damit es angenehmer zu spielen ist.

Ich nehme an das der User nocheinmal spielen will und gebe ihnen die Entscheidung nochmals zu spielen.


| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   30.08    |   Cyril Lutziger        |     2x 45          |      135min           |
| 2.A  |   30.08    |    Cyril Lutziger       |      45min         |      60min             |
| 3.A  |   30.08    |    Cyril Lutziger       |      45min         |      30min             |
| 4.A  |   06.09    |    Cyril Lutziger       |      45min         |      90min             |
| 5.A  |   06.09    |    Cyril Lutziger       |      20         |      45min             |
| 6.A  |   06.09    |    Cyril Lutziger       |      45         |           |
| 7.A  |    6.09   | Cyril Lutziger      |    45      |    90+min      |
| 8.A  |    6.09   | Cyril Lutziger      |    45      |    90min      |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ----- | -------- | ------ | ------- |
|   1.1     |  30.08    |  Das System gibt aus ob die Zahl grösser oder kleiner ist          | Cyril Lutziger      |
|   2.1     |  30.08   |   Das Programm kann sagen ob ddie Zahl grösser oder kleiner ist        | Cyril Lutziger      |
|   3.1    |  6.09     |   Das Programm gibt einen gewinnerscreen raus und fragt ob man erneut spielen will.       | Cyril Lutziger      |



### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| 1   |  |    Aplikation gestartet        |   3,5, -4 oder buchstaben      |  Programm stürzt ab oder eine fehler anzeige                 |      Das Programm bittet um eine erneute Eingabe.                |

## 6 Auswerten

namespace Kombiniert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double erreichtePunkteQuiz = 0;
            double totalePunkteQuiz = 0;
            int ieb = 0;
            while (true)
            {
                try
                {
                    Console.Write("Möchten Sie Aufgaben importieren [1] oder erstellen [2]? ");
                    ieb = Convert.ToInt32(Console.ReadLine());
                    switch (ieb)
                    {
                        case 1:
                            break;
                        case 2:
                            Console.Write("Geben Sie den Speicherort als Pfad ein: ");
                            string pfadErstellen = Console.ReadLine();
                            Console.Write("Wie soll deine Datei heissen? (mit .txt): ");
                            string dateiNameErstellen = Console.ReadLine();
                            if (File.Exists(pfadErstellen + dateiNameErstellen))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("WARNUNG! - " + pfadErstellen + dateiNameErstellen);

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Diese Datei existiert bereits! Wenn Sie fortfahren wird die Datei überschrieben.");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Fortfahren [y/n] ");
                                string fortfahrenUeberschreiben = Console.ReadLine();
                                if (fortfahrenUeberschreiben == "y")
                                {
                                    File.Delete(pfadErstellen + dateiNameErstellen);
                                }
                                else
                                {
                                    Console.WriteLine("Das Programm wurde abgebrochen.");
                                    System.Environment.Exit(1);
                                }
                            }

                            Console.Clear();
                            int aufgabeNr = 1;
                            int auswahlNr = 1;

                            using (StreamWriter sw = File.CreateText(pfadErstellen + dateiNameErstellen))
                            {
                                sw.WriteLine("");
                            }

                            while (true)
                            {
                                Console.Write("Aufgabe " + aufgabeNr + ": Typ auswählen: Multiplechoice [MC] / Einzelauswahl [EC] ");
                                string erstellenMCEC = Console.ReadLine();
                                using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                {
                                    sw.WriteLine(erstellenMCEC);
                                }
                                Console.WriteLine("");


                                Console.Write("Aufgabe " + aufgabeNr + ": Frage eingeben: ");
                                using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                {
                                    sw.WriteLine(Console.ReadLine());
                                }
                                Console.WriteLine("");
                                char c = 'a';
                                for(int i = 0; i != 6; i++)
                                {
                                    Console.Write("Aufgabe " + aufgabeNr + ": Auswahlmöglichkeit " + c + ") eingeben: ");
                                    c++;
                                    using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                    {
                                        sw.WriteLine(Console.ReadLine());
                                    }
                                    Console.WriteLine("");

                                    if (i < 5)
                                    {
                                        Console.Write("Eine weitere Auswahlmöglichkeit hinzufügen? [y/n] ");
                                        if (Console.ReadLine() == "y")
                                        {
                                            auswahlNr++;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                                
                                using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                {
                                    sw.WriteLine("Antwort-PRA-FRA");
                                }
                                if (erstellenMCEC == "EC")
                                {
                                    Console.Write("Aufgabe " + aufgabeNr + ": Richtige Antwort eingeben: ");
                                    using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                    {
                                        sw.WriteLine(Console.ReadLine());
                                    }
                                }
                                else
                                {
                                    int erstellenLoesung = Convert.ToInt32(1);
                                    for (int i = 0; i != 6; i++)
                                    {
                                        Console.WriteLine("Aufgabe " + aufgabeNr + ": Richtige Antwort (" + erstellenLoesung + ") eingeben: ");
                                        using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                        {
                                            sw.WriteLine(Console.ReadLine());
                                        }

                                        if (i < 5)
                                        {
                                            Console.Write("Eine weitere richtige Antwort hinzufügen? [y/n] ");
                                            if (Console.ReadLine() == "y")
                                            {
                                                erstellenLoesung++;
                                            }
                                            else
                                            { break; }
                                        }
                                    }
                                    using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                    {
                                        sw.WriteLine("Ende-Antwort-PRA-FRA");
                                    }
                                }

                                auswahlNr = 1;

                                Console.Write("Eine weitere Aufgabe hinzufügen? [y/n] ");
                                if (Console.ReadLine() == "y")
                                {
                                    aufgabeNr++;
                                    Console.Clear();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.Clear();
                            //Console.WriteLine("Text-Editor geschlossen. Datei erfolgreich erstellt.");

                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsche Eingabe getätigt! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            //Console.WriteLine("Der Text-Editor endet hier. Nun wird nach dem Dateipfad gefragt. Dies ist der Beginn des eigentlichen Programm zum abfragen.");

            Console.WriteLine("Importieren einer Aufgabendatei:");
            string text = "";
            while (true)
            {
                try
                {
                    Console.Write("Dateipfad: ");
                    string pfad = Console.ReadLine();
                    string validation = pfad.Substring(pfad.Length - 4);

                    if (validation != ".txt")
                    {
                        throw new Exception();
                    }
                    text = System.IO.File.ReadAllText(@pfad);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die angegebene Datei existiert nicht oder entspricht dem falschen Dateiformat.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            string str = text;
            string[] seperator = { Environment.NewLine };
            int count = 2147483600;
            string[] strlist = str.Split(seperator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            Console.Clear();

            int runThrough = 0;
            while (true)
            {
                try
                {
                    if (strlist[runThrough] == "EC")
                    {
                        //Console.WriteLine("Singelecgoice    Ausführungs-Code: " + runThrough);
                        runThrough++;
                        Console.WriteLine(strlist[runThrough]);
                        Console.WriteLine("");
                        char c = 'a';
                        for (int i = 1; strlist[runThrough] != "Antwort-PRA-FRA"; i++)
                        {
                            runThrough++;
                            if (strlist[runThrough] != "Antwort-PRA-FRA")
                            {
                                Console.WriteLine(c + ") " + strlist[runThrough]);
                                c++;
                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Was ist die richtige Antwort? (Lösung als Buchstaben angeben) ");
                        string userSolution = Console.ReadLine();
                        if (userSolution == strlist[runThrough + 1])
                        {
                            //Console.WriteLine("Richtig");
                            erreichtePunkteQuiz++;
                        }
                        else
                        {
                            //Console.WriteLine("Falsch");
                            //Console.WriteLine("Musterlösung: " + strlist[runThrough + 1]);
                        }
                        runThrough++;
                    }
                    if (strlist[runThrough] == "MC")
                    {
                        //Console.WriteLine("Choice       Ausführungs-Code: " + runThrough);
                        runThrough++;
                        Console.WriteLine(strlist[runThrough]);
                        Console.WriteLine("");
                        char c = 'a';
                        for (int i = 1; strlist[runThrough] != "Antwort-PRA-FRA"; i++)
                        {
                            runThrough++;
                            if (strlist[runThrough] != "Antwort-PRA-FRA")
                            {
                                Console.WriteLine(c + ") " + strlist[runThrough]);
                                c++;
                            }
                        }

                        Console.WriteLine("");
                        //Console.WriteLine("Angeblich Liste");
                        int anzahlAntworten = 0;
                        for (int i = 0; strlist[runThrough] != "Ende-Antwort-PRA-FRA"; i++)
                        {
                            runThrough++;
                            anzahlAntworten++;
                            //Console.WriteLine(i);
                        }
                        anzahlAntworten--;
                        //Console.WriteLine("Anzahl Antworten: " + anzahlAntworten);

                        runThrough = runThrough - anzahlAntworten;
                        
                        string userSolution = "";

                        string[] alleAntworten = new[] { "", "", "", "", "", "" };

                        for (int i = 0; i != anzahlAntworten; runThrough++, i++)
                        {
                            //Console.Write(i);
                            alleAntworten[i] = strlist[runThrough];
                            //Alle Antworten befinden sich erfolgreich in alleAntworten[] (max.6)
                        }

                        //string endAntworten = alleAntworten[0] + ", " + alleAntworten[1] + ", " + alleAntworten[2] + ", " + alleAntworten[3] + ", " + alleAntworten [4] + "," + alleAntworten[5];

                        int antwortenPunkte = 0;

                        while (true)
                        {
                            Console.WriteLine("Wie lautet die richtige Antwort / die richtigen Antworten? (Lösung als Buchstaben angeben) ");
                            userSolution = Console.ReadLine();

                            switch (userSolution)
                            {
                                case var value when value == alleAntworten[0]:
                                    //Console.WriteLine("Richtig");
                                    alleAntworten[0] = "geloest";
                                    antwortenPunkte++;
                                    break;
                                case var value when value == alleAntworten[1]:
                                    //Console.WriteLine("Richtig");
                                    alleAntworten[1] = "geloest";
                                    antwortenPunkte++;
                                    break;
                                case var value when value == alleAntworten[2]:
                                    //Console.WriteLine("Richtig");
                                    alleAntworten[2] = "geloest";
                                    antwortenPunkte++;
                                    break;
                                case var value when value == alleAntworten[3]:
                                    //Console.WriteLine("Richtig");
                                    alleAntworten[3] = "geloest";
                                    antwortenPunkte++;
                                    break;
                                case var value when value == alleAntworten[4]:
                                    //Console.WriteLine("Richtig");
                                    alleAntworten[4] = "geloest";
                                    antwortenPunkte++;
                                    break;
                                case var value when value == alleAntworten[5]:
                                    //Console.WriteLine("Richtig");
                                    alleAntworten[5] = "geloest";
                                    antwortenPunkte++;
                                    break;
                                default:
                                    //Console.WriteLine("Punkt abzug");
                                    antwortenPunkte--;
                                    break;
                            }
                            Console.WriteLine("Möchten Sie eine weitere Lösung hinzufügen? [y/n]");
                            if (Console.ReadLine() != "y")
                            {
                                break;
                            }
                        }
                        //Console.WriteLine("Alle Eingaben getätigt (User)");
                        //Console.WriteLine("Erzielte Punkte: " + antwortenPunkte + "/ " + anzahlAntworten + " Punkten.");

                        if (antwortenPunkte == anzahlAntworten)
                        {
                            //Console.WriteLine("Bravo, alle Antworten Richtig!");
                            erreichtePunkteQuiz++;
                        }
                        if (antwortenPunkte != anzahlAntworten)
                        {
                            //Console.WriteLine("Schade. Du hast nicht alles Richtig.");
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Beliebe Taste drücken um mit der nächsten Aufgabe fortzufahren.");
                    Console.ReadLine();
                    Console.Clear();
                    runThrough++;
                }
                catch
                {
                    runThrough = 0;
                    Console.WriteLine("Sie haben alle Aufgaben abgeschlossen");
                    break;
                }
                totalePunkteQuiz++;
            }
            Console.WriteLine("Ende");
            Console.WriteLine("Totale Punkte: " + totalePunkteQuiz);
            Console.WriteLine("Erzielte Punkte: " + erreichtePunkteQuiz);
            Console.WriteLine("Deine Note: " + ((6 / totalePunkteQuiz)*erreichtePunkteQuiz));
            Console.ReadLine();
        }
    }
}
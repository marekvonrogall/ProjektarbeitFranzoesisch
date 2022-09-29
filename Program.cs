namespace Kombiniert
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                            Console.WriteLine("Erstellen ausgewählt.");

                            Console.Write("Wo möchtest du deine Datei speichern?: ");
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

                                while (true)
                                {
                                    Console.Write("Aufgabe " + aufgabeNr + ": Auswahlmöglichkeit " + auswahlNr + " eingeben: ");
                                    using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                    {
                                        sw.WriteLine(Console.ReadLine());
                                    }
                                    Console.WriteLine("");

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
                                    while (true)
                                    {
                                        Console.WriteLine("Aufgabe " + aufgabeNr + ": Richtige Antwort (" + erstellenLoesung + ") eingeben: ");
                                        using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                        {
                                            sw.WriteLine(Console.ReadLine());
                                        }
                                        Console.Write("Eine weitere richtige Antwort hinzufügen? [y/n] ");
                                        if (Console.ReadLine() == "y")
                                        {
                                            erstellenLoesung++;
                                        }
                                        else
                                        {
                                            using (StreamWriter sw = File.AppendText(pfadErstellen + dateiNameErstellen))
                                            {
                                                sw.WriteLine("Ende-Antwort-PRA-FRA");
                                            }
                                            break;
                                        }
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
                            Console.WriteLine("Text-Editor geschlossen. Datei erfolgreich erstellt.");

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
            int count = 1000;
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
                        Console.WriteLine("Singelecgoice    Ausführungs-Code: " + runThrough);
                        runThrough++;
                        Console.WriteLine(strlist[runThrough]);
                        Console.WriteLine("");
                        for (int i = 1; strlist[runThrough] != "Antwort-PRA-FRA"; i++)
                        {
                            runThrough++;
                            if (strlist[runThrough] != "Antwort-PRA-FRA")
                            {
                                Console.WriteLine(i + ".) " + strlist[runThrough]);
                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Was ist die richtige Antwort? (Wort ausschreiben) ");
                        string userSolution = Console.ReadLine();
                        if (userSolution == strlist[runThrough + 1])
                        {
                            Console.WriteLine("Richtig");
                        }
                        else
                        {
                            Console.WriteLine("Falsch");
                            Console.WriteLine("Musterlösung: " + strlist[runThrough + 1]);
                        }
                        runThrough++;
                    }
                    if (strlist[runThrough] == "MC")
                    {
                        Console.WriteLine("Choice       Ausführungs-Code: " + runThrough);
                        runThrough++;
                        Console.WriteLine(strlist[runThrough]);
                        Console.WriteLine("");
                        for (int i = 1; strlist[runThrough] != "Antwort-PRA-FRA"; i++)
                        {
                            runThrough++;
                            if (strlist[runThrough] != "Antwort-PRA-FRA")
                            {
                                Console.WriteLine(i + ".) " + strlist[runThrough]);
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

                        string[] alleAntworten = { "", "", "", "", "", "" };
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
                            Console.WriteLine("Wie lautet die richtige Antwort / die richtigen Antworten? (Wort/Wörter ausschreiben) ");
                            userSolution = Console.ReadLine();


                            if (alleAntworten[0] == userSolution)
                            {
                                Console.WriteLine("Richtig. Lösung 1");
                                antwortenPunkte++;
                                alleAntworten[0] = "geloest";
                            }
                            if (alleAntworten[1] == userSolution)
                            {
                                Console.WriteLine("Richtig. Lösung 2");
                                antwortenPunkte++;
                                alleAntworten[1] = "geloest";
                            }
                            if (alleAntworten[2] == userSolution)
                            {
                                Console.WriteLine("Richtig. Lösung 3");
                                antwortenPunkte++;
                                alleAntworten[2] = "geloest";
                            }
                            if (alleAntworten[3] == userSolution)
                            {
                                Console.WriteLine("Richtig. Lösung 4");
                                antwortenPunkte++;
                                alleAntworten[3] = "geloest";
                            }
                            if (alleAntworten[4] == userSolution)
                            {
                                Console.WriteLine("Richtig. Lösung 5");
                                antwortenPunkte++;
                                alleAntworten[4] = "geloest";
                            }
                            if (alleAntworten[5] == userSolution)
                            {
                                Console.WriteLine("Richtig. Lösung 6");
                                antwortenPunkte++;
                                alleAntworten[5] = "geloest";
                            }

                            Console.WriteLine("Möchten Sie eine weitere Lösung hinzufügen? [y/n]");
                            if (Console.ReadLine() != "y")
                            {
                                break;
                            }
                        }
                        //Console.WriteLine("Alle Eingaben getätigt (User)");
                        Console.WriteLine("Erzielte Punkte: " + antwortenPunkte + "/ " + anzahlAntworten + " Punkten.");

                        if (antwortenPunkte == anzahlAntworten)
                        {
                            Console.WriteLine("Bravo, alle Antworten Richtig!");
                        }
                        if (antwortenPunkte != anzahlAntworten)
                        {
                            Console.WriteLine("Schade. Du hast nicht alles Richtig.");
                        }
                    }
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
            }
            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }
}

test

using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace FranzVerbessert
{
    internal class Program
    {
        static int reachedPoints = 0;
        static int totalPointsQuiz = 0;
        static string path = "";
        static int taskNumber = 1;
        static int taskSelectionNumber = 1;
        static string export()
        {
            while (true)
            {
                try
                {
                    Console.Write("Dateispeicherort + \\Dateiname: ");
                    path = Console.ReadLine() + ".txt";

                    if(path.Length < 3) { throw new Exception(); }

                    string[] drive = path.Split(':');
                    DriveInfo myDrive = new DriveInfo(drive[0]);

                    if (myDrive.IsReady) { }
                    else
                    {
                        throw new Exception();
                    }
                    if (File.Exists(path))
                    {
                        Console.Write("Datei überschreiben? [y/n] ");
                        if (Console.ReadLine() == "y") { }
                        else { throw new Exception(); }
                    }
                    try
                    {
                        using (StreamWriter sw = File.CreateText(path)) { }
                        if (Directory.Exists(path) || File.Exists(path))
                        { Console.WriteLine("Path is valid."); break; }
                        else { throw new Exception(); }
                    }
                    catch { Console.WriteLine("Ungültige Administratorrechte oder Dateiname: Erneute Eingabe: "); }
                }
                catch { Console.Write("Ungültiger Dateipfad: Erneute Eingabe: "); }
            }
            return path;
        }
        static void editor(string pfad)
        {
            int taskNumber = 1;
            string input = "";
            Console.Clear();
            Console.WriteLine("Editor - " + pfad + " - gespeichert.");
            while(true)
            {
                int taskSelectionNumber = 1;
                string createMCSC = "";
                while (true)
                {
                    Console.Write("Aufgabe " + taskNumber + ": Typ auswählen: Multiplechoice [MC] / Einzelauswahl [SC] ");
                    createMCSC = Console.ReadLine();
                    if (createMCSC == "SC" || createMCSC == "MC") { write(createMCSC); break; }
                }
                Console.Write("Aufgabe " + taskNumber + ": Frage eingeben: ");
                input = Console.ReadLine();
                write(input);

                char c = 'a';
                for (int i = 0; i != 6; i++)
                {
                    Console.Write("Aufgabe " + taskNumber + ": Auswahlmöglichkeit " + c + ") eingeben: ");
                    input = Console.ReadLine();
                    write(Convert.ToString(input));
                    c++;
                    if (i < 5)
                    {
                        Console.Write("Möchten Sie eine weitere Auswahlmöglichkeit hinzufügen? [y/n] ");
                        if (Console.ReadLine() == "y") { taskSelectionNumber++; }
                        else{ break; }
                    }
                }
                write("Antwort-PRA-FRA");

                if (createMCSC == "SC")
                {
                    Console.Write("Aufgabe " + taskNumber + ": Richtige Antwort eingeben (Nur Buchstabe noetig. Z.B. \"d\"): ");
                    input = Console.ReadLine();
                    write(Convert.ToString(input));
                }
                else
                {
                    int createSolution = 1;
                    for (int i = 0; i != 6; i++)
                    {
                        Console.WriteLine("Aufgabe " + taskNumber + ": Richtige Antwort (" + createSolution + ") eingeben (Nur Buchstabe noetig. Z.B. \"d\"): ");
                        input = Console.ReadLine();
                        write(Convert.ToString(input));

                        if (i < 5)
                        {
                            Console.Write("Eine weitere richtige Antwort hinzufügen? [y/n] ");
                            if (Console.ReadLine() == "y")
                            {
                                createSolution++;
                            }
                            else
                            { break; }
                        }
                    }
                    write("Ende-Antwort-PRA-FRA");
                }

                Console.Write("Eine weitere Aufgabe hinzufügen? [y/n] ");
                if (Console.ReadLine() == "y")
                {
                    taskNumber++;
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }
        static void write(string input)
        {
            using (StreamWriter sw = File.AppendText(path)) { sw.WriteLine(input); }
        }
        static void import()
        {
            Console.WriteLine("Importieren einer Aufgabendatei:");
            string text = "";
            while (true)
            {
                try
                {
                    Console.Write("Dateipfad: ");
                    string path = Console.ReadLine();
                    string validation = path.Substring(path.Length - 4);
                    if(File.Exists(@path))
                    {
                        if (validation != ".txt")
                        {
                            throw new Exception();
                        }
                    }
                    else { throw new Exception(); }
                    text = System.IO.File.ReadAllText(path);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die angegebene Datei existiert nicht oder entspricht dem falschen Dateiformat.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            string[] strlist = text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Console.Clear();

            int runThrough = 0;
            while (true)
            {
                try
                {
                    if (strlist[runThrough] == "SC")
                    {
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
                        Console.WriteLine("Wie lautet die richtige Antwort? (Lösung als Buchstaben angeben. Z.B. \"d\") ");
                        string userSolution = Console.ReadLine().ToLower();
                        if (userSolution == strlist[runThrough + 1])
                        {
                            reachedPoints++;
                        }
                        else
                        {
                            //Musterlösung anzeigen
                        }
                        runThrough++;
                    }
                    if (strlist[runThrough] == "MC")
                    {
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
                        int solutionsCount = 0;
                        for (int i = 0; strlist[runThrough] != "Ende-Antwort-PRA-FRA"; i++)
                        {
                            runThrough++;
                            solutionsCount++;
                        }
                        solutionsCount--;
                        runThrough = runThrough - solutionsCount;
                        string userSolution = "";
                        string[] allSolutions = new[] { "", "", "", "", "", "" };
                        for (int i = 0; i != solutionsCount; runThrough++, i++)
                        {
                            allSolutions[i] = strlist[runThrough];
                        }
                        int pointsSolution = 0;
                        while (true)
                        {
                            Console.WriteLine("Wie lautet die richtige Antwort / die richtigen Antworten? (Lösung als Buchstaben angeben. Z.B. \"d\") ");
                            userSolution = Console.ReadLine();

                            switch (userSolution)
                            {
                                case var value when value == allSolutions[0]:
                                    allSolutions[0] = "geloest";
                                    pointsSolution++;
                                    break;
                                case var value when value == allSolutions[1]:
                                    allSolutions[1] = "geloest";
                                    pointsSolution++;
                                    break;
                                case var value when value == allSolutions[2]:
                                    allSolutions[2] = "geloest";
                                    pointsSolution++;
                                    break;
                                case var value when value == allSolutions[3]:
                                    allSolutions[3] = "geloest";
                                    pointsSolution++;
                                    break;
                                case var value when value == allSolutions[4]:
                                    allSolutions[4] = "geloest";
                                    pointsSolution++;
                                    break;
                                case var value when value == allSolutions[5]:
                                    allSolutions[5] = "geloest";
                                    pointsSolution++;
                                    break;
                                default:
                                    pointsSolution--;
                                    break;
                            }
                            Console.WriteLine("Möchten Sie eine weitere Lösung hinzufügen? [y/n]");
                            if (Console.ReadLine() != "y")
                            {
                                break;
                            }
                        }
                        if (pointsSolution == solutionsCount)
                        {
                            reachedPoints++;
                        }
                        if (pointsSolution != solutionsCount)
                        {
                            //Kein Punkteabzug
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
                    Console.WriteLine("Sie haben alle Aufgaben abgeschlossen.");
                    break;
                }
                totalPointsQuiz++;
            }
            Console.WriteLine("");
            Console.WriteLine("Auswertung:");
            Console.WriteLine("");
            Console.WriteLine("Totale Punkte: " + totalPointsQuiz);
            Console.WriteLine("Erzielte Punkte: " + reachedPoints);
            double grade = (((5.0 / totalPointsQuiz) * reachedPoints) + 1.0);
            Console.WriteLine("Deine Note: " + grade);
            Console.ReadLine();
            Environment.Exit(1);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Möchten Sie ein Quiz importieren oder ein Quiz erstellen? [I/E] ");
                string input = Console.ReadLine();
                if (input == "E") { editor(export()); break; }
                if (input == "I") { import(); break; }
                Console.Write("Erneute Eingabe: ");
            }
            Console.Clear();
            import();
            Console.WriteLine("Fertig");
        }
    }
}   

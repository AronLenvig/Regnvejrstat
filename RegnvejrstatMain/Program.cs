// Regnvejrsstatistik
// Lav et console-projekt, der beder brugeren om et antal måleværdier og laver noget statistik på værdierne. Benyt Git til løsningen af opgaven.

// Markdown dokumentation
// Prøv at lav en README.md der kort beskriver applikationen med input/output værdier og hvad du ellers synes kunne være relevant hvis en anden person skulle overtage projektet efter dig

// INPUT
// Programmet beder brugeren indtaste antallet af måleværdier. Det kan f.eks. være 7, hvis det skal svare til en uge.

// Programmet beder brugeren om at indtaste de enkelte måleværdier efter tur, indtil antallet er indtastet. Måleværdierne skal gemmes på en effektiv måde.

// Måleværdierne indeholder kommatal.

// PROCESS
// Programmet beregner:

// -          Gennemsnittet

// -          Maksimum-værdien

// -          minimum-værdien

 

// OUTPUT
// Lav lille menu til styring af funktionerne.

// Udlæser de indtastede værdier i en form for tabel:

// -          Måleværdi 1 = 20,5 mm

// -          Måleværdi 2 = 5,2 mm

// -          Osv…

// Udlæser gennemsnittet

// Udlæser maksimum-værdien

// Udlæser minimum-værdien

// Aflevering
// Du afleverer ved at indsætte et link til dit GitHub repository. Du skal sikre dig, at dit repository enten er delt med din underviser eller public

using System.Linq;

namespace RegnvejrstatMain
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("How many measurements do you want to enter? ");
            int numberOfMeasurements = int.Parse(System.Console.ReadLine());

            double[] measurements = new double[numberOfMeasurements];
            for (int i = 0; i < numberOfMeasurements; i++)
            {
                System.Console.WriteLine("Enter measurement " + (i + 1) + ": ");
                measurements[i] = double.Parse(System.Console.ReadLine());
            }

            System.Console.WriteLine("Average: " + Average(measurements));
            System.Console.WriteLine("Maximum: " + Maximum(measurements));
            System.Console.WriteLine("Minimum: " + Minimum(measurements));
        }

        static double Average(double[] measurements)
        {
            return Math.Round(measurements.Sum() / measurements.Length, 2);
        }

        static double Maximum(double[] measurements)
        {
            return measurements.Max();
        }

        static double Minimum(double[] measurements)
        {
            return measurements.Min();
        }
    }
}

/*
Start Visual Studio og lag et nytt prosjekt "Console App" under "Windows Classic Desktop".

Legg inn koden under og finn ut hva den gjør. Hvis du står fast, kan du se begynnelsen på neste undervisningsvideo.
var range = 250;
var counts = new int[range];
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text ?? string.Empty)
    {
        counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i]);
        }
    }
}
Endre det så det håndterer store og små bokstaver likt (bruk google/stackoverflow.com)

Tell i prosent

Skriv ut tall høyrejustert, se eksempel:
1
20
*/



namespace Hva_gjør_denne_koden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            writeToConsole();
        }

        /*
        Koden vi starter med -
        lar bruker skrive inn symboler og sier så hvor mange av de forskjellige symbolene som ble brukt i teksten.

        For å håndtere store og små bokstaver likt kan du konvertere alle bokstaver - 
        til enten store bokstaver eller små bokstaver før du teller dem. 
        En måte å gjøre dette på er å bruke ToLower() eller ToUpper() metoden på hver karakter før du teller antallet.
        */


        static void writeToConsole()
        {
            var range = 26;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    if (char.IsLetter(character))
                    {
                        var index = char.ToLower(character) - 'a'; // konverterer karakteren til en indeks mellom 0 og 25
                        if (index >= 0 && index < range) // sjekker om indeksen er innenfor grensene for counts-arrayen
                        {
                            counts[index]++;
                        }
                    }
                }
                var total = counts.Sum();
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)('a' + i);
                        var percentage = (double)counts[i] / total * 100;
                        Console.WriteLine($"{character,2} - {counts[i],4} ({percentage,6:F2}%)");
                    }
                }
            }
        }
    }
}
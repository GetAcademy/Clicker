
/* TODO
 
Skriv om til mer objektorientert ved å innføre en klasse ClickerGame med objektvariabler
for de tre int-variablene og en metode for hver kommando.

Innfør også et interface ICommand med kun én metode, Run. Lag så en klasse for hver kommando
i applikasjonen. Lag også en egen klasse CommandSet.

Denne har en array med et objekt av hver kommando. Når brukeren
taster et tegn, skal dette sendes til metoden RunCommand i CommandSet.

Der slår den opp hvilken kommando som har den aktuelle bokstaven og kjører så Run på denne kommandoen.

*/

namespace Clickerprogram
{
    internal class Program
    {
        private static ClickerGame _Clicker = new ClickerGame();
        private static CommandSet _commandSet = new CommandSet(_Clicker);
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"-SPACE = klikk(og få poeng)\r\n");
                Console.WriteLine($"- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n");
                Console.WriteLine($"- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n ");
                Console.WriteLine($"- X = avslutt applikasjonen");
            }
        }
    }
}

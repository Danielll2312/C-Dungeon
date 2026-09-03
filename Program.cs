using System;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    static void Main(string[] args)
    {
        const int maximaleLebenspunkte = 20;
        int lebenspunkte = maximaleLebenspunkte;
        int gold = 5;
        bool imDungeon = false;
        double anteil = (double)lebenspunkte/maximaleLebenspunkte;
        int prozentLP = (int)(anteil * 100);
        bool isNahkampfer = false;
        bool isFernkampfer = false;
        bool isMagier = false;
        bool klassenAuswahlErfolgt;

        System.Console.WriteLine("> DIE VERLASSENE KRYPTA <");
        System.Console.WriteLine("-------------------------");
        //Prolog und Vorgeschichte zur Seuchenausbreitung
        System.Console.WriteLine("Sie sind einer der letzten tausend Überlebenden auf der Welt.");
        System.Console.WriteLine("Eine Seuche ist ausgebrochen und hat ihre ganze Familie umgebracht.\n Sie waren schlau genug und vorbereitet und haben in ihrem Bunker mit Konserven und einem Radio gewartet.");
        System.Console.WriteLine("Es sind Monate vergangen bis eine Nachricht im Radio auftauchte und Sie den Anweisungen im Radio folgten\num ein mögliches Gegenmittel zu finden.");
        Console.WriteLine("Sie stehen vor einem verwitterten Steintor, welches mit etwas wie schwarzem Schimmel überzogen ist.\n");

        System.Console.Write("Auf dem Tor steht in rot: ");
        System.Console.WriteLine("\"KEHR UM!\"\n");
        System.Console.WriteLine("In der Hoffnung dort ein Heilmittel zu finden, gehen Sie durch das Tor");
        System.Console.WriteLine("Sie sehen ein helles Licht und zögern kurz...");
        System.Console.WriteLine("Da sie sowieso nichts zu verlieren haben und endlich etwas sinnvolles für die Menschheit machen wollen\n entscheiden Sie sich ins Licht zu laufen");
        System.Console.WriteLine("Ein lauter Knall ertönt und ihre Ohren schmerzen und Sie befinden sich in einem Raum ohne Türen oder Fenster");
        System.Console.WriteLine("Vor Ihnen erscheint eine Art Hologram mit Wörtern und Sie beginnen es zu lesen..\n");
        System.Console.WriteLine("--- AKTUELLER ZUSTAND ---");
        System.Console.WriteLine($"Lebenspunkte: {lebenspunkte}");
        System.Console.WriteLine($"Gold: {gold}");
        System.Console.WriteLine($"Im Dungeon: {imDungeon}");
        System.Console.WriteLine($"Maximallebenspunkte: {maximaleLebenspunkte}\n");
        System.Console.WriteLine("Sie sind verwirrt und probieren das Hologram anzufassen und es erscheint ein neuer Text mit einer Aufforderung\n");
        System.Console.Write("Wie soll Ihr Held heißen?: ");
        string name = Console.ReadLine() ?? "Held";
        System.Console.WriteLine($"Guten Tag {name}. Sie besitzen {lebenspunkte} Lebenspunkte und {gold} Gold.\n");
        System.Console.WriteLine("Drei bunte Kristalle reißen sich aus dem Boden und schweben vor ihrem Gesicht, auf den Steinen steht jeweils ein anderes Wort\n");
        System.Console.WriteLine("Wähle aus:\n1 = Nahkämpfer, 2 = Fernkämpfer, 3= Magier");
        
        string klasse = Console.ReadLine() ?? "1";
        int klassenwahl = int.Parse(klasse);
        //Kurze Info bevor man auswählt als Addon?
        if(klassenwahl == 1)
        {
            isNahkampfer = true;
        }
        else if (klassenwahl == 2)
        {
            isFernkampfer = true;
        }
        else if (klassenwahl == 3)
        {
            isMagier = true;
        }


        if (isNahkampfer || isFernkampfer || isMagier)
        {
            klassenAuswahlErfolgt = true;
        }
        else if (!isNahkampfer || !isFernkampfer || !isMagier)
        {
            klassenAuswahlErfolgt = false;
        }

        string klassenname = "";

        if(isNahkampfer)
        {
            klassenname = "Nahkämpfer";
        }
        else if(isFernkampfer)
        {
            klassenname = "Fernkämpfer";
        }
        else if(isMagier)
        {
            klassenname = "Magier";
        }
        else
        {
            klassenname = "Abenteuerer";
            System.Console.WriteLine("Die bunten Kristalle vibrieren laut und verpuffen\n, es erscheint ein neues Hologram");
            System.Console.WriteLine("Klasse ungültig! Sie werden der Klasse Abenteurer zugeordnet!");
        }

        int wurf1 = Random.Shared.Next(1,7);
        int wurf2 = Random.Shared.Next(1,7);
        int wurf3 = Random.Shared.Next(1,7);
        int wurf4 = Random.Shared.Next(1,7);

        int niedrigsterWurf = Math.Min(
            Math.Min(wurf1, wurf2), 
            Math.Min(wurf3, wurf4)
        );

        Console.WriteLine("1 = Steintor");
        Console.WriteLine("2 = Mauerspalt");
        Console.WriteLine("3 = Runenpforte");
        Console.Write("Zugang: ");
        
        int zugang = int.Parse(Console.ReadLine() ?? "");
        int w20 = Random.Shared.Next(1, 21);
        Console.WriteLine($"W20: {w20}");

        int staerke = wurf1+wurf2+wurf3+wurf4-niedrigsterWurf;
    }
}
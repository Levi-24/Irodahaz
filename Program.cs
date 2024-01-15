using Irodahaz;
using System.Text;

List<Iroda>Irodak = new List<Iroda>();
using StreamReader sr = new StreamReader("../../../src/irodahaz.txt", Encoding.UTF8);
int y = 1;
while (!sr.EndOfStream)
{
    Irodak.Add(new Iroda(y,sr.ReadLine()));
    y++;
}

Console.WriteLine("Az irodaház adatai:");
Console.WriteLine("\tNév\t\tÉv\tIrodisták száma");

for (int i = 0; i < Irodak.Count; i++) Console.WriteLine(Irodak[i]);

Console.WriteLine();
Console.WriteLine("8.Feladat:");
var max = Irodak.Max(x => x.irodaLetszam.Count());
Console.WriteLine(max+1);

Console.WriteLine();
Console.WriteLine("9.Feladat:");
var kilenc = Irodak.Where(x => x.irodaLetszam.Contains(9));
foreach (var item in kilenc) Console.WriteLine(item.ToString());

Console.WriteLine();
Console.WriteLine("10.Feladat:");
int szam = 0;
foreach (var item in Irodak)
{
    foreach (var item1 in item.irodaLetszam)
    {
        if (item1 > 5)
        {
            szam++;
        }
    }
}
Console.WriteLine(szam);

Console.WriteLine();
Console.WriteLine("11.Feladat:");
var senki = Irodak.Where(x => x.irodaLetszam.Contains(0));


Console.WriteLine();
Console.WriteLine("12.Feladat:");
var atlag = Irodak.Where(x => x.cegNev == "LOGMEIN").Select(x => x.irodaLetszam.Average()).FirstOrDefault();
Console.WriteLine(Math.Round(atlag));

Console.WriteLine();
Console.WriteLine("13.Feladat:");


Console.WriteLine();
Console.WriteLine("14.Feladat:");
var szum = Irodak.Sum(x => x.irodaLetszam.Sum());
Console.WriteLine(szum);

Console.WriteLine();
Console.WriteLine("15.Feladat:");
var elso = Irodak.Min(x => x.bekoltozesEve);
Console.WriteLine(elso);

Console.WriteLine();
Console.WriteLine("16.Feladat:");
var utolso = Irodak.Max(x => x.bekoltozesEve);
var datum = DateTime.Now.Year;
Console.WriteLine(datum - utolso);
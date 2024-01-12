using Irodahaz;
using System.Text;

List<Iroda>Irodak = new List<Iroda>();
using StreamReader sr = new StreamReader("../../../src/irodahaz.txt", Encoding.UTF8);
while (!sr.EndOfStream) Irodak.Add(new Iroda(sr.ReadLine()));

Console.WriteLine("Az irodaház adatai:");
Console.WriteLine("\tNév\t\tÉv\tIrodisták száma");

for (int i = 0; i < Irodak.Count; i++)
{
    Console.Write(i+1 + ". ");
    Console.WriteLine(Irodak[i]);
}

Console.WriteLine("8.Feladat:");
var max = Irodak.Max(x => x.irodaLetszam.Count());
Console.WriteLine(Irodak[max]);

Console.WriteLine("9.Feladat:");
var kilenc = Irodak.Where(x => x.irodaLetszam.Contains(9));
foreach (var item in kilenc) Console.WriteLine(item.ToString());

Console.WriteLine("10.Feladat:");
var ot = Irodak.Where(x => x.irodaLetszam.Contains(5));
foreach (var item in ot) Console.WriteLine(item.ToString());

// See https://aka.ms/new-console-template for more information

int anos = 0;
int meses = 0;
int dias = 0;
int resultado = 0;

Console.WriteLine("Quantos anos você tem?");
anos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantos meses de idade você tem?");
meses = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantos dias de idade você tem?");
dias = Convert.ToInt32(Console.ReadLine());

resultado = (anos * 365) + (meses * 30) + dias;
Console.WriteLine("Você já viveu " + resultado + " dias!");

Console.ReadLine();
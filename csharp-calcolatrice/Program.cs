// See https://aka.ms/new-console-template for more information

using csharp_calcolatrice;

Console.WriteLine("Somma:");
Console.WriteLine(CalcoliHelper.somma(23,45));
Console.WriteLine(CalcoliHelper.somma(23.4, 45.3));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Differenza:");
Console.WriteLine(CalcoliHelper.differenza(56, 90));
Console.WriteLine(CalcoliHelper.differenza(3.4, 15.8));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Moltiplicazione:");
Console.WriteLine(CalcoliHelper.moltiplicazione(45, 87));
Console.WriteLine(CalcoliHelper.moltiplicazione(56.8, 67.9));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Valore Assolutoo: ");
Console.WriteLine(CalcoliHelper.valoraAssoluto(-23));
Console.WriteLine(CalcoliHelper.valoraAssoluto(-56.9));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Minimo: ");
Console.WriteLine(CalcoliHelper.valoreMinimo(23, 45));
Console.WriteLine(CalcoliHelper.valoreMinimo(23.7, 45.9));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Massimo: ");
Console.WriteLine(CalcoliHelper.valoreMassimo(23, 45));
Console.WriteLine(CalcoliHelper.valoreMassimo(23.7, 45.9));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Elevazione a potenza: ");
Console.WriteLine(CalcoliHelper.elevazionePotenza(2, 15));
Console.WriteLine("------------------------------\n");
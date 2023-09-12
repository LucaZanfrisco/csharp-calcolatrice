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
Console.WriteLine(CalcoliHelper.valoreAssoluto(-23));
Console.WriteLine(CalcoliHelper.valoreAssoluto(-56.9));
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
Console.WriteLine(CalcoliHelper.elevazionePotenza(2, -3));
Console.WriteLine("------------------------------\n");

Console.WriteLine("\n----------------------------------------------------------------------------\n\n" +
    "Metodi Generici");

Console.WriteLine("Somma:");
Console.WriteLine(GenericsCalcoliHelper.Somma(23, 45));
Console.WriteLine(GenericsCalcoliHelper.Somma(23.4, 45.3));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Differenza:");
Console.WriteLine(GenericsCalcoliHelper.Differenza(56, 90));
Console.WriteLine(GenericsCalcoliHelper.Differenza(3.4, 15.8));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Moltiplicazione:");
Console.WriteLine(GenericsCalcoliHelper.Moltiplicazione(45, 87));
Console.WriteLine(GenericsCalcoliHelper.Moltiplicazione(56.8, 67.9));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Valore Assolutoo: ");
Console.WriteLine(GenericsCalcoliHelper.ValoreAssoluto(-23));
Console.WriteLine(GenericsCalcoliHelper.ValoreAssoluto(-56.9));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Minimo: ");
Console.WriteLine(GenericsCalcoliHelper.ValoreMinimo(23, 45));
Console.WriteLine(GenericsCalcoliHelper.ValoreMinimo(23.7, 45.9));
Console.WriteLine("------------------------------\n");

Console.WriteLine("Massimo: ");
Console.WriteLine(GenericsCalcoliHelper.ValoreMassimo(23, 45));
Console.WriteLine(GenericsCalcoliHelper.ValoreMassimo(23.7, 45.9));
Console.WriteLine("------------------------------\n");



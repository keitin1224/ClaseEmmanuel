using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Digite el numero 1");
int n1 = int.Parse (Console.ReadLine());
Console.WriteLine("Digite el numero 2 ");
int n2 = int.Parse(Console.ReadLine());
int suma = n1 + n2;
int resta = n1 - n2;
int mult = n1 * n2;
int div = n1 / n2;
Console.WriteLine ("suma:" + suma);
Console.WriteLine("resta:" + resta);
Console.WriteLine("mult" + mult);
Console.WriteLine("div" + div);

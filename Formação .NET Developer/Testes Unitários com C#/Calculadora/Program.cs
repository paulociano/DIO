﻿using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
Console.WriteLine($"{num1} - {num2} = {c.Subtrair(num1, num2)}");
Console.WriteLine($"{num1} * {num2} = {c.Multiplicar(num1, num2)}");
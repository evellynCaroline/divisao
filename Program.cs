﻿try
{
    Console.WriteLine("Informe o primeiro valor!");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor!");
    int b = int.Parse(Console.ReadLine());
    int resultado = a / b;
    Console.WriteLine($"O resultado é: "+ resultado);

}catch(Exception ex)
{
    Console.WriteLine("Algo deu errado!");
}
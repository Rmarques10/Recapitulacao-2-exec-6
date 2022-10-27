/* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo” */


double num;

Console.WriteLine("informe um numero:");
num = double.Parse(Console.ReadLine());


if (num < 0.0 || num > 100.0)
{
    Console.WriteLine("Fora de intervalo");
}
else if (num <= 25.0)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if (num <= 50.0)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (num <= 75.0)
{
    Console.WriteLine("Intervalo (50,75]");
}
else
{
    Console.WriteLine("Intervalo (75,100]");
}
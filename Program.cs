// Calcular a área de um triângulo
float areaT;
float baseT;
float alturaT;
float calculo;

Console.WriteLine("Olá! Vamos calcular a área de um triângulo qualquer.");
Console.WriteLine("Digite a base do triângulo em números:");
baseT = float.Parse(Console.ReadLine());
Console.WriteLine("Agora digite a altura do triângulo em números:");
alturaT = float.Parse(Console.ReadLine());
calculo = (baseT * alturaT) / 2;
Console.WriteLine($"A área do triângulo é {calculo} ");

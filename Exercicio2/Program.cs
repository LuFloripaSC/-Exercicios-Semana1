Console.Write("Qual o valor da base do triângulo? ");
decimal baseTriangulo;
baseTriangulo = decimal.Parse(Console.ReadLine());
Console.Write("Qual o valor da altura do triangulo? ");
decimal alturaTriangulo;
alturaTriangulo = decimal.Parse(Console.ReadLine());
decimal areaTriangulo;
areaTriangulo = (baseTriangulo * alturaTriangulo)/2;
Console.Write("A area do Triangulo é igual: " + areaTriangulo);

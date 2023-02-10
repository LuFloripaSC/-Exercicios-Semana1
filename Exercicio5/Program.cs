int lado1, lado2, lado3;
Console.WriteLine("Qual o valor do lado1? ");
lado1 = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor do lado2? ");
lado2 = int.Parse(Console.ReadLine())
Console.WriteLine("Qual o valor do lado3? ");
lado3 = int.Parse(Console.ReadLine());
if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2){
    if (lado1 == lado2 && lado2 == lado3) {
        Console.WriteLine("É um triangulo Equilatero");
    }
    else if (lado1 == lado2 && lado1 != lado3) {
        Console.WriteLine("É um triangulo Isósceles");
    }
    else if (lado2 == lado3 && lado1 != lado2 || lado1 == lado3 && lado3 != lado2) {
        Console.WriteLine("É um triangulo Isósceles");
    }
    else Console.WriteLine("É um triangulo escaleno");
}
else Console.WriteLine("Não é um triangulo!");


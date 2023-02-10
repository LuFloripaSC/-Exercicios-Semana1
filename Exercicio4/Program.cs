// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Nome do Funcionario: ");
string nome;
nome = Console.ReadLine();
Console.WriteLine("Qual o valor do salario bruto?" );
decimal salario;
decimal salarioLiquido;
decimal imposto;
salario = decimal.Parse(Console.ReadLine());
if (salario <=900) {Console.WriteLine("Imposto = 0,00");
Console.WriteLine("Salario Liquido: " + salario);
}
else if 
(salario >900 && salario<= 1500) {
    imposto = (salario * 5)/100;
Console.WriteLine("Imposto = " + imposto);
salarioLiquido = salario - imposto;
Console.WriteLine("Salario Liquido: " + salarioLiquido);
    }
else if (salario >1500 && salario<= 2500) {
    imposto = (salario * 10)/100;
Console.WriteLine("Imposto = " + imposto);
salarioLiquido = salario - imposto;
Console.WriteLine("Salario Liquido: " + salarioLiquido);
    }    
else 
{imposto = (salario * 20)/100;
Console.WriteLine("Imposto = " + imposto);
salarioLiquido = salario - imposto;
Console.WriteLine("Salario Liquido: " + salarioLiquido);
}
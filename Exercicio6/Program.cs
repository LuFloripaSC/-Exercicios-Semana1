int taboada, resultado;
Console.WriteLine("Qual numero deseja consultar a taboada? ");
taboada = int.Parse(Console.ReadLine());
int num = 0;
do
{
    resultado = taboada * num;
       Console.WriteLine(resultado);
    num = num +1;
}while (num <= 10);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int tamanho;
string nome;
Console.WriteLine("Qual o nome do aluno?:");
nome = Console.ReadLine();
Console.WriteLine("Quantas notas serão usadas para média do aluno?:");
tamanho = int.Parse(Console.ReadLine());
decimal [] notas = new decimal[tamanho];
int i = 0;
do{
    Console.WriteLine("Digite a nota " + (i+1));
    notas[i] = decimal.Parse(Console.ReadLine());
    i++;
}while (i <tamanho);
decimal sum = notas.Sum();
decimal mediaNotas = sum /tamanho;
Console.WriteLine($"Aluno: {nome}");
for (int j =0; j<tamanho; j++){
    Console.WriteLine($"Nota {j+1}: {notas[j]}");
}
Console.WriteLine($"Média: {mediaNotas}");
if (mediaNotas >= 6) {Console.WriteLine($"Aluno Aprovado");
}
else if (mediaNotas >= 5 && mediaNotas <6) {Console.Write("Aluno em recuperação");
}
else {Console.Write ("Aluno reprovado");
}






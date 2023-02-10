Console.Write("Digite o nome do aluno: ");
string nome;
nome = Console.ReadLine();
Console.Write("Digite a primeira nota: ");
decimal nota1;
nota1 = decimal.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
decimal nota2;
nota2 = decimal.Parse(Console.ReadLine());
Console.Write("Digite a terceira nota: ");
decimal nota3;
nota3 = decimal.Parse(Console.ReadLine());
decimal mediaNota;
mediaNota = ((nota1 + nota2 + nota3)/3);
if (mediaNota >= 6) {Console.Write("Aluno aprovado com média: " + mediaNota);
}
else if (mediaNota >= 5 && mediaNota <6) {Console.Write("Aluno em recuperação com média: " + mediaNota);
}
else {Console.Write ("Aluno reprovado com média: " + mediaNota);
}



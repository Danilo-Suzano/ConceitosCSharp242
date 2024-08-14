// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * comentário em bloco
 */

Console.WriteLine("Informe seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem vindo(a) {nome}");
Console.WriteLine("Informe sua idade");
int idade = int.Parse(Console.ReadLine());
//De acordo coma idade informada diga se o usuário pode ou não votar


if (idade >= 18 && idade < 65)
{ 
    Console.WriteLine("Deve votar");
} 
else if (idade>= 16  || idade >= 65)
{
    Console.WriteLine("Pode votar");
}
else 
{
    Console.WriteLine("Não pode votar");
}
//modifique o código para que diferencie o Pode Votar do Deve Votar



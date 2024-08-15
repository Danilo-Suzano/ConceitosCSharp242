// See https://aka.ms/new-console-template for more information


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


int[] multiplos = new int[10];
int indice = 0;
for (int divisor = 2; divisor < multiplos.Length; divisor++)
{
    if (idade % divisor == 0) 
    {
        multiplos[indice] = divisor;
        indice++;
    }
        
        
    

}
foreach(int multiplo in multiplos)
{
    if (multiplo != 0)
    Console.Write($" {multiplo} - ");
}
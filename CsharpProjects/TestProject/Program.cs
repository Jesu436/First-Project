using System.Text;
Random dados = new Random();
int total = 0;
int[] roll = new int[3];
string resultado = "";

for (int i = 0; i < 3; i++)
{
    roll[i] = dados.Next(1, 7);
    total += roll[i];
    resultado += (i > 0 ? " + " : "") + roll[i];
}
 Console.WriteLine($"dados roll: {resultado} = {total}");

if(roll[0] == roll[1] || roll[1] == roll[2] || roll[0] == roll[2])  
{
    Console.WriteLine("!Puntos dobles +2 puntos extras wey");
    total += 2;
    Console.WriteLine($"Total con puntos extras : {total}");
}
else
{
    Console.WriteLine("!No tienes puntos extras mamador de pene!");
}

if (total > 10)
{
    Console.WriteLine("You win");
}
else
{
    Console.WriteLine("You lose");
}



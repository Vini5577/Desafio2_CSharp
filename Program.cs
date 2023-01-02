using System.IO;
using System.Linq;

class Program{

    static void Main(string[] args)
    {
        int qt = int.Parse(System.Console.ReadLine());
        string[] num = new string[2];
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < qt; i++)
        {
            num = Console.ReadLine().Split(" ");

            string a = num[0];
            string b = num[1];

            if (a.EndsWith(b))
                System.Console.WriteLine("encaixa");
            else
                System.Console.WriteLine("nao encaixa");
        }
    }
}
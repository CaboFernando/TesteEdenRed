
class Solution
{
    static void Main(string[] args)
    {
        string choice;
        do
        {
            Console.WriteLine("Escolha qual teste você quer verificar:\n");
            Console.WriteLine("1 - Print de 1 até 100");
            Console.WriteLine("2 - Palavra palíndromo");
            Console.WriteLine("3 - Sair da aplicação\n");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new Print().OnForHundred();
                    break;
                case "2":
                    new Palindrome().InserirPalavra();
                    break;
                case "3":
                    Console.WriteLine("\nTchau Tchau!\n");
                    break;
                default:
                    Console.WriteLine("\n{0} Não é um opção!\n", choice);
                    break;
            }

        } while (choice != "3");
    }
}



class Print
{
    //Print números de 1 até 100.
    //Caso o número seja múltiplo de 3 print "Buzz" ao invés do número
    //Caso o número seja múltiplo de 5 print "Fizz" ao invés do número
    //Caso o número seja múltiplo de 3 e 5 print "BuzzFizz" ao invés do número

    public void OnForHundred()
    {
        for (int i = 1; i < 101; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
            {
                Console.WriteLine($"Fizz \n");
                continue;
            }
            if (i % 5 == 0 && i % 3 != 0)
            {
                Console.WriteLine($"Buzz \n");
                continue;
            }
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"FizzBuzz \n");
                continue;
            }

            Console.WriteLine($"Número: {i} \n");
        }
    }
}

class Palindrome
{
    //Informe uma palavra de verifica se a mesma pe um palíndromo

    public void InserirPalavra()
    {
        Console.WriteLine("Digite a palavra de descubra se ela é um palíndromo:\n");
        string palavra = Console.ReadLine();

        bool resposta = verificaPalavra(palavra);

        Console.WriteLine(resposta ? "\nSim, essa palavra é um Palíndromo!\n" : "\nNão, essa palavra não é um Palíndromo!\n");
    }

    public bool verificaPalavra(string palavra)
    {
        string primeiraParte = palavra.Substring(0, palavra.Length / 2);
        char[] array = palavra.ToCharArray();

        Array.Reverse(array);

        string palavraTemporaria = new string(array);
        string segundaParte = palavraTemporaria.Substring(0, palavraTemporaria.Length / 2);

        return primeiraParte.Equals(segundaParte);
    }
}

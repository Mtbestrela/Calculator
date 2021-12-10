class Calculator
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu(){
        Console.Clear();

        Console.WriteLine("Qual a operação você deseja fazer ?");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Dividir");
        Console.WriteLine("4 - Multiplicar");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("------------------------------------");
        Console.WriteLine("Selecione uma opção:");
        short opcao = short.Parse(Console.ReadLine());
        
        switch( opcao ){
            case 1 : Soma();
            break;
            case 2 : Subtracao();
            break;
            case 3 : Divisao();
            break;
            case 4 : Multiplicacao();
            break;
            case 5 : Sair();
            break;
            default : Menu();
            break;
        }

    }
    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        float soma = v1 + v2 ;
        Console.WriteLine($"A soma dos valores é igual a {soma}.");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao(){
        Console.Clear();

        Console.WriteLine("Informe o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da subtração é : {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Divisao(){
        Console.Clear();

        Console.WriteLine("Informe o primeir valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2; 

        Console.WriteLine($"O resultado da divisão foi {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao(){
        Console.Clear();

        Console.WriteLine("Informe o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o primeiro valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicação é : {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Sair(){
        Console.Clear();
        Console.WriteLine("O MtbSystem agradece aos testes efetuados");
    }

}



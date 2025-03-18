namespace CalculadoraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[] array  =  new string[10];
            int contadorHistorico = 0;

            double resultado = 0;

            while (true)
            {

                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Calculadora 2025");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico de operações");
                Console.WriteLine("S - Sair");
                Console.WriteLine("Escolha uma opção");

                string opcao = Console.ReadLine();

                if (opcao == "S")
                    break;

                else if (opcao == "5")
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("---------------------------------");
                    Console.Write("Digite o número desejado: ");

                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int result = numeroTabuada * contador;
                       // string tab = numeroTabuada + " x " + contador + " = " + result;
                        string tab = $"{numeroTabuada} x {contador} = {result}";
                    
                    Console.WriteLine(tab);                   }
                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6"){
                    for(int contador = 0; contador < contadorHistorico; contador++)
                        Console.WriteLine(array[contador]);
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Digite o primeiro número");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());



                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    array[contadorHistorico] = $" {primeiroNumero}  + { segundoNumero} = { resultado}";

                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    array[contadorHistorico] = $" {primeiroNumero}  - {segundoNumero} = {resultado}";

                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    array[contadorHistorico] = $" {primeiroNumero}  * {segundoNumero} = {resultado}";
                }
                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Digite o segundo numero novamente: ");
                        segundoNumero = Convert.ToDouble(Console.ReadLine());

                    }
                    resultado = primeiroNumero / segundoNumero;
                    array[contadorHistorico] = $" {primeiroNumero}  / {segundoNumero} = {resultado}";
                }
                else
                    continue;

                contadorHistorico++;

                    Console.WriteLine("O resultado da operação  é : " + resultado.ToString("F2"));
                Console.ReadLine();
            }
           
        }
           
        }
    }


using System;

class Forma {
    public string Nome {get; set;}
    public double Base {get; set;}
    public double Altura {get; set;}
    public double Lado {get; set;}
    public double Raio {get; set;}

    public double Area() {

        double area = 0;

        if (Nome == "Quadrado" ) {
            area = (Lado * Lado);

        }

        else if (Nome == "Retângulo") {
            area = (Base * Altura);
        }

        else if (Nome == "Triângulo") {
            area = ((Base * Altura) / 2);
        }

        else if (Nome == "Círculo") {
            area = (3.14 * (Raio * Raio));
        }

        return area;

    }

}

class Program {
    static void Main(){

        int op;
        double lado = 0;
        double Base = 0;
        double Altura = 0;
        double area = 0;
        double Raio = 0;

        Console.Write("Escolha a forma geométrica para calcular a área:\n[1] Quadrado\n[2] Retângulo\n[3] Triângulo\n[4] Círculo\nR:    ");
        op = Convert.ToInt32(Console.ReadLine());

        Forma formaG = new Forma();

        switch (op) {
            case 1:

                Console.Write("Digite o valor do lado do quadrado:  ");
                try {
                    lado = Convert.ToDouble(Console.ReadLine());
                    formaG.Nome = "Quadrado";
                    formaG.Lado = lado;
                    area = formaG.Area();
                    Console.WriteLine("A área do '" +  formaG.Nome +"' é: " + area);
                }

                catch (FormatException) {
                    Console.WriteLine("O formato de entrada é inválido! Digite um número decimal ou inteiro.");
                }

                break;

            case 2:

                Console.Write("Digite o valor da base do retângulo: ");
                Base = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o valor da altura do retângulo:   ");
                Altura = Convert.ToDouble(Console.
                ReadLine());

                try {
                formaG.Nome = "Retângulo";
                formaG.Base = Base;
                formaG.Altura = Altura;
                area = formaG.Area();
                Console.WriteLine("A área do '" +  formaG.Nome +"' é: " + area);
                }
                
                
                catch (FormatException) {
                    Console.WriteLine("O formato de entrada é inválido! Digite um número decimal ou inteiro.");
                } 

                break;
            
            case 3:

                Console.Write("Digite o valor da base do triângulo: ");
                Base = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o valor da altura do triângulo:   ");
                Altura = Convert.ToDouble(Console.ReadLine());

                try {
                    formaG.Nome = "Triângulo";
                    formaG.Altura = Altura;
                    formaG.Base = Base;
                    area = formaG.Area();
                    Console.WriteLine("A área do '" +  formaG.Nome +"' é: " + area);
                }

                catch (FormatException) {
                    Console.WriteLine("O formato de entrada é inválido! Digite um número decimal ou inteiro.");
                }

                break;

            case 4:

                Console.Write("Digite o raio do círculo:    ");
                Raio = Convert.ToDouble(Console.ReadLine());

                try {
                    formaG.Nome = "Círculo";
                    formaG.Raio = Raio;
                    area = formaG.Area();
                    Console.WriteLine("A área do '" +  formaG.Nome +"' é: " + area);
                }

                catch (FormatException) {
                    Console.WriteLine("O formato de entrada é inválido! Digite um número decimal ou inteiro.");
                }

                break;

            default:
                Console.Write("Opção inválida.");
                break;

        }

        Console.Write("Pressione qualquer tecla para sair...        ");
        Console.ReadKey();

    }
}

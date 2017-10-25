using System;

namespace OOP_Aula
{
    class Program
    {
        static void Main(string[] args) 
      /*  {
            carro carro1 = new carro(); 
            carro1.cor = "Azul";
            carro1.modelo = "Uno";
            carro1.ano = 2017;
            

          //  System.Console.WriteLine(carro1.modelo + " " + carro1.cor + " " + carro1.ano);
            carro1.MostrarDados(carro1.modelo, carro1.cor,  carro1.ano);
            
            carro carro2 = new carro(); // cria novo objeto
            carro2.cor = "Branco"; // cria os parametros dos objetos
            carro2.modelo = "Fiesta";
            carro2.ano = 2004;

            carro2.MostrarDados(carro2.modelo, carro2.cor, carro2.ano);
            carro2.LigarCarro();
        }

        static void CPF()
        */
        {    string cpf;

            System.Console.WriteLine("Digite seu CPF");
            cpf = Console.ReadLine();

            Validacao validadocumento = new Validacao();
            bool cpfvalido = validadocumento.checagemcpf(cpf);

            if (cpfvalido)
            {
                System.Console.WriteLine("CPF VÁLIDO!");
            }
            else
            {
                System.Console.WriteLine("CPF INVÁLIDO!");
            }
        }

    }
}

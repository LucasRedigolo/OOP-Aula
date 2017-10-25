using System;

/// <summary>
/// Classe do tipo CARRO
/// </summary>
public class Carro // usado pra criar uma classe
{
    public string cor { get; set; } // "set" para dar valor a variavel, e "get" para usar o valor
    public string modelo { get; set; } // criando atributos do dessa classe
    public int ano { get; set; } // criando atributos do dessa classe
    public opcionais opc { get; set; } //Snippet "prop" para criar um atributo 


    /// <summary>
    /// Mostrar dados do CARRO na tela
    /// </summary>
    /// <param name="modelo_"> Mostrar modelo do carro </param>
    /// <param name="cor_"> Mostrar cor do carro </param>
    /// <param name="ano_"> Mostrar ano do carro </param>
    public void MostrarDados(Carro carro) // no código, tenho que pedir os atributos na ordem que aparecem (ou usar o nome da classe)
    {
        System.Console.WriteLine(carro.modelo);
        System.Console.WriteLine(carro.cor);
        System.Console.WriteLine(carro.ano);
        System.Console.WriteLine(carro.opc.TravaEletrica);
        System.Console.WriteLine(carro.opc.VidroEletrico);
        System.Console.WriteLine(carro.opc.direcaoHidraulica);
    }

    public void LigarCarro()
    {
        System.Console.WriteLine("Ligando carro");
    }
}
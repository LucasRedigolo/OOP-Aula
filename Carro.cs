using System;


/// <summary>
/// Classe do tipo CARRO
/// </summary>
public class carro // usado pra criar uma classe
{
    public string cor {get; set;} // "set" para dar valor a variavel, e "get" para usar o valor
    public string modelo {get; set;} // criando atributos do dessa classe
    public int ano {get; set;} // criando atributos do dessa classe

    //Snippet "prop" para criar um atributo 

 /// <summary>
 /// Mostrar dados do CARRO na tela
 /// </summary>
 /// <param name="modelo_"> Mostrar modelo do carro </param>
 /// <param name="cor_"> Mostrar cor do carro </param>
 /// <param name="ano_"> Mostrar ano do carro </param>
    public void MostrarDados(string modelo_, string cor_, int ano_) // no código, tenho que pedir os atributos nessa ordem
    {
                System.Console.WriteLine(modelo_ + " " +  cor_ + " " + ano_ );
    }

    public void LigarCarro()
    {
        System.Console.WriteLine("Ligando carro");
    }
}
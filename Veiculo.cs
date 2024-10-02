using System.Xml.Serialization;

public class Veiculo
{
    protected string Marca;
    protected string Modelo;
    protected int Ano;
    public void Ligar()
    {
        Console.WriteLine("Ligado");
    }
    public void Desligar()
    {
        Console.WriteLine("Desligado");
    }

    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
}
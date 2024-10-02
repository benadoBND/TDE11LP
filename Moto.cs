using System.Reflection.Metadata;

public class Moto : Veiculo
{
    private bool temBagageiro;
    public void darGrau()
    {
        Console.WriteLine("Randandandan");
    }
    public void exibirInformações()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Tem bagageiro: {temBagageiro}.");
    }
    public Moto(string marca, string modelo, int ano, bool temBagageiro) :base(marca, modelo, ano,)
    {
        this.temBagageiro = temBagageiro;
    }
}
public class Carro : Veiculo
{
    private int numeroDePortas;
    public Carro(int numDePortas, string marca, string modelo, int ano) :base(marca, modelo, ano)
    {
        numeroDePortas = numDePortas;
    }
    public void abrirMalas()
    {
        Console.WriteLine("O porta malas está aberto");
    }
    public void exibirInformações()
    {
        Console.WriteLine($"{Marca} {Modelo} {Ano} {numeroDePortas}");
    }
}
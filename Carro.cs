public class Carro : Veiculo
{
    private int NumeroPortas;

    public Carro(string marca, string modelo, int ano, int NumeroPortas)
    :base(marca, modelo, ano)
    {
        this.NumeroPortas = NumeroPortas;
    }

    public void AbrirPortaMalas()
    {
        Console.WriteLine("O porta-malas está aberto!");
    }

    public void ExibirInformacoes()
    {
         Console.WriteLine($"Marca: {marca}, Modelo {modelo}, Ano {ano}, Número de Portas: {NumeroPortas}");
    }

}
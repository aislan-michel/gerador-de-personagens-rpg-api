namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Defeito
{
    public Defeito(string nome, int valor)
    {
        Nome = nome;
        Valor = valor;
    }

    public string Nome { get; set; }
    public int Valor { get; set; }
}
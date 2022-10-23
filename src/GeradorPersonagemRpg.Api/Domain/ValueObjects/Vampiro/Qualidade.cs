namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Qualidade
{
    public Qualidade(string nome, int valor)
    {
        Nome = nome;
        Valor = valor;
    }

    public string Nome { get; set; }
    public int Valor { get; set; }
}
namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Atributo
{
    public Atributo(int valor, string? especializacao = "")
    {
        Valor = valor + 1;
        Especializacao = especializacao;
    }

    public int Valor { get; set; }
    public string? Especializacao { get; set; }
}
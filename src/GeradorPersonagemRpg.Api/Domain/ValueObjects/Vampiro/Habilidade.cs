namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Habilidade
{
    public Habilidade(int valor, string? especializacao = "")
    {
        Valor = valor;
        Especializacao = especializacao;
    }

    public int Valor { get; set; }
    public string? Especializacao { get; set; }
}
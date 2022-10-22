namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Disciplina
{
    public Disciplina(string nome, int valor)
    {
        Nome = nome;
        Valor = valor;
    }

    public string Nome { get; set; }
    public int Valor { get; set; }
}
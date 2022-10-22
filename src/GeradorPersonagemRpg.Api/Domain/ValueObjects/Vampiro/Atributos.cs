namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Atributos
{
    public Atributos(Fisicos fisicos, Sociais sociais, Mentais mentais)
    {
        Fisicos = fisicos;
        Sociais = sociais;
        Mentais = mentais;
    }

    public Fisicos Fisicos { get; set; }
    public Sociais Sociais { get; set; }
    public Mentais Mentais { get; set; }
}
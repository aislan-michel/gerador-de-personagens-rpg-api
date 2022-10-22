namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Habilidades
{
    public Habilidades(Talentos talentos, Pericias pericias, Conhecimentos conhecimentos)
    {
        Talentos = talentos;
        Pericias = pericias;
        Conhecimentos = conhecimentos;
    }

    public Talentos Talentos { get; set; }
    public Pericias Pericias { get; set; }
    public Conhecimentos Conhecimentos { get; set; }
}
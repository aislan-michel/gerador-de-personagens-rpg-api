namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Fisicos
{
    public Fisicos(int forca, int destreza, int vigor)
    {
        Forca = new Atributo(forca);
        Destreza = new Atributo(destreza);
        Vigor = new Atributo(vigor);
    }

    public Atributo Forca { get; set; }
    public Atributo Destreza { get; set; }
    public Atributo Vigor { get; set; }
}
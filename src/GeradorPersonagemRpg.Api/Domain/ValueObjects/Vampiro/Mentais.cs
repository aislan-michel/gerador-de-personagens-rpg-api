namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Mentais
{
    public Mentais(int percepcao, int inteligencia, int raciocinio)
    {
        Percepcao = new Atributo(percepcao);
        Inteligencia = new Atributo(inteligencia);
        Raciocinio = new Atributo(raciocinio);
    }

    public Atributo Percepcao { get; set; }
    public Atributo Inteligencia { get; set; }
    public Atributo Raciocinio { get; set; }
}
namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Sociais
{
    public Sociais(int carisma, int manipulacao, int aparencia)
    {
        Carisma = new Atributo(carisma);
        Manipulacao = new Atributo(manipulacao); 
        Aparencia = new Atributo(aparencia);
    }

    public Atributo Carisma { get; set; }
    public Atributo Manipulacao { get; set; }
    public Atributo Aparencia { get; set; }
}
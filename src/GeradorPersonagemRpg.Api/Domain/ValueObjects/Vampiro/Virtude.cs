namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Virtude
{
    public Virtude(int valor)
    {
        Valor = valor + 1;
    }
    
    public int Valor { get; set; }
}
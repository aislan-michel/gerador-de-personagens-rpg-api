namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class PontosDeSangue
{
    public PontosDeSangue(int quantidade)
    {
        Quantidade = quantidade;
    }

    public int Quantidade { get; set; }
}
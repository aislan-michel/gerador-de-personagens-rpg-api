namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Virtudes
{
    public Virtudes(int consciencia, int autoControle, int coragem)
    {
        Consciencia = new Virtude(consciencia);
        AutoControle = new Virtude(autoControle);
        Coragem = new Virtude(coragem);
    }

    /// <summary>
    /// Consciencia/Convicção
    /// </summary>
    public Virtude Consciencia { get; set; }

    /// <summary>
    /// AutoControle/Instintos
    /// </summary>
    public Virtude AutoControle { get; set; }

    public Virtude Coragem { get; set; }
}
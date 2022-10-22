namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Conhecimentos
{
    public Conhecimentos(int academicos, int computador, int financas, int investigacao, int direito, 
        int linguistica, int medicina, int ocultimo, int politica, int ciencia)
    {
        Academicos = new Habilidade(academicos);
        Computador = new Habilidade(computador);
        Financas = new Habilidade(financas);
        Investigacao = new Habilidade(investigacao);
        Direito = new Habilidade(direito);
        Linguistica = new Habilidade(linguistica);
        Medicina = new Habilidade(medicina);
        Ocultimo = new Habilidade(ocultimo);
        Politica = new Habilidade(politica);
        Ciencia = new Habilidade(ciencia);
    }

    public Habilidade Academicos { get; set; }
    public Habilidade Computador { get; set; }
    public Habilidade Financas { get; set; }
    public Habilidade Investigacao { get; set; }
    public Habilidade Direito { get; set; }
    public Habilidade Linguistica { get; set; }
    public Habilidade Medicina { get; set; }
    public Habilidade Ocultimo { get; set; }
    public Habilidade Politica { get; set; }
    public Habilidade Ciencia { get; set; }
}
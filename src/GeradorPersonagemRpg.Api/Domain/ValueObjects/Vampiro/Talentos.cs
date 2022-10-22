namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Talentos
{
    public Talentos(int prontidao, int esportes, int briga, int esquiva, int empatia, int expressao, 
        int intimidacao, int lideranca, int manha, int labia)
    {
        Prontidao = new Habilidade(prontidao);
        Esportes = new Habilidade(esportes);
        Briga = new Habilidade(briga);
        Esquiva = new Habilidade(esquiva);
        Empatia = new Habilidade(empatia);
        Expressao = new Habilidade(expressao);
        Intimidacao = new Habilidade(intimidacao);
        Lideranca = new Habilidade(lideranca);
        Manha = new Habilidade(manha);
        Labia = new Habilidade(labia);
    }

    public Habilidade Prontidao { get; set; }
    public Habilidade Esportes { get; set; }
    public Habilidade Briga { get; set; }
    public Habilidade Esquiva { get; set; }
    public Habilidade Empatia { get; set; }
    public Habilidade Expressao { get; set; }
    public Habilidade Intimidacao { get; set; }
    public Habilidade Lideranca { get; set; }
    public Habilidade Manha { get; set; }
    public Habilidade Labia { get; set; }
}
namespace GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

public class Pericias
{
    public Pericias(int empatiaComAnimais, int oficios, int conducao, int etiqueta, int armaDeFogo, 
        int armaBranca, int performance, int seguranca, int furtividade, int sobrevivencia)
    {
        EmpatiaComAnimais = new Habilidade(empatiaComAnimais);
        Oficios = new Habilidade(oficios);
        Conducao = new Habilidade(conducao);
        Etiqueta = new Habilidade(etiqueta);
        ArmaDeFogo = new Habilidade(armaDeFogo);
        ArmaBranca = new Habilidade(armaBranca);
        Performance = new Habilidade(performance);
        Seguranca = new Habilidade(seguranca);
        Furtividade = new Habilidade(furtividade);
        Sobrevivencia = new Habilidade(sobrevivencia);
    }

    public Habilidade EmpatiaComAnimais { get; set; }
    public Habilidade Oficios { get; set; }
    public Habilidade Conducao { get; set; }
    public Habilidade Etiqueta { get; set; }
    public Habilidade ArmaDeFogo { get; set; }
    public Habilidade ArmaBranca { get; set; }
    public Habilidade Performance { get; set; }
    public Habilidade Seguranca { get; set; }
    public Habilidade Furtividade { get; set; }
    public Habilidade Sobrevivencia { get; set; }
}
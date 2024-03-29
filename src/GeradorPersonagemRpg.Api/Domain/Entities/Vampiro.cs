﻿using GeradorPersonagemRpg.Api.Domain.Enums.Vampiro;
using GeradorPersonagemRpg.Api.Domain.ValueObjects.Vampiro;

namespace GeradorPersonagemRpg.Api.Domain.Entities;

public class Vampiro
{
    public Vampiro(Cla cla, TipoVampiro tipoVampiro)
    {
        Cla = cla;
        TipoVampiro = tipoVampiro;

        if (TipoVampiro == TipoVampiro.Neofito)
        {
            CriarNeofito();
        }
    }
    
    public string Nome { get; set; }
    public string Jogador { get; set; }
    public string Cronica { get; set; }

    public string Natureza { get; set; }
    public string Comportamento { get; set; }
    public Cla Cla { get; set; }

    public int Geracao { get; set; } = 13;
    public string Refugio { get; set; }
    public string Conceito { get; set; }

    public Atributos Atributos { get; set; }

    public Habilidades Habilidades { get; set; }

    public IEnumerable<Antecedente> Antecedentes { get; set; }
    public IEnumerable<Disciplina> Disciplinas { get; set; }

    public Virtudes Virtudes { get; set; }

    public IEnumerable<Qualidade> Qualidades { get; set; }
    public IEnumerable<Defeito> Defeitos { get; set; }

    public Trilha Trilha { get; set; }
    public ForcaDeVontade ForcaDeVontade { get; set; }
    public PontosDeSangue PontosDeSangue { get; set; }

    public TipoVampiro TipoVampiro { get; set; }

    private void CriarNeofito()
    {
        TipoVampiro = TipoVampiro.Neofito;

        Antecedentes = new List<Antecedente>(5)
        {
            new Antecedente("Recursos", 2),
            new Antecedente("Contatos", 1),
            new Antecedente("Rebanho", 1),
            new Antecedente("Aliados", 1)
        };

        if (Cla == Cla.Brujah)
        {
            CriarNeofitoBrujah();
        }

        if (Cla == Cla.Ventrue)
        {
            CriarNeofitoVentrue();
        }   
    }

    private void CriarNeofitoVentrue()
    {
        Atributos = new Atributos(
            new Fisicos(1, 1, 1), new Sociais(3, 2, 2), new Mentais(2, 1, 2));
    }
    
    private void CriarNeofitoBrujah()
    {
        Atributos = new Atributos(
            new Fisicos(3, 2, 2), new Sociais(1, 1, 1), new Mentais(2, 1, 2));
        
        Habilidades = new Habilidades(
            new Talentos(2, 3, 3, 2, 0, 0, 2, 0, 0, 0), 
            new Pericias(0, 0, 2, 0, 2, 2, 0, 1, 0, 2),
            new Conhecimentos(0, 0, 0, 2, 0, 0, 0, 1, 2, 0));

        Disciplinas = new List<Disciplina>(3)
        {
            new Disciplina("Potência", 1),
            new Disciplina("Fortitude", 1),
            new Disciplina("Rapidez", 1)
        };

        Virtudes = new Virtudes(2, 2, 3);

        Qualidades = new List<Qualidade>()
        {
            new Qualidade("Sentido Aguçado", 1)
        };

        Defeitos = new List<Defeito>()
        {
            new Defeito("Vício", 3)
        };

        Trilha = new Humanidade(4);

        ForcaDeVontade = new ForcaDeVontade(5);

        PontosDeSangue = new PontosDeSangue(10);
    }

    private static Random _random = new Random();

    public void DistribuirAtributos()
    {
        var pontos = new List<int>() { 7, 5, 3 };

        var pontosOrdenados = new List<int>();

        for (var i = 0; i < 3; i++)
        {
            pontosOrdenados.Add(pontos[_random.Next(pontos.Count)]);
            pontos.Remove(pontos[_random.Next(pontos.Count)]);
        }

        Atributos = new Atributos();

        int ponto1 = 0;
        int ponto2 = 0;
        int ponto3 = 0;
        
        ponto1 = _random.Next(pontosOrdenados[0]);
        ponto2 = _random.Next(pontosOrdenados[0] - ponto1);
        ponto3 = pontosOrdenados[0] - (ponto1 + ponto2);

        Atributos.Fisicos = new Fisicos(ponto1, ponto2, ponto3);
        
        ponto1 = _random.Next(pontosOrdenados[1]);
        ponto2 = _random.Next(pontosOrdenados[1] - ponto1);
        ponto3 = pontosOrdenados[1] - (ponto1 + ponto2);

        Atributos.Sociais = new Sociais(ponto1, ponto2, ponto3);
            
        ponto1 = _random.Next(pontosOrdenados[2]);
        ponto2 = _random.Next(pontosOrdenados[2] - ponto1);
        ponto3 = pontosOrdenados[2] - (ponto1 + ponto2);

        Atributos.Mentais = new Mentais(ponto1, ponto2, ponto3);
            
        
        
        

        


    }

    private void PreencherAtributos()
    {
        
    }
}
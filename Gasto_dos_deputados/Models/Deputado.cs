namespace Gasto_dos_deputados.Models;

public class Deputado
{
    public Deputado(string nome, string uf, string cpf, string partido, string urlFoto)
    {
        Nome = nome;
        Uf = uf;
        Cpf = cpf;
        Partido = partido;
        UrlFoto = urlFoto;
    }

    private Deputado()
    {

    }

    public int id { get; set; }
    public string UrlFoto { get; set; }
    public string Nome { get; set; }
    public string Uf { get; set; }
    public string Cpf { get; set; }
    public string Partido { get; set; }

    public ICollection<Despesa> Despesas { get; set; } 
    
    }

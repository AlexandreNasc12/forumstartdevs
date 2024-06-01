using FSD.Core;

namespace FSD.Usuarios.App;

public class Usuario : Entity, IAggregateRoot
{
    public string Nome { get; private set; }
    public Cpf Cpf { get; private set; }
    public DateTime DataDeNascimento { get; private set; }
    public string Foto { get; private set; }
    public Login Login { get; private set; }

    //EF
    private HashSet<Endereco> _Enderecos;
    public IReadOnlyCollection<Endereco> Enderecos => _Enderecos;

    public int Idade
    {
        get
        {
            if (DataDeNascimento == DateTime.MinValue) return 0;

            var idade = DateTime.Now.Year - DataDeNascimento.Year;

            if (DateTime.Now.Month < DataDeNascimento.Month ||
            (DateTime.Now.Month == DataDeNascimento.Month && DateTime.Now.Day < DataDeNascimento.Day))
            {
                idade--;
            }

            return idade;
        }
    }

    protected Usuario() { }

    public Usuario(string nome, Cpf cpf, string foto)
    {
        Nome = nome;
        Cpf = cpf;
        Foto = foto;
    }

    public void AtribuirNome(string nome) => Nome = nome;

    public void AtribuirDataDeNascimento(DateTime dataNascimento) => DataDeNascimento = dataNascimento;

    public void AtribuirFoto(string foto) => Foto = foto;
}

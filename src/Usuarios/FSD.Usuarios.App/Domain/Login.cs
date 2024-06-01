using FSD.Core;

namespace FSD.Usuarios.App;

public class Login
{
    public Guid Hash { get; private set; }
    public Email Email { get; private set; }
    public Senha Senha { get; private set; }

    public Login(Email email, Senha senha)
    {
        Email = email;
        Senha = senha;
        Hash = new Identidade(email.Endereco,senha.Valor);
    }
}
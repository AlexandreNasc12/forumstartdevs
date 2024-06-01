using System.Globalization;

namespace FSD.Core;

public abstract class Entity
{
    public Guid Id { get; private set; }

    public DateTime DataDeCadastro { get; private set; }

    public DateTime DataDeAlteracao { get; private set; }

    public string ObterDataFormatada() => DataDeCadastro.ToString("G",new CultureInfo("pt-Br"));

    public void AtribuirEntidadeId(Guid id) => Id = id;

}

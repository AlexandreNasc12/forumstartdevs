namespace FSD.Core;

public interface IUnitOfWorks
{
    Task<bool> Commit();
}
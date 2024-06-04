using ModuloOrientacaoAObjetos.NotificationsContext;

namespace ModuloOrientacaoAObjetos.SharedContext;

public abstract class Base : Notifiable
{
    public Base()
    {
        Id = Guid.NewGuid();

    }
    public Guid Id { get; set; }
}
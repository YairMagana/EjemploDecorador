namespace EjemploDecorador
{
    public interface IDecoradorGuardadorCxP : IGuardadorCxP
    {
        IGuardadorCxP GuardadorCxP { get; set; }
    }
}

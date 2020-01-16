namespace EjemploDecorador
{
    public class DecoradorGuardadorCxPGuardadorHistorial : IDecoradorGuardadorCxP
    {
        public IGuardadorCxP GuardadorCxP { get; set; }

        public DecoradorGuardadorCxPGuardadorHistorial(IGuardadorCxP _guardadorCxP)
        {
            GuardadorCxP = _guardadorCxP;
        }

        public string GuardarCxP()
        {
            if (GuardadorCxP != null)
            {
                return $"{GuardadorCxP.GuardarCxP()}\n -> {GuardarHistorial()}";
            }
            else
                return string.Empty;
        }

        private string GuardarHistorial()
        {
            return "Se Guarda En el Historial";
        }
    }
}

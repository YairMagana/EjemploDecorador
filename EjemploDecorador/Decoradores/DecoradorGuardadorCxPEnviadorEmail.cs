namespace EjemploDecorador
{
    public class DecoradorGuardadorCxPEnviadorEmail : IDecoradorGuardadorCxP
    {
        public IGuardadorCxP GuardadorCxP { get; set; }

        public DecoradorGuardadorCxPEnviadorEmail(IGuardadorCxP _guardadorCxP)
        {
            GuardadorCxP = _guardadorCxP;
        }

        public string GuardarCxP()
        {
            if (GuardadorCxP != null)
            {
                return $"{GuardadorCxP.GuardarCxP()}\n -> {EnviarEmail()}";
            }
            else
                return string.Empty;
        }

        private string EnviarEmail()
        {
            return "Se Envía el Email";
        }
    }
}

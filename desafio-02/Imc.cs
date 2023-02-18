namespace desafio_02
{
    public class Imc
    {
        private double resultado { get; set; }

        public Imc(double peso, double altura)
        {
            Exceptions.InvalidImcException.ThrowIfInvalid(peso, altura);
            Calcular(peso, altura);
        }

        private double Calcular(double peso, double altura) => resultado = peso / (altura * altura);

        private (string? classificacaoImc, string? classificaoRisco) ObterClassificacao() => resultado switch
        {
            < 16 => (ClassificacaoImc.MagrezaGrauIII.GetDisplayName(), string.Empty),
            < 16.9 => (ClassificacaoImc.MagrezaGrauII.GetDisplayName(), string.Empty),
            < 18.4 => (ClassificacaoImc.MagrezaGrauI.GetDisplayName(), string.Empty),
            < 24.9 => (ClassificacaoImc.Eutrofia.GetDisplayName(), string.Empty),
            < 29.9 => (ClassificacaoImc.Sobrepeso.GetDisplayName(), ClassificacaoRisco.Aumentando.GetDisplayName()),
            < 34.9 => (ClassificacaoImc.ObesidadeGrauI.GetDisplayName(), ClassificacaoRisco.Moderado.GetDisplayName()),
            < 40 => (ClassificacaoImc.ObesidadeGrauII.GetDisplayName(), ClassificacaoRisco.Grave.GetDisplayName()),
            > 40 => (ClassificacaoImc.ObesidadeGrauIII.GetDisplayName(), ClassificacaoRisco.MuitoGrave.GetDisplayName()),
            _ => throw new InvalidImcException()
        };

        public override string ToString()
        {
            var (classificacaoImc, classificaoRisco) = ObterClassificacao();
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Seu IMC é {resultado.ToString("F2")}");
            stringBuilder.AppendLine($"{classificacaoImc}");

            if (!string.IsNullOrEmpty(classificaoRisco))
                stringBuilder.AppendLine($"Risco: {classificaoRisco}");

            return stringBuilder.ToString();
        }
    }
}
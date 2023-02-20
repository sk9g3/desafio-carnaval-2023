namespace desafio_04
{
    public class Troco
    {
        float[] moedas = { 100, 50, 10, 2, 1, 0.50f, 0.25f, 0.10f };
        public double ValorFinal { get; private set; }
        public double ValorPago { get; private set; }
        public double ValorTroco => ValorPago - ValorFinal;

        public Troco(double valorFinal, double valorPago)
        {
            InvalidTrocoException.ThrowIfInvalid(valorFinal, valorPago);
            ValorFinal = valorFinal;
            ValorPago = valorPago;
        }

        private string ObterDescricoesNotasParaTroco()
        {
            StringBuilder descricoes = new StringBuilder();

            var trocoAuxiliar = ValorTroco;
            foreach (var moeda in moedas)
            {
                var notas = (int)(trocoAuxiliar / moeda);
                if (notas > 0)
                {
                    trocoAuxiliar -= Math.Round(notas * moeda, 2);
                    descricoes.AppendLine(ObterDescricaoMoeda(moeda, notas));
                }
            }

            return descricoes.ToString();
        }

        private string ObterDescricaoMoeda(float moeda, int quantidadeNotas)
        {
            if (moeda <= 1)
            {
                return $"    - {quantidadeNotas} {(quantidadeNotas > 1 ? "moedas" : "moeda")} de {moeda} {(moeda == 1 ? "real" : "centavos")}";
            }

            return $"    - {quantidadeNotas} {(quantidadeNotas > 1 ? "notas" : "nota")} de {moeda} reais";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"-Valor final da compra: {ValorFinal:C}");
            stringBuilder.AppendLine($"- Pagamento: {ValorPago:C}");
            stringBuilder.AppendLine($"- Troco: {ValorTroco:C}");
            stringBuilder.AppendLine($"{ObterDescricoesNotasParaTroco()}");
            return stringBuilder.ToString();
        }
    }
}
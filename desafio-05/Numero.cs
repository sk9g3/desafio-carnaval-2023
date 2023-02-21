namespace desafio_05
{
    public class Numero
    {
        Dictionary<ClasseDecimal, ConfiguracaoDecimal> configuracoes = new Dictionary<ClasseDecimal, ConfiguracaoDecimal>()
        {
            {ClasseDecimal.Centavos, new ConfiguracaoDecimal(2,1,"centavo","centavos")},
            {ClasseDecimal.Centenas, new ConfiguracaoDecimal(3,2,1)},
            {ClasseDecimal.Milhar, new ConfiguracaoDecimal(6,5,4, "mil","mil")},
            {ClasseDecimal.Milhao, new ConfiguracaoDecimal(9,8,7, "milhão","milhões")},
            {ClasseDecimal.Bilhao, new ConfiguracaoDecimal(12,11,10, "bilhão","bilhões")}
        };
        public Numero(decimal valor)
        {
            Valor = valor;
            var valorInteiro = Convert.ToInt32(Math.Floor(Valor));
            TextoValorInteiro = valorInteiro.ToString();
            TextoValorDecimal = Convert.ToInt32(((Valor - valorInteiro) * 100)).ToString();
        }

        public decimal Valor { get; private set; }
        public string TextoValorInteiro { get; private set; }
        public string TextoValorDecimal { get; private set; }



        private (int centena, int dezena, int unidade) ObterCentenaDezenaUnidade(ClasseDecimal classeDecimal, string texto)
        {
            var centena = 0;
            var dezena = 0;
            var unidade = 0;

            if (!string.IsNullOrWhiteSpace(texto))
            {
                var configuracao = configuracoes[classeDecimal];
                centena = configuracao.CasaCentena.HasValue && texto.Length >= configuracao.CasaCentena.Value ? Convert.ToInt32(texto.Substring(texto.Length - configuracao.CasaCentena.Value, 1)) : 0;
                dezena = texto.Length >= configuracao.CasaDezena ? Convert.ToInt32(texto.Substring(texto.Length - configuracao.CasaDezena, 1)) : 0;
                unidade = texto.Length >= configuracao.CasaUnidade ? Convert.ToInt32(texto.Substring(texto.Length - configuracao.CasaUnidade, 1)) : 0;
            }

            return (centena, dezena, unidade);
        }

        public string ObterPorExtenso()
        {
            StringBuilder porExtenso = new StringBuilder();

            ObterCentenaDezenaUnidadePorExtenso(ClasseDecimal.Bilhao, ObterCentenaDezenaUnidade(ClasseDecimal.Bilhao, TextoValorInteiro), ref porExtenso);
            ObterCentenaDezenaUnidadePorExtenso(ClasseDecimal.Milhao, ObterCentenaDezenaUnidade(ClasseDecimal.Milhao, TextoValorInteiro), ref porExtenso);
            ObterCentenaDezenaUnidadePorExtenso(ClasseDecimal.Milhar, ObterCentenaDezenaUnidade(ClasseDecimal.Milhar, TextoValorInteiro), ref porExtenso);
            ObterCentenaDezenaUnidadePorExtenso(ClasseDecimal.Centenas, ObterCentenaDezenaUnidade(ClasseDecimal.Centenas, TextoValorInteiro), ref porExtenso);

            ObterCentenaDezenaUnidadePorExtenso(ClasseDecimal.Centavos, ObterCentenaDezenaUnidade(ClasseDecimal.Centavos, TextoValorDecimal), ref porExtenso);
            return porExtenso.ToString().Trim();
        }

        private void ObterCentenaDezenaUnidadePorExtenso(ClasseDecimal classeDecimal, (int centena, int dezena, int unidade) unidades, ref StringBuilder porExtenso)
        {
            if (unidades.centena == 0 && unidades.dezena == 0 && unidades.unidade == 0)
                return;
            string centenaExtenso = string.Empty;
            string dezenaExtenso = string.Empty;
            string unidadeExtenso = string.Empty;

            var configuracao = configuracoes[classeDecimal];

            if (unidades.centena > 0)
            {
                centenaExtenso = (unidades.centena == 1 && unidades.dezena == 0 && unidades.unidade == 0) ? SistemaDecimal.Centenas[0] : SistemaDecimal.Centenas[unidades.centena];
            }

            if (unidades.dezena > 1)
            {
                dezenaExtenso = SistemaDecimal.Dezenas[unidades.dezena];
            }

            if (unidades.unidade > 0 || unidades.dezena == 1)
            {
                unidadeExtenso = SistemaDecimal.Unidades[unidades.dezena == 1 ? unidades.unidade + 10 : unidades.unidade];
            }

            const string conjucao = " e ";

            porExtenso.AppendIfNotNull("{0}", porExtenso.Length > 0 && (centenaExtenso.IsNotNullOrNotEmpty() || dezenaExtenso.IsNotNullOrNotEmpty() || unidadeExtenso.IsNotNullOrNotEmpty()) ? conjucao : string.Empty);
            porExtenso.AppendIfNotNull("{0}", centenaExtenso);
            porExtenso.AppendIfNotNull("{0}{1}", centenaExtenso.IsNotNullOrNotEmpty() && dezenaExtenso.IsNotNullOrNotEmpty() && unidadeExtenso.IsNotNullOrNotEmpty() ? conjucao : string.Empty, dezenaExtenso);
            porExtenso.AppendIfNotNull("{0}{1}", unidadeExtenso.IsNotNullOrNotEmpty() && (centenaExtenso.IsNotNullOrNotEmpty() || dezenaExtenso.IsNotNullOrNotEmpty()) ? conjucao : string.Empty, unidadeExtenso);
            porExtenso.AppendIfNotNull(" {0}", (unidades.unidade == 1 && unidades.dezena == 0 && unidades.centena == 0 ? configuracao.DescricaoClasseSingular : configuracao.DescricaoClassePlural));
            if (classeDecimal != ClasseDecimal.Centavos)
            {
                const string moedaPlural = " reais";
                const string moedaSingular = " real";
                porExtenso.Replace(moedaPlural, string.Empty).Replace(moedaSingular, string.Empty);
                porExtenso.AppendIfNotNull("{0}", Valor > 1 ? moedaPlural : moedaSingular);
            }

        }

        public override string ToString()
        {
            return ObterPorExtenso();
        }
    }
}
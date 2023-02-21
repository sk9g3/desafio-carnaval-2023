namespace desafio_05
{
    public class ConfiguracaoDecimal
    {
        public ConfiguracaoDecimal(int? casaCentena, int casaDezena, int casaUnidade)
         => (CasaCentena, CasaDezena, CasaUnidade) = (casaCentena, casaDezena, casaUnidade);
        public ConfiguracaoDecimal(int casaDezena, int casaUnidade, string descricaoClasseSingular, string descricaoClassePlural)
         => (CasaDezena, CasaUnidade, DescricaoClasseSingular, DescricaoClassePlural) = (casaDezena, casaUnidade, descricaoClasseSingular, descricaoClassePlural);
        public ConfiguracaoDecimal(int? casaCentena, int casaDezena, int casaUnidade, string descricaoClasseSingular, string descricaoClassePlural) : this(casaDezena, casaUnidade, descricaoClasseSingular, descricaoClassePlural)
         => (CasaCentena) = (casaCentena);

        public int? CasaCentena { get; init; }
        public int CasaDezena { get; init; }
        public int CasaUnidade { get; init; }
        public string? DescricaoClasseSingular { get; init; }
        public string? DescricaoClassePlural { get; init; }
    }
}
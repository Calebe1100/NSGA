namespace NSGA
{
    public class Individuo
    {
        public List<Individuo> Individuos { get; set; }

        public double[] Genes { get; set; }
        public double[] Objetivos { get; set; }
        public int N { get; set; }
        public int R { get; set; }
        public string Descricao { get; set; }
        public Individuo(int qtdGenes, int qtdObj)
        {
            this.Genes = new double[qtdGenes];
            this.Objetivos = new double[qtdObj];
        }
        public Individuo(double[] genes, double[] objetivo, string descricao)
        {
            this.Genes = genes;
            this.Objetivos = objetivo;
            this.Descricao = descricao;
        }
    }
}

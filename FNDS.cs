namespace NSGA
{
    public class FNDS
    {
        public static List<List<Individuo>> Execute(List<Individuo> pop)
        {
            var fronteiras = new List<List<Individuo>>();
            var fronteiraAtual = new List<Individuo>();

            foreach (var ind in pop)
            {
                ind.Individuos = new List<Individuo>();
                ind.N = 0;

                foreach (var indAux in pop)
                {
                    if (Domina(ind, indAux))
                    {
                        ind.Individuos.Add(indAux);
                    }
                    else if (Domina(indAux, ind))
                    {
                        ind.N++;
                    }
                }

                if (ind.N == 0)
                {
                    ind.R = 1;
                    fronteiraAtual.Add(ind);
                }
            }

            fronteiras.Add(fronteiraAtual);

            int i = 1;

            while (fronteiraAtual.Count > 0)
            {
                var qBig = new List<Individuo>();

                foreach (var p in fronteiraAtual)
                {
                    foreach (var q in p.Individuos)
                    {
                        q.N--;

                        if (q.N == 0)
                        {
                            q.R = i + 1;
                            qBig.Add(q);
                        }
                    }
                }

                i++;
                fronteiras.Add(qBig);
                fronteiraAtual = qBig;
            }

            return fronteiras;
        }

        public static bool Domina(Individuo p, Individuo q)
        {
            for (int i = 0; i < p.Objetivos.Length; i++)
            {
                if (q.Objetivos[i] < p.Objetivos[i])
                {
                    return false;
                }
            }

            bool ret = false;

            for (int i = 0; i < p.Objetivos.Length; i++)
            {
                if (p.Objetivos[i] < q.Objetivos[i])
                {
                    ret = true;
                    break;
                }
            }

            return ret;
        }
    }
}

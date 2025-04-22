using NSGA;

public class Program
{
    public static void Main(string[] args)
    {
        var pop = new List<Individuo>
        {
            new Individuo(new double[] { 1 }, new double[] { 1, 5 }, "A"),
            new Individuo(new double[] { 2 }, new double[] { 2, 3 }, "B"),
            new Individuo(new double[] { 3 }, new double[] { 4, 1 }, "C"),
            new Individuo(new double[] { 4 }, new double[] { 3, 4 }, "D"),
            new Individuo(new double[] { 5 }, new double[] { 4, 3 }, "E"),
            new Individuo(new double[] { 6 }, new double[] { 5, 5 }, "F")
        };

        var fronteiras = FNDS.Execute(pop);

        int i = 1;
        foreach (var list in fronteiras)
        {
            Console.WriteLine($"Elementos da fronteira {i}");
            foreach (var ind in list)
            {
                Console.Write($" {ind.Descricao};");
            }
            i++;
            Console.WriteLine("\n");
        }
    }
}
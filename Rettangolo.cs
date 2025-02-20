namespace FormeGeometriche_EX
{
    public class Rettangolo : IFormeGeometriche
    {
        private readonly double _altezza;
        private readonly double _base;

        public Rettangolo(double altezza, double @base)
        {
            _altezza = altezza;
            _base = @base;
            Console.WriteLine(value: $"l'area del rettangolo è: {CalcArea()}\ned il perimetro è: {CalcPerimetro()} ");

        }

        public double CalcArea()
        {
            return _base*_altezza;
        }

        public double CalcPerimetro()
        {
            return 2*(_base+_altezza);
        }
    }
}

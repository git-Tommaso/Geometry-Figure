namespace FormeGeometriche_EX
{
    public class Triangolo : IFormeGeometriche
    {
        private readonly double _altezza;
        private readonly double _base;

        public Triangolo(double altezza, double @base)
        {
            _altezza = altezza;
            _base = @base;
            Console.WriteLine(value: $"l'area del triangolo è: {CalcArea()}\ned il perimetro è: {CalcPerimetro()} ");

        }

        public double CalcArea()
        {
            return (_base * _altezza) / 2;
        }

        public double CalcPerimetro()
        {
            return Math.Sqrt((_base * _base) + (_altezza * _altezza)) + _base + _altezza;
        }
    }
}

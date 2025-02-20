namespace FormeGeometriche_EX
{
    public class Cerchio : IFormeGeometriche
    {
        const float pi = (float)Math.PI;
        private readonly double _raggio;

        public Cerchio(double raggio)
        {
            this._raggio = raggio;
            Console.WriteLine(value: $"l'area del cerchio è: {CalcArea()}\ned il perimetro è: {CalcPerimetro()} ");
        }

        public double CalcArea()
        {
            return pi * _raggio * _raggio;
        }
        public double CalcPerimetro()
        {
            return 2 * pi * _raggio;
        }
    }
}

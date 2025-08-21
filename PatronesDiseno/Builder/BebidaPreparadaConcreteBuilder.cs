namespace PatronesDiseno.Builder
{
    public class BebidaPreparadaConcreteBuilder : IBuilder
    {

        private BebidaPreparada _bebidaPreparada;
        // Constructor
        public BebidaPreparadaConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _bebidaPreparada = new BebidaPreparada();
        }

        public void SetAlcohol(decimal alcohol)
        {
            _bebidaPreparada.Alcohol = alcohol;
        }

        public void SetAgua(int agua)
        {
            _bebidaPreparada.Agua = agua;
        }

        public void SetLeche(int leche)
        {
            _bebidaPreparada.Leche = leche;
        }

        public void SetIngredientes(string ingrediente)
        {
            if (_bebidaPreparada.Ingredientes == null)
            {
                _bebidaPreparada.Ingredientes = new List<string>();
            }
            _bebidaPreparada.Ingredientes.Add(ingrediente);
        }

        public void Mix()
        {
            string ingredientes = _bebidaPreparada.Ingredientes.Aggregate((current, next) => current + ", " + next);
            _bebidaPreparada.Result = ingredientes;
            Console.WriteLine($"Mezclando ingredientes: {ingredientes}");
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine($"Listo para beberse");
        }

        public BebidaPreparada GetBebidaPreparada()
        {
            return _bebidaPreparada;
        }
    }
}

namespace PatronesDiseno.Builder
{
    public interface IBuilder
    {
        public void Reset();
        public void SetAlcohol(decimal alcohol);
        public void SetAgua(int agua);
        public void SetLeche(int leche);
        public void SetIngredientes(string ingredientes);
        public void Mix();
        public void Rest(int time);
    }
}
namespace PatronesDiseno.Builder
{
    // Clase base para una bebida preparada
    public class BebidaPreparada
    {
        public string Result { get; set; }
        public List<String> Ingredientes { get; set; } = new List<string>();
        public int Leche { get; set; }
        public int Agua { get; set; }
        public decimal Alcohol { get; set; }



    }
}
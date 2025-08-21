using System;

namespace PatronesDiseno.Builder
{
    public class BarmanDirector
    {
        private IBuilder _builder;

        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }


        public void PrepareDrink()
        {
            _builder.Reset();
            _builder.SetIngredientes("Tequila");
            _builder.SetAlcohol(10);
            _builder.Mix();
            _builder.Rest(1000);
        }
    }
}
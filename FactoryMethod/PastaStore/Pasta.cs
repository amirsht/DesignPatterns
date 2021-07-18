using System.Collections.Generic;

namespace PastaStore
{
    public abstract class Pasta
    {
        private List<string> _ingredients = new List<string>();

        public Pasta()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();

        public List<string> Ingredients => _ingredients;
    }
}

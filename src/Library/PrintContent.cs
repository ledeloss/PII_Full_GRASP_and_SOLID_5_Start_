/*

namespace Full_GRASP_And_SOLID
{
 public class PrintContent : IReceipeContent
    {
        private Recipe receta;
        
        public  PrintRecipe(Recipe receta)
        {
            this.receta = receta;
        }
        
        public string GetTextToPrint()
        {
         string result = $"Receta de {this.receta.Description}:\n";
            foreach (BaseStep step in this.)
            {
                result = result + step.GetTextToPrint() + "\n";
            }

            // Agregado por Expert
            result = result + $"Costo de producción: {this.GetProductionCost()}";

            return result;
    }
}

*/
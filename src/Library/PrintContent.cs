
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
            string result = "Receta";
            return result;
        }
    }
}
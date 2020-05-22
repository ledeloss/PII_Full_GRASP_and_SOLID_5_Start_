using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IReceipeContent recipecontent)
        {
            File.WriteAllText("Recipe.txt", recipecontent.GetTextToPrint());
        }
    }
}
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\Users\\Hp\\Documents\\GitHub\\3Modul\\HomeTask\\.gitignore";
            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }
            else
            {
                Console.WriteLine("  File Exists ");
            }
        }
    }
}
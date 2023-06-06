namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Hp\\Documents\\GitHub\\";
            Determination(path);
        }
        static void Determination(string path)
        {
            string[] folder = Directory.GetDirectories(path);
            string[] file = Directory.GetFiles(path);

            if (folder.Length != 0 && file.Length != 0)
                Console.WriteLine(" There are folders and filies.");

            else if (folder.Length != 0)
                Console.WriteLine(" There is a folder.");

            else if (file.Length != 0)
                Console.WriteLine(" There is a file..");

            else
                Console.WriteLine(" Folder and file are empty.");
        }
    }
}
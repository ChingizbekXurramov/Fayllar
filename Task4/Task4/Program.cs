namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Hp\\Documents\\GitHub\\3Modul\\HomeTask\\HomeTask1\\Directory\\HomeWork1";
            int count = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.ReadLine() != null)
                {
                    count++;
                }
            }
            Console.WriteLine($" Qatorlar soni: {count}");
        }
    }
}
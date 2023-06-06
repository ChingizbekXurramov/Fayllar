namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string files1 = "C:\\Users\\Hp\\Documents\\GitHub\\3Modul\\HomeTask\\HomeTask1\\Directory\\HomeWork1\\Directory-DirectoryInfo1";
            string files2 = "C:\\Users\\Hp\\Documents\\GitHub\\3Modul\\New";
            File.Copy(files1, files2, true);
        }
    }
}
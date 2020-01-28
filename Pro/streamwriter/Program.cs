using System;
using System.IO;

namespace steamwriter
{
    class Program
    {
        private static string path = "./mijntext.txt";
        private static bool result;
        static void Main(string[] args)
        {

            writeToFile("dit is de eerste regel");
            writeToFile("dit is de tweede regel");
        
        }
        static bool writeToFile(string text)
            {
                using (System.IO.StreamWriter file =
                           new System.IO.StreamWriter(path, true))
                    try
                    {
                        file.WriteLine(text);
                        result = true;
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("IOException:\r\n\r\n" + ex.Message);
                        result = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception:\r\n\r\n" + ex.Message);
                        result = false;
                    }
                    finally
                    {
                        if (file != null)
                        {
                            file.Flush();
                            file.Close();
                            file.Dispose();
                        }
                    }
                Console.WriteLine(result);
                return result;

            }
    }
}
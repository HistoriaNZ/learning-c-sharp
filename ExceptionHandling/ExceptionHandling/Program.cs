using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\Tom\source\repos\exceptionData.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            //more specific exceptions handled explicitly
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n");
                Console.WriteLine("Please check if the file {0} exists.", ex.FileName);
                Console.ReadLine();
            }
            //generic catch LAST
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Generic exception block.");
                Console.ReadLine();
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                    Console.WriteLine("finally block reached.");
                    Console.ReadLine();
                    Console.WriteLine("This block is never reached if the catch fails?");
                }
                
            }
        }
    }
}

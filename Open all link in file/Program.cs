using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_all_link_in_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program will open URI than in text file.");
            Console.WriteLine("Plz remove all none URI text in the file.");
            Console.WriteLine("Text shoud be in UTF8 format.");
            Console.WriteLine("Created by: Dr.Mohammad.");
            Console.WriteLine("Enter file path here:");
            string file = Console.ReadLine();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(File.Open(file, FileMode.Open));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open File '" + file + "'.");
                Console.WriteLine("Error Details: " + ex.Message + ".");
                Console.WriteLine("----------------------------------------");
            }
            if (sr != null)
            {
                while (!sr.EndOfStream)
                {
                    string uri = string.Empty;
                    try
                    {
                        uri = sr.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Can not read file '" + file + "'.");
                        Console.WriteLine("Error Details: " + ex.Message + ".");
                        Console.WriteLine("----------------------------------------");
                    }
                    if (uri != string.Empty)

                        try
                        {
                            Process.Start(uri);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Can not open Uri '" + uri + "'.");
                            Console.WriteLine("Error Details: " + ex.Message + ".");
                            Console.WriteLine("----------------------------------------");
                        }
                    Console.WriteLine("Press any key to open nex URI...");
                    Console.ReadKey();
                }
                sr.Close();
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

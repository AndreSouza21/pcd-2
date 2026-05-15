using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PCDAmazonia pcdRio1 = new PCDAmazonia("Rio 1");
            PCDAmazonia pcdRio2 = new PCDAmazonia("Rio 2");

            Universidade usp = new Universidade("USP", new List<string> { "TEMP", "PH" });
            Universidade unifesp = new Universidade("Unifesp", new List<string> { "UMIDADE" });
            Universidade unesp = new Universidade("Unesp", new List<string> { "TEMP" });
            Universidade ufrj = new Universidade("UFRJ", new List<string> { "PH", "UMIDADE" });
            Universidade ufmg = new Universidade("UFMG", new List<string> { "TEMP", "UMIDADE" });

            pcdRio1.AddObserver(usp);
            pcdRio1.AddObserver(unesp);
            pcdRio1.AddObserver(ufmg);

            pcdRio2.AddObserver(unifesp);
            pcdRio2.AddObserver(ufrj);


            Console.WriteLine("Rio 1");
            pcdRio1.TempAgua = 29.5; 
            pcdRio1.PhAgua = 6.2;    

            Console.WriteLine("\nRio 2");
            pcdRio2.UmidadeAr = 88.0;
            pcdRio2.TempAgua = 27.0; 
        }
    }
}

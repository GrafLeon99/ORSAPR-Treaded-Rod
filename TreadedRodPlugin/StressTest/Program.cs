using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.IO;

using Plugin;
using Kompas;


namespace StressTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            int maxModel = 200; 
            using (StreamWriter streamWriter =
                new StreamWriter("./stressTest.txt"))
            {
                for (int count = 0; count < maxModel; count++)
                {
                    ModelBuilder modelBuider = new ModelBuilder();
                    ModelParameters modelParameters = new ModelParameters();
                    
                    modelBuider.BuildModel(modelParameters);

                    var computerInfo = new ComputerInfo();
                    var usedMemory = computerInfo.TotalPhysicalMemory 
                        - computerInfo.AvailablePhysicalMemory;
                    streamWriter.WriteLineAsync($"{count}\t" +
                        $"{stopWatch.ElapsedMilliseconds}\t{usedMemory}");
                    streamWriter.Flush();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace CSharp_Net_module1_7_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////1, 2, 3, 4, 5 task
            //string filename = "Computers.json";
            //List<Computer> list = new List<Computer> { new Computer(50, 4000, 8, 2000), new Computer(51, 5800, 16, 8000)};
            //InOutOperation operations = new InOutOperation();
            //operations.WriteDataObjectJson(list[0], filename);
            //operations.WriteDataObjectJson(list[1], filename);
            //Console.WriteLine("Worked method : Write data !");
            //list = operations.ReadDataJson(filename);
            //Console.WriteLine("Worked method : Read data !");
            //foreach (var item in list)
            //{ 
            //    Console.WriteLine(item);
            //}
            //List<Computer> computers = new List<Computer> { new Computer(53, 5000, 32, 10000)};
            //operations.WriteZip(computers, filename);
            //computers = operations.ReadZip(filename);
            //foreach (Computer item in computers)
            //{
            //    Console.WriteLine(item); ;
            //}
            //////////6 task
            //string filename = "Computers.json";
            //InOutOperation operations = new InOutOperation();
            //Console.WriteLine("*");
            //List<Computer> computers = operations.ReadDataJsonAsync(filename).Result;
            //foreach (var item in computers)
            //{
            //    Console.WriteLine(item);
            //}
            // 3) create collection of computers;
            // set path to file and file name

            // 4) save data and read it in the seamplest way (with WriteData() and ReadData() methods)

            // 5) save data and read it with WriteZip() and ReadZip() methods
            // Note: create another file for these operations

            // 6) read info about computers asynchronously (from the 1st file)
            // While asynchronous method will be running, Main() method must print ‘*’ 

            // use 
            // collection of Task with info about computers as type to get returned data from method ReadAsync()
            // use property Result of collection of Task to get access to info about computers

            // Note:
            // print all info about computers after reading from files
            ////////////8 Task ADVANCED
            //string filename = "Computers.bin";
            //Computer computer = new Computer(4, 3200, 8, 1000);
            //InOutOperation inOutOperation = new InOutOperation();
            //FileStream fs = null;
            //fs = inOutOperation.WriteToMemoryStream(computer, filename);
            //string ReadedBytesFromFile = inOutOperation.WriteToFileFromMemoryStream(fs);
            //Console.WriteLine(ReadedBytesFromFile);
            //fs.Close();
            // ADVANCED:
            // 8) save data to memory stream and from memory to file
            // declare file stream and set it to null
            // call method WriteToMemory() with info about computers as parameter
            // save returned stream to file stream

            // call method WriteToFileFromMemory() with parameter of file stream
            // open file with saved data and compare it with input info
            
                        
            Console.ReadKey();
        }
    }
}

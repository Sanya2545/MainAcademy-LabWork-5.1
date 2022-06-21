using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace CSharp_Net_module1_7_1_lab
{
    class InOutOperation
    {
        public string CurrentPath { get; set; }
        public string CurrentDirectory { get; set; }
        public string CurrentFile{ get; set; }
        // 1) declare properties  CurrentPath - path to file (without name of file), CurrentDirectory - name of current directory,
        // CurrentFile - name of current file
        public InOutOperation()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\MainAcademy\C# .NET\LabWorks\Module_5\LabWork#5.1\(begin)CSharp_Net_module5_1_lab\CSharp_Net_module1_7_1_lab\CSharp_Net_module1_7_1_lab\bin\Debug");
            CurrentPath = directoryInfo.FullName;
            CurrentDirectory = directoryInfo.Name;
            CurrentFile = "CSharp_Net_module1_7_1_lab.exe";
        }
        public void ChangeLocation(string filepath)
        {
            CurrentPath = filepath;
            if(!Directory.Exists(filepath))
            {
                CreateDirectory(filepath);
            }
        }
        public void CreateDirectory (string nameOfDirectory)
        {
            Directory.CreateDirectory(nameOfDirectory);
        }
        public void WriteData(List<Computer> data)
        {
            string filename = "SomeText.txt";
            using (FileStream fs = File.Open(CurrentPath + filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                StreamWriter streamWriter = new StreamWriter(fs);
                for (int i = 0; i < data.Count; ++i)
                {
                    streamWriter.Write(data[i].ToString());
                }
            }
        }
        public List<Computer> ReadData()
        {
            List<Computer> computers = new List<Computer>(); 
            string filename = "SomeText.txt";
            using (FileStream fs = File.Open(CurrentPath + filename, FileMode.OpenOrCreate, FileAccess.Read))
            {
                char[] separators = new char[] { ' ', '\n' };
                StreamReader streamReader = new StreamReader(fs);
                for (int i = 0; streamReader.ReadLine() != null; ++i)
                {
                    string[] props;
                    props = streamReader.ReadLine().Split(separators, 4);
                        Computer computer = new Computer(Convert.ToInt32(props[0]), Convert.ToDouble(props[1]),
                            Convert.ToInt32(props[2]), Convert.ToInt32(props[3]));
                    computers.Add(computer);
                }
            }
            return computers;
        }
        public void WriteZip(Computer[] data )
        {

        }
        //public Computer [] ReadZip()
        //{

        //}
        //public Task ReadAsync()
        //{

        //}
        // 2) declare public methods:
        //ChangeLocation() - change of CurrentPath; 
        // method takes new file path as parameter, creates new directories (if it is necessary)

        // CreateDirectory() - create new directory in current location

        // WriteData() – save data to file
        // method takes data (info about computers) as parameter

        // ReadData() – read data from file
        // method returns info about computers after reading it from file

        // WriteZip() – save data to zip file
        // method takes data (info about computers) as parameter

        // ReadZip() – read data from file
        // method returns info about computers after reading it from file

        // ReadAsync() – read data from file asynchronously
        // method is async
        // method returns Task with info about computers
        // use ReadLineAsync() method to read data from file
        // Note: don't forget about await

        // 7)
        // ADVANCED:
        // WriteToMemoryStream() – save data to memory stream
        // method takes data (info about computers) as parameter
        // info about computers is saved to Memory Stream

        // use  method GetBytes() from class UnicodeEncoding to save array of bytes from string data 
        // create new file stream
        // use method WriteTo() to save memory stream to file stream 
        // method returns file stream

        // WriteToFileFromMemoryStream() – save data to file from memory stream and read it
        // method takes file stream as parameter
        // save data to file      


        // Note: 
        // - use '//' in path string or @ before it (for correct path handling without escape sequence)
        // - use 'using' keyword to organize correct working with files
        // - don't forget to check path before any file or directory operations
        // - don't forget to check existed directory and file before creating
        // use File class to check files, Directory class to check directories, Path to check path


    }
}

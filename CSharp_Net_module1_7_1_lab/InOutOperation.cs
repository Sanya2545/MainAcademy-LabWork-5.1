using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Threading;
using Newtonsoft.Json;

namespace CSharp_Net_module1_7_1_lab
{
    class InOutOperation
    {
        public string CurrentPath { get; set; }
        public string CurrentDirectory { get; set; }
        public string CurrentFile{ get; set; }
        string ZipPath = "rezult.zip";
        string extractPath = "extract";
        // 1) declare properties  CurrentPath - path to file (without name of file), CurrentDirectory - name of current directory,
        // CurrentFile - name of current file
        private List<Computer> computers = new List<Computer>();
        public InOutOperation()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\MainAcademy\C# .NET\LabWorks\Module_5\LabWork#5.1\(begin)CSharp_Net_module5_1_lab\CSharp_Net_module1_7_1_lab\CSharp_Net_module1_7_1_lab\bin\Debug");
            CurrentPath = directoryInfo.FullName;
            CurrentDirectory = directoryInfo.Name;
            CurrentFile = "CSharp_Net_module1_7_1_lab.exe";
            ZipPath = "result.zip";
            extractPath = "extract.json";
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
            if(Directory.Exists(nameOfDirectory))
            {
                return;
            }
            Directory.CreateDirectory(nameOfDirectory);
        }
        public void WriteDataObjectJson(Computer data, string filename, FileMode fileMode = FileMode.Append)
        {
            string strJson = JsonConvert.SerializeObject(data);
            using (FileStream fs = new FileStream(filename, fileMode, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.NewLine = "\n";
                sw.WriteLine(strJson);
                sw.Close();
            }
        }
        public List<Computer> ReadDataJson(string filename)
        {
            List<Computer> computers = new List<Computer>();
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    StreamReader streamReader = new StreamReader(fs);
                    List<string> stringsJson = new List<string>();
                    stringsJson = streamReader.ReadToEnd().Split('\n').ToList();
                    foreach(string item in stringsJson)
                    {
                        computers.Add(JsonConvert.DeserializeObject<Computer>(item));
                    }
                    //JsonConvert.DeserializeObject<List<Computer>>(stringsJson.ToString());
                    //computers = JsonConvert.DeserializeObject<List<Computer>>(streamReader.ReadToEnd());
                    streamReader.Close();
                }
            }
            else
            {
                throw new ArgumentException("This file does not exists, you can't read it !");
            }
            return computers;
        }
        public void WriteZip(List<Computer> data, string filename, FileMode fileMode = FileMode.OpenOrCreate)
        {
            string zipFolderName = "ZipFolder";
            string zipFolderPath = CurrentPath + @"\" + zipFolderName;
            Directory.CreateDirectory(zipFolderPath);
            for (int i = 0; i < data.Count; ++i)
            {
                WriteDataObjectJson(data[i], zipFolderPath+ @"\" + filename, fileMode);
            }
            ZipFile.CreateFromDirectory(zipFolderPath, ZipPath);

        }
        public List<Computer> ReadZip()
        {
            ZipFile.ExtractToDirectory(ZipPath, extractPath);
            return ReadDataJson(extractPath);
        }
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

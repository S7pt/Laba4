using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Laba4Task3.menu;
using Laba4Task3.models;
using Laba4Task3.WorkWithFile;

namespace Laba4Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D://Students.txt";
            List <Performance>performances=new List<Performance>();
            FileEdit fileEdit = new FileEdit();
            fileEdit.FileInformationRead(path,performances);
            Menu menuObject=new Menu(path,performances);
            menuObject.OpenMenu();
        }
    }
}
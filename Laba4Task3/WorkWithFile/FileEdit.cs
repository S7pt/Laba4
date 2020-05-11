using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Laba4Task3.models;

namespace Laba4Task3.WorkWithFile
{
    public class FileEdit
    {
        public void FileInformationRewrite(string path, List<Performance> performances)
        {
            File.WriteAllText(path,String.Empty);
            using (StreamWriter sw=new StreamWriter(path))
            {
                foreach (Performance informationUnit in performances)
                {
                    sw.WriteLine(informationUnit.ToString());
                }
            }
        }
        public void FileInformationRead(string path,List<Performance> performanceList)
        {
            string reader;
            string[] stringArray;
            using (StreamReader streamReader=new StreamReader(path))
            {
                while (streamReader.EndOfStream == false)
                {
                    reader = streamReader.ReadLine();
                    if (reader != ""&& reader != " ")
                    {
                        stringArray = reader.Split(" ");
                        performanceList.Add(new Performance(stringArray[0], stringArray[1], int.Parse(stringArray[2]),
                            int.Parse(stringArray[3]), int.Parse(stringArray[4])));
                    }
                } } }
        public void FileInformationWrite(List<Performance> performanceList,string path)
        {
            using (StreamWriter studentInformationWriter=new StreamWriter(path))
            {
                Console.WriteLine("Type student surname: ");
                string surnameOfStudent = Console.ReadLine();
                Console.WriteLine("Type student group");
                string groupOfStudent = Console.ReadLine();
                Console.WriteLine("Type student Ukrainian language mark");
                int ukrainianLanguageMark = int.Parse(Console.ReadLine());
                Console.WriteLine("Type student Mathematics mark");
                int mathematicsMark = int.Parse(Console.ReadLine());
                Console.WriteLine("Type student English language mark");
                int englishMark = int.Parse(Console.ReadLine());
                Performance studentInformationToAdd=new Performance(surnameOfStudent, groupOfStudent,ukrainianLanguageMark,
                    mathematicsMark,englishMark);
                performanceList.Add(studentInformationToAdd);
                foreach (Performance performanceUnit in performanceList)
                {
                    studentInformationWriter.WriteLine(performanceUnit.ToString());
                }
            }
        }

        public void FileInformationEdit(List<Performance> performanceList, string path)
        {
            for (int i = 0; i < performanceList.Count; i++)
            {
                Console.WriteLine(i+1+"."+performanceList[i]);
            }
            Console.WriteLine("Type the number of student you want to edit");
            int number = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Select action:");
            Console.WriteLine("1.Edit surname");
            Console.WriteLine("2.Edit group");
            Console.WriteLine("3.Edit Ukrainian language mark");
            Console.WriteLine("4.Edit Mathematics mark");
            Console.WriteLine("5.Edit English language mark");
            Console.WriteLine("6.Edit all parameters");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    Console.WriteLine("Type new surname");
                    performanceList[number].SetSurname(Console.ReadLine());
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Type new group");
                    performanceList[number].SetGroup(Console.ReadLine());
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Type new mark");
                    performanceList[number].SetUkrainianMark(int.Parse(Console.ReadLine()));
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Type new mark");
                    performanceList[number].SetMathematicsMark(int.Parse(Console.ReadLine()));
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Type new mark");
                    performanceList[number].SetEnglishLanguageMark(int.Parse(Console.ReadLine()));
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Type new surname");
                    performanceList[number].SetSurname(Console.ReadLine());
                    Console.WriteLine("Type new group");
                    performanceList[number].SetGroup(Console.ReadLine());
                    Console.WriteLine("Type new mark");
                    performanceList[number].SetUkrainianMark(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Type new mark");
                    performanceList[number].SetMathematicsMark(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Type new mark");
                    performanceList[number].SetEnglishLanguageMark(int.Parse(Console.ReadLine()));
                    break;
                }
                default:
                {
                    throw new ArgumentException("You typed the wrong symbol");
                }
            }
            File.WriteAllText(path,String.Empty);
            using (StreamWriter sw=new StreamWriter(path))
            {
                foreach (Performance informationUnit in performanceList)
                {
                    sw.WriteLine(informationUnit.ToString());
                }
            } }

        public void RemoveExistingStudent(List<Performance> performanceList, string path)
        {
            for (int i = 0; i < performanceList.Count; i++)
            {
                Console.WriteLine(i+1+"."+performanceList[i].ToString());
            }
            Console.WriteLine("Type the number of student you want to remove");
            int number = int.Parse(Console.ReadLine())-1;
            performanceList.RemoveAt(number);
            File.WriteAllText(path,String.Empty);
            using (StreamWriter sw=new StreamWriter(path))
            {
                foreach (Performance informationUnit in performanceList)
                {
                    sw.WriteLine(informationUnit.ToString());
                }
            }
        }
        
    }
}
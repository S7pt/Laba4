using System;
using System.Collections.Generic;
using System.IO;
using Laba4Task3.manager;
using Laba4Task3.models;
using Laba4Task3.WorkWithFile;

namespace Laba4Task3.menu
{
    public class Menu
    {
        private string path;
        private List<Performance> studentsInformation;

        public Menu(string path,List<Performance> list)
        {
            this.path = path;
            studentsInformation = list;
        }
        public void OpenMenu()
        {
            FileEdit fileEdit = new FileEdit();
            Console.WriteLine("1.Add a new student information");
            Console.WriteLine("2.Edit existing information");
            Console.WriteLine("3.Destroy existing information");
            Console.WriteLine("4.Show the existing information");
            Console.WriteLine("5.Sort students alphabetically");
            Console.WriteLine("6.Search by specified group");
            Console.WriteLine("7.Exit");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    fileEdit.FileInformationWrite(studentsInformation,path);
                    Console.ReadKey();
                   OpenMenu();
                   break;
                }
                case 2:
                {
                    fileEdit.FileInformationEdit(studentsInformation,path);
                    Console.ReadLine();
                    OpenMenu();
                    break;
                }
                case 3:
                {
                    fileEdit.RemoveExistingStudent(studentsInformation,path);
                    Console.ReadLine();
                    OpenMenu();
                    break;
                }
                case 4:
                {
                    foreach (Performance informationUnit in studentsInformation)
                    {
                        Console.WriteLine(informationUnit.ToString());
                    }

                    Console.ReadLine();
                    OpenMenu();
                    break;
                }
                case 5:
                {
                   PerformanceManagerUtils.SortByName(studentsInformation,SortType.ASCENDING);
                   foreach (Performance performanceUnit in studentsInformation)
                   {
                       Console.WriteLine(performanceUnit.ToString());
                   }
                   fileEdit.FileInformationRewrite(path,studentsInformation);
                   Console.ReadLine();
                   OpenMenu();
                   break;
                }
                case 6:
                {
                    Console.Write("Type the group you want to find:");
                    string group = Console.ReadLine();
                    PerformanceManager manager=new PerformanceManager();
                    List <Performance> filteredList=manager.SearchByGroup(studentsInformation, group);
                    if (filteredList.Count != 0)
                    {
                        foreach (Performance performanceUnit in filteredList)
                        {
                            Console.WriteLine(performanceUnit.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no student matching your group");
                    }

                    Console.ReadLine();
                    OpenMenu();
                    break;
                }
                case 7:
                {
                    break;
                }
                default:
                {
                    throw new ArgumentException("You typed the wrong symbol");
                }
            }
        }
        
    }
}
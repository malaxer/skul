using System;
using System.Collections.Generic;

namespace School
{
    internal static class Program
    {
        private static School _firstSchool;

        public static void Main(string[] args)
        {
            _firstSchool = new School();
            AddMembersFromListGivenToSchool(SchoolMembers.SchoolMembersList);

//            _firstSchool.SortByName(_firstSchool._humans);
//            _firstSchool.ShowMembers();

            Start();
        }
        
        private static void AddMembersFromListGivenToSchool(IReadOnlyList<Human> members)
        {
            var i = 0;
            foreach (var member in members)
            {
                _firstSchool.AddMember(members[i]);
                i++;
            }
        }

        private static void Start()
        {
            while (true)
            {
                var choose = Menu.GetChooseFromTheMenu();
                switch (choose)
                {
                    case 'a':
                        ShowPeopleInSchool();
                        break;
                    case 'b':
                        ShowClasses();
                        break;
                    case 'c':
                        CreateNewClass();
                        break;
                    case 'd':
                        AddMemberToSchool();
                        break;
                    case 'e':
                        AddMemberToClass();
                        break;
                    case 'f':
                        ShowSpecificClassMembers();
                        break;
                    case 'g':
                        LeavingSchool();
                        break;
                    case 'h':
                        AddMemberToSchool();
                        break;
                    case 'i':
                        ShowMembersSortedByName();
                        break;
                    case 'j':
                        ShowMembersSortedByID();
                        break;

                    default:
                        Console.WriteLine("Chujowy choice");
                        continue;
                }
                break;
            }
        }

        private static void ShowPeopleInSchool()
        {
            Console.WriteLine("People in school");
            _firstSchool.ShowMembers();
            Start();
        }
        
        private static void ShowClasses()
        {
            Console.WriteLine("Classes:");
            if(_firstSchool.ShowClasses() == 0)
                Console.WriteLine("You must create class first");
            Start();
        }

        private static void CreateNewClass()
        {
            Console.Write("\nEnter class name: ");
            var name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name)) 
                _firstSchool.AddClass(name.ToString());
            CleanConsoleBuffer();
            Start();
        }

        private static void AddMemberToSchool()
        {
            _firstSchool.AddMember(GetMemberDataFromConsole());
            Start();
        }
        
        private static void AddMemberToClass()
        {
            if(CheckSomeClassExist())
            {
                var className = ShowAndChooseClassesAvailable();
                if (!string.IsNullOrEmpty(className))
                {
                    var _class = _firstSchool.FindAndGetClass(className);
                    Console.WriteLine("Found class: " + _class.Name);
                    _class.AddMember(GetMemberDataFromConsole());
                }
            }
            Start();
        }
        
        private static void ShowSpecificClassMembers()
        {
            if (CheckSomeClassExist())
            {
                var className = ShowAndChooseClassesAvailable();
                if (!string.IsNullOrEmpty(className))
                {
                    var _class = _firstSchool.FindAndGetClass(className);
                    Console.WriteLine("Found class: " + _class.Name);
                    _class.ShowMembers();
                }
            }
            Start();
        }

        private static void LeavingSchool()
        {
            Console.WriteLine("...in school building:");
            _firstSchool.ShowMembers();
            Console.Write("\nType part of name member to leave: ");
            CleanConsoleBuffer();
            var name = Console.ReadLine();
            _firstSchool.LeavingSchool(name);
            CleanConsoleBuffer();
            Start();
        }

        private static void ShowMembersSortedByID()
        {
            _firstSchool.SortByID(_firstSchool._humans);
            ShowPeopleInSchool();
        }

        private static void ShowMembersSortedByName()
        {
            _firstSchool.SortByName(_firstSchool._humans);
            ShowPeopleInSchool();
        }

        private static Human GetMemberDataFromConsole()
        {
            Console.WriteLine("Adding member...");
            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            CleanConsoleBuffer();
            Console.Write("Enter lastname: ");
            CleanConsoleBuffer();
            var lastName = Console.ReadLine();
            CleanConsoleBuffer();
            Console.Write("Enter ID: ");
            var ID = Convert.ToInt32(Console.ReadLine());
            CleanConsoleBuffer();
            
            return new Human(name, lastName, ID);
        }
        
        private static string ShowAndChooseClassesAvailable()
        {
            Console.WriteLine("Classes available:");
            _firstSchool.ShowClasses();
            Console.WriteLine("Choose class: (type part of name)");
            Console.Write(": ");
            CleanConsoleBuffer();
            var className = Console.ReadLine();
            CleanConsoleBuffer();
            return className;
        }

        private static bool CheckSomeClassExist()
        {
            bool exist;
            if (_firstSchool.ShowClasses() == 0)
            {
                Console.WriteLine("You must create class first...");
                exist = false;
            }
            else
            {
                exist = true;
            }
            return exist;
        }
        
        private static void CleanConsoleBuffer()
        {
            while(Console.KeyAvailable) 
            {
                Console.ReadKey(false);
            }
            Console.ReadKey();
        }
    }
}
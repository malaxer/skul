using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    public static class Menu
    {
        public static int GetChooseFromTheMenu() 
        {
            Console.WriteLine("\nChoose option: ");
            Console.WriteLine("a - show people in a school building");
            Console.WriteLine("b - show classes");
            Console.WriteLine("c - create new class");
            Console.WriteLine("d - add new member to school");
            Console.WriteLine("e - add member to class");
            Console.WriteLine("f - show specific class members");
            Console.WriteLine("g - leaving school");
            Console.WriteLine("h - entering school");
            Console.WriteLine("i - sort school members by name");
            Console.WriteLine("j - sort school members by ID");
            
            var choose = Console.Read();
            Console.Clear();
            return choose;
        }
    }
}
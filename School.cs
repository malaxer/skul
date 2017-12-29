using System;
using System.Collections.Generic;

namespace School
{
    public class School : SchoolBase
    {
        private readonly List<SchoolClass> _classes = new List<SchoolClass>();
        
        public void AddClass(string className)
        {
            _classes.Add(new SchoolClass(className));
        }

        public int ShowClasses()
        {
            var i = 1;
            foreach (var _class in _classes)
            {
                Console.WriteLine(i++ + ". " + _class.Name);
            }
            Console.WriteLine("\n");
            return _classes.Count;
        }
        public void LeavingSchool(string partOfName)
        {
            RemoveHuman(partOfName);
        }

//        public void EnteringSchool(Human human) 
//        {                                       
//            AddMember(human);
//        }

        public SchoolClass FindAndGetClass(string name)
        {
            SchoolClass temp = null;
            foreach (var _class in _classes)
            {
                if (_class.Name.Contains(name))
                    temp = _class;
            }
            return temp;
        }
    }
}
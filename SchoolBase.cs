using System;
using System.Collections.Generic;

namespace School
{
    public abstract class SchoolBase : Sorting
    {
        public List<Human> _humans = new List<Human>();

        protected string _name;

        public void AddMember(Human human)
        {
            _humans.Add(human);
        }

        public void ShowMembers()
        {
            var i = 1;
            foreach (var human in _humans)
            {
                Console.WriteLine(i++ + ". " + human.Name + " ID: " + human.ID);
            }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Human FindMember(int ID)
        {
            var temp = new Human();
            foreach (var human in _humans)
            {
                if (human.ID == ID)
                {
                    temp = human;
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            return temp;
        }

        private Human FindMember(string partOfName)
        {
            var temp = new Human();
            partOfName = partOfName.ToLower();
            foreach (var human in _humans)
            {
                var tempName = human.Name.ToLower();
                if (tempName.Contains(partOfName))
                {
                    temp = human;
                }
            }
            return temp;
        }
        
        public void RemoveHuman(int ID)
        {
            _humans.Remove(FindMember(ID));
        }
        
        protected void RemoveHuman(string partOfName)
        {
            _humans.Remove(FindMember(partOfName));
        }
    }
}
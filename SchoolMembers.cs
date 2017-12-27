using System.Collections.Generic;

namespace School
{
    public static class SchoolMembers
    {
        public static readonly List<Human> SchoolMembersList;

        static SchoolMembers()
        {
            SchoolMembersList = new List<Human>()
            {
                new Human("Adam", "Lisicki", 6),
                new Human("Dawid", "Wierzbicki", 2),
                new Human("Stan", "Getz", 4),
                new Human("Jaroslaw", "Kaczynski", 3)
            };
        }
    }
}
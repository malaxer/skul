namespace School
{
    public class Teacher : Human
    {
        public Teacher(string name, string lastName, int ID) : base(name, lastName, ID)
        {
            
        }

        public Teacher(string name, string lastName, int ID, bool isHumanAtSchool) : base(name, lastName, ID, isHumanAtSchool)
        {
            
        }
    }
}
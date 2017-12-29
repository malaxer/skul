namespace School
{
    public class Student : Human
    {
        public Student(string name, string lastName, int ID) : base(name, lastName, ID)
        {
            
        }

        public Student(string name, string lastName, int ID, bool isHumanAtSchool) : base(name, lastName, ID, isHumanAtSchool)
        {
            
        }
    }
}
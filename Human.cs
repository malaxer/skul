namespace School
{
    public class Human
    {
        public Human()
        {
            
        }

        public Human(string name, string lastName, int ID)
        {
            Name = name + " " + lastName;
            this.ID = ID;
        }

        protected Human(string name, string lastName, int ID, bool isHumanAtSchool)
        {
            Name = name + " " + lastName;
            this.ID = ID;
        }
        
        public string Name { get; }

        public int ID { get; }
    }
}
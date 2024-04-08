namespace DefiningClasses
{
    internal class Family
    {
        List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member) => this.members.Add(member);
    
        public Person GetOldestMember() => this.members.OrderByDescending(x => x.Age).First();
    }
}

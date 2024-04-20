namespace ComparingObjects
{
    internal class Person : IComparable<Person>
    {
        private readonly string _name;
        private readonly int _age;
        private readonly string _town;

        public Person(string name, int age, string town)
        {
            this._name = name;
            this._age = age;
            this._town = town;
        }

        public string Name
        {
            get => this._name;
        }

        public int Age
        {
            get => this._age;
        }

        public string Town
        {
            get => this._town;
        }

        public int CompareTo(Person other)
        {
            {
                if (other == null) return 1;

                int nameComarison = this.Name.CompareTo(other.Name);
                if (nameComarison != 0) return nameComarison;

                int ageComparison = this.Age.CompareTo(other.Age);
                if (ageComparison != 0) return ageComparison;

                return this.Town.CompareTo(other.Town);
            }
        }
    }
}

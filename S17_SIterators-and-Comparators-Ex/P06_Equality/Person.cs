using System.Diagnostics.CodeAnalysis;

namespace EqualityLogic
{
    internal class Person : IComparable<Person>
    {
        private readonly string _name;
        private readonly int _age;

        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string Name
        {
            get => this._name;
        }

        public int Age
        {
            get => this._age;
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result != 0)
                return result;
            return this.Age.CompareTo(other.Age);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Age.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null)
                return false;
            return this.Name == other.Name && this.Age == other.Age;
        }
    }
}

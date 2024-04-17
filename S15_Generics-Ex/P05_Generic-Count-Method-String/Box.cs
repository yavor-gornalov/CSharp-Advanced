using System.Text;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        private readonly List<T> list;

        public Box()
        {
            this.list = new List<T>();
        }

        public void Add(T item) { 
            this.list.Add(item); 
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            this.list.ForEach(el => sb.AppendLine($"{typeof(T)}: {el}"));
            return sb.ToString();
        }

        public int CountOfGreaterElements (T item) {
            return this.list.Where(el => el.CompareTo(item) > 0).Count();
        }

    }
}

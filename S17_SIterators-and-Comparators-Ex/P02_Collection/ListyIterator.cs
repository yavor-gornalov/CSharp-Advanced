using System.Collections;

namespace Collection
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private List<T> _list;
        private int _index = 0;

        public ListyIterator(List<T> list)
        {
            this._list = list;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this._index++;
                return true;
            }
            return false;
        }

        public bool HasNext() => this._index < this._list.Count - 1;

        public void Print() {
            if (this._list.Count == 0)
                throw new InvalidOperationException();
            Console.WriteLine(this._list[this._index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this._list.Count; i++)
                yield return this._list[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

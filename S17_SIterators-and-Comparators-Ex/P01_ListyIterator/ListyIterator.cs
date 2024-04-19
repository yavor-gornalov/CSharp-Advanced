namespace ListyIterator
{
    public class ListyIterator<T>
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
    }
}

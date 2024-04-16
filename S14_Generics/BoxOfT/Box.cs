namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove()
        {

            T removedItem = this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            return removedItem;
        }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }
    }
}

using System.Collections;

namespace Stack
{
    internal class CustomStack<T> : IEnumerable<T>
    {
        private List<T> _stack;

        public CustomStack()
        {
            _stack = new List<T>();
        }

        public void Push(T[] items)
        {
            foreach (var item in items)
            {
                this._stack.Add(item);
            }
        }
        public T Pop()
        {
            if (this._stack.Count == 0)
            {
                throw new InvalidOperationException();
            }
            int lastIdx = this._stack.Count - 1;
            var item = this._stack[lastIdx];
            this._stack.RemoveAt(lastIdx);
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = this._stack.Count - 1; i >= 0; i--)
                yield return this._stack[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections;

namespace Froggy
{
    internal class Lake : IEnumerable<int>
    {
        private List<int> _stones;
        public Lake(List<int> stones)
        {
            this._stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this._stones.Count; i += 2)
                yield return this._stones[i];

            for (int i = this._stones.Count - 1; i >= 0; i--)
                if (i % 2 != 0)
                    yield return this._stones[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

namespace Threeuple
{
    public class Threeuple<T1, T2, T3> : CustomTuple<T1, T2>
    {
        private readonly T3 item3;

        public Threeuple(T1 item1, T2 item2, T3 item3) : base(item1, item2)
        {
            this.item3 = item3;
        }

        public T3 Item3 { get { return this.item3; } }

        public override string ToString() => $"{Item1} -> {Item2} -> {Item3}";
    }
}

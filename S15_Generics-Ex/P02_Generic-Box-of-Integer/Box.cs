namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private readonly T value;

        public Box(T value)
        {
            this.value = value;
        }

        //public override string ToString() => this.value.ToString();
        public override string ToString()
        {
            return $"{this.value.GetType().ToString()}: {this.value}";
        }
    }
}

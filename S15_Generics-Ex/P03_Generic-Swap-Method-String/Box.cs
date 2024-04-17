namespace GenericSwapMethodString
{
    public class Box<T>
    {
        private readonly T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.value}";
        }
    }
}

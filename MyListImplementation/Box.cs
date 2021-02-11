namespace MyListImplementation
{
    internal class Box
    {
        public Box(object value)
        {
            Value = value;
            Next = null;
            Index = 0;
        }

        public object Value { get; set; }

        public int Index { get; set; }

        public Box Next { get; set; }
    }
}

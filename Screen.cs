namespace Chapter14
{
    public class Screen
    {

        public int Size;
        public string Colour;
        //question 13
        private string shape { get; set; }

        public Screen(int size, string colour)
        {
            Size = size;
            Colour = colour;
        }
    }
}
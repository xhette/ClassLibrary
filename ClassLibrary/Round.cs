namespace ClassLibrary
{
    public class Round : IFigure
    {
        private readonly double R;

        public Round(double r) : base()
        {
            R = r;
        }

        public double Square()
        {
            return Math.PI * R * R;
        }
    }
}
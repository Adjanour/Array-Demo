
namespace app_demo
{
    public interface IArrayV
    {
        public int numRows { get; set; }
        public int numCols { get; set; }

        public void RequestDimensions();

        public void RequestValues();

        public void Display();
    }
}

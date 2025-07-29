using System;

namespace AppDemo
{
    public interface IArrayVisualizer
    {
        int NumRows { get; set; }
        int NumCols { get; set; }

        void RequestDimensions();
        void RequestValues();
        void Display();
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Array Visualizer ===\n");
            Console.WriteLine("Welcome to Array Visualizer");
            Console.WriteLine("""
                [1] Create 2D Rectangular Array
                [2] Create Jagged Array
                [3] Exit
                """);

            Console.Write("> ");
            if (!int.TryParse(Console.ReadLine(), out int typeChoice))
            {
                Console.WriteLine("Invalid input. Exiting.");
                return;
            }

            if (typeChoice == 3)
            {
                Console.WriteLine("Exiting program.");
                return;
            }

            IArrayVisualizer? arrayVisualizer = typeChoice switch
            {
                1 => new RectangularArray(),
                2 => new JaggedArray(),
                _ => null
            };

            if (arrayVisualizer != null)
            {
                arrayVisualizer.RequestDimensions();
                arrayVisualizer.RequestValues();
                arrayVisualizer.Display();
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
        }
    }

    class RectangularArray : IArrayVisualizer
    {
        public int NumRows { get; set; }
        public int NumCols { get; set; }
        public int[,] Matrix { get; set; }

        public void RequestDimensions()
        {
            Console.Write("Enter number of rows: ");
            NumRows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            NumCols = Convert.ToInt32(Console.ReadLine());

            Matrix = new int[NumRows, NumCols];
        }

        public void RequestValues()
        {
            for (int i = 0; i < NumRows; i++)
            {
                for (int j = 0; j < NumCols; j++)
                {
                    Console.Write($"Enter value for [{i},{j}]: ");
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("\n=== Rectangular Array Visualization ===");
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                int rowSum = 0;
                Console.Write($"Row {i,2}: [ ");
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j],3} ");
                    rowSum += Matrix[i, j];
                }
                Console.WriteLine($"]  → Sum: {rowSum}");
            }
        }
    }

    class JaggedArray : IArrayVisualizer
    {
        public int NumRows { get; set; }
        public int NumCols { get; set; }  // Optional in this context
        public int[][] JArray { get; set; }

        public void RequestDimensions()
        {
            Console.Write("Enter number of rows: ");
            NumRows = Convert.ToInt32(Console.ReadLine());

            JArray = new int[NumRows][];
            for (int i = 0; i < NumRows; i++)
            {
                Console.Write($"Enter number of columns for row {i}: ");
                int cols = Convert.ToInt32(Console.ReadLine());
                JArray[i] = new int[cols];
            }
        }

        public void RequestValues()
        {
            for (int i = 0; i < JArray.Length; i++)
            {
                for (int j = 0; j < JArray[i].Length; j++)
                {
                    Console.Write($"Enter value for [{i},{j}]: ");
                    JArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("\n=== Jagged Array Output ===");
            for (int i = 0; i < JArray.Length; i++)
            {
                Console.Write($"Row {i,2}: ");
                for (int j = 0; j < JArray[i].Length; j++)
                {
                    Console.Write($"{JArray[i][j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}

```
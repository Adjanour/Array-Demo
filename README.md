# Array Visualizer - C# Console Application

## Overview

**Array Visualizer** is a simple C# console application designed to help users create, populate, and visualize two types of arrays:

- **Rectangular (2D) Arrays**: Fixed-size, rectangular grid of elements.
- **Jagged Arrays**: Arrays of arrays where each row can have a different length.

This tool provides an interactive way to input array dimensions and values, then displays the arrays neatly with row sums for rectangular arrays, helping users better understand array structures and their visual representations.


## Features

- Supports creation of both rectangular and jagged arrays.
- Dynamic user input for dimensions and element values.
- Clear, formatted output with row-wise visualization.
- Computes and displays the sum of each row for rectangular arrays.
- Simple menu-driven interface for easy use.


## How to Use

1. Run the program.
2. Choose the array type from the menu:
   - Enter `1` for Rectangular 2D Array.
   - Enter `2` for Jagged Array.
   - Enter `3` to Exit.
3. Input the number of rows (and columns for rectangular arrays).
4. Enter the values for each element as prompted.
5. View the formatted output with row sums (for rectangular arrays).


## Code Structure

- `IArrayVisualizer` interface: Defines the contract for array visualization classes.
- `RectangularArray` class: Implements rectangular 2D array input and display.
- `JaggedArray` class: Implements jagged array input and display.
- `Program` class: Main entry point with the menu and user interaction.


## Example Output

```csharp

=== Array Visualizer ===

Welcome to Array Visualizer
[1] Create 2D Rectangular Array
[2] Create Jagged Array
[3] Exit

> 1
> Enter number of rows: 2
> Enter number of columns: 3
> Enter value for [0,0]: 5
> Enter value for [0,1]: 8
> Enter value for [0,2]: 3
> Enter value for [1,0]: 6
> Enter value for [1,1]: 7
> Enter value for [1,2]: 2

=== Rectangular Array Visualization ===
Row  0: [   5   8   3 ]  → Sum: 16
Row  1: [   6   7   2 ]  → Sum: 15

```


## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.


## Author

Bernard Adjanour  
[GitHub](https://github.com/Adjanour)  
Email: katamansokirk@gmail.com


## Contribution

Feel free to fork, improve, and submit pull requests. Open for feedback and collaboration!


## Acknowledgments

Inspired by the fundamentals of arrays and their importance in computer science and programming education.

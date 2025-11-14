# StringBuilder
A C# educational project demonstrating the performance differences between string concatenation and StringBuilder in .NET.

## Description
This project provides a hands-on demonstration of why StringBuilder is more efficient than standard string concatenation in C#. Through four progressive parts, it showcases how string immutability causes memory overhead with repeated concatenation, and how StringBuilder's mutable buffer provides a more efficient alternative. The program uses hash codes to visually demonstrate that each string concatenation creates a new object, while StringBuilder modifies an existing buffer.

## Features
- **String Concatenation Examples** - Demonstrates inefficient string building with the `+` operator
- **Hash Code Tracking** - Visual representation of object creation using `RuntimeHelpers.GetHashCode()`
- **Performance Comparison** - Side-by-side comparison of 5 iterations vs 1000 iterations
- **Memory Efficiency Analysis** - Shows how garbage collection pressure increases with string concatenation
- **Reference vs Value Demonstration** - Illustrates StringBuilder's reference-type behavior

## Technologies
- **Language/Framework:** C# / .NET (compatible with .NET 6+)
- **Libraries:** 
  - System.Text (StringBuilder class)
  - System.Runtime.CompilerServices (RuntimeHelpers for hash code inspection)

## How to Run (Local)
1. **Clone:** `git clone https://github.com/Sxoony/StringBuilder.git`
2. **Navigate:** `cd StringBuilder`
3. **Setup:**
   - Open the solution in Visual Studio 2022 or later
   - Or open in Visual Studio Code with C# extension
4. **Run:**
   - Press F5 in Visual Studio, or
   - Run `dotnet run` in terminal
   - Observe the console output showing hash codes and performance differences

## Project Structure (4 Parts)

### Part 1: Basic String Operations
- Simple string concatenation with a for loop (40 iterations)
- Demonstrates inefficient memory allocation with repeated `+=` operations
- Displays final string length

### Part 2: Hash Code Visualization
- Smaller scale demonstration (5 iterations)
- Tracks and displays hash codes for each concatenation
- Shows that **each concatenation creates a new string object** with a new hash code
- Visualizes garbage collection pressure as old strings become unreferenced

### Part 3: StringBuilder Efficiency
- Large scale operation (1000 iterations)
- Uses StringBuilder's `Append()` method to build string efficiently
- Modifies existing buffer instead of creating new objects
- Demonstrates consistent hash code (same object throughout)
- Single conversion to immutable string at the end

### Part 4: Reference Type Behavior
- Shows StringBuilder is a reference type
- Demonstrates that assignment creates references, not copies
- Proves both variables point to the same StringBuilder object
- Modifications through one reference affect all references

## Key Concepts Demonstrated

### String Immutability
- Strings in C# are immutable (cannot be changed after creation)
- Each concatenation with `+` or `+=` creates a **new string object**
- Old string objects must be garbage collected, creating memory overhead

### StringBuilder Advantages
- Uses a **resizable array of characters** (mutable buffer)
- Modifies existing buffer instead of creating new objects
- No garbage collection pressure for intermediate values
- Much more efficient for repeated string modifications
- Only converts to immutable string when needed (`ToString()`)

### Performance Impact
```
String Concatenation (1000 iterations):
- Creates 1000 new string objects
- 1000 old objects need garbage collection
- High memory allocation

StringBuilder (1000 iterations):
- Creates 1 StringBuilder object
- Resizes buffer as needed
- 1 final string conversion
- Minimal memory overhead
```

## Expected Output Example
```
data structures and algorithms 
Hello! Hello! ... (repeated 40 times) ... 280
Hash: 54267293
hello 
Iteration 0: Hash: 13092345 and length: 6
hello hello 
Iteration 1: Hash: 29834562 and length: 12
... (hash changes each iteration)
Final String Length: 6000
```

## Learning Objectives
- Understand string immutability in C#
- Learn when to use StringBuilder vs string concatenation
- Visualize object creation through hash codes
- Recognize performance implications of string operations
- Understand reference type behavior in .NET

## Best Practices Demonstrated
✅ Use StringBuilder for loops with string concatenation  
✅ Use regular strings for simple, one-time concatenations  
✅ Convert StringBuilder to string only when final result is needed  
✅ Be aware of reference vs value semantics  

## Author
**Zamir Kruger**  

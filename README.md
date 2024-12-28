# NullReferenceException in C# Example

This repository demonstrates a common C# error: the `NullReferenceException`.  This exception occurs when a program attempts to access a member (method, property, or field) of an object that has not been initialized (is null). The example shows a simple scenario where a property is accessed before it has a value assigned.

## How to Reproduce

1. Clone this repository.
2. Compile and run the `bug.cs` file.
3. Observe the `NullReferenceException` being thrown.

## Solution

The `bugSolution.cs` file provides a corrected version by initializing `MyProperty` before accessing it.

## Lesson Learned

Always initialize object members before attempting to use them.  Consider using null checks or the null-conditional operator (`?.`) to avoid these exceptions.
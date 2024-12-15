# NullReferenceException in C# Example

This repository demonstrates a common C# error: the `NullReferenceException`.  The provided `bug.cs` file contains code that attempts to access a member of a null reference, resulting in this exception. The `bugSolution.cs` file provides a corrected version, showing how to prevent this error.

## How to Reproduce

1. Compile and run `bug.cs`.
2. Observe the `NullReferenceException`.

## Solution

The solution is to check for null before accessing the property. The `bugSolution.cs` file shows the corrected code.
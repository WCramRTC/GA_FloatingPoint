# Tutorial: Double and Floating-Point Operations in C#

## Introduction
In C#, `double` is one of the floating-point types used to represent real numbers with a decimal point. Floating-point types are suitable for a wide range of applications that require high precision, such as scientific calculations, financial applications, and more. Understanding `double` and how to perform floating-point operations is essential for working with non-integer numerical data in C#.

Here is an overview of the `double` data type:

- **Data Type:** `double`
- **Size:** 64 bits (8 bytes)
- **Range:** Approximately ±5.0 x 10^−324 to ±1.7 x 10^308
- **Precision:** Approximately 15-17 significant decimal digits

`double` provides a wide range and high precision, making it suitable for most real-world numerical calculations.

---

#### Requirements (Total 100 Points)

#### Project Setup (10 Points)
- Create a new console application named `GA_DoubleMath_YourName`.
- Ensure the project is properly set up with `Program.cs`.

#### Understanding `double` (15 Points)
- Explain the purpose and range of the `double` data type.
- Provide examples showcasing the use of `double`.

#### Implementation of Basic Floating-Point Operations (15 Points)
- Implement and thoroughly explain basic floating-point operations (addition, subtraction, multiplication, division) using `double`.
- Include multiple examples for each operation.

#### Math Operations with `int` and `double` (15 Points)
- Discuss the interaction and outcome of operations between `int` and `double`.

#### Complex Floating-Point Operations (20 Points)
- Develop and explain complex mathematical expressions that combine different floating-point operations.
- Use examples to demonstrate the correct application of the order of operations.

#### Handling Floating-Point Precision (10 Points)
- Explain the limitations of floating-point precision and potential issues with rounding errors.
- Provide examples illustrating precision problems and possible solutions.

#### Code Testing and Validation (10 Points)
- Test all basic and complex operations in the `Main` method.
- Validate the results with detailed explanations.

#### Submission (5 Points)
- Successfully upload the complete project to GitHub.
- Ensure the repository is public and contains all necessary files.
- Submit the correct GitHub repository link in Canvas.


---

### Starting Code
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exploring C# Double and Floating-Point Operations");
        // Additional implementation will follow
    }
}
```

---

## Step-by-Step Implementation

### **Step 1: Understanding `double`**

Explain the purpose and range of the `double` data type.

```csharp
double myDouble = 123.456;
```

The `double` data type in C# is used to store real numbers with a decimal point. It offers a wide range of values and high precision, making it suitable for various applications like scientific calculations, financial modeling, and more. `double` can represent numbers with approximately 15-17 significant decimal digits and has a range from approximately ±5.0 x 10^−324 to ±1.7 x 10^308.

### **Step 2: Basic Floating-Point Operations**

Implement basic floating-point operations with explanations.

```csharp
double sum = 5.6 + 3.2; // Addition: Adds two double values.
double difference = 10.5 - 4.3; // Subtraction: Subtracts one double value from another.
double product = 2.5 * 3.0; // Multiplication: Multiplies two double values.
double quotient = 12.6 / 2.0; // Division: Divides one double value by another.
```

Please write and display the results of the following equations in the table.

| Equation (Code Representation)                                       | Result |
|----------------------------------------------------------------------|--------|
| `double result1 = 5.6 + 3.2; // Console.WriteLine(result1)`          | 8.8    |
| `double result2 = 10.5 - 4.3; // Console.WriteLine(result2)`         | 6.2    |
| `double result3 = 2.5 * 3.0; // Console.WriteLine(result3)`          | 7.5    |
| `double result4 = 12.6 / 2.0; // Console.WriteLine(result4)`         | 6.3    |
| `double result5 = 9.1 + 4.3; // Console.WriteLine(result5)`          | 13.4   |
| `double result6 = 15.7 - 8.2; // Console.WriteLine(result6)`         | 7.5    |
| `double result7 = 3.0 * 5.5; // Console.WriteLine(result7)`          | 16.5   |
| `double result8 = 24.8 / 4.0; // Console.WriteLine(result8)`         | 6.2    |
| `double result9 = 7.2 + 2.3; // Console.WriteLine(result9)`          | 9.5    |
| `double result10 = 18.5 - 6.4; // Console.WriteLine(result10)`       | 12.1   |
| `double result11 = 4.5 * 6.0; // Console.WriteLine(result11)`        | 27.0   |
| `double result12 = 30.2 / 5.0; // Console.WriteLine(result12)`       | 6.04   |
| `double result13 = 9.8 + 7.2; // Console.WriteLine(result13)`        | 17.0   |
| `double result14 = 22.4 - 11.2; // Console.WriteLine(result14)`      | 11.2   |
| `double result15 = 5.5 * 3.0; // Console.WriteLine(result15)`        | 16.5   |

### **Step 3: Complex Floating-Point Operations**

Create complex mathematical expressions using `double`.

```csharp
// Assuming the declarations of 'number' and 'doubleNumber' variables
double number = 5.0; // Example value
double doubleNumber = 2.5; // Example value

double complexOperation1 = (number / 2.0) + 3.0 * doubleNumber; // Combines division, multiplication, and addition.
// Explanation: First, 'number' is divided by 2.0, then the result is multiplied by 3.0 and added to 'doubleNumber'.

double complexOperation2 = 5.0 * (doubleNumber - 1.0) / 2.0; // Combines subtraction, multiplication, and division.
// Explanation: First, 'doubleNumber' is subtracted by 1.0, then the result is multiplied by 5.0 and divided by 2.0.
```

A complex mathematical operation refers to an expression that combines multiple arithmetic operations in a single statement. Complex operations often require careful consideration of the order in which the operations are performed, adhering to standard rules of arithmetic order (PEMDAS/BODMAS).

### **Step 4: Handling Floating-Point Precision**

Explain the limitations of floating-point precision and potential issues with rounding errors.

Floating-point numbers have limited precision due to the finite number of bits used to represent them. This can lead to rounding errors when performing operations on very large or very small numbers or when adding numbers with significantly different magnitudes.

For example:

```csharp
double a = 0.1;
double b = 0.2;
double sum = a + b; // sum will not be exactly 0.3 due to rounding errors.
```

To mitigate precision issues, consider using appropriate data types or libraries designed for handling high-precision arithmetic, such as the `decimal` data type for financial calculations.

### **Step 5: Testing and Validation**

Test each operation and equation in the `Main` method.

```csharp
Console.WriteLine($"Equation 1 Result: {equation1}");
Console.WriteLine($"Equation 2 Result: {equation2}");
```

### **Step 6: Submission**

- Review and organize your code.
- Upload to GitHub and submit the link in Canvas.

---

## Updated Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Correct project creation and setup. | 10 |
| **Understanding `double`** | Detailed explanation and examples of the `double` data type. | 15 |
| **Basic Floating-Point Operations** | Correct implementation and in-depth explanation. | 15 |
| **Math Operations with `int` and `double`** | Explaining interactions between `int` and `double` in operations. | 15 |
| **Complex Floating-Point Operations** | Accurate execution of complex expressions with explanations. | 20 |
| **Handling Floating-Point Precision** | Explanation of precision issues and solutions. | 10 |
| **Code Testing and Validation** | Effective testing, validation, and explanation of results. | 10 |
| **Submission** | Proper GitHub upload and submission. | 5 |
| **Total** | | 100 |

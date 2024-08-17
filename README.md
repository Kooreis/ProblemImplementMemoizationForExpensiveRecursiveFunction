# Question: How do you implement memoization for an expensive recursive function? JavaScript Summary

The provided JavaScript code implements memoization for an expensive recursive function, specifically the Fibonacci sequence. The function `memoize` is a higher-order function that accepts another function (`fn`) as an argument. It creates a cache object to store the results of the function calls. When the returned function is called with certain arguments, it first checks if the results for these arguments are already in the cache. If they are, it returns the cached results, avoiding the need to re-run the expensive function. If the results are not in the cache, it calls the original function with the provided arguments, stores the result in the cache, and then returns the result. The `expensiveRecursiveFunction` calculates the nth number in the Fibonacci sequence using recursion. The `memoizedExpensiveRecursiveFunction` is a memoized version of the `expensiveRecursiveFunction`, created by passing the `expensiveRecursiveFunction` to the `memoize` function. This memoized function is then used to calculate the 10th and 50th Fibonacci numbers, with the results being logged to the console. This approach significantly improves the performance of the recursive function by avoiding redundant calculations.

---

# TypeScript Differences

The TypeScript version solves the problem in a similar way to the JavaScript version, but with a few key differences:

1. TypeScript uses a class-based approach: In the TypeScript version, memoization is implemented using a class `Memoization` with a method `fibonacci` and a private property `cache`. This is different from the JavaScript version, where memoization is implemented using a higher-order function `memoize`.

2. TypeScript uses static typing: TypeScript is a statically typed language, which means that the type of a variable is known at compile time. In the TypeScript version, the type of the `cache` property is explicitly declared as an object with keys of type `number` and values of type `number`. The `fibonacci` method is also explicitly declared to take a parameter of type `number` and return a value of type `number`. This provides additional type safety compared to the JavaScript version, where the types of variables are not explicitly declared.

3. TypeScript uses private properties: In the TypeScript version, the `cache` property is declared as private, which means it can only be accessed from within the `Memoization` class. This provides a level of encapsulation that is not available in the JavaScript version.

4. TypeScript uses `else if` and `else` statements: In the TypeScript version, the `fibonacci` method uses `else if` and `else` statements to check if the result for the given input is already in the cache and to compute the result if it's not. This is slightly different from the JavaScript version, where the `memoize` function uses an `if` statement to check if the result is in the cache and a separate statement to compute the result if it's not.

Overall, the TypeScript version provides additional type safety, encapsulation, and a slightly different control flow compared to the JavaScript version. However, the basic concept of memoization is the same in both versions.

---

# C++ Differences

The C++ version of the solution also uses memoization to optimize the expensive recursive function, similar to the JavaScript version. However, there are some differences due to the language features and syntax of C++.

1. Data Types: In JavaScript, all numbers are floating-point numbers, while in C++, we can specify the data type. In this case, the C++ version uses `long long` to store the result, which can hold larger numbers than JavaScript's number type.

2. Cache Storage: In JavaScript, an object (`cache`) is used to store the computed values. In C++, an `unordered_map` named `memo` is used for the same purpose. Both are key-value stores, but `unordered_map` in C++ is a standard library container that provides O(1) average complexity for search, insert, and delete operations.

3. Function Structure: In JavaScript, the memoization is implemented using a higher-order function (`memoize`) that takes a function as an argument and returns a new function. In C++, due to the lack of first-class functions, the memoization is directly implemented inside the `expensiveRecursiveFunction`.

4. Input/Output: In JavaScript, the function is immediately called with arguments, and the result is logged to the console. In C++, the `main` function asks the user for input, calls the `expensiveRecursiveFunction` with this input, and then outputs the result to the console.

5. Base Case: The base case for the Fibonacci sequence is slightly different in the two versions. In JavaScript, if `n` is less than 2, it returns `n` (so the first two numbers are 0 and 1). In C++, if `n` is less than or equal to 2, it returns 1 (so the first two numbers are 1 and 1).

---

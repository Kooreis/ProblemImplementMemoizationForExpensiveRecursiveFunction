Here is a TypeScript console application that demonstrates how to implement memoization for an expensive recursive function. In this case, we will use the Fibonacci sequence as an example of an expensive recursive function.

```typescript
class Memoization {
    private cache: { [key: number]: number } = {};

    fibonacci(n: number): number {
        if (n <= 1) {
            return n;
        } else if (this.cache[n]) {
            return this.cache[n];
        } else {
            this.cache[n] = this.fibonacci(n - 1) + this.fibonacci(n - 2);
            return this.cache[n];
        }
    }
}

let memoization = new Memoization();
console.log(memoization.fibonacci(10));
console.log(memoization.fibonacci(20));
console.log(memoization.fibonacci(30));
```

In this code, we define a class `Memoization` that has a method `fibonacci` and a private property `cache`. The `cache` property is used to store previously computed results of the `fibonacci` function. When the `fibonacci` function is called, it first checks if the result for the given input is already in the cache. If it is, it returns the cached result. If it's not, it computes the result, stores it in the cache, and then returns it. This way, if the function is called again with the same input, it can return the result immediately without having to recompute it. This is the essence of memoization.
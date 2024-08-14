Here is a simple example of how you can implement memoization for an expensive recursive function in JavaScript. In this example, we will use the Fibonacci sequence, which is a common example of an expensive recursive function.

```javascript
function memoize(fn) {
    const cache = {};
    return function(...args) {
        if (cache[args]) {
            return cache[args];
        }
        const result = fn.apply(this, args);
        cache[args] = result;
        return result;
    };
}

function expensiveRecursiveFunction(n) {
    if (n < 2){
        return n
    }
    return memoizedExpensiveRecursiveFunction(n - 1) + memoizedExpensiveRecursiveFunction(n - 2);
}

const memoizedExpensiveRecursiveFunction = memoize(expensiveRecursiveFunction);

console.log(memoizedExpensiveRecursiveFunction(10));  // 55
console.log(memoizedExpensiveRecursiveFunction(50));  // 12586269025
```

In this code, `memoize` is a higher-order function that takes an expensive function as an argument and returns a new function that caches the results of the expensive function. The `expensiveRecursiveFunction` is a recursive function that calculates the nth number in the Fibonacci sequence. The `memoizedExpensiveRecursiveFunction` is the memoized version of the `expensiveRecursiveFunction`.
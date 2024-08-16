function expensiveRecursiveFunction(n) {
    if (n < 2){
        return n
    }
    return memoizedExpensiveRecursiveFunction(n - 1) + memoizedExpensiveRecursiveFunction(n - 2);
}
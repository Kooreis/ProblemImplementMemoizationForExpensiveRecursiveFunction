```cpp
#include <iostream>
#include <unordered_map>

std::unordered_map<int, long long> memo;

long long expensiveRecursiveFunction(int n) {
    if (n <= 2) return 1;
    if (memo.find(n) != memo.end()) return memo[n];
    memo[n] = expensiveRecursiveFunction(n - 1) + expensiveRecursiveFunction(n - 2);
    return memo[n];
}

int main() {
    int n;
    std::cout << "Enter a number: ";
    std::cin >> n;
    std::cout << "Result: " << expensiveRecursiveFunction(n) << std::endl;
    return 0;
}
```
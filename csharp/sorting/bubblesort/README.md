# Bubble Sort

Problem: <https://www.hackerrank.com/challenges/ctci-bubble-sort/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting>

Given an array of integers, sort the array in ascending order using Bubble Sort algorithm.

Once sorted, print three lines:

> Array is sorted in *numSwaps* swaps
> 
> First Element: *firstElement*
> 
> Last Element: *lastElement*

Use the following algorithm:

```csharp
for (int i = 0; i < n; i++) {
    
    for (int j = 0; j < n - 1; j++) {
        // Swap adjacent elements if they are in decreasing order
        if (a[j] > a[j + 1]) {
            swap(a[j], a[j + 1]);
        }
    }
    
}
```

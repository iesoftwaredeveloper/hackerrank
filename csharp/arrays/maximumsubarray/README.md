# Maximum subarray sum

> Currently I do not have a direct link on hackerrank for this.  There might be, but I have not found/completed it at this time.

Reference: <https://en.wikipedia.org/wiki/Maximum_subarray_problem>

It has been some time in my career since I had to really analyze an algortihm and come up with an effecient way to solve a problem. When I do, it can really tax my brain.

Perhaps you have the same issue.  It would bring me comfort to know that I am not the only one with this problem.

Perhaps you were never presented with a particular type of problem.  Perhaps you never learned how to create an algorithm and determine how effecient it is.  Perhaps it has just been a really long time since you had a real world problem that required a really smart and effecient solution and "good enough" has been, well, good enough. Let's face it, there are plenty of us that do not work in a life-or-death environment or where the pressure to optimize everything is paramount.

After being stumped on how to compute the largest sub-array with a maximum sum I decided to do a little research on how this could be solved.

## Implementation 1: Sum only

In this implementation we want to return the sum of the maximum sub-array.

We do not actually need to know what the elements in the array are, just the maximum sum you can get from the array.

### Brute Force: Sum

- **Time Complexity:** O(n^3)
- **Space Complexity:** O()

Whenever I am trying create a solution, the brute-force method is one of the first things I do.  It certainly is not the best, but it can be an effective way to better understand the problem and ensure you are getting a correct solution.

The concept behind the brute-force method is that you will just try all of the possible solutions until you are satisfied that you have the best.

Brute force algorithms are rarely the best.  Sometimes they are the only method available for a problem.  This is not the case for this problem though.

### Divide and Conquer: Sum

- **Time Complexity:** O()
- **Space Complexity:** O()

Another common approach to solving any problem is the divide and conquer.  The concept here is that you break the problem down into smaller sized problems.

### Kadane's algorithm: sum

- **Time Complexity:** O(n)
- **Space Complexity:** O(1)

This algorithm is described here <https://en.wikipedia.org/wiki/Maximum_subarray_problem>.  

When thinking of the brute-force method, I was trying to come up with this algorithm.  I was not aware there was one already out there.  However, it is a great algorithm that is very effecient.

Some limitation of this particular algoritm is that it requires at least 1 positive value.  If the entire array is negative numbers then it will not work.

The up side is that if you know you will have at least one positive value then this is an efficent algorithm.

The basic concept is that the array is scanned from left to right.  As the array is scanned, the running sum is kept.  If the current sum is greater than the current maximum sum then it becomes the maximum sum.

Once the sum becomes less than zero, the starting point of the sub-array is reset, the current sum is reset to 0 and the scan continues.

Once the entire array has been scanned the result is the value of the max sum.

#### Edge Cases

Some edge cases to consider when iterating over the array.

- An empty array.  If there are no values to sum then the sum is known.
- An array of all negative numbers.  This algorithm will not work properly if all of the values in the array are negative.
- An array of all positive number.  When all numbers are positive, then the largest sub-array is the entire array.
- A single postive number.  When all numbers are negative except for one entry then the sub-array will be of size 1.
- Maximum value of zero. When the maximum entry is zero, this is the equivalent of all negative values.

## Implementation: The subarray

In this implementation we want to know what the actual sub-array is that has the largest sum.  We are not concerned with the actual sum, just that the sub-array will contain the values that will result in the maximum sum.

### Brute Force: Sub-array

### Divide and Conquer: Sub-array

### Kadane's algorithm: sub-array

The same algorithm for computing the sum can be used to obtain the sub-array.

It does require a minor change.  The start and end index of the sub array must be tracked.

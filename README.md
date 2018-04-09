# Project Euler #205: Dice Game
[Link to challenge](https://www.hackerrank.com/contests/projecteuler/challenges/euler205)

## Problem
Peter has `np` `sp`-sided dice, each with faces numbered.  
Colin has `nc` `sc`-sided dice, each with faces numbered.

Both Peter's and Colin's dice are uniform and fair-for each die every outcome 
occurs with the equal probability of `1/sp` in Peter's case and `1/sc` in Colin's 
case.

Peter and Colin roll their dice and compare totals: the highest total wins. 
The result is a draw if the totals are equal.

What is the probability that `sp`-sided Pete beats `sc`-sided Colin? If the 
answer is `p/q`, then give it as `p * q^-1 (mod 1012924417)`.

## Input Format

The first line of each test file contains a single integer `q`, which is the 
number of queries per this file. `q` lines follow with 4 integers separated by
single spaces on each: the corresponding `np`, `sp`, `nc` and `sc`.

## Constraints
* `1 <= q, np, nc`
* `4 <= sp, sc`
* all queries per test file: `max(np * sp, nc * sc) <= 10^6`

## Sample Input 0

```
1
1 4 1 4
```

## Sample Output 0
```
633077761
```
## Explanation 0

There are 16 combinations in total. Peter wins Colin in 6 of them:

Peter: 2, Colin: 1
Peter: 3, Colin: 1
Peter: 3, Colin: 2
Peter: 4, Colin: 1
Peter: 4, Colin: 2
Peter: 4, Colin: 3

`6/16 = 3/8`

`3 * 8^-1 = 3 * 886308865 = 633077761 (mod 1012924417)`




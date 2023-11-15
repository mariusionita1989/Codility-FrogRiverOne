# Codility-FrogRiverOne
A small frog wants to get to the other side of a river.</br> 
The frog is initially located on one bank of the river (position 0) and wants to get to the opposite bank (position X+1).</br> 
Leaves fall from a tree onto the surface of the river.

You are given an array A consisting of N integers representing the falling leaves.</br> 
A[K] represents the position where one leaf falls at time K, measured in seconds.</br> 
The goal is to find the earliest time when the frog can jump to the other side of the river.</br>  
The frog can cross only when leaves appear at every position across the river from 1 to X</br> 
(that is, we want to find the earliest moment when all the positions from 1 to X are covered by leaves).</br>  
You may assume that the speed of the current in the river is negligibly small,</br>
i.e. the leaves do not change their positions once they fall in the river.

For example, you are given integer X = 5 and array A such that:</br> 
A[0] = 1</br> 
A[1] = 3</br> 
A[2] = 1</br> 
A[3] = 4</br> 
A[4] = 2</br> 
A[5] = 3</br> 
A[6] = 5</br> 
A[7] = 4</br> 
In second 6, a leaf falls into position 5.</br> 
This is the earliest time when leaves appear in every position across the river. 

Write a function:</br> 
class Solution { public int solution(int X, int[] A); }</br> 
that, given a non-empty array A consisting of N integers and integer X,  
returns the earliest time when the frog can jump to the other side of the river.

If the frog is never able to jump to the other side of the river, the function should return −1.</br> 
For example, given X = 5 and array A such that:</br> 
A[0] = 1</br> 
A[1] = 3</br> 
A[2] = 1</br> 
A[3] = 4</br> 
A[4] = 2</br> 
A[5] = 3</br> 
A[6] = 5</br> 
A[7] = 4</br> 
the function should return 6, as explained above.

Write an efficient algorithm for the following assumptions:</br> 
N and X are integers within the range [1..100,000];</br> 
each element of array A is an integer within the range [1..X].

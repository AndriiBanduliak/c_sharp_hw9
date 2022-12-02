﻿using static System.Console;
Clear();


int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Write($"Sum of elements is {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
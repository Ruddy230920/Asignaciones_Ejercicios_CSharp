﻿using System;


public class LINQ
{
    public static void Main(string[] args)
    {
        List<int> Numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        var ordenarnumeros = Numeros.Where(x => x % 2 != 0).OrderByDescending(x => x).ToList();

        foreach(var numeros in ordenarnumeros) {Console.WriteLine(numeros); }

    }
}
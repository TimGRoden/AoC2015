using System;
using System.IO;
using System.Collections.Generic;

class Program {
  public static int floorcalc(string datain) {
    int pos = 0;
    for (int i=0;i<datain.Length;i++) {
      if (datain[i]=='(') {
        pos += 1;
      } else {
        pos -= 1;
      }
    }
    return pos;
  }

  public static int findbase(string datain) {
    int pos = 0;
    int floor = 0;
    while (floor!=-1) {
      if (datain[pos]=='(') {
        floor += 1;
      } else {
        floor -= 1;
      }
      pos += 1;
    }
    return pos;
  }

  public static void Main (string[] args) {
    string[] datain = File.ReadAllLines("input.txt");
    Console.WriteLine("Part 1 Solution: Floor {0}",floorcalc(datain[0]));
    Console.WriteLine("Part 2 Solution: Step {0}.",findbase(datain[0]));
  }
}

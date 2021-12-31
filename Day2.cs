using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static int[] wrapping(string present) {
    string[] dims = present.Split('x');
    int[] dimi = {int.Parse(dims[0]),int.Parse(dims[1]),int.Parse(dims[2])};
    int[] areas = {dimi[0]*dimi[1],dimi[0]*dimi[2],dimi[1]*dimi[2]};
    int wrap = 2*areas.Sum() + areas.Min();
    int ribbon = 2*(dimi.Sum() - dimi.Max()) + dimi[0]*dimi[1]*dimi[2];
    int[] result = {wrap, ribbon};
    return result;
  }

  public static int[] totaluse(string[] datain) {
    int area = 0;
    int ribbon = 0;
    for (int i=0;i<datain.Length;i++) {
      int[] result = wrapping(datain[i]);
      area += result[0];
      ribbon += result[1];
    }
    int[] soln = {area, ribbon};
    return soln;
  }
  public static void Main (string[] args) {
    string[] datain = File.ReadAllLines("input.txt");
    int[] results = totaluse(datain);
    Console.WriteLine("Total Square footage: {0}.\nTotal Ribbon: {1}.",results[0],results[1]);
  }
}

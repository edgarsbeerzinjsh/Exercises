using System;

namespace Exercises.Level2;
public class Triangle
{
    /// <summary>
    /// Note: compleete half trangle first
    /// 
    /// The program:
    ///  You must create a triangle. 
    ///  n is the number of lines a triangle will have.
    ///  Triangle body has to be made out of "*",
    ///  so result should for 3 be like:
    ///  * 
    /// ***
    ///*****
    /// 
    /// Example of 5:
    /// 
    ///    *
    ///   ***
    ///  *****
    /// *******
    ///*********
    ///
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string[] GetTRiangle(int n)
    {
        string[] narray = new string[n];
        for (int i = 0; i < n; i++)
        {
            string narray1 = new string(' ', (n - 1 - i));
            string narray2 = new string('*', (i * 2) + 1);

            narray[i] = narray1 + narray2;
        }
        return narray;
    }
}

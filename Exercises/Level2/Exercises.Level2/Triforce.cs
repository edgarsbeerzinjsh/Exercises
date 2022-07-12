using System;

namespace Exercises.Level2;
public class Triforce
{
    /// <summary>
    /// !!! COMPLETE TRIANGLE BEFORE ATTEMPTING THIS !!!
    /// 
    /// 
    /// The program:
    ///  You must create a program that echoes a Triforce of a given size N.       
    /// - A triforce is made of 3 identical triangles
    /// - A triangle of size N should be made of N lines
    /// - A triangle's line starts from 1 star, and earns 2 stars each line
    /// 
    /// For example, a Triforce of size 3 will look like:
    ///        
    ///     *
    ///    ***
    ///   *****
    ///  *     *
    /// ***   ***
    ///***** *****
    ///
    /// Another example, a Triforce of size 5 will look like:
    ///
    ///         *
    ///        ***
    ///       *****
    ///      *******
    ///     *********
    ///    *         *
    ///   ***       ***
    ///  *****     *****
    /// *******   *******
    ///********* *********
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>


    public string[] GetTriforce(int n)
    {
        string[] narray = new string[2 * n];
        for (int i = 0; i < (2 * n); i++)
        {
            if (i < n)
            {
                string narray1 = new string(' ', ((2 * n) - 1 - i));
                string narray2 = new string('*', (i * 2) + 1);

                narray[i] = narray1 + narray2;
            }
            else
            {
                string narray1 = new string(' ', ((2 * n) - 1 - i));
                string narray2 = new string('*', ((i - n) * 2) + 1);
                string narray3 = new string(' ', ((2 * n) - i));

                string narray12 = narray1 + narray2;
                narray[i] = narray12 + narray3 + narray12;
            }
        }
        return narray;

    }
}

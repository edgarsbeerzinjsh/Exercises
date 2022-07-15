using System;

namespace Exercises.Level2;
public class WordsInBox
{
    /// <summary>
    /// Draw a box made out of stars (*) and put the word inide of them.
    /// So that a word Home makes:
    /// 
    /// ********
    /// * Home *
    /// ********
    /// 
    /// If you need more examples go to the tests project.
    /// </summary>
    /// <param name="word">Word to put in a box</param>
    /// <returns></returns>
    public string[] GetBox(string word)
    {
        string[] boxArray = new string[3];
        for (int i = 0; i < 3; i++)
        {
            if (i != 1)
            {
                boxArray[i] = new string('*', word.Length + 4);
            }
            else
            {
                boxArray[i] = $"* {word} *";
            }
        }
        return boxArray;
    }
}


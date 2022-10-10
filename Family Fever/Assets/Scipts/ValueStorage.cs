using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueStorage : MonoBehaviour
{
    // Holds the names of the families 
    public static string Fam1Name;
    public static string Fam2Name;

    public static int Points1;
    public static int Points2;

    public static bool Player1Turn;
    public static bool Player2Turn;

    public static int Xcount1;
    public static int Xcount2;

    // Inteded use is to change the question based on the number
    // Number will be incremented based on answers correct or 3 wrong marks Ex: if ans = 5, ++QuestionNum.
    public static int QuestionNum = 1;

    public void FixedUpdate()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueStorage : MonoBehaviour
{
    // Holds the names of the families 
    public static string Fam1Name;
    public static string Fam2Name;

    // Inteded use is to change the question based on the number
    // Number will be incremented based on answers correct or 3 wrong marks Ex: if ans = 5, ++QuestionNum.
    public static int QuestionNum = 1;

    public void FixedUpdate()
    {
        
    }
}

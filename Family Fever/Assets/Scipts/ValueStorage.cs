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

    public static bool skeleton = false;
    public static bool shotgun = false;
    public static bool dress = false;
    public static bool suit = false;
    public static bool jewelry = false;

    public static bool cabin = false;
    public static bool graveyard = false;
    public static bool basement = false;
    public static bool closet = false;
    public static bool shower = false;

    public static bool legs = false;
    public static bool lips = false;
    public static bool lungs = false;
    public static bool liver = false;
    public static bool lCB = false;

    public static bool money = false;
    public static bool car = false;
    public static bool vacations = false;
    public static bool appliances = false;
    public static bool dignity = false;


    public static bool hair = false;
    public static bool friends = false;
    public static bool personality = false;
    public static bool height = false;
    public static bool humor = false;

    public static bool dog = false;
    public static bool NakedGrandma = false;
    public static bool EmptyHouse = false;
    public static bool PoliceOfficer = false;
    public static bool VideoCamera = false;

    // Inteded use is to change the question based on the number
    // Number will be incremented based on answers correct or 3 wrong marks Ex: if ans = 5, ++QuestionNum.
    public static int QuestionNum = 1;

    public void FixedUpdate()
    {
        
    }
}

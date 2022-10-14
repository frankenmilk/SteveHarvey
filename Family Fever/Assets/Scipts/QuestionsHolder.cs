using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditorInternal;

public class QuestionsHolder : MonoBehaviour
{
    
    public string Question1 = "Name something in a person's closet that only comes out on special occasions?";
    public string Question2 = "In horror movies, name a place teenagers always go when there is a killer on the loose?";
    public string Question3 = "Name the most useful body part that begins with the letter \"L\" ";
    public string Question4 = "Name something you have more of than Steve Harvey?";
    public string Question5 = "Name something people win on game shows?";
    public string Question6 = "Name something a burglar wouldn't want to see when they break into a house";

    private string Answer;
    


    public void Start()
    {
        DisplayQuestion();
    }

    public void ReadStringInput(string playerInput)
    {
        Answer = playerInput;
        Debug.Log(Answer);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            Debug.Log("Bozo mode");
            PlayerAnswer();
        }
        if (Input.GetKeyDown(KeyCode.Backslash))
        { 
            PlayerAnswer();
        }
    }

    public void DisplayQuestion()
    {
        if (ValueStorage.QuestionNum == 1)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question1;
        }
        else if (ValueStorage.QuestionNum == 2)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question2;
        }
        else if (ValueStorage.QuestionNum == 3)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question2;
        }
        else if (ValueStorage.QuestionNum == 4)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question4;
        }
        else if (ValueStorage.QuestionNum == 5)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question5;
        }
        else if (ValueStorage.QuestionNum == 6)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question6;
        }

    }

    // Changes the displayed question based on QuestionNum which is held in ValueStorage
    public void PlayerAnswer()
    {
        if(ValueStorage.QuestionNum == 1)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "skeleton") == 0 && ValueStorage.skeleton == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.skeleton = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "suit") == 0 && ValueStorage.suit == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.suit = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "dress") == 0 && ValueStorage.dress == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.dress = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "jewelry") == 0 && ValueStorage.jewelry == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.jewelry = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shotgun") == 0 && ValueStorage.shotgun == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.shotgun = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount1 == 0)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount1 == 1)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount1 == 2)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            else if (ValueStorage.Player2Turn == true) // Player 2
            {
                if (string.Compare(Answer, "skeleton") == 0 && ValueStorage.skeleton == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.skeleton = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "suit") == 0 && ValueStorage.suit == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.suit = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "dress") == 0 && ValueStorage.dress == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.dress = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "jewelry") == 0 && ValueStorage.jewelry == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.jewelry = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shotgun") == 0 && ValueStorage.shotgun == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.shotgun = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount2 == 0)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount2 == 1)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount2 == 2)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            if (ValueStorage.skeleton == true && ValueStorage.shotgun == true && ValueStorage.dress == true && ValueStorage.suit == true && ValueStorage.jewelry == true)
            {
                ValueStorage.QuestionNum += 1;
            }
        }
            
        if(ValueStorage.QuestionNum == 2)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "cabin/woods/camp") == 0 && ValueStorage.cabin == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.cabin = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "graveyard") == 0 && ValueStorage.graveyard == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.graveyard = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "basement") == 0 && ValueStorage.basement == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.basement = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "closet") == 0 && ValueStorage.closet == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.closet = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shower") == 0 && ValueStorage.shower == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.shower = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount1 == 0)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount1 == 1)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount1 == 2)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            else if (ValueStorage.Player2Turn == true) // Player 2
            {
                if (string.Compare(Answer, "cabin/woods/camp") == 0 && ValueStorage.cabin == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.cabin = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "graveyard") == 0 && ValueStorage.graveyard == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.graveyard = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "basement") == 0 && ValueStorage.basement == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.basement = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "closet") == 0 && ValueStorage.closet == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.closet = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shower") == 0 && ValueStorage.shower == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.shower = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount2 == 0)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount2 == 1)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount2 == 2)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            if (ValueStorage.cabin == true && ValueStorage.graveyard == true && ValueStorage.basement == true && ValueStorage.closet == true && ValueStorage.shower == true)
            {
                ValueStorage.QuestionNum += 1;
            }
        }

        if(ValueStorage.QuestionNum == 3)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "legs") == 0 && ValueStorage.legs == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.legs = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lips") == 0 && ValueStorage.lips == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.lips = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "liver") == 0 && ValueStorage.liver == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.liver = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lungs") == 0 && ValueStorage.lungs == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.lungs = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lateral cuneiform bone") == 0 && ValueStorage.lCB == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.lCB = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount1 == 0)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount1 == 1)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount1 == 2)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            else if (ValueStorage.Player2Turn == true) // Player 2
            {
                if (string.Compare(Answer, "legs") == 0 && ValueStorage.legs == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.legs = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lips") == 0 && ValueStorage.lips == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.lips = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "liver") == 0 && ValueStorage.liver == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.liver = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lungs") == 0 && ValueStorage.lungs == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.lungs = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lateral cuneiform bone") == 0 && ValueStorage.lCB == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.lCB = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount2 == 0)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount2 == 1)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount2 == 2)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            if (ValueStorage.legs == true && ValueStorage.lips == true && ValueStorage.lungs == true && ValueStorage.liver == true && ValueStorage.lCB == true)
            {
                ValueStorage.QuestionNum += 1;
            }
        }

        if(ValueStorage.QuestionNum == 4)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "hair") == 0 && ValueStorage.hair == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.hair = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "friends") == 0 && ValueStorage.friends == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.friends = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "personality") == 0 && ValueStorage.personality == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.personality = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "height") == 0 && ValueStorage.height == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.height = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "humor") == 0 && ValueStorage.humor == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.humor = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount1 == 0)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount1 == 1)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount1 == 2)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            else if (ValueStorage.Player2Turn == true) // Player 2
            {
                if (string.Compare(Answer, "hair") == 0 && ValueStorage.hair == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.hair = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "friends") == 0 && ValueStorage.friends == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.friends = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "personality") == 0 && ValueStorage.personality == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.personality = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "humor") == 0 && ValueStorage.humor == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.humor = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "height") == 0 && ValueStorage.height == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.height = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount2 == 0)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount2 == 1)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount2 == 2)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            if (ValueStorage.legs == true && ValueStorage.lips == true && ValueStorage.lungs == true && ValueStorage.liver == true && ValueStorage.lCB == true)
            {
                ValueStorage.QuestionNum += 1;
            }
        }

        if (ValueStorage.QuestionNum == 5)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "money") == 0 && ValueStorage.money == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.hair = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "car") == 0 && ValueStorage.car == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.friends = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "vacations") == 0 && ValueStorage.vacations == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.personality = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "appliances") == 0 && ValueStorage.appliances == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.height = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "dignity") == 0 && ValueStorage.dignity == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.humor = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount1 == 0)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount1 == 1)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount1 == 2)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            else if (ValueStorage.Player2Turn == true) // Player 2
            {
                if (string.Compare(Answer, "hair") == 0 && ValueStorage.money == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.money = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "friends") == 0 && ValueStorage.car == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.car = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "personality") == 0 && ValueStorage.vacations == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.vacations = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "humor") == 0 && ValueStorage.appliances == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.appliances = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "height") == 0 && ValueStorage.dignity == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.dignity = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount2 == 0)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount2 == 1)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount2 == 2)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            if (ValueStorage.money == true && ValueStorage.car == true && ValueStorage.vacations == true && ValueStorage.appliances == true && ValueStorage.dignity == true)
            {
                ValueStorage.QuestionNum += 1;
            }
        }

        if (ValueStorage.QuestionNum == 6)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "dog") == 0 && ValueStorage.dog == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.dog = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "naked grandma") == 0 && ValueStorage.NakedGrandma == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.NakedGrandma = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "empty house") == 0 && ValueStorage.EmptyHouse == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.EmptyHouse = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "police officer") == 0 && ValueStorage.PoliceOfficer == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.PoliceOfficer = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "video camera") == 0 && ValueStorage.VideoCamera == false)
                {
                    ValueStorage.Points1 += 1;
                    ValueStorage.VideoCamera = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount1 == 0)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount1 == 1)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount1 == 2)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            else if (ValueStorage.Player2Turn == true) // Player 2
            {
                if (string.Compare(Answer, "dog") == 0 && ValueStorage.dog == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.dog = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "naked grandma") == 0 && ValueStorage.NakedGrandma == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.NakedGrandma = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "empty house") == 0 && ValueStorage.EmptyHouse == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.EmptyHouse = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "police officer") == 0 && ValueStorage.PoliceOfficer == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.PoliceOfficer = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "video camera") == 0 && ValueStorage.VideoCamera == false)
                {
                    ValueStorage.Points2 += 1;
                    ValueStorage.VideoCamera = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (ValueStorage.Xcount2 == 0)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (ValueStorage.Xcount2 == 1)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (ValueStorage.Xcount2 == 2)
                    {
                        ValueStorage.Xcount2 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            if (ValueStorage.dog == true && ValueStorage.NakedGrandma == true && ValueStorage.EmptyHouse == true && ValueStorage.PoliceOfficer == true && ValueStorage.VideoCamera == true)
            {
                ValueStorage.QuestionNum += 1;
            }
        }
    }
}

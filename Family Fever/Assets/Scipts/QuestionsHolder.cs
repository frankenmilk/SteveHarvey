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
    public string Question5 = "Name something people win on game shows?";
    public string Question4 = "Name something you have more of than Steve Harvey?";
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
                if (string.Compare(Answer, "skeleton") == 0 && skeleton == false)
                {
                    ValueStorage.Points1 += 1;
                    skeleton = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "suit") == 0 && suit == false)
                {
                    ValueStorage.Points1 += 1;
                    suit = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "dress") == 0 && dress == false)
                {
                    ValueStorage.Points1 += 1;
                    dress = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "jewelry") == 0 && jewelry == false)
                {
                    ValueStorage.Points1 += 1;
                    jewelry = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shotgun") == 0 && shotgun == false)
                {
                    ValueStorage.Points1 += 1;
                    shotgun = true;
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
                if (string.Compare(Answer, "skeleton") == 0 && skeleton == false)
                {
                    ValueStorage.Points2 += 1;
                    skeleton = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "suit") == 0 && suit == false)
                {
                    ValueStorage.Points2 += 1;
                    suit = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "dress") == 0 && dress == false)
                {
                    ValueStorage.Points2 += 1;
                    dress = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "jewelry") == 0 && jewelry == false)
                {
                    ValueStorage.Points2 += 1;
                    jewelry = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shotgun") == 0 && shotgun == false)
                {
                    ValueStorage.Points2 += 1;
                    shotgun = true;
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
            if (skeleton == true && shotgun == true && dress == true && suit == true && jewelry == true)
            {
                ValueStorage.QuestionNum + 1;
            }
        }
            
        if(ValueStorage.QuestionNum == 2)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "cabin/woods/camp") == 0 && cabin == false)
                {
                    ValueStorage.Points1 += 1;
                    cabin = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "graveyard") == 0 && graveyard == false)
                {
                    ValueStorage.Points1 += 1;
                    graveyard = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "basement") == 0 && basement == false)
                {
                    ValueStorage.Points1 += 1;
                    basement = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "closet") == 0 && closet == false)
                {
                    ValueStorage.Points1 += 1;
                    closet = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shower") == 0 && shower == false)
                {
                    ValueStorage.Points1 += 1;
                    shower = true;
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
                if (string.Compare(Answer, "cabin/woods/camp") == 0 && cabin == false)
                {
                    ValueStorage.Points2 += 1;
                    cabin = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "graveyard") == 0 && graveyard == false)
                {
                    ValueStorage.Points2 += 1;
                    graveyard = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "basement") == 0 && basement == false)
                {
                    ValueStorage.Points2 += 1;
                    basement = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "closet") == 0 && closet == false)
                {
                    ValueStorage.Points2 += 1;
                    closet = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shower") == 0 && shower == false)
                {
                    ValueStorage.Points2 += 1;
                    shower = true;
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
            if (cabin == true && graveyard == true && basement == true && closet == true && shower == true)
            {
                ValueStorage.QuestionNum + 1;
            }
        }

        if(ValueStorage.QuestionNum == 3)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "legs") == 0 && legs == false)
                {
                    ValueStorage.Points1 += 1;
                    legs = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lips") == 0 && lips == false)
                {
                    ValueStorage.Points1 += 1;
                    lips = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "liver") == 0 && liver == false)
                {
                    ValueStorage.Points1 += 1;
                    liver = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lungs") == 0 && lungs == false)
                {
                    ValueStorage.Points1 += 1;
                    lungs = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lateral cuneiform bone") == 0 && lCB == false)
                {
                    ValueStorage.Points1 += 1;
                    lCB = true;
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
                if (string.Compare(Answer, "legs") == 0 && legs == false)
                {
                    ValueStorage.Points2 += 1;
                    legs = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lips") == 0 && lips == false)
                {
                    ValueStorage.Points2 += 1;
                    lips = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "liver") == 0 && liver == false)
                {
                    ValueStorage.Points2 += 1;
                    liver = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lungs") == 0 && lungs == false)
                {
                    ValueStorage.Points2 += 1;
                    lungs = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lateral cuneiform bone") == 0 && lCB == false)
                {
                    ValueStorage.Points2 += 1;
                    lCB = true;
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
            if (legs == true && lips == true && lungs == true && liver == true && lCB == true)
            {
                ValueStorage.QuestionNum + 1;
            }
        }

        if(ValueStorage.QuestionNum == 4)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "hair") == 0 && hair == false)
                {
                    ValueStorage.Points1 += 1;
                    hair = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "friends") == 0 && friends == false)
                {
                    ValueStorage.Points1 += 1;
                    friends = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "personality") == 0 && personality == false)
                {
                    ValueStorage.Points1 += 1;
                    personality = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "height") == 0 && height == false)
                {
                    ValueStorage.Points1 += 1;
                    height = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "humor") == 0 && humor == false)
                {
                    ValueStorage.Points1 += 1;
                    humor = true;
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
                if (string.Compare(Answer, "hair") == 0 && hair == false)
                {
                    ValueStorage.Points2 += 1;
                    hair = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "friends") == 0 && friends == false)
                {
                    ValueStorage.Points2 += 1;
                    friends = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "personality") == 0 && personality == false)
                {
                    ValueStorage.Points2 += 1;
                    personality = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "humor") == 0 && humor == false)
                {
                    ValueStorage.Points2 += 1;
                    humor = true;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "height") == 0 && height == false)
                {
                    ValueStorage.Points2 += 1;
                    height = true;
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
            if (legs == true && lips == true && lungs == true && liver == true && lCB == true)
            {
                ValueStorage.QuestionNum + 1;
            }
        }
    }
}

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
    public string Question4 = "Name something people win on game shows?";
    public string Question5 = "Name something you have more of than Steve Harvey?";
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
        else if (ValueStorage.QuestionNum == 3)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question2;
        }

    }

    // Changes the displayed question based on QuestionNum which is held in ValueStorage
    public void PlayerAnswer()
    {
        if(ValueStorage.QuestionNum == 1)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "skeleton") == 0)
                {
                    ValueStorage.Points1 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "suit") == 0)
                {
                    ValueStorage.Points1 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "dress") == 0)
                {
                    ValueStorage.Points1 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "jewelry") == 0)
                {
                    ValueStorage.Points1 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shotgun") == 0)
                {
                    ValueStorage.Points1 += 1;
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
                if (string.Compare(Answer, "skeleton") == 0)
                {
                    ValueStorage.Points2 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "suit") == 0)
                {
                    ValueStorage.Points2 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "dress") == 0)
                {
                    ValueStorage.Points2 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "jewelry") == 0)
                {
                    ValueStorage.Points2 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "shotgun") == 0)
                {
                    Debug.Log("shotgun Used");
                    ValueStorage.Points2 += 1;
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
        }
            

        if (ValueStorage.QuestionNum == 3)
        {
            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(Answer, "legs") == 0)
                {
                    ValueStorage.Points1 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lips") == 0)
                {
                    ValueStorage.Points1 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lungs") == 0)
                {
                    ValueStorage.Points1 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "liver") == 0)
                {
                    ValueStorage.Points1 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lateral cuneiform bone") == 0)
                {
                    ValueStorage.Points1 += 100000;
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
                if (string.Compare(Answer, "legs") == 0)
                {
                    ValueStorage.Points2 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lips") == 0)
                {
                    ValueStorage.Points2 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lungs") == 0)
                {
                    ValueStorage.Points2 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "liver") == 0)
                {
                    ValueStorage.Points2 += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(Answer, "lateral cuneiform bone") == 0)
                {
                    ValueStorage.Points2 += 100000;
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
        }

    }
}

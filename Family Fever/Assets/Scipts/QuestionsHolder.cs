using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionsHolder : MonoBehaviour
{
    
    public string Question1 = "Name something in a person's closet that only comes out on special occasions?";
    public string Question2 = "In horror movies, name a place teenagers always go when there is a killer on the loose?";
    public string Question3 = "Name the most useful body part that begins with the letter \"L\" ";
    public string Question4 = "Name something people win on game shows?";
    public string Question5 = "Name something you have more of than Steve Harvey?";
    public string Question6 = "Name something a burglar wouldn't want to see when they break into a house";

    string Answer;
    


    public void Start()
    { 
        TextChange();
    }

    // Changes the displayed question based on QuestionNum which is held in ValueStorage
    public void TextChange()
    {
        if(ValueStorage.QuestionNum == 1)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question1;

            Answer = Input.inputString;

            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(answer, "skeleton") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "suit") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "dress") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "jewelry") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "shotgun") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (Xcount == 0)
                    {
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (Xcount == 1)
                    {
                        SceneManager.LoadScene(5);
                    }
                    else if (Xcount == 2)
                    {
                        SceneManager.LoadScene(6);
                    }
                }
            }
            else
            {
                if (string.Compare(answer, "skeleton") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "suit") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "dress") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "jewelry") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "shotgun") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (Xcount1 == 0)
                    {
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (Xcount1 == 1)
                    {
                        SceneManager.LoadScene(5);
                    }
                    else if (Xcount1 == 2)
                    {
                        SceneManager.LoadScene(6);
                    }
                }
            }
        }
            

        if (ValueStorage.QuestionNum == 3)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question2;

            Answer = Input.inputString;

            if (ValueStorage.Player1Turn == true)
            {
                if (string.Compare(answer, "legs") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "lips") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "lungs") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "liver") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "lateral cuneiform bone") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (Xcount == 0)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (Xcount == 1)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (Xcount == 2)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
            else
            {
                if (string.Compare(answer, "legs") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "lips") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "lungs") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "liver") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else if (string.Compare(answer, "lateral cuneiform bone") == 0)
                {
                    ValueStorage.Points += 1;
                    SceneManager.LoadScene(14); // happy bald man
                }
                else
                {
                    if (Xcount == 0)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(4); // x1 scene
                    }
                    else if (Xcount == 1)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(5);
                    }
                    else if (Xcount == 2)
                    {
                        ValueStorage.Xcount1 += 1;
                        SceneManager.LoadScene(6);
                    }
                }
            }
        }

    }
}

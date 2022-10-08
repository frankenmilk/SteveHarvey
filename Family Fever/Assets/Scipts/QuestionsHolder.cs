using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsHolder : MonoBehaviour
{
    
    public string Question1 = "Name something in a person's closet that only comes out on special occasions?";
    public string Question2 = "In horror movies, name a place teenagers always go when there is a killer on the loose?";
    public string Question3 = "Name the most useful body part that begins with the letter \"L\" ";
    public string Question4 = "Name something people win on game shows?";
    public string Question5 = "Name something you have more of than Steve Harvey?";
    public string Question6 = "Name something a burglar wouldn't want to see when they break into a house";


    public void Start()
    { 
        TextChange();
    }

    public void TextChange()
    {
        if(ValueStorage.QuestionNum == 1)
        {
            Text DisplayText = GameObject.Find("Canvas/Text").GetComponent<Text>();
            DisplayText.text = Question1;
        }
        
    }
}

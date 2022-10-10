using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveStuff : MonoBehaviour
{
    public InputField inputText;
    public string family1Name;
    public string family2Name;
    
    // Most of this can probably be removed
    void Start()
    {
        PlayerPrefs.SetString("familiy1TextKeyName", family1Name);
        PlayerPrefs.SetString("familiy2TextKeyName", family2Name);
        family1Name = PlayerPrefs.GetString("familiy1TextKeyName");
        inputText.text = family1Name;
    }

    // Saves the name of the first family and sends it to ValueStorage
    public void SaveFam1()
    {
        family1Name = inputText.text;
        PlayerPrefs.SetString("familiy1TextKeyName", family1Name);
        ValueStorage.Fam1Name = family1Name;
        
    }
    
    // Saves the name of the second family and sends it to ValueStorage
    public void SaveFam2()
    {
        family2Name = inputText.text;
        PlayerPrefs.SetString("familiy2TextKeyName", family2Name);
        ValueStorage.Fam2Name = family2Name;

    }




}

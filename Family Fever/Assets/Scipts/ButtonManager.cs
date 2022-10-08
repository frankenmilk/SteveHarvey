using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }
    
     public void firstButton()
     {
        SceneManager.LoadScene(1);
     }

    public void fam1NameButton()
    {
        SceneManager.LoadScene(16);
    }

    public void fam2NameButton()
    {
        SceneManager.LoadScene(3);
    }
}

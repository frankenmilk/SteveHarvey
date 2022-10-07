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
    
     public void OnButtonPress()
     {
        SceneManager.LoadScene(1);
     }
}

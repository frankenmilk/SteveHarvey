using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float TimeValue;
    public Text TimerText;

    private string scene;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        scene = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (scene == "1X Screen" || scene == "2X Screen" || scene == "3X Screen" || scene == "WinScreen")
        {
            if(TimeValue <= 0)
            {
                Debug.Log("Player 1 points: " + ValueStorage.Points1);
                Debug.Log("Player 1 points: " + ValueStorage.Points2);
                SceneManager.LoadScene(3);
            }
        }
        else if (scene == "Target")
        {
            if (TimeValue <= 0)
            {
                SceneManager.LoadScene(15);
            }
        }

            if (TimeValue > 0)
            {
                TimeValue -= Time.deltaTime;
            }
            else
            {
                TimeValue = 0;
            }
    
            DisplayTime(TimeValue);
     }

    void DisplayTime(float TimeToDisplay)
    {
        if (TimeToDisplay < 0)
        {
            TimeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(TimeToDisplay / 60);
        float seconds = Mathf.FloorToInt(TimeToDisplay % 60);

        TimerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}

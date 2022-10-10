using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backslash))
        {
            ValueStorage.Player1Turn = false;
            ValueStorage.Player2Turn = true;
        }

        if (Input.GetKeyDown(KeyCode.Tilde))
        {
            ValueStorage.Player2Turn = false;
            ValueStorage.Player1Turn = true;
        }
    }
}

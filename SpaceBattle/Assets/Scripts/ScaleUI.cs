using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUI : MonoBehaviour
{
    public int fractionPos;
    public float fractionScreen;

    public bool center = false;

    void Start()
    {
        float xPos = Screen.width / fractionPos;
        float scaleToScreen = Screen.width / fractionScreen;

        if (center == true)
        {
            transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        }
        else
        {
            transform.position = new Vector3(xPos, (Screen.height - xPos), 0);
        }

        if (scaleToScreen <= 1)
        {
            transform.localScale = new Vector3(2, 2, 0);
        }
        else
        {
            transform.localScale = new Vector3(scaleToScreen, scaleToScreen, 0);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChange : MonoBehaviour {
    public void screenChange(string screen)
    {
        Debug.Log("hoooooop " + screen);
        Application.LoadLevel(screen);
    }
}

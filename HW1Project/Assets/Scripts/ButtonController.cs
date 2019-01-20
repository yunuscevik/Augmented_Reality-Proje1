using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    public GameObject character;
    public float speed = 5f;

    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    // Use this for initialization
    void Start()
    {
        
        try
        {
            (GameObject.Find("Enter").GetComponent<Button>()).interactable = false;
            (GameObject.Find("ScreenChange").GetComponent<Button>()).interactable = false;
        }
        catch(System.Exception e)
        {
            e.StackTrace.ToString();
        }
        
        
    }

    void Update()
    {
        if (StaticVariables.right == "right")
            rightAction();
        else if (StaticVariables.left == "left")
            leftAction();
        else if (StaticVariables.up == "up")
            upAction();
        else if (StaticVariables.down == "down")
            downAction();
            
    }
   

    public void rightAction()
    {
        StaticVariables.right = "right";
        character.transform.eulerAngles = new Vector3(
            character.transform.eulerAngles.x,
            character.transform.eulerAngles.y + (90 *Time.deltaTime),
            character.transform.eulerAngles.z
        );
    }

    public void leftAction()
    {
        StaticVariables.left = "left";
        character.transform.eulerAngles = new Vector3(
            character.transform.eulerAngles.x,
            character.transform.eulerAngles.y - (90 * Time.deltaTime),
            character.transform.eulerAngles.z
        );
    }
    public void upAction()
    {
        StaticVariables.up = "up";
        character.transform.position += character.transform.forward * Time.deltaTime;  
    }
    public void downAction()
    {
        StaticVariables.down = "down";
        character.transform.position += -character.transform.forward * Time.deltaTime;
    }

    public void stopAction()
    {
        StaticVariables.right = "";
        StaticVariables.left = "";
        StaticVariables.up = "";
        StaticVariables.down = "";
        character.transform.position = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z);
    }


    public void Enter()
    {
        var videoPlayer = GameObject.Find("leftPlane").GetComponent<UnityEngine.Video.VideoPlayer>();
        if (StaticVariables.turnOnOff == true)
        {
            videoPlayer.Play();
            (GameObject.Find("ScreenChange").GetComponent<Button>()).interactable = true;
            StaticVariables.turnOnOff = false;
        }
        else
        {
            videoPlayer.Pause();
            StaticVariables.turnOnOff = true;
        }
        
    }
}

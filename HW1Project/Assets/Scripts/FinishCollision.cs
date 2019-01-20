using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision obj)
    {
        (GameObject.Find("Enter").GetComponent<Button>()).interactable = true;
    }

    void OnCollisionExit(Collision obj)
    {
        (GameObject.Find("Enter").GetComponent<Button>()).interactable = false;
    }
}

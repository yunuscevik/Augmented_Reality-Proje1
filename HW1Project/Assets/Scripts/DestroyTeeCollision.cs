using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyTeeCollision : MonoBehaviour {

    private static GameObject tree = null;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnCollisionEnter(Collision obj)
    {
        tree = this.gameObject;
        (GameObject.Find("Enter").GetComponent<Button>()).interactable = true;

    }
    void OnCollisionExit(Collision obj)
    {
        
        (GameObject.Find("Enter").GetComponent<Button>()).interactable = false;
        

    }

    public void DestroyTee()
    {
        Debug.Log("===========>>>> " + tree);
        Destroy(tree);
        tree = null;
        (GameObject.Find("Enter").GetComponent<Button>()).interactable = false;
    }
    
}

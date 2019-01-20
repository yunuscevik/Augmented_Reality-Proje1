using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour {
    
    public TextMesh countdownText;
    private float countdownTo = 3.5F;
    private Vector3 rhino;
    private Vector3 obstacle;
    // Use this for initialization
    void Start () {


        rhino = GameObject.Find("Rhino").transform.position;
        obstacle = GameObject.Find("Obstacle").transform.position;
        countdownText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        if(StaticVariables.startSecond == true)
        {
            
            countdownTo -= Time.deltaTime;

            if (countdownTo >= 0)
                countdownText.text = ((int)countdownTo).ToString();
            else
            {
                countdownText.text = "";
                countdownTo = 3.5F;
                GameObject.Find("Rhino").transform.position = rhino;
                GameObject.Find("Rhino").transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                GameObject.Find("Obstacle").transform.position = obstacle;

                StaticVariables.startSecond = false;
            }
        }
        

    }

    void OnCollisionEnter(Collision obj)
    {
        countdownText.text = "3";
        StaticVariables.startSecond = true;
    }
}

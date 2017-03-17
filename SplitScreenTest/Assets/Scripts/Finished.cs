using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finished : MonoBehaviour {

    public Text GUIReady1;
    public Text GUIReady2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Player2")
        {
            Time.timeScale = 0;
            ReadySetGo.Set1 = false;
            ReadySetGo.Set2 = false;

            if (other.gameObject.tag == "Player")
            {
                GUIReady1.text = "Player 1 Win";
                GUIReady2.text = "Player 2 Lose";
            }

            if (other.gameObject.tag == "Player2")
            {
                GUIReady1.text = "Player 1 Lose";
                GUIReady2.text = "Player 2 Win";
            }


        }
    }
}

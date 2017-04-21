using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class done : MonoBehaviour {

    public Text GUIReady1;

   // public Text GUIText;
    private bool reset;

    // Use this for initialization
    void Start()
    {
        reset = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (reset == true)
        {
            if (Input.GetKey(KeyCode.R))
            {
                Application.LoadLevel("CPlevel");
            }

            if (Input.GetKey(KeyCode.M))
            {
                Application.LoadLevel("MAIN MENU");
            }

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Player2")
        {
            Time.timeScale = 0;


            if (other.gameObject.tag == "Player")
            {
                GUIReady1.text = "Player 1 Win";

                //GUIText.text = "Please press R to Restart or M to MainMenu";
                reset = true;
            }



        }
    }
}

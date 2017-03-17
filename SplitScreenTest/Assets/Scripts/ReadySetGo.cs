using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadySetGo : MonoBehaviour {

    public Text GUIReady1;
    public Text GUIReady2;
    public Text GUITimer;
    public Text GUIraceTimer1;
    public Text GUIraceTimer2;
    private float raceTimer1;
    private float raceTimer2;
    public static bool Set1;
    public static bool Set2;
    private float endCnt = 0;
    private float myTimer = 5.0f;



	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        myTimer = 5.0f;
        GUIReady1.text = "Player 1 Press Space to ready up";
        GUIReady2.text = "Player 2 Press Enter to ready up";

    }

    // Update is called once per frame
    void Update()
    {

        print(Time.realtimeSinceStartup);
        Debug.Log(myTimer);
        if(Input.GetKey(KeyCode.Space))
        {
            Set1 = true;
            GUIReady1.text = "Player 1 is Ready";
            Debug.Log("Player 1 is Ready");
        }

        if(Input.GetKey(KeyCode.Return))
        {
            Set2 = true;
            GUIReady2.text = "Player 2 is Ready";
            Debug.Log("Player 2 is Ready");
        }

        if(Set1 == true & Set2 == true)
        {
            //myTimer -= Time.deltaTime;
            //GUITimer.text = "Get Ready: " + myTimer;
            Time.timeScale = 1;
            endCnt = 1;
            GUIReady1.text = "";
            GUIReady2.text = "";

            /* Destroy(GUITimer);
             Destroy(GUIReady1);
             Destroy(GUIReady2);*/


        }

        if(Time.timeScale == 1)
        {
            raceTimer1 += Time.deltaTime;
            raceTimer2 += Time.deltaTime;
            GUIraceTimer1.text = "Time: " + raceTimer1;
            GUIraceTimer2.text = "Time: " + raceTimer2;
        }
        if(Time.timeScale == 1 & endCnt == 1)
        {

        }

       /* if(myTimer <= 0)
        {
            Time.timeScale = 1;
            Destroy(GUITimer);
            Destroy(GUIReady1);
            Destroy(GUIReady2);
        }*/





    }



    IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
        Time.timeScale = 1;
        Debug.Log("test");
    }

}

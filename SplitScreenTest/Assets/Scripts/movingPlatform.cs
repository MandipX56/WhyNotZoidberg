using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour {


    public Transform MovingPlatform;
    public Transform Position1;
    public Transform Position2;


    public Vector3 newPosition;
    public string currentState;
    public float Smooth;
    public float resetTime;

    // Use this for initialization
    void Start()
    {

        ChangeTarget();

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        MovingPlatform.position = Vector3.Lerp(MovingPlatform.position, newPosition, Smooth * Time.deltaTime);

    }

    void ChangeTarget()
    {
        if (currentState == "Moving to Position 1")
        {
            currentState = "Moving to Position 2";
            newPosition = Position2.position;
        }
        else if (currentState == "Moving to Position 2")
        {
            currentState = "Moving to Position 1";
            newPosition = Position1.position;
        }
        
        else if (currentState == "")
        {
            currentState = "Moving to Position 1";
            newPosition = Position1.position;
        }
        Invoke("ChangeTarget", resetTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.gameObject.tag == "Player2")
        {
            other.transform.parent = gameObject.transform;
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player" || other.gameObject.tag == "Player2")
        {
            other.transform.parent = null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField]
    public GameObject Spawn;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Respawn");
            other.gameObject.transform.position = Spawn.transform.position;

        }

        else if(other.gameObject.tag == "Player2")
        {
            other.gameObject.transform.position = Spawn.transform.position;
        }

    }
}

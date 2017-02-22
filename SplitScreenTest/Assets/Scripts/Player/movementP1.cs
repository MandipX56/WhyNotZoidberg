using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementP1 : MonoBehaviour {


    Animator anim;
    public float movementSpeed;
    public float jumpSpeed;
    float moveVelocity;

    public bool grounded = false;

    private Rigidbody2D player;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    //Jumping
        if(Input.GetKey(KeyCode.W))
        {
            if(grounded == true)
            {
                player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            }
        }
        
        if(Input.GetKey(KeyCode.A))
        {
            anim.SetInteger("State", 1);
            moveVelocity -= movementSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {

            anim.SetInteger("State", 1);
            moveVelocity += movementSpeed;
        }
        else
        {
            anim.SetInteger("State", 0);
        }

        player.velocity = new Vector2(moveVelocity, player.velocity.y);
        moveVelocity = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        grounded = false;
    }
}

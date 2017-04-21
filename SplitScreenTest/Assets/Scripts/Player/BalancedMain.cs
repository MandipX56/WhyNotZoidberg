using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalancedMain : MonoBehaviour {

    Animator anim;

    public Transform centerOfMass;

    public float movementSpeed;
    public float jumpSpeed;
    float moveVelocity;

    public bool grounded = false;

    private Rigidbody2D player;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();

        player.centerOfMass = centerOfMass.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        //Jumping
        if (Input.GetKey(KeyCode.W))
        {
            if (grounded == true)
            {
                player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            }
        }


        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(Vector3.up * 180);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetInteger("State", 1);
            moveVelocity -= movementSpeed;
        }



        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 180);
        }

        else if (Input.GetKey(KeyCode.D))
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
        if (other.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        grounded = false;
    }
}

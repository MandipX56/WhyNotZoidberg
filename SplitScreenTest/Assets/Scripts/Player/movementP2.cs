using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementP2 : MonoBehaviour
{

    public float movementSpeed;
    public float jumpSpeed;
    float moveVelocity;

    public bool grounded = false;

    private Rigidbody2D player;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jumping
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (grounded == true)
            {
                player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveVelocity -= movementSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveVelocity += movementSpeed;
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
        else if (other.gameObject.CompareTag("Notground"))
        {
            grounded = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        grounded = false;
    }
}

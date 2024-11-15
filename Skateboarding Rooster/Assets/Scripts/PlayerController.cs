using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float moveSpeed;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        if(Input.GetButton("Vertical"))
        {
            moveSpeed = moveSpeed + (2 * Time.deltaTime);
        }

        if(Input.GetButton("Horizontal1"))
        {
            transform.Rotate(0, -1, 0);
        }
        else if(Input.GetButton("Horizontal2"))
        {
            transform.Rotate(0, 1, 0);
        }
        if (speed >= 15)
        {
            
            rb.AddForce(transform.forward * moveSpeed);
            speed = rb.velocity.magnitude;
            speed = 15;
        }
        else if(speed < 1)
        {
            rb.AddForce(transform.forward * moveSpeed);
            speed = rb.velocity.magnitude;
            speed = 1;
        }
        else
        {
            rb.AddForce(transform.forward * moveSpeed);
            speed = rb.velocity.magnitude;
        }
    }
    
    void movePlayer()
    {
        float moveX = Input.GetAxis("Horizontal1");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * moveZ;
        move.Normalize();
        Vector3 moveVelocity = move * moveSpeed;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float moveSpeed;

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
        moveSpeed = moveSpeed + (1 * Time.deltaTime);
    }
    
    void movePlayer()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        move.Normalize();
        Vector3 moveVelocity = move * moveSpeed;
        moveVelocity.y = rb.velocity.y;
        rb.velocity = moveVelocity;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using UnityEngine;
using Timer = System.Timers.Timer;

public class movePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float moveSpeed;
    public Vector2 jumpHeight;
    bool isGrounded = true;

    public void Update()
    {
    }
    public void FixedUpdate()
    {
        if (!transform.position.y.ToString().Contains("-2.8"))
        {
            isGrounded = false;
        }

        if (transform.position.y.ToString().Contains("-2.8") || transform.position.y.ToString().Contains("-1.6864") || transform.position.y.ToString().Contains("-0.5564"))
        {
            isGrounded = true;
        }
        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y.ToString().Contains("-2.8"))
                return;
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.D) && transform.position.x <= -7)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime; //1800steamers test

        }
        if (Input.GetKey(KeyCode.A))
        {

        }
    }
}


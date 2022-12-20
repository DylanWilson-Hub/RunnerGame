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

    public void Update()
    {
        Timer timer = new Timer();


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            
        }
         if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

        }

         if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }
         if (Input.GetKey(KeyCode.S))
        {
            if(transform.position.y.ToString().Contains("-2.8"))
                return;
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;

        }
    }
}


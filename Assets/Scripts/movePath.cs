using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using UnityEngine;
using Timer = System.Timers.Timer;

public class movePath : MonoBehaviour
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
    }
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * -moveSpeed / 2 * Time.deltaTime; //1800steamers
        else
            transform.position += Vector3.right * (-moveSpeed / 4) * Time.deltaTime; //1800steamers

    }
}


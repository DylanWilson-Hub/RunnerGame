using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SystemRandom = System.Random;

public class PlayerDetected : MonoBehaviour
{
    SystemRandom rand = new SystemRandom();

    // Start is called before the first frame update
    public GameObject oneBlock;
    public GameObject twoBlock;
    int blockCount = 0;
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Obstacle")
        {
            Destroy(collision.gameObject,1.0f);

            //print("here");
            if (blockCount > 1 && rand.Next(0, 4) != 0)
            {
                Instantiate(twoBlock, new Vector3(11, (float)-2.57, 0), Quaternion.identity);
                blockCount = 0;
            }
            else
            {
                Instantiate(oneBlock, new Vector3(11, -3, 0), Quaternion.identity);
                blockCount++;

            }
        }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

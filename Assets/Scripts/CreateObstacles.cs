using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;
using SystemRandom = System.Random;
public class CreateObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    public GameObject BackGround;
    public int numOfObstacles;
    SystemRandom rand = new SystemRandom();
    private Collider collider;
    
    void Start()
    {
        collider = GetComponent<Collider>();
        int blockCount = 0;
        Instantiate(myPrefab, new Vector3(-7, -3, 0), Quaternion.identity);

        for (int i = 0; i < numOfObstacles; i++)
        {


            if (blockCount == 1 && rand.Next(0, 4) != 0)
            {
                int random = Random.Range(-5, 11);
               Instantiate(myPrefab, new Vector3(random, -3, 0), Quaternion.identity);
               Instantiate(myPrefab, new Vector3(random, (float)-1.87, 0), Quaternion.identity);            
                blockCount = 0;
            }
            else
            {
                int random = Random.Range(-5, 11);
                Instantiate(myPrefab, new Vector3(random, -3, 0), Quaternion.identity);   
                blockCount++;

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

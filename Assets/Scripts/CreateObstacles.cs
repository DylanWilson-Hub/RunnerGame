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
    public GameObject oneBlock;
    public GameObject twoBlock;
    public int numOfObstacles;
    public int speedOfGame = 1500;
    SystemRandom rand = new SystemRandom();
    int i = 0;
    public static int score;
    public static int speedRate = 0;
    void Start()
    {
        int blockCount = 0;
        Instantiate(oneBlock, new Vector3(-7, -3, 0), Quaternion.identity);
        for (int i = 0; i < numOfObstacles; i++)
        {
           if (blockCount > 1 && rand.Next(0, 4) != 0)
            {
                int random = Random.Range(-5, 11);
               Instantiate(twoBlock, new Vector3(random, (float)-2.7, 0), Quaternion.identity);
                blockCount = 0;
            }
            else
            {
                int random = Random.Range(-5, 11);
                Instantiate(oneBlock, new Vector3(random, -3, 0), Quaternion.identity);   
                blockCount++;

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        score++;
        if(i == speedOfGame) {
            speedRate++;
            i = 0;
        }
    }


}

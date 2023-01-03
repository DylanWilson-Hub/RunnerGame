using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMPro.TextMeshProUGUI m_MyText;

    void Start()
    {
        m_MyText.text = "Score: ";
    }

    // Update is called once per frame
    void Update()
    {
        m_MyText.text = "Score: "+ Mathf.RoundToInt((float)(CreateObstacles.score * .10));
    }
}

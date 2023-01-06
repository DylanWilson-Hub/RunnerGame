using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button03;

    void Start()
    {
        button03.onClick.AddListener(delegate { LoadScene("SampleScene"); });
    }

    private void LoadScene(string sceneToLoad)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
        CreateObstacles.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

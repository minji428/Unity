using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage0 : MonoBehaviour
{
    public void S1()
    {
        SceneManager.LoadScene("GameScene1_1");
    }
    public void S2()
    {
        SceneManager.LoadScene("GameScene2");
    }
    public void S3()
    {
        SceneManager.LoadScene("GameScene3");
    }
    public void S4()
    {
        SceneManager.LoadScene("GameScene4");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

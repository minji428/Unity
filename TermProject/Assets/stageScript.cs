using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stageScript : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("Game Scene");
    }
    public void Stage()
    {
        SceneManager.LoadScene("");
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

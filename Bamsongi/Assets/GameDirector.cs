using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject hpgauage;
    void Start()
    {
        this.hpgauage = GameObject.Find("Gauge");
      //  Debug.Log(this.hpgauage);
    }
    public void DecreaseHp()
    {
        this.hpgauage.GetComponent<UnityEngine.UI.Image>().fillAmount -= 0.1f;
        if(this.hpgauage.GetComponent<UnityEngine.UI.Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

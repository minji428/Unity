using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject gameover;
    GameObject arrow;
    GameObject hpGauge;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.arrow = GameObject.Find("ArrowGenerator");

        //  this.hpGauge.GetComponent<Text>().text = "Game Over";
    }

    public void DecreaseHP()
    {
        GetComponent<AudioSource>().Play();
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.21f;
        Debug.Log(this.hpGauge.GetComponent<Image>().fillAmount);
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            gameover.SetActive(true);
            Destroy(arrow);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

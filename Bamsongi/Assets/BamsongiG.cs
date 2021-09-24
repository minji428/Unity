using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiG : MonoBehaviour
{
    GameObject target;
    public GameObject bamsongiPrefab;
    GameObject bamsongi;
    // Start is called before the first frame update
    void Start()
    {
        this.target = GameObject.Find("target");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bamsongi = Instantiate(bamsongiPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bamsongi.GetComponent<Bamsongi>().Shoot(worldDir.normalized * 2000);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseHp();
    }
}



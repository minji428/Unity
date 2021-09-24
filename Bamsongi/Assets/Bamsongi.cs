using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamsongi : MonoBehaviour
{
    // Start is called before the first frame update
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "target")
        {
            Debug.Log(transform);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            other.transform.GetComponent<AudioSource>().Play();
        }
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
    void Start()
    {
        //Shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

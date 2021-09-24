using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrans : MonoBehaviour
{
    Vector3 dir = Vector3.up;
    public float dirtime = 3f;
    public float speed = 5.0f;
    public float dirMaxtime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        dirtime += Time.deltaTime;
        if (dirtime >= dirMaxtime)
        {
            dirtime = 0;
            if(dir == Vector3.up)
            {
                dir = Vector3.down;
            }
            else
            {
                dir = Vector3.up;
            }
        }


    }
}

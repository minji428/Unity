using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public Camera cameraObj;
    public GameObject myGameObj;
    public float speed = 2f;
    public int key = 0;
    public int key2 = 0;
  
    public void RButtonDown1()
    {
        key = -1;
    }
    public void LButtonDown1()
    {
        key = 1;
    }
    public void UButtonDown1()
    {
        key2 = 1;
    }
    public void DButtonDown1()
    {
        key2 = -1;
    }

    public void ButtonUp1()
    {
        key = 0;
        key2 = 0;
    }
    void Update()
    {
        RotateCamera();
    }
    void RotateCamera()
    {   


        cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.up, key * speed);
        cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.right, key2 * speed);
      

        if (Input.GetMouseButton(0))
        {

            //
            // 
            //cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.up, -Input.GetAxis("Mouse X") * speed);    //좌우
            //cameraObj.transform.RotateAround(myGameObj.transform.position, cameraObj.transform.right, -Input.GetAxis("Mouse Y") * speed); //위아래
        }
    }

}










/*
GameObject player;
// Start is called before the first frame update
void Start()
{
    this.player = GameObject.Find("player");
}

// Update is called once per frame
void Update()
{
    Vector3 playerPos = this.player.transform.position;
    transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
}*/


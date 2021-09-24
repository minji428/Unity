using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
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

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl2 : MonoBehaviour
{
    public Animator animator;
    Rigidbody rigid;
    public Camera cam;
    public Transform target;

    int keykey1 = 0;
    int keykey2 = 0;

    public bool Urun;
    public bool Drun;
    public bool Lrun;
    public bool Rrun;

    public float speed = 2.0f;
    public void RButtonDown()
    {
        keykey1 = 1;
        Rrun = true;

        transform.Rotate(Vector3.up * speed);

        //cam.GetComponent<CameraController>().key = 0;
        //cam.GetComponent<CameraController>().key2 = 0;
    }
    public void LButtonDown()
    {
        keykey1 = -1;
        Lrun = true;
        transform.Rotate(Vector3.down * speed);
    }
    public void UButtonDown()
    {
        keykey2 = 1;
        Urun = true;

    }
    public void DButtonDown()
    {
        keykey2 = -1;
        Drun = true;
    }
    public void ButtonUP()
    {
        keykey1 = 0;
        keykey2 = 0;
        Urun = false;
        Rrun = false;
        Drun = false;
        Lrun = false;

    }

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(keykey1, 0, keykey2), ForceMode.Impulse);
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
        if (Urun == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            animator.SetBool("Walk", true);
        }
        else if (Drun == true)
        {
            transform.Translate(Vector3.forward * -Time.deltaTime);
            animator.SetBool("Walk", true);
        }
        else if (Rrun == true)
        {
            transform.Rotate(Vector3.up * speed);
            //transform.Translate(Vector3.right * Time.deltaTime);
            //animator.SetBool("Walk", true);
        }
        else if (Lrun == true)
        {

            transform.Rotate(Vector3.down * speed);
            //transform.Translate(Vector3.right * -Time.deltaTime);
            //animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
        
    }
    void Update()
    {
       // 캐릭터가 떨어지면 다시 시작
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        MoveLookAt();
    }

    void MoveLookAt()
    {
        // 메인카메라가 바라보는 방향
        Vector3 dir = cam.transform.localRotation * Vector3.forward;
    }

}

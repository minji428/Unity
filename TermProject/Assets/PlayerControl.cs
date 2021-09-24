using System.Security;
using UnityChan;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Animator animator;
    GameObject goal;
    GameObject player;
    Rigidbody rigid;
    public Camera cam;
    public Transform target;
   // private float speed = 0.5f;
    int keykey1 = 0;
    int keykey2 = 0;
    public double speed = 2;
    public bool Urun;
    public bool Drun;
    public bool Lrun;
    public bool Rrun;

    public void RButtonDown()
    {
        keykey1 = 1;
        Rrun = true;
        //cam.GetComponent<CameraController>().key = 0;
        //cam.GetComponent<CameraController>().key2 = 0;
    }
    public void LButtonDown()
    {
        keykey1 = -1;
        Lrun = true;
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
        this.goal = GameObject.Find("Cube (8)");
        this.player = GameObject.Find("unitychan");
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {

        //Debug.Log(keykey1);
        //Debug.Log(keykey2);
        // float h = Input.GetAxisRaw("Horizontal");
        //  float v = Input.GetAxisRaw("Vertical");
        // rigid.AddForce(new Vector3(keykey1, 0, keykey2), ForceMode.Impulse);
        //  rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
        if(Urun == true)
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
            transform.Translate(Vector3.right * Time.deltaTime);
            animator.SetBool("Walk", true);
        }
        else if (Lrun == true)
        {
            transform.Translate(Vector3.right * -Time.deltaTime);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
        //rigid.velocity = new Vector3(keykey1, 0, keykey2);



    }
    void Update()
    {
        //print("x=" + transform.position.x);
        //print("x1=" + this.goal.transform.position.x);
        //print("y=" + transform.position.y);
        //print("y1=" + this.goal.transform.position.y);
        //print("z=" + transform.position.z);
        //print("z1=" + this.goal.transform.position.z);

        //Debug.Log("goal y = " + this.goal.transform.position.y);
        //Debug.Log("y = " + transform.position.y);
       /* if (transform.position.x > this.goal.transform.position.x &&
            transform.position.y > this.goal.transform.position.y &&
            transform.position.z < this.goal.transform.position.z)
        {
            SceneManager.LoadScene("Stage");
        }*/
        //transform.LookAt(Camera.main.transform.position);

        // 캐릭터가 떨어지면 다시 시작
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }

        MoveLookAt();    
    }

    void MoveLookAt()
    {
        // 메인카메라가 바라보는 방향
        Vector3 dir = cam.transform.localRotation * Vector3.forward;
        // 카메라가 바라보는 방향으로 플레이어도 바라보게 
        //transform.localRotation = cam.transform.localRotation;
        
        transform.LookAt(target);
       







        // 카메라가 회전하면 캐릭터 방향키도 회전    
        //player.transform.Translate(new Vector3(dir.x+transform.localRotation.x, dir.y, +transform.localRotation.z) * Time.deltaTime);
        //player.transform.Translate(dir.x, dir.y, dir.z);
        //transform.Translate(Vector3.right, Space.World);

    }





    // 플레이어의 Rotation.x값을 freeze해놓았지만 움직여서 따로 Rotation값을 0으로 세팅
    //transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
    //바라보는 시점 방향으로 이동
    //gameObject.transform.Translate(dir * 0.1f * Time.deltaTime);
}

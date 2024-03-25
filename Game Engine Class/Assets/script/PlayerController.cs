using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public float speed = 8f;
    float hAxis;
    float vAxis;

    Vector3 moveVec;
    // Start is called before the first frame update
    void Start()
    {
       playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidBody.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidBody.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidBody.AddForce(speed, 0,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidBody.AddForce(-speed, 0, 0);
        }   
        */
        GetInput();
        move();
    }

    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
    }
    void move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * speed * Time.deltaTime;
    }


    public void Die() // 게임 오브젝트가 비활성화 된다.
    {
        gameObject.SetActive(false);
    }
}

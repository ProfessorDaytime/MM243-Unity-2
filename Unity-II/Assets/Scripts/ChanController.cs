using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanController : MonoBehaviour
{

    Animator chanim;

    Rigidbody rb;

    float inH;
    float inV;

    bool isRunning;


    // Start is called before the first frame update
    void Start()
    {
        chanim = GetComponent<Animator>();    
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            chanim.Play("WAIT01");
        } else if(Input.GetKeyDown(KeyCode.Alpha2)){
            chanim.Play("WAIT02");
        } else if(Input.GetKeyDown(KeyCode.Alpha3)){
            chanim.Play("WAIT03");
        } else if(Input.GetKeyDown(KeyCode.Alpha4)){
            chanim.Play("WAIT04");
        }

        if(Input.GetMouseButtonDown(0)){
            int n = Random.Range(0,2);

            if(n == 0){
                chanim.Play("DAMAGED00");
            } else{
                chanim.Play("DAMAGED01");
            }
            
        } 

        inH = Input.GetAxis("Horizontal");
        inV = Input.GetAxis("Vertical");

        chanim.SetFloat("inH",inH);
        chanim.SetFloat("inV",inV);

        float moveX = inH * 200f * Time.deltaTime;
        float moveZ = inV * 200f * Time.deltaTime;

        print("moveX: " + moveX);
        print("moveZ: " + moveZ);

        rb.velocity = new Vector3(moveX, 0, moveZ);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unitychan0117 : MonoBehaviour
{
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow)){

            transform.Rotate(0, 5, 0);
            ani.SetBool("run", true);
        }

        if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Rotate(0, -5, 0);
            ani.SetBool("run", true);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {   
            transform.position += transform.forward * 0.01f;
            ani.SetBool("run", true);
        }
        else
        {
            ani.SetBool("run", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
           
            transform.position += -transform.forward * 0.01f; 
            ani.SetBool("run", true);
        }
        else
        {
            ani.SetBool("run", false);
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            ani.SetTrigger("jump");
        }


        
       
    }
}

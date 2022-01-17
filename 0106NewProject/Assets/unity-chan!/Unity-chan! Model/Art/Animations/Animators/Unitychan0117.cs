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
        }

        if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Rotate(0, -5, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {   ani.SetBool("run", true);
            transform.position += transform.forward * 0.01f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            ani.SetBool("run", true);
            transform.position += -transform.forward * 0.01f;
        }

        if (Input.GetKey(KeyCode.Space)){
            ani.SetTrigger("jump");
        }

       
    }
}

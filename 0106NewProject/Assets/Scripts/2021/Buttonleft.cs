using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonleft : MonoBehaviour
{
    public GameObject button;
    public GameObject ball;//�{�[���̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);

        //Sphere�I�u�W�F�N�g���i�[
        ball = GameObject.Find("Cube(Rotate)");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "button")
        {
            button.SetActive(true);
        }
    }
    //Sphere��Y���W��5�ɂ���
    public void BallUp()
    {
        ball.transform.Rotate(0, -50, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {

        transform.Rotate(0, 50 * Time.deltaTime, 0);
        //���O�o��
        Debug.Log("��������I");
    }
}

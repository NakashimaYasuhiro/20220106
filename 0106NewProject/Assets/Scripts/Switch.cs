using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject cube;
    public GameObject player;
    public void �{�^���܂Ƃ�(string �X�C�b�`)
    {
        switch (�X�C�b�`)
        {
            case "A":

                Debug.Log("A�������ꂽ");
               // cube.transform.Translate(0, 1, 0);
                cube.transform.Rotate(new Vector3(0, 1, 0));
                player.transform.Rotate(new Vector3(0, 5, 0));
                break;

            case "B":
                Debug.Log("B�������ꂽ");
                player.transform.Rotate(new Vector3(0, -5, 0));
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

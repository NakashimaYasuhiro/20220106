using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���C��
public class Main : MonoBehaviour
{
    public FixedJoystick joystick;

    // �X�V���ɌĂ΂��
    void Update()
    {
        // �W���C�X�e�B�b�N�̏�ԕ\��
        print("Horizontal: " + joystick.Horizontal);
        print("Vertical: " + joystick.Vertical);
    }
}

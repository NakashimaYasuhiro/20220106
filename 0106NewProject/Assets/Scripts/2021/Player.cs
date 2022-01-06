using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    public float speed;   // Player�I�u�W�F�N�g�̈ړ����x
    Vector3 mousePos;     // �ŏ��Ƀ^�b�`(���N���b�N)�����n�_�̏�������



    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move���\�b�h���펞�Ăяo��
        Move();
    }

    void Move()
    {
        // �}�E�X���N���b�N(��ʃ^�b�`)���s��ꂽ��
        if (Input.GetMouseButtonDown(0))
        {
            // �^�b�`�����ʒu����
            mousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            // �x�N�g���̈����Z���s���A���݂̃^�b�`�ʒu�Ƃ��̂P�t���[���O�̃^�b�`�ʒu�Ƃ̍���������Ƃ��đ��
            Vector3 mouseDiff = Input.mousePosition - mousePos;
            // ���̃t���[���̃^�b�`�����v�Z�ł���悤�Ɍ��݂̃^�b�`�ʒu��1�t���[���O�̃^�b�`�ʒu�Ƃ��đ��
            // ����ɂ��A�����̎擾���X�V���^�b�`���Ă���ԌJ��Ԃ��Ă���
            mousePos = Input.mousePosition;

            // ���݂�Player�̈ʒu�ɑ΂��āA�^�b�`�ʒu�̈ړ��������g���Ĉړ�����Z�o����
            // ���W�͉�ʂ�height�Ŋ��邱�Ƃňړ��ʒu�𒲐�
            // �^�b�`���ɂ�Z���̏�񂪂Ȃ��̂ŁAX���̈ړ�����X���̈ړ��p�Ɏg�p
            Vector3 newPos = transform.position + new Vector3(0, 0, -mouseDiff.x / Screen.height) * speed;

            // Player�I�u�W�F�N�g�̈ʒu���X�V���Ĉړ�����������
            transform.position = newPos;
        }
    }

}



    



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class ScriptTest : MonoBehaviour
{
    public class Boss
    {
        int hp;
        int power;
        int mp = 53;
        public void Attack()
        {
            // �U���p�̊֐�
        }
        public void Defence(int damage)
        {
            // �h��p�̊֐�
        }
        public void Magic()
        {
            if (mp >= 5)
            {
                mp -= 5;
                Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
            }
            else
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
        }
    }
        // Start is called before the first frame update
        void Start()
        {
            int[] array = { 10, 30, 80, 50, 70 };
            for (int i = 0; i < array.Length; i++)
            {
                Debug.Log(array[i]);
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Debug.Log(array[i]);
            }
            //���@���g��
            Boss magic = new Boss();
            for (int i = 0; i < 10; i++)
            {
                magic.Magic();
            }

            magic.Magic();

        }
        // Update is called once per frame
        void Update()
        {
        }
    }
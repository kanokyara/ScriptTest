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
            // 攻撃用の関数
        }
        public void Defence(int damage)
        {
            // 防御用の関数
        }
        public void Magic()
        {
            if (mp >= 5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
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
            //魔法を使う
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
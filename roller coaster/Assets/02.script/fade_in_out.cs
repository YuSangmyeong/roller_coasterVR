using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using Color = UnityEngine.Color;


public class fade_in_out : MonoBehaviour
{
    private GameObject SplashObj;               //�ǳڿ�����Ʈ
    private Image image;                            //�ǳ� �̹���
    private bool checkbool = false;     //���� ���� ���� ����

    [SerializeField] private float timer = 3.0f;

    void Awake()
    {

        SplashObj = this.gameObject;                         //��ũ��Ʈ ������ ������Ʈ

        image = SplashObj.GetComponent<Image>();    //�ǳڿ�����Ʈ�� �̹��� ����

    }
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            StartCoroutine("MainSplash");                        //�ڷ�ƾ    //�ǳ� ���� ����
        }

        if (checkbool)                                            //���� checkbool �� ���̸�

        {
            Destroy(this.gameObject);                        //�ǳ� �ı�, ����

        }

    }
    IEnumerator MainSplash()
    {
        Color color = image.color;                            //color �� �ǳ� �̹��� ����

        for (int i = 100; i >= 0; i--)                            //for�� 100�� �ݺ� 0���� ���� �� ����

        {
            color.a -= Time.deltaTime * 0.001f;               //�̹��� ���� ���� Ÿ�� ��Ÿ �� * 0.01

            image.color = color;                                //�ǳ� �̹��� �÷��� �ٲ� ���İ� ����

            if (image.color.a <= 0)                        //���� �ǳ� �̹��� ���� ���� 0���� ������

            {

                checkbool = true;                              //checkbool �� 

            }
        }
        yield return null;                                        //�ڷ�ƾ ����
    }
}






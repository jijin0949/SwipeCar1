using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 0f;
    Vector2 startPos;    //���콺 Ŭ���� ���� ��ġ�� �����ϴ� �Լ�
    public bool hasMove = false; //true�� �����̴� ����
    void Start()
    {
       
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && hasMove.Equals(false))
        {
            startPos = Input.mousePosition;  //Ŭ���� ��ġ�� ���콺 ����Ʈ ��ġ���� ����
            
        }
        else if (Input.GetMouseButtonUp(0) && hasMove.Equals(false))
        {
            Vector2 endPos = Input.mousePosition;  //�հ��� ���� �� ��ġ
            float swipeLenght = endPos.x - startPos.x;
            moveSpeed = swipeLenght / 500.0f;  // �������� ���̸� ó�� �ӵ��� �����Ѵ�.

            hasMove = true;
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(moveSpeed, 0, 0);

        if (moveSpeed <= 0.01f)
        {
            moveSpeed = 0f;
        }
        else
            moveSpeed *= 0.95f;
    }
}

    


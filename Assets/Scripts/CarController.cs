using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 0f;
    Vector2 startPos;    //마우스 클릭시 시작 위치를 저장하는 함수
    public bool hasMove = false; //true가 움직이는 상태
    void Start()
    {
       
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && hasMove.Equals(false))
        {
            startPos = Input.mousePosition;  //클릭한 위치에 마우스 포인트 위치값을 저장
            
        }
        else if (Input.GetMouseButtonUp(0) && hasMove.Equals(false))
        {
            Vector2 endPos = Input.mousePosition;  //손가락 떗을 때 위치
            float swipeLenght = endPos.x - startPos.x;
            moveSpeed = swipeLenght / 500.0f;  // 스와이프 길이를 처음 속도로 변경한다.

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

    


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text distance_Text;
    void Start()
    {
        
    }

    void Update()
    {
        float lenght = flag.transform.position.x - car.transform.position.x;
       
        if (lenght <= 0)
        {
            distance_Text.text = "실패.";
        }
        else
        {
            distance_Text.text = "목표 지점까지:" + lenght.ToString("F2") + "m";
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            car.gameObject.GetComponent<CarController>().hasMove = false;
            car.gameObject.GetComponent<CarController>().moveSpeed = 0f;
            car.gameObject.transform.position = new Vector3(-7f, -3.7f, 0);
        }
            
    }
   
}

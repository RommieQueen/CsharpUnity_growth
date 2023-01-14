using System.Collections;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;
using UnityEngine;

public class C3_if : MonoBehaviour
{
    void Start()
    {
        //조건문
        int health = 30;
        int power = 25;
        bool isQueen = health >= 30 && power >= 25;
        string[] shop = { "ring", "ear_ring", "book" };

        if (isQueen)
        {
            Debug.Log("여왕님, 안녕하십니까?");
        }
        else
        {
            Debug.Log("입장할 수 없습니다.");
        }
        if (isQueen && shop[1] == "ear_ring")
        {
            Debug.Log("여왕의 귀걸이를 얻었다.");
        }
        else
        {
            Debug.Log("재고가 없습니다.");
        }

    }
    void Update()
    {
        
    }
}

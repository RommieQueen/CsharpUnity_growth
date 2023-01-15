using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int currentHealth = 40;
        for (int i = 0; i < 3; i++)
        {
            currentHealth = Heal(currentHealth);
            Debug.Log("현재 체력" + currentHealth);
        }
    }
    //함수 형식 : 반환값 함수명()
    int Heal(int health) //매개변수 인수 안같아도됨
    {
        health += 20;
        Debug.Log("치유 성공");
        return health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 100;
        
        while (health > 0)
        {
            health = health -10;

            if (health > 0)
            {
                Debug.Log("피해를 입었습니다." + health);
            }
            else
            {
                Debug.Log("YOU DIED!");
                break;
            }
            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }
        Debug.Log("현재 체력 : " + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

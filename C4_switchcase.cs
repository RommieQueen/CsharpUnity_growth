using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] monsters = { "멍뭉이", "고먐미", "햄찌찌" ,"니얼굴"};

        switch (monsters[2])
        {
            case "멍뭉이":
                Debug.Log("멍멍!");
                break;
            case "고먐미":
                Debug.Log("먐먐!네모네모빔!");
                break;
            case "햄찌찌":
                Debug.Log("찎찌찎찎찎찌찎!");
                break;
            default:
                Debug.Log("???이 나타났다!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

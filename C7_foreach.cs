using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //형식 : foreach(자료형 변수명(같은배열) in 배열명)
        string[] family = { "mom", "dad", "sister", "brother" };
        foreach(string family in family)
        {
            Debug.Log("가족 : " + family);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

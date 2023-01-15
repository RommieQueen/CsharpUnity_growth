using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int count=0; count <=  100; count=count+10)
        {
            Debug.Log("치료 중.." + count + "%");
        }
        Debug.Log("치료 성공!");

        //그룹형 변수와 조합
        string[] monsters = { "멈뭄미", "고먐미", "햄찌찌", "냥냥펀치" };
        for(int index = 0; index < monsters.Length; index++) //인덱스 0으로 초기화, 길이는 1부터니까 < 또는 > 쓰기
        {
            Debug.Log(monsters[index]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

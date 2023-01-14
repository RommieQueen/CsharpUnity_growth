using System.Collections;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;
using UnityEngine;

public class 2_operator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //연산자

        string title1 = "수학자";
        string playername = "플레이어";
        Debug.Log(title1+" "+playername); //프린트 시 +로 이을 수 있다.

            //bool
        int level = 103;
        bool isHundrad = level >= 100;
        Debug.Log("100레벨 이상 입장 가능합니다. 100레벨 이상입니까? " + isHundrad);

        // 논리연산
            //AND
        int health = 35;
        int power = 50;
        bool isQueen = health >= 50 && power >= 50;
        Debug.Log("여왕 칭호를 얻으려면 체력 50 이상, 힘 50 이상을 충족해야합니다." + isQueen); //False

        health = 60;
        power = 95;
        isQueen = health >= 50 && power >= 50;
        Debug.Log("여왕 칭호를 얻으려면 체력 50 이상, 힘 50 이상을 충족해야합니다." + isQueen); //True  
            //OR
        health = 9;
        power = 12;
        bool isDanger = health < 20 || power < 15; //단락효과!!
        Debug.Log("플레이어가 위험 상태입니까?" + isDanger);

            //삼항연산자 ( 자료형 변수명 = 불 ? true일때 : false일때; )     
        string queen = isQueen ? "당신은 여왕입니다." : "아직 여왕이 되기엔 부족합니다.";
        Debug.Log(queen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

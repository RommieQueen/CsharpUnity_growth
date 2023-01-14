using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;    

public class 1_datatype_list : MonoBehaviour
{
    void Start()
    {
        //1. 자료형
        int age = 18;
        double weight = 48.1;
        string name = "Jes";
        bool isGirl = true;

        Debug.Log(age);
        Debug.Log(weight);
        Debug.Log(name);
        Debug.Log(isGirl);

        //2. 그룹형 변수(배열) 인덱스 사용
            //2-1. 문자열배열
        string[] movies = { "Titanic", "NoteBook", "Eternal_Sunshine", "KissingBooth" };

        Debug.Log(movies[0]);

            //2-2. 정수형 배열
        int[] num = new int[5];

        num[0] = 3;
        num[1] = 4;
        num[2] = 12;
        num[3] = 16;
        num[4] = 22;

        Debug.Log(num[0]);
        Debug.Log(num[1]);
        Debug.Log(num[2]);
        Debug.Log(num[3]);
        Debug.Log(num[4]);

            /* 2-3. 리스트 : 기능 추가된 가변형 그룹형 변수
             * 선언 : List<자료형> 변수명 = new List<자료형>();
             * 대입 : 변수명.Add(요소명);
             * 사용 : Add한 순서대로 인덱스0번부터 대입됨. 예) Debug.Log(변수명[인덱스]); 하면 출력 */

        List<string> items = new List<string>();
        items.Add("clothes");
        items.Add("laptop");
        items.Add("hamster");

        Debug.Log(items[0]);
        Debug.Log(items[1]);
        Debug.Log(items[2]);
    }

    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //������

        string title1 = "������";
        string playername = "�÷��̾�";
        Debug.Log(title1+" "+playername); //����Ʈ �� +�� ���� �� �ִ�.

            //bool
        int level = 103;
        bool isHundrad = level >= 100;
        Debug.Log("100���� �̻� ���� �����մϴ�. 100���� �̻��Դϱ�? " + isHundrad);

        // ������
            //AND
        int health = 35;
        int power = 50;
        bool isQueen = health >= 50 && power >= 50;
        Debug.Log("���� Īȣ�� �������� ü�� 50 �̻�, �� 50 �̻��� �����ؾ��մϴ�." + isQueen); //False

        health = 60;
        power = 95;
        isQueen = health >= 50 && power >= 50;
        Debug.Log("���� Īȣ�� �������� ü�� 50 �̻�, �� 50 �̻��� �����ؾ��մϴ�." + isQueen); //True  
            //OR
        health = 9;
        power = 12;
        bool isDanger = health < 20 || power < 15; //�ܶ�ȿ��!!
        Debug.Log("�÷��̾ ���� �����Դϱ�?" + isDanger);

            //���׿����� ( �ڷ��� ������ = �� ? true�϶� : false�϶�; )     
        string queen = isQueen ? "����� �����Դϴ�." : "���� ������ �Ǳ⿣ �����մϴ�.";
        Debug.Log(queen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

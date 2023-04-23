using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B40423 : MonoBehaviour // 유니티 게임 오브젝트 클래스
{

    string title = "전설의";
    string playerName = "Asmodeus";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = false;



    //그룹형 변수
    string[] monsters = { "슬라임", "사막뱀", "악마" };
    int[] monsterLevel = { 1, 11, 31 };


    // 클래스불러오기 못해서
    int id2 = 0;
    string name2 = "Mamon";
    string title2 = "The Brave";
    string weapon2 = "Sword";
    float strength2 = 2.4f;
    //float level2;

    string Talk2()
    {
       return "대화를 걸었습니다.";
    }


    string HasWeapon2()
    {
        return weapon2;
    }

    void LevelUp2()
    {
       level += 1;
    }

    



    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log();
        Debug.Log("HAHAHAHA! I CAN!!!!");

        /*B4
        //변수 : 선언 -> 초기화 -> 호출*/
        int level = 5;
        float strength = 15.5f; // float은 꼭 f 붙이기
        string playerName = "Asmodeus";
        bool isFullLevel = false;
        string title = "전설의";
        
        
        
        
        
        





        //그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 11;
        monsterLevel[2] = 31;

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        items.Add("마나물약30");

        // 시스트 수정(항목삭제, 뒤 요소들이 한칸씩 앞으로 옮겨짐)
        //items.RemoveAt(0); // 왜 이건 소괄호임?

        //연산자
        int exp = 1500;
        exp = 1500 + 320;
        exp -= 10;
        level = exp / 300;
        strength = level * 3.1f;
        int nextExp = 300 - (exp % 300);


        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level > 10;

        int health = 30;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <=20;
        bool isBadCondition = health <= 50 || mana <= 20;
        string condition = isBadCondition ? "나쁨" : "좋음";

        //키워드 : 프로그래밍 언어를 구성하는 특별한 단어 != 변수명

        //조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어의 상태가 좋습니다.");
        }

        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (isBadCondition && items[0] == "마나물약30")
        {
        items.RemoveAt(0);
        mana += 30;
        Debug.Log("마나포션30을 사용하였습니다.");
        }
        else
        {
        //do nothing
        }
            // 스위치문은 브레이크꼭 쓰기(아니면 다음걸로 넘어가거나 오류남)
        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형몬스터 " + monsters[0] + " 출현!");
                break;
            case "악마": //여러개는 콤마쓰고 이어써도 됨                
                Debug.Log("중형몬스터 " + monsters[0] + " 출현!");
                break;
            case "골램":
                Debug.Log("대형몬스터 " + monsters[0] + " 출현!");
                break;
            default:
                Debug.Log("??? 몬스터가 출현!");
                break;
            }

        /*출력접기*/
        Debug.Log("용사의 이름은?");
            Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        Debug.Log("용사는 만렙입니까? " + isFullLevel);

        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        Debug.Log("용사의 상태는 나쁩니까? " + condition);

        // 스위치문은 브레이크꼭 쓰기(아니면 다음걸로 넘어가거나 오류남)
        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형몬스터 " + monsters[0] + " 출현!");
                break;
            case "악마": //여러개는 콤마
                Debug.Log("중형몬스터 " + monsters[0] + " 출현!");
                break;
            case "골램":
                Debug.Log("대형몬스터 " + monsters[0] + " 출현!");
                break;
            default:
                Debug.Log("??? 몬스터가 출현!");
                break;
        }

        //반복문
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다. " + health);
            else
                Debug.Log("사망하였습니다.");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for (int count = 0; count < 10; count++){
            health++;
            Debug.Log("붕대로 치료 중... " + health);
        }

        for (int index = 0; index < monsters.Length; index++){
           Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }
        Heal();
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monsterLevel[index]));
        }

    }


        
    
    void Heal()
    {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";

       return result;
    }

}

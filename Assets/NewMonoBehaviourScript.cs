using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Unity");
        // 1. 변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);

        // 2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        int[] mosterLevel = new int[3];
        mosterLevel[0] = 1;
        mosterLevel[1] = 6;
        mosterLevel[2] = 20;
        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(mosterLevel[0]);
        Debug.Log(mosterLevel[1]);
        Debug.Log(mosterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        // 삭제 : items.RemoveAt(0); 실행 시 인덱스 오류 발생

        // 3.연산자

        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        int health = 30;
        int mana = 25;
        // && : AND , || : OR  
        bool isBadCondition = health <= 50 && mana <= 20;
        

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까? " + condition);

        // 4. 키워드
        // int float string bool new List

        // 5. 조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다");
        }

        if ( isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명물약30을 사용하였습니다.");
        }
        else if (isBadCondition && items[1] == "마나물약30")
        {
            items.RemoveAt(1);
            mana += 30;
            Debug.Log("마나물약30을 사용하였습니다.");
        }

        switch (monsters[1])
        {
            case "슬라임":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default:
                break;

        }

        // 6. 반복문
        /* while (조건)
        {
            바디
        }*/

        /* for (연산될 변수 ; 조건 ; 연산){
            바디
         }*/
        // 그룹형 변수길이 배열: Length, 리스트: Count
        foreach ( string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 :"+ monster);
        }

        health = Heal(health);

        // 8. 클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());
        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다");
        Debug.Log(player.move());
    }

    // 7. 함수 (메소드)

    int Heal(int health)
    {
        health += 10;
        Debug.Log("힐을 받았습니다." + health);
        return health;
    }
    // void로 만들시 return 없이 가능 단, 지역변수, 전역변수의 개념을 알고있어야함.

    
}

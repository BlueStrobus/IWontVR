using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedClass : MonoBehaviour
{//MonoBehaviour : 유니티 오브젝트 부모 클래스
    // Start is called before the first frame update
    void Start()
    { 
        // 클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWepon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        Debug.Log(player.move());



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

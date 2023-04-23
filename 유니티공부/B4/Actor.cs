// C# 에서는 하나의 파일애 하나의 클래스가 원칙

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor //: MonoBehaviour
{
    // 앞에 아무것도 없으면 
    // private int 가 됨
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public float level;

    public string Talk(){
        return "대화를 걸었습니다.";
    }

    public string HasWepon(){
        return weapon;
    }

    public void LevelUp(){
        level += 1;
    }

}

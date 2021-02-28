using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    // 늑대 0, 타이거 1, 표범 2, 하늘다람쥐 3, 여우 4, 담비 5, 판다 6
    public bool apple = false;
    public bool lettuce = false; //상추
    public bool grape = false;
    public bool tree = false;//tree=대나무
    public bool sweetpotato = false;
    public bool cherry = false;
    public bool ricecake = false;//찹쌀떡
    public bool peach = false;

    public int money = 1000;

    // 경로당: 0이면 게임, 1이면 대화 (-1로 초기화)
    public bool What_animal = false;    // 버튼 클릭시 true
    public int Wolf = -1;
    public int Tiger = -1;
    public int Leopard = -1;
    public int Squirrel = -1;
    public int Fox = -1;
    public int Dambi = -1;
    public int Panda = -1;

    public int[] talk_num = new int[8];
}

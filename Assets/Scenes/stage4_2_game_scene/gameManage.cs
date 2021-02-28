using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManage : MonoBehaviour
{
    public static int score;
    public static int total;
    public int getMoney;
    public StageManager StageManager;

    public Text moneyScore;

    void Awake()
    {
        score = 0;
        total = 0;
        getMoney = 0;
        moneyScore = GameObject.Find("Canvas").transform.Find("moneyScore").gameObject.GetComponent<Text>();
        moneyScore.enabled = false;
        StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        if (total == 13)
        {
            getMoney += score * 10;
            moneyScore.text = getMoney.ToString("D3") + "원 획득!";
            moneyScore.enabled = true;
            StageManager.money += getMoney;      
            total++;
        }
    }

}






using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinScript : MonoBehaviour
{
    public StageManager StageManager;
    public Text coinNum;
    //public GameObject coinImg;

    void Start()
    {
        coinNum = GameObject.Find("CoinCanvas").transform.Find("coinNum").GetComponent<Text>();
        //coinImg = GameObject.Find("CoinCanvas").transform.Find("coinImg").gameObject;
        StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        numPrint();
    }

    void numPrint()
    {
        coinNum.text = StageManager.money.ToString("D2");
    }
}



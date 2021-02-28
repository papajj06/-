using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextQuiz : MonoBehaviour
{
    public StageManager StageManager;
    public MissionClick MissionClick;

    public GameObject bearCanvas;
    public GameObject catCanvas;
    public GameObject dearCanvas;
    public GameObject duckCanvas;
    public GameObject frogCanvas;
    public GameObject horseCanvas;
    public GameObject lionCanvas;
    public GameObject mouseCanvas;
    public GameObject pigCanvas;
    public GameObject sheepCanvas;
    public GameObject wolfCanvas;

    public GameObject home;

    public Text Score;
    public Text totalMoney;

    int rand;
    public int total = 0;
    public int num;
    public int score = 0;
    public bool end = false;

    public bool nextOkay = true;

    void Start()
    {
        StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        Score = GameObject.Find("footCanvas").transform.Find("Score").GetComponent<Text>();
        totalMoney = GameObject.Find("footCanvas").transform.Find("totalMoney").GetComponent<Text>();

        bearCanvas = GameObject.Find("bearCanvas").transform.Find("bearImg").gameObject;
        catCanvas = GameObject.Find("catCanvas").transform.Find("catImg").gameObject;
        dearCanvas = GameObject.Find("dearCanvas").transform.Find("dearImg").gameObject;
        duckCanvas = GameObject.Find("duckCanvas").transform.Find("duckImg").gameObject;
        frogCanvas = GameObject.Find("frogCanvas").transform.Find("frogImg").gameObject;
        horseCanvas = GameObject.Find("horseCanvas").transform.Find("horseImg").gameObject;
        lionCanvas = GameObject.Find("lionCanvas").transform.Find("lionImg").gameObject;
        mouseCanvas = GameObject.Find("mouseCanvas").transform.Find("mouseImg").gameObject;
        pigCanvas = GameObject.Find("pigCanvas").transform.Find("pigImg").gameObject;
        sheepCanvas = GameObject.Find("sheepCanvas").transform.Find("sheepImg").gameObject;
        wolfCanvas = GameObject.Find("wolfCanvas").transform.Find("wolfImg").gameObject;

        home = GameObject.Find("Canvas").transform.Find("HomeButton").gameObject;


    }

    void Update()
    {
        Score.text = score.ToString("D1") + " / 3";
        rand = Random.Range(1, 123);
        gameStart(rand);
        if (total == 3 && !end)
        {
            textPrint();
            StageManager.money += score * 100;
            end = true;
        }
    }

    public void gameStart(int rand)
    {
        if (total < 3 && nextOkay)
        {
            num = rand % 11;
            nextQuizImg(num);            
        }              
    }

    public void textPrint()
    {
        totalMoney.text = "상금으로 " + score * 100 + "원 획득하셨습니다!";
        totalMoney.gameObject.SetActive(true);
        home.SetActive(true);
    }

    public void nextQuizImg(int num)
    {
        switch (num)
        {
            case 0:
                bearCanvas.SetActive(true);
                break;
            case 1:
                catCanvas.SetActive(true);
                break;
            case 2:
                dearCanvas.SetActive(true);
                break;
            case 3:
                duckCanvas.SetActive(true);
                break;
            case 4:
                frogCanvas.SetActive(true);
                break;
            case 5:
                horseCanvas.SetActive(true);
                break;
            case 6:
                lionCanvas.SetActive(true);
                break;
            case 7:
                mouseCanvas.SetActive(true);
                break;
            case 8:
                pigCanvas.SetActive(true);
                break;
            case 9:
                sheepCanvas.SetActive(true);
                break;
            case 10:
                wolfCanvas.SetActive(true);
                break;
        }
        nextOkay = false;
        //Debug.Log(total);
    }

    public void QuizClose(int num)
    {
        switch (num)
        {
            case 0:
                bearCanvas.SetActive(false);
                break;
            case 1:
                catCanvas.SetActive(false);
                break;
            case 2:
                dearCanvas.SetActive(false);
                break;
            case 3:
                duckCanvas.SetActive(false);
                break;
            case 4:
                frogCanvas.SetActive(false);
                break;
            case 5:
                horseCanvas.SetActive(false);
                break;
            case 6:
                lionCanvas.SetActive(false);
                break;
            case 7:
                mouseCanvas.SetActive(false);
                break;
            case 8:
                pigCanvas.SetActive(false);
                break;
            case 9:
                sheepCanvas.SetActive(false);
                break;
            case 10:
                wolfCanvas.SetActive(false);
                break;
        }
        total++; Debug.Log("게임:" + total);
        nextOkay = true;
    }
}

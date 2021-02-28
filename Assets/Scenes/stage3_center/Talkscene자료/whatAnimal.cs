using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whatAnimal : MonoBehaviour
{
    public StageManager StageManager;
    public GameObject wolf;
    public GameObject tiger;
    public GameObject squirrel;
    public GameObject leopard;
    public GameObject dambi;
    public GameObject fox;
    public GameObject panda;

    int num;

    void Start()
    {
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        wolf = GameObject.Find("animal").transform.Find("wolf").gameObject;
        tiger = GameObject.Find("animal").transform.Find("tiger").gameObject;
        squirrel = GameObject.Find("animal").transform.Find("squirrel").gameObject;
        leopard = GameObject.Find("animal").transform.Find("leopard").gameObject;
        dambi = GameObject.Find("animal").transform.Find("dambi").gameObject;
        fox = GameObject.Find("animal").transform.Find("fox").gameObject;
        panda = GameObject.Find("animal").transform.Find("panda").gameObject;

        for (int i = 0; i < 7; i++)
        {
            if (StageManager.talk_num[i] == 1)
                num = i;
        }
        showAnimal(num);
    }

    void showAnimal(int num)
    {
        switch (num)
        {
            case 0:
                wolf.SetActive(true);
                break;
            case 1:
                tiger.SetActive(true);
                break;
            case 2:
                leopard.SetActive(true);
                break;
            case 3:
                squirrel.SetActive(true);
                break;
            case 4:
                fox.SetActive(true);
                break;
            case 5:
                dambi.SetActive(true);
                break;
            case 6:
                panda.SetActive(true);
                break;
        }
    }
}

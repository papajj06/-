using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMission : MonoBehaviour
{
    public StageManager StageManager;
    public AnimalManager AnimalManager;
    public GameObject talk_w;
    public GameObject game_w;
    public GameObject food_w;
    public GameObject talk_d;
    public GameObject game_d;
    public GameObject food_d;
    public GameObject talk_f;
    public GameObject game_f;
    public GameObject food_f;
    public GameObject talk_s;
    public GameObject game_s;
    public GameObject food_s;
    public GameObject talk_p;
    public GameObject game_p;
    public GameObject food_p;
    public GameObject talk_l;
    public GameObject game_l;
    public GameObject food_l;
    public GameObject talk_t;
    public GameObject game_t;
    public GameObject food_t;

    int rand1;
    int rand2;
    int rand3;
    int rand4;

    void Start()
    {
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        this.AnimalManager = GameObject.Find("AnimalManager").GetComponent<AnimalManager>();
        talk_w = GameObject.Find("Canvas").transform.Find("bubble_talk_w").gameObject;
        game_w = GameObject.Find("Canvas").transform.Find("bubble_game_w").gameObject;
        food_w = GameObject.Find("Canvas").transform.Find("bubble_food_w").gameObject;
        talk_d = GameObject.Find("Canvas").transform.Find("bubble_talk_d").gameObject;
        game_d = GameObject.Find("Canvas").transform.Find("bubble_game_d").gameObject;
        food_d = GameObject.Find("Canvas").transform.Find("bubble_food_d").gameObject;
        talk_s = GameObject.Find("Canvas").transform.Find("bubble_talk_s").gameObject;
        game_s = GameObject.Find("Canvas").transform.Find("bubble_game_s").gameObject;
        food_s = GameObject.Find("Canvas").transform.Find("bubble_food_s").gameObject;
        talk_f = GameObject.Find("Canvas").transform.Find("bubble_talk_f").gameObject;
        game_f = GameObject.Find("Canvas").transform.Find("bubble_game_f").gameObject;
        food_f = GameObject.Find("Canvas").transform.Find("bubble_food_f").gameObject;
        talk_p = GameObject.Find("Canvas").transform.Find("bubble_talk_p").gameObject;
        game_p = GameObject.Find("Canvas").transform.Find("bubble_game_p").gameObject;
        food_p = GameObject.Find("Canvas").transform.Find("bubble_food_p").gameObject;
        talk_l = GameObject.Find("Canvas").transform.Find("bubble_talk_l").gameObject;
        game_l = GameObject.Find("Canvas").transform.Find("bubble_game_l").gameObject;
        food_l = GameObject.Find("Canvas").transform.Find("bubble_food_l").gameObject;
        talk_t = GameObject.Find("Canvas").transform.Find("bubble_talk_t").gameObject;
        game_t = GameObject.Find("Canvas").transform.Find("bubble_game_t").gameObject;
        food_t = GameObject.Find("Canvas").transform.Find("bubble_food_t").gameObject;

        rand1 = Random.Range(0, 50);
        rand2 = Random.Range(0, 23);
        rand3 = Random.Range(0, 101);
        rand4 = Random.Range(0, 48);
    }

    void Update()
    {
        if (AnimalManager.Wolf_State)
        {
            if (rand1 % 3 == 0)
            {
                talk_w.SetActive(true);
                //StageManager.Wolf = 1;
            }
            else if (rand1 % 3 == 1)
            {
                game_w.SetActive(true);
                //StageManager.Wolf = 0;
            }
            else
            {
                food_w.SetActive(true);
            }
        }
        if (AnimalManager.Tiger_State)
        {
            if (rand2 % 3 == 0)
            {
                talk_t.SetActive(true);
                //StageManager.Tiger = 1;
            }
            else if (rand2 % 3 == 1)
            {
                game_t.SetActive(true);
                //StageManager.Tiger = 0;
            }
            else
            {
                food_t.SetActive(true);
            }
        }
        if (AnimalManager.Leopard_State)
        {
            if (rand1 % 3 == 0)
            {
                talk_l.SetActive(true);
                //StageManager.Leopard = 1;
            }
            else if (rand1 % 3 == 1)
            {
                game_l.SetActive(true);
                //StageManager.Leopard = 0;
            }
            else
            {
                food_l.SetActive(true);
            }
        }
        if (AnimalManager.Squirrel_State)
        {
            if (rand4 % 3 == 0)
            {
                talk_s.SetActive(true);
                //StageManager.Squirrel = 1;
            }
            else if (rand4 % 3 == 1)
            {
                game_s.SetActive(true);
                //StageManager.Squirrel = 0;
            }
            else
            {
                food_s.SetActive(true);
            }
        }
        if (AnimalManager.Fox_State)
        {
            if (rand3 % 3 == 0)
            {
                talk_f.SetActive(true);
                //StageManager.Fox = 1;
            }
            else if (rand3 % 3 == 1)
            {
                game_f.SetActive(true);
                //StageManager.Fox = 0;
            }
            else
            {
                food_f.SetActive(true);
            }
        }
        if (AnimalManager.Dambi_State)
        {
            if (rand4 % 3 == 0)
            {
                talk_d.SetActive(true);
                //StageManager.Dambi = 1;
            }
            else if (rand4 % 3 == 1)
            {
                game_d.SetActive(true);
                //StageManager.Dambi = 0;
            }
            else
            {
                food_d.SetActive(true);
            }
        }
        if (AnimalManager.Panda_State)
        {
            if (rand2 % 3 == 0)
            {
                talk_p.SetActive(true);
                //StageManager.Panda = 1;
            }
            else if (rand2 % 3 == 1)
            {
                game_p.SetActive(true);
                //StageManager.Panda = 0;
            }
            else
            {
                food_p.SetActive(true);
            }
        }
    }
}

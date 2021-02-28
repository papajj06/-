using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32;
using UnityEngine;

public class CenterGameManager : MonoBehaviour
{
    public AnimalManager AnimalManager;
        public GameObject wolf;
        public GameObject tiger;
        public GameObject leopard;
        public GameObject squirrel;
        public GameObject fox;
        public GameObject dambi;
        public GameObject panda;

    void Start()
    {
        this.AnimalManager = GameObject.Find("AnimalManager").GetComponent<AnimalManager>();
        int rand = Random.Range(1, 7);
        Animal_Random(rand);
    }

    void Animal_Random(int rand)
    {
        if (rand == 1)
        {
            tiger.SetActive(false);
            dambi.SetActive(false);
            squirrel.SetActive(false);
            panda.SetActive(false);

            AnimalManager.Tiger_State = false;
            AnimalManager.Dambi_State = false;
            AnimalManager.Squirrel_State = false;
            AnimalManager.Panda_State = false;
        }
        else if (rand == 2)
        {
            wolf.SetActive(false);
            leopard.SetActive(false);
            fox.SetActive(false);
            panda.SetActive(false);

            AnimalManager.Wolf_State = false;
            AnimalManager.Leopard_State = false;
            AnimalManager.Fox_State = false;
            AnimalManager.Panda_State = false;
        }
        else if (rand == 3)
        {
            tiger.SetActive(false);
            leopard.SetActive(false);
            squirrel.SetActive(false);
            wolf.SetActive(false);

            AnimalManager.Tiger_State = false;
            AnimalManager.Leopard_State = false;
            AnimalManager.Squirrel_State = false;
            AnimalManager.Wolf_State = false;
        }
        else if (rand == 4)
        {
            fox.SetActive(false);
            dambi.SetActive(false);
            leopard.SetActive(false);
            squirrel.SetActive(false);

            AnimalManager.Squirrel_State = false;
            AnimalManager.Dambi_State = false;
            AnimalManager.Leopard_State = false;
            AnimalManager.Fox_State = false;
        }
        else if (rand == 5)
        {
            wolf.SetActive(false);
            tiger.SetActive(false);
            panda.SetActive(false);
            dambi.SetActive(false);

            AnimalManager.Wolf_State = false;
            AnimalManager.Panda_State = false;
            AnimalManager.Tiger_State = false;
            AnimalManager.Dambi_State = false;
        }
        else
        {
            panda.SetActive(false);
            leopard.SetActive(false);
            fox.SetActive(false);
            tiger.SetActive(false);

            AnimalManager.Panda_State = false;
            AnimalManager.Leopard_State = false;
            AnimalManager.Fox_State = false;
            AnimalManager.Tiger_State = false;
        }
    }
}

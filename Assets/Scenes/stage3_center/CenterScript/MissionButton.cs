using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissionButton : MonoBehaviour
{
    public GameObject obj;
    public Image hungry;
    public Sprite food;
    public Sprite no;
    public Sprite heart;

    public StageManager StageManager;
    public AnimalMission AnimalMission;
    private int click = 0;
    private bool Heart = false;

    private int randomNumber;

    void Awake()
    {
        StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        randomNumber = Random.Range(0, 3);
    }

    public void gameClick()
    {
        SceneManager.LoadScene("gameScene");
    }

    public void talkClick()
    {
        StageManager.What_animal = true;
        if (randomNumber == 0)
            SceneManager.LoadScene("talkScene");
        else if (randomNumber == 1)
            SceneManager.LoadScene("talkScene2");
        else 
            SceneManager.LoadScene("talkScene3");
    }

    public void Wolf_t()
    {
        if (StageManager.What_animal)
            StageManager.talk_num[0] = 1;
    }

    public void Tiger_t()
    {
        if (StageManager.What_animal)
            StageManager.talk_num[1] = 1;
    }
    public void Leopard_t()
    {
        if (StageManager.What_animal)
            StageManager.talk_num[2] = 1;
    }
    public void Squirrel_t()
    {
        if (StageManager.What_animal)
            StageManager.talk_num[3] = 1;
    }
    public void Fox_t()
    {
        if (StageManager.What_animal)
            StageManager.talk_num[4] = 1;
    }
    public void Dambi_t()
    {
        if (StageManager.What_animal)
            StageManager.talk_num[5] = 1;
    }
    public void Panda_t()
    {
        if (StageManager.What_animal)
            StageManager.talk_num[6] = 1;
    }

    public void foodClick()
    {
        click++;
        if (click == 1)
            hungry.sprite = food;
        Debug.Log(click);
    }

    public void WolfFunc()
    {
        if (StageManager.sweetpotato && click % 2 == 0)
        {
            hungry.sprite = heart;
            StageManager.sweetpotato = false;
            Heart = true;
        }
        else if(!StageManager.sweetpotato && click > 1 && !Heart)
        {           
            Invoke("foodButtonChange", 1f);
            hungry.sprite = no;
        }
    }

    public void TigerFunc()
    {
        if (StageManager.ricecake && click % 2 == 0)
        {
            hungry.sprite = heart;
            StageManager.sweetpotato = false;
            Heart = true;
        }
        else if (!StageManager.ricecake && click > 1 && !Heart)
        {
            Invoke("foodButtonChange", 1f);
            hungry.sprite = no;
        }
    }

    public void LeopardFunc()
    {
        if (StageManager.peach && click % 2 == 0)
        {
            hungry.sprite = heart;
            StageManager.sweetpotato = false;
            Heart = true;
        }
        else if (!StageManager.peach && click > 1 && !Heart)
        {
            Invoke("foodButtonChange", 1f);
            hungry.sprite = no;
        }
    }

    public void SquirrelFunc()
    {
        if (StageManager.lettuce && click % 2 == 0)
        {
            hungry.sprite = heart;
            StageManager.sweetpotato = false;
            Heart = true;
        }
        else if (!StageManager.lettuce && click > 1 && !Heart)
        {
            Invoke("foodButtonChange", 1f);
            hungry.sprite = no;
        }
    }

    public void FoxFunc()
    {
        if (StageManager.grape && click % 2 == 0)
        {
            hungry.sprite = heart;
            StageManager.sweetpotato = false;
            Heart = true;
        }
        else if (!StageManager.grape && click > 1 && !Heart)
        {
            Invoke("foodButtonChange", 1f);
            hungry.sprite = no;
        }
    }

    public void DambiFunc()
    {
        if (StageManager.cherry && click % 2 == 0)
        {
            hungry.sprite = heart;
            StageManager.sweetpotato = false;
            Heart = true;
        }
        else if (!StageManager.cherry && click > 1 && !Heart)
        {
            Invoke("foodButtonChange", 1f);
            hungry.sprite = no;
        }
    }

    public void PandaFunc()
    {
        if (StageManager.tree && click % 2 == 0)
        {
            hungry.sprite = heart;
            StageManager.sweetpotato = false;
            Heart = true;
        }
        else if (!StageManager.tree && click > 1 && !Heart)
        {
            Invoke("foodButtonChange", 1f);
            hungry.sprite = no;
        }
    }

    private void foodButtonChange()
    {
        hungry.sprite = food;
    }
}

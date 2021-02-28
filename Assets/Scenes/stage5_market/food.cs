using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public StageManager StageManager;

    void Start()
    {
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    public void appleClick()
    {
        if (StageManager.money >= 300 && !StageManager.apple)
        {
            gameObject.SetActive(false);
            StageManager.apple = true;
            StageManager.money -= 300;
        }
    }


    public void lettuceClick()
    {
        if (StageManager.money >= 200 && !StageManager.lettuce)
        {
            gameObject.SetActive(false);
            StageManager.lettuce = true;
            StageManager.money -= 200;
        }
    }


    public void grapeClick()
    {
        if (StageManager.money >= 500 && !StageManager.grape)
        {
            gameObject.SetActive(false);
            StageManager.grape = true;
            StageManager.money -= 500;
        }
    }

    public void treeClick()
    {
        if (StageManager.money >= 600 && !StageManager.tree)
        {
            gameObject.SetActive(false);
            StageManager.tree = true;
            StageManager.money -= 600;
        }
    }

    public void sweetpotatoClick()
    {
        if (StageManager.money >= 400 && !StageManager.sweetpotato)
        {
            gameObject.SetActive(false);
            StageManager.sweetpotato = true;
            StageManager.money -= 400;
        }

    }


    public void cherryClick()
    {
        if (StageManager.money >= 400 && !StageManager.cherry)
        {
            gameObject.SetActive(false);
            StageManager.cherry = true;
            StageManager.money -= 400;
        }
    }

    public void ricecakeClick()
    {
        if (StageManager.money >= 600 && !StageManager.ricecake)
        {
            gameObject.SetActive(false);
            StageManager.ricecake = true;
            StageManager.money -= 600;
        }
    }

    public void peachClick()
    {
        if (StageManager.money >= 600 && !StageManager.peach)
        {
            gameObject.SetActive(false);
            StageManager.peach = true;
            StageManager.money -= 300;
        }
    }
}
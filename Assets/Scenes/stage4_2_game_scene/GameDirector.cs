using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    GameObject hpGage;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGage = GameObject.Find("hpGage");
        
    }

   public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.3f;
    }
    public void IncreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount+= 0.3f;
    }
}


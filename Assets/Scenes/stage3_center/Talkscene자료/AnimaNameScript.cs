using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimaNameScript : MonoBehaviour
{
    public StageManager StageManager;
    public Text animal_name;
    int num;

    void Start()
    {
        animal_name = GameObject.Find("name").gameObject.GetComponent<Text>();
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        for (int i = 0; i < 7; i++)
        {
            if (StageManager.talk_num[i] == 1)
                num = i;
        }
        Name(num);
    }

    void Name(int num)
    {
        switch (num)
        {
            case 0:
                animal_name.text = "늑대";
                break;
            case 1:
                animal_name.text = "호랑이";
                break;
            case 2:
                animal_name.text = "표범";
                break;
            case 3:
                animal_name.text = "하늘 다람쥐";
                break;
            case 4:
                animal_name.text = "여우";
                break;
            case 5:
                animal_name.text = "담비";
                break;
            case 6:
                animal_name.text = "판다";
                break;
        }
    }
}

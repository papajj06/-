using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    public StageManager StageManager;

    void Start()
    {
        StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    // Update is called once per frame
    public void HomeButtonClick()
    {
        for (int i = 0; i < 7; i++)
            StageManager.talk_num[i] = 0;
        SceneManager.LoadScene("villageScene");
    }
}

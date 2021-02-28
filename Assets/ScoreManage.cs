using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManage : MonoBehaviour
{
    Text Scorelabel;

    void Awake()
    {
        Scorelabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Scorelabel.text = gameManage.score.ToString();
    }
}

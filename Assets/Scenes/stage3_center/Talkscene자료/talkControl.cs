/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkControl : MonoBehaviour
{
    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Canvas3;

    int ranNum;

    void Start()
    {
        Canvas1 = GameObject.Find("Canvas1").transform.Find("Button").gameObject;
        Canvas2 = GameObject.Find("Canvas2").transform.Find("Button").gameObject;
        Canvas3 = GameObject.Find("Canvas3").transform.Find("Button").gameObject;
        ranNum = Random.Range(0, 100);
        CanvasOpen(ranNum);
    }

    void CanvasOpen(int ranNum)
    {
        switch (ranNum % 3)
        {
            case 0:
                Canvas1.SetActive(true);
                Debug.Log("canvas1");
                break;
            case 1:
                Canvas2.SetActive(true);
                Debug.Log("canvas2");
                break;
            case 2:
                Canvas3.SetActive(true);
                Debug.Log("canvas3");
                break;
        }
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footImgChange : MonoBehaviour
{
    public float time = 0;
    public float changeTime = 2f;
    public GameObject feet_q;

    void Start()
    {
        feet_q = GameObject.Find("footCanvas").transform.Find("feet_q").gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        if (time >= changeTime)
        {
            time = 0;
            this.gameObject.SetActive(false);
            feet_q.SetActive(true);
        }
        time += Time.deltaTime;
    }
}

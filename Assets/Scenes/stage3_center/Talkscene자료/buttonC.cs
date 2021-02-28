using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonC : MonoBehaviour
{
    public bool button_1 = true;
    public bool button_2 = true;

    public void button1Click()
    {
        gameObject.SetActive(false);
        button_1 = false;

    }
    public void button2Click()
    {
        gameObject.SetActive(false);
        button_2 = false;
    }
}

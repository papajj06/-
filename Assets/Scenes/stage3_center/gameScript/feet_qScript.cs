using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feet_qScript : MonoBehaviour
{
    public GameObject nextAnimal;

    void Start()
    {
        nextAnimal = GameObject.Find("footCanvas").transform.Find("nextAnimal").gameObject;
    }

    public void feetqClick()
    {
        this.gameObject.SetActive(false);
        nextAnimal.SetActive(true);
    }
}

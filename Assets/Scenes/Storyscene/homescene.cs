using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homescene : MonoBehaviour
{
  
    public void ButtonClick()
    {
        SceneManager.LoadScene("villageScene");
    }
}


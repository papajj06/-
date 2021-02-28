using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ButtonClick()
    {
        SceneManager.LoadScene("otter_game");
    }
}

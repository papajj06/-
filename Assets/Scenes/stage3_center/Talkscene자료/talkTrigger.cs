using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkTrigger : MonoBehaviour
{
    public talkDia info;

    public void tTrigger()
    {
        var system = FindObjectOfType<talkSystem>();
        system.Begin(info);
    }
}

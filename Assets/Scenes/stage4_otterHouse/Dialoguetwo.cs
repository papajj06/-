using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialoguetwo : MonoBehaviour
{
    public Dialoguett info;
    public void Trigger()
    {
       var system =  FindObjectOfType<DialogueSystem>();
        system.Begin(info);
    }
}

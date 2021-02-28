using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialoguetrigger : MonoBehaviour
{
    public Dialogue info;

    public void Trigger()
    {
        var system = FindObjectOfType<DialogueManager>();
        system.Begin(info);
    }
}

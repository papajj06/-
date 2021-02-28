using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diatrigger : MonoBehaviour
{

    public Dia info;
    public void Trigger()
    {
        var system = FindObjectOfType<Dsystem>();
        system.Begin(info);
    }
}

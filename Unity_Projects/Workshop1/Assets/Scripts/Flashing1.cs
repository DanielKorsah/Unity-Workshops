using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing1 : MonoBehaviour
{
    Renderer rend;
    public Material Red;
    public Material Green;
    public float delay = 1;

    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        InvokeRepeating("Clock", delay, delay);
    }

    void Clock()
    {
        print(rend.material.name);
        if (rend.material.name != "Red (Instance)")
        {
            print("tick");
            rend.material = Red;
        }
        else
        {
            print("tock");
            rend.material = Green;
        }
    }
}
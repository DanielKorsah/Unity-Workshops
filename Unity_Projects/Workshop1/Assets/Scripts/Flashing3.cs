using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing3 : MonoBehaviour
{

    public Material Red;
    public Material Green;
    public float delay = 1;

    Renderer rend;
    float acc;

    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        acc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        acc += Time.deltaTime;
        if (acc >= delay)
        {
            Clock();
            acc = 0;
        }
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
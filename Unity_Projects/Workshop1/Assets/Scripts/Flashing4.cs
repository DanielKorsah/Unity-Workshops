using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing4 : MonoBehaviour
{
    Renderer rend;
    float referenceTime;

    public Material Red;
    public Material Green;
    public float delay = 1;

    // Start is called before the first frame update
    void Start()
    {
        referenceTime = Time.time;
        rend = gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        if (Time.time - referenceTime >= delay)
        {
            Clock();
            referenceTime = Time.time;
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
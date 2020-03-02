using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing2 : MonoBehaviour
{

    Renderer rend;
    public Material Red;
    public Material Green;
    public float delay = 1;
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        Invoke("Tick", delay);
    }

    void Tick()
    {
        print("tick");
        rend.material = Red;
        Invoke("Tock", delay);
    }

    void Tock()
    {
        print("tock");
        rend.material = Green;
        Invoke("Tick", delay);
    }
}
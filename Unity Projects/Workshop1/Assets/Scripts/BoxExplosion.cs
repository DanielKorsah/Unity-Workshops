using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxExplosion : MonoBehaviour
{

    [SerializeField] private GameObject boxToSpawn;
    private Vector3 spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SpawnBox();
        }
    }

    void SpawnBox()
    {
        Instantiate(boxToSpawn, spawnLocation, Quaternion.identity);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float launchSpeed = 8;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * launchSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        Debug.Log("Hit");

        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Kill");
            Destroy(col.gameObject);
        }
    }
}
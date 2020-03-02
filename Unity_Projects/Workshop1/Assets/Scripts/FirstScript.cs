using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public int PublicInt;
    public string MyWord;
    private bool MyBool;

    private int privateInt;
    [SerializeField]
    public float myFloat;

    // public GameObject MyGameObject;
    // public Material MyMaterial;
    // public Transform MyTransform;
    // public Vector3 MyVector3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PublicInt + " " + privateInt + " " + myFloat + " " + MyWord + " " + MyBool);

        PublicInt = 0;
        privateInt = 5;

        myFloat = 0.5f;
        MyWord = "HelloWorld";
        MyBool = true;

        Debug.Log(PublicInt + " " + privateInt + " " + myFloat + " " + MyWord + " " + MyBool);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(MyWord);
        //Debug.Log(MyGameObject + ", " + MyMaterial + ", " + MyTransform + ", " + MyVector3);
    }
}
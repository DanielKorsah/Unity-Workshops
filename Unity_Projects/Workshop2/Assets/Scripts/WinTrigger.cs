using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public string NextLevel;

    void Start()
    {
        if (NextLevel == "")
        {
            NextLevel = "level1";
        }
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(NextLevel);
    }
}
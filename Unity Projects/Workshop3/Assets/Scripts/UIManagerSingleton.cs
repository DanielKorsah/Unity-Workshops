using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerSingleton : MonoBehaviour
{
    //static means there is only one instance of that objects class anywhere
    public static UIManagerSingleton Instance;

    private Text textObject;
    private Image hpBar;
    private Image heart;

    //Awake is called after all objects are initialized so you can safely speak to other objects or query them using for example GameObject.
    void Awake()
    {
        //if one doesn't exist 
        if (Instance == null)
        {
            //set this object as the static instance
            Instance = this;
            //make this object stay whenever loading a new scene
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //an instance already exists so destroy this object
            Destroy(gameObject);
        }
    }

    void Start()
    {
        textObject = GameObject.Find("ScoreText").GetComponent<Text>();
        hpBar = GameObject.Find("fronthp").GetComponent<Image>();
        heart = GameObject.Find("heartImage").GetComponent<Image>();
    }

    public void UpdateHealthText(float newHp, float maxHP)
    {
        float percent = newHp / maxHP;
        Debug.Log("HP percentage: " + percent);
        Debug.Log("HP vals: " + newHp + maxHP);
        textObject.text = "Health: " + newHp + "/" + maxHP;
        hpBar.fillAmount = percent;
        heart.fillAmount = percent;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homePage : MonoBehaviour
{
    int page = 0;
    // Start is called before the first frame update
    void Start()
    {
        page = PlayerPrefs.GetInt("page");
        Debug.Log("MyInt = " + page);
        if(page==1){
            
        GameObject MainMenu = GameObject.Find("MainMenu");
        GameObject LevelMenu = GameObject.Find("LevelMenu");
        MainMenu.SetActive(false);
        LevelMenu.SetActive(true);
        }
        if(page==0){
            
        GameObject MainMenu = GameObject.Find("MainMenu");
        GameObject LevelMenu = GameObject.Find("LevelMenu");
        MainMenu.SetActive(true);
        LevelMenu.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {   PlayerPrefs.SetInt("page", 0);
        page = 0;
    }
}

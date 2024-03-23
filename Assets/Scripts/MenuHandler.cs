using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuHandler : MonoBehaviour
{
    public static string Name;
    public TMP_Text NameText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void StartNew() 
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();

    #else
        Application.Quit();
    #endif

    }

    public void SetName()
    {
        PlayerPrefs.SetString("PlayerName", NameText.text);
        PlayerPrefs.Save();
        //Name = NameText.text;
    }
}

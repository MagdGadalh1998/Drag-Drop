using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ControlButtons : MonoBehaviour
{
    public Button[] btns;
    private const string GameEntryCountKey = "GameEntryCount";

    private void Start()
    {
        int gameEntryCount = PlayerPrefs.GetInt(GameEntryCountKey, 0) + 1;
        PlayerPrefs.SetInt(GameEntryCountKey, gameEntryCount);

        Debug.Log("Before Game Entry Count: " + PlayerPrefs.GetInt(GameEntryCountKey));
        switch (gameEntryCount)
        {
            case 1:
                ControlButton(btns[0]);
                break;
            case 2:
                ControlButton(btns[1]);
                break;
            case 3:
                ControlButton(btns[2]);
                break;
            case 4:
                ControlButton(btns[3]);
                PlayerPrefs.SetInt(GameEntryCountKey, 0);
                Debug.Log("When Finish =" + PlayerPrefs.GetInt(GameEntryCountKey));
                break;
        }
    }
    void ControlButton(Button _btn)
    {
        foreach(Button btn in btns)
        {
            btn.interactable = false;
        }
        _btn.interactable = true;

    }
    void Update()
    {
        
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}

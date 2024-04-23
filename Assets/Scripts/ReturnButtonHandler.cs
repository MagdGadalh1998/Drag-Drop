using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnReturnButtonClick()
    {
        SceneManager.LoadScene(0);
/*
        // Update button interactability in ButtonController script
        ControlButtons buttonController = FindObjectOfType<ControlButtons>();
        buttonController.EnableNextButton();*/
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    public GameObject startMenuBG;

    public GameObject startMenuButton;

    public GameObject startMenuFrog;

    public void Start()
    {
        LoungeMenu();
    }

    public void StartButtonPressed()
    {
        startMenuBG.SetActive(false);
        startMenuFrog.SetActive(false);
        startMenuButton.SetActive(false);
        SceneManager.LoadScene(1);
    }

    private void LoungeMenu()
    {
        startMenuBG.SetActive(true);
        startMenuFrog.SetActive(true);
        startMenuButton.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartButtonPressed();
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    private string gameSceneName;

    [SerializeField]
    private Animator fadePanelAnim;

    public void LoadGameScene()
    {
        StartCoroutine(FadeOut());
    }

    public void ExitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    IEnumerator FadeOut()
    { 
        fadePanelAnim.SetBool("leavingScene", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(gameSceneName);
    }
}

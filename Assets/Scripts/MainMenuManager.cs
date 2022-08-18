using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public int gameSceneIndex;
    public float delay;
    public void PlayButton()
    {
        StartCoroutine(SceneChangeDelay());
        
    }

    IEnumerator SceneChangeDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(gameSceneIndex);
    }
}

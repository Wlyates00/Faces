using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LY;

public class WinScreen : MonoBehaviour
{
    public int mainMenuSceneIndex;
    public int firstLevelSceneIndex;
    public LevelManager levelManager;
    public void StartOverButton()
    {
        levelManager.reset = true;
        levelManager.SaveLevel();
        SceneManager.LoadScene(firstLevelSceneIndex);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(mainMenuSceneIndex);
    }
}

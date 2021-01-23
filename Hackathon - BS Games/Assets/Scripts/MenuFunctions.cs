using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
   
    public void runGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameManager.Instance.TimeRemaining = 120;
        GameManager.Instance.PlayerHealth = 1;
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        GameManager.Instance.TimeRemaining = 120;
        GameManager.Instance.PlayerHealth = 1;
    }
    public void returnBeginning ()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame ()
    {
        Debug.Log("Attempted to QUIT!");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}


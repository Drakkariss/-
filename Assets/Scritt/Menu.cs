using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayHandler()
    {
        SceneManager.LoadScene(1);
    }
    public void RestartHandler()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ContinueHandler()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitHandler()
    {
        Application.Quit();
    }
}

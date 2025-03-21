using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartGame : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("NextScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);                  // Loads MainScene
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);                  // Loads MainMenu
    }

}

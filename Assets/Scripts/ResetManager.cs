using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);

    }
}

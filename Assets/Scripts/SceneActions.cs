using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneActions : MonoBehaviour
{
    public void LoadOpengamerScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }
}

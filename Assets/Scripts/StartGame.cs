using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadNewScene()
    {
        SceneManager.LoadScene(1); //シーンを呼び出す
    }
}
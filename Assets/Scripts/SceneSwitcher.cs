using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void GotoPlayScene()
    {
        SceneManager.LoadScene("Play");
    }

    public void GotoARScene()
    {
        SceneManager.LoadScene("AR");
    }

    public void GotoSoSScene()
    {
        SceneManager.LoadScene("SoS");
    }
}

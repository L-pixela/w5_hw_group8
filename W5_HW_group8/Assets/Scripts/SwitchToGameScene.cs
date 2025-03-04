using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToGameScene : MonoBehaviour
{
    public void GoToGameScene(string scenes)
    {
        SceneManager.LoadScene(scenes);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointText;
    public Text resultText;
   public void Setup(int yourScore, int comScore,string result)
    {
        gameObject.SetActive(true);
        resultText.text = result;
        pointText.text = "Point: " + yourScore.ToString() + " - " + comScore.ToString();
    }

    public void OnClickButton(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

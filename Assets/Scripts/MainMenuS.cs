using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuS : MonoBehaviour {

    public TextMeshProUGUI highscoreText;

    void Start()
    {
        highscoreText.text = "Highest Score: " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
    }
    public void PlayGame()
    {
       // Debug.Log("UUU");
        SceneManager.LoadScene("Level 01");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void BackMenu()
    {
        /*GetComponent<Score>().ResetScore();
        GetComponent<Trigger>().ResetPlayer();*/
        SceneManager.LoadScene("Begining");
    }

}

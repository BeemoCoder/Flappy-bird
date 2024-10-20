using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject endScreen;
    public GameObject Logo;
    public int score;
    int highscore;

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void Start()
    {
        int highscore = PlayerPrefs.GetInt("highscore", score);
        print(highscore);
    }

    public void startGame()
    {
        Logo.SetActive(false);
        scoreText.gameObject.SetActive(true);

    }

    public void EndGame()
    {
        endScreen.SetActive(true);
        scoreText.gameObject.SetActive(false);
        if (score > highscore)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}

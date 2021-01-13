using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    void Start()
    {
        score = 0;
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int highScore;
    public int currentScore;
    public TextMeshProUGUI highScoreText;
    public int platformCount = 300;

    private void Start() {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        highScoreText.text = "High score: " + highScore.ToString() + "m"; 
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(0.6f, 4f);
            spawnPosition.x = Random.Range(-10f, 2f);
            GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    public void SetHighScore() {
        if (highScore < currentScore) {
            PlayerPrefs.SetInt("highScore", currentScore);
        }
    }
}

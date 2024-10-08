using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    private void OnEnable()
    {
        Pickup.OnPickupCollected += AddScore;
    }

    private void OnDisable()
    {
        Pickup.OnPickupCollected -= AddScore;
    }

    private void AddScore()
    {
        score += 50;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
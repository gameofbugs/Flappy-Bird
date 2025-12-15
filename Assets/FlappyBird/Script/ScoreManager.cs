using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI currentScoreText;
    public int score=0;
    public int currentScore;
    public AudioManager audioManager;

    void Start()
    {
        Reset();
        scoreText.text = "SCORE: " + score;
    }
    public void AddScore()
    {
        score++;
        audioManager.PlaySFX(audioManager.score);
        scoreText.text = "SCORE: " + score;
    }
    private void Update()
    {
        currentScore= score;
    }
    public void Reset()
    {
        score = 0;
    }
   
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LevelSelectionUI : MonoBehaviour
{
    [SerializeField] GameObject levelSelectionUI;
    [SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject scoreUI;
    [SerializeField] private GameObject bird;
    [SerializeField] private GameObject obstaclesSpawner;
    [SerializeField]ScoreManager scoreManager;
    SceneManager mainscene;
    public AudioManager audioManager;

    private void Start()
    {
        levelSelectionUI.SetActive(true);
        scoreUI.SetActive(false);
        gameOverUI.SetActive(false);
        bird.SetActive(false);
        obstaclesSpawner.SetActive(false);
    }
    public void Easy()
    {
        LevelManager.Instance.SetLevel(LevelManager.Instance.easy);
    }
    public void Medium()
    {
        LevelManager.Instance.SetLevel(LevelManager.Instance.medium);
    }
    public void Hard()
    {
        LevelManager.Instance.SetLevel(LevelManager.Instance.hard);
    }
    public void Play()
    {
        levelSelectionUI?.SetActive(false);
        bird?.SetActive(true);
        obstaclesSpawner?.SetActive(true);
        scoreUI?.SetActive(true);  // <-- so score is visible right away
        Time.timeScale = 1f;
        scoreManager?.Reset();     // <-- sets score to 0 and updates UI
    }


    public void Replay()
    {
        SceneManager.LoadScene("Main Scene");
        gameOverUI?.SetActive(false);
    }
    public void MainMenu()
    {
        levelSelectionUI.SetActive(true);
        scoreUI.SetActive(false);
        gameOverUI.SetActive(false);
    }
    public void GameOver()
    {
        audioManager.PlaySFX(audioManager.gameOver);
        gameOverUI.SetActive(true);
        scoreManager.currentScoreText.text ="Score:"+scoreManager.score;
        //levelSelectionUI.SetActive(false);
        scoreUI.SetActive(false);
        scoreManager.Reset();
    }
    public void OnButtonClick()
    {
        audioManager.PlaySFX(audioManager.button);
    }
}

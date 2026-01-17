using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] TextMeshProUGUI finalScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    public void ShowGameOverScreen()
    {
        Time.timeScale = 0;
        finalScoreText.text = "Final Score: " + scoreManager.score;
        gameOverScreen.SetActive(true);
    }
    public void RestartGame ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitGame ()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start()
    {
        // Hide the game over panel initially
        gameOverPanel.SetActive(false);
    }

    public void ShowGameOver()
    {
        // Show the game over panel
        gameOverPanel.SetActive(true);
    }

    public void ResetGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

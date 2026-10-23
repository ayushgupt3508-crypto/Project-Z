```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Scene Settings")]
    [SerializeField] private string gameSceneName = "Level1";

    [Header("Panels")]
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;

    private void Start()
    {
        // Ensure both panels are closed when the main menu opens.
        if (settingsPanel != null)
            settingsPanel.SetActive(false);

        if (creditsPanel != null)
            creditsPanel.SetActive(false);
    }

    // PLAY BUTTON
    public void PlayGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    // SETTINGS BUTTON
    public void OpenSettings()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(true);

        if (creditsPanel != null)
            creditsPanel.SetActive(false);
    }

    // CREDITS BUTTON
    public void OpenCredits()
    {
        if (creditsPanel != null)
            creditsPanel.SetActive(true);

        if (settingsPanel != null)
            settingsPanel.SetActive(false);
    }

    // CLOSE SETTINGS OR CREDITS
    public void ClosePanels()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(false);

        if (creditsPanel != null)
            creditsPanel.SetActive(false);
    }

    // QUIT BUTTON
    public void QuitGame()
    {
        Debug.Log("Quitting GlitchVerse...");

        Application.Quit();
    }
}
```
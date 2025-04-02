using UnityEngine;
using UnityEngine.SceneManagement;

public class utilities : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestFunction()
    {
        Debug.Log("De knop werkt");
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
}

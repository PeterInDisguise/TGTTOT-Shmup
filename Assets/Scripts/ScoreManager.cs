using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private int currentScore;
    [SerializeField]
    private TMP_Text scoreText;

    private void Start()
    {
        UpdateText();
    }

    public void AddScore(int score)
    {
        currentScore += score;
        UpdateText();
    }

    private void UpdateText()
    {
        scoreText.text = currentScore.ToString();
    }
}

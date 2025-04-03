using UnityEngine;
using UnityEngine.SceneManagement;

public class Sardeen : EnemyBase
{
    private ScoreManager scoreManager;
    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
        Debug.Log(scoreManager);
    }

    void Update()
    {

    }

    protected override void OnTriggerEnter(Collider other)
    {
        if (scoreManager != null & other.gameObject.CompareTag("Bullet"))
        {
            scoreManager.AddScore(scoreToAdd);
        }
        base.OnTriggerEnter(other);
    }
}

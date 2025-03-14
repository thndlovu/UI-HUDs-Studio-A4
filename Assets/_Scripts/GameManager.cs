using TMPro;
using UnityEngine;

public class GameManager : SingletonMonoBehavior<GameManager>
{
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private CoinCounterUI coinCounter;

    protected override void Awake()
    {
        base.Awake();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
        coinCounter.UpdateScore(score);
    }
}

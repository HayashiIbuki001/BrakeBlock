using UnityEngine;
using TMPro;

public class TimerSystem : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timerText;
    [SerializeField] public float timer;
    private float currentTimer;
    public GameManager gameManager;

    private void Start()
    {
        currentTimer = timer;
    }

    private void Update()
    {
        if (currentTimer <= 0)
        {
            currentTimer = 0;
            gameManager.GameOver();
        }
        else
        {
            currentTimer -= Time.deltaTime;
        }

        timerText.text = currentTimer.ToString("F2");
    }
}

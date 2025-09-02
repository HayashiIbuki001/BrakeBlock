using UnityEngine;
using TMPro;

public class TimerSystem : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timerText;
    [SerializeField] public float timer;
    private float currentTimer;

    private void Start()
    {
        currentTimer = timer;
    }

    private void Update()
    {
        currentTimer -= Time.deltaTime;
        timerText.text = currentTimer.ToString("F2");
    }
}

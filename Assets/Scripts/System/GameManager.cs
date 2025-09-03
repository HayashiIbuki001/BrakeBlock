using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isGameOver = false;

    private void Awake()
    {
        Instance = this;
    }


    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;
        Destroy(GameObject.FindWithTag("Ball"));
        Debug.Log("Ç∞Å[ÇﬁÇ®Å[ÇŒÅ[");
    }
}

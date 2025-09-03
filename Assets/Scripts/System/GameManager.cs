using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public BlockPlaceManager blockPlaceManager;
    public bool isGameOver = false;

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform paddle;
    [SerializeField] private int health = 3;

    public int liveblocks = 40;
    private int currentblocks = 40;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentblocks = liveblocks;
    }


    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        foreach (var ball in GameObject.FindGameObjectsWithTag("Ball"))
        {
            Destroy(ball);
        }

        Debug.Log("げーむおーばー");
    }

    public void BallFind()
    {
        int liveBall = GameObject.FindGameObjectsWithTag("Ball").Length;
        Debug.Log("ボール" + liveBall + "個");

        if (liveBall <= 0)
        {
            health--;
            Debug.Log("残り残機：" + health);

            if (health <= 0)
            {
                GameOver();
            }
            else
            {
                GameObject ball = Instantiate(ballPrefab);
                Ball ballScript = ball.GetComponent<Ball>();
                ballScript.paddle = paddle;
            }
        }
    }

    public void OnBlockDestroyed()
    {
        currentblocks--;

        if (currentblocks == 0)
        {
            currentblocks = liveblocks;
            blockPlaceManager.Place();
        }
    }
}

using System.Collections;
using UnityEngine;

public class Block : MonoBehaviour
{
    public BlockPlaceManager blockPlaceManager;
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            gameManager.OnBlockDestroyed();
            Destroy(this.gameObject);
        }
    }
}

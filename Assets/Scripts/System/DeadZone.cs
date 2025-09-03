using System.Collections;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            StartCoroutine(SkipFlame());
        }
    }

    private IEnumerator SkipFlame()
    {
        yield return null;
        GameManager.Instance.BallFind();
    }
}

using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    private void Update()
    {
        float move = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(move, 0, 0);
        transform.Translate(dir * speed * Time.deltaTime);
    }
}

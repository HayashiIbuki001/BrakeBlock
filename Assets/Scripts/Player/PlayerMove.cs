using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform leftWall;
    public Transform rightWall;

    private void Update()
    {
        if (Input.GetMouseButton(0)) // ���N���b�N������
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10f; // �J��������̋���
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mouse);

            // �o�[�̔����̕����l��
            float halfWidth = transform.localScale.x / 2f;
            float minX = leftWall.position.x + halfWidth;
            float maxX = rightWall.position.x - halfWidth;

            float clampX = Mathf.Clamp(worldPos.x, minX, maxX);

            transform.position = new Vector3(clampX, transform.position.y, transform.position.z);
        }
    }
}

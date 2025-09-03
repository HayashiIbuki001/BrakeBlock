using UnityEngine;

public class BlockPlaceManager : MonoBehaviour
{
    [SerializeField] public GameObject blockPrefub;
    [SerializeField,Tooltip("�s(�c)�̃u���b�N��")] private int rows;
    [SerializeField, Tooltip("��(��)�̃u���b�N��")] private int cols;
    [SerializeField] private float xSpace;
    [SerializeField] private float ySpace;

    private void Start()
    {
        Place();
    }

    private void Update()
    {

    }

    public void Place()
    {
        Vector2 startPos = transform.position;
        float OffsetRows = (rows - 1) * 0.5f * ySpace;
        float OffsetCols = (cols - 1) * 0.5f * xSpace;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Vector2 pos = new Vector2(j * xSpace - OffsetRows, i * ySpace - OffsetCols) + startPos;
                Instantiate(blockPrefub, pos, Quaternion.identity);
            }
        }
    }
}

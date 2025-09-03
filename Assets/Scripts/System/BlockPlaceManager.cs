using UnityEngine;

public class BlockPlaceManager : MonoBehaviour
{
    [SerializeField] public GameObject blockPrefub;
    [SerializeField,Tooltip("行(縦)のブロック数")] private int rows;
    [SerializeField, Tooltip("列(横)のブロック数")] private int cols;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject brickPrefab;

    public int ySize;
    public int xSize;
    
    void Start()
    {
        for (int y = 0; y < ySize; y++)
        {
            int xOffset = (y % 2 == 0) ? 1 : 0;
 
            for (int x = 0; x < xSize; x++)
            {
                Vector3 position = new Vector3(x * 2 + xOffset, y, 0);
                var brick = Instantiate(brickPrefab, position, Quaternion.identity);
                brick.transform.parent = transform;
                
            }
        }
    }
}
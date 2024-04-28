using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[,] units;

    
    

    void ShowGrid()
    {
        for (int x = 0; x < units.Length; x++)
        {
            for (int y = 0; y < units.Length; y++)
            {
                GameObject unitPrefab = Instantiate(prefab);
                Vector3 prefabPosition = new Vector3(x, y, 0);
                unitPrefab.transform.position = prefabPosition;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[,] grid;

    public int gridHeight = 6;
    public int gridWidth = 10;

    private void Awake()
    {
        ShowGrid();
    }


    void ShowGrid()
    {
        grid = new GameObject[gridWidth,gridHeight]; // Initialize the grid
        
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                grid[x, y] = Instantiate(prefab); // Add object to the array and show the object in the scene
                float xPos = x * Mathf.Cos(y);
                float yPos = x * Mathf.Sin(y);
                grid[x, y].transform.position = new Vector2(xPos, yPos);
            }
        }
        
    }
    
}

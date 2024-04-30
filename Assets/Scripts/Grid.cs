using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Random = UnityEngine.Random;

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            grid.Initialize();
            ShowGrid();
        }
    }


    void ShowGrid()
    {
        grid = new GameObject[gridWidth,gridHeight]; // Initialize the grid
        
        
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                grid[x, y] = Instantiate(prefab); // Add object to the array and show the object in the scene
                grid[x, y].GetComponent<Note>().pitch = Random.Range(1, 7);
                grid[x, y]. transform.localScale = Vector3.one / (grid[x, y].GetComponent<Note>().pitch * 0.5f);
                grid[x, y].transform.position = new Vector3(x, y);
            }
        }
        
    }
    
}

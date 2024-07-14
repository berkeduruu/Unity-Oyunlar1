using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSweeper : MonoBehaviour
{
    public int width = 20, height = 20;

    private Board board;
    private Cells[,] stateCell; 

    private void Awake()
    {
        board = GetComponentInChildren<Board>();
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        stateCell = new Cells[width, height];

        GenerateCells();

        board.Draw(stateCell);

        Camera.main.transform.position = new Vector3(width / 2 - 2.1f, height / 2 , -1);
    }


    private void GenerateCells()
    {
        for (int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                Cells cell = new Cells();
                cell.position = new Vector3Int(j, i, 0);
                cell.type = Cells.Type.Empty;
                stateCell[i, j] = cell;
            }
        }
    }

}

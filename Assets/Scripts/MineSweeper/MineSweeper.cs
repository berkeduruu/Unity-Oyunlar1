using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSweeper : MonoBehaviour
{
    public int width = 20, height = 20, mineCount = 10;

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
        GenerateMines();




        Camera.main.transform.position = new Vector3(width / 2 - 1.9f, height / 2 , -1);
        board.Draw(stateCell);
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

    private void GenerateMines()
    {
        for (int i = 0; i < mineCount; i++)
        {
            int x = Random.Range(0, width);
            int y = Random.Range(0, height);

            if(stateCell[x, y].type == Cells.Type.Mine)
            {
                i--;
                continue;
            }

            stateCell[x, y].type = Cells.Type.Mine;
        }
    }
}

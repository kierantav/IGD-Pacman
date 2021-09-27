using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{ 
    public Sprite[] sprites;

    int[,] levelMap = 
    {
         {1,2,2,2,2,2,2,2,2,2,2,2,2,1},
         {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
         {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
         {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
         {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
         {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
         {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
         {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
         {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
         {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
         {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
         {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
         {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
         {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
         {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    };
    // Start is called before the first frame update
    void Start()
    {
        

        /*for (int row = 0; row < levelMap.GetLength(0); row++)
        {
            for (int col = 0; col < levelMap.GetLength(1); col++)
            {
                switch (col)
                {
                    case 0:

                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnTile(int x, int y, int value) {
        GameObject sprite = new GameObject("X: " + x + "Y:" + y);
        //sprite.transform.position = (x);
    }  
}

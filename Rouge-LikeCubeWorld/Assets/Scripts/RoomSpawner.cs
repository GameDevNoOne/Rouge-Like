using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDir;

    public void Update()
    {
        if (openingDir == 1)
        {
            //BottomDoor
        }
        else if (openingDir == 2)
        {
            //LeftDoor
        }
        else if (openingDir == 3)
        {
            //UpDoor
        }
        else if (openingDir == 4)
        {
            //RightDoor
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StoreRoomDecider : MonoBehaviour
{

    public GameObject centerRoom;
    public GameObject[] rooms;
    public RoomChecker roomChecker;
    public GameObject storeRoom;
    public int storeRoomCount;
    public int randomNumber;
    public int spawnFrequency;
    public GameObject StoreRoomLocation;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ActualSpawnFunction", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        rooms = roomChecker.GetComponent<RoomChecker>().ActiveRooms;
        countRoomsFunction();
    }

    public void countRoomsFunction()
    {
        storeRoomCount = rooms.Length / spawnFrequency;
    }

    public void SpawnStoreRooms()
    {
        Instantiate(storeRoom, StoreRoomLocation.transform.position, StoreRoomLocation.transform.rotation);
    }

    public void DecideStoreRoomLocation()
    {
        for (int i = 0; i < storeRoomCount; i++)
        {
            randomNumber = Random.RandomRange(2, rooms.Length);
            StoreRoomLocation = rooms[randomNumber];
            if (StoreRoomLocation == centerRoom)
            {
                randomNumber = Random.RandomRange(2, rooms.Length);
                StoreRoomLocation = rooms[randomNumber];
            }
        }
    }

    public void ActualSpawnFunction()
    {
        for (int i = 0; i < storeRoomCount; i++)
        {
            Invoke("SpawnStoreRooms", 3f);
        }
    }
}

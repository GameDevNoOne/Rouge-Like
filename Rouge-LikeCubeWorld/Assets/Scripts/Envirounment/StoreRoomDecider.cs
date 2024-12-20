using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Security.Cryptography;
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

    private bool hasSpawned = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Thread.Sleep(2000);
        rooms = roomChecker.GetComponent<RoomChecker>().ActiveRooms;
        countRoomsFunction();
        if (hasSpawned == false)
        {
            List<GameObject> storeRoomLocation = DecideStoreRoomLocation();
            SpawnStoreRooms(storeRoomLocation);
            hasSpawned = true;
        }
    }

    public void countRoomsFunction()
    {
        storeRoomCount = rooms.Length / spawnFrequency;
    }

    public List<GameObject> DecideStoreRoomLocation()
    {
        List<GameObject> StoreRoomLocation = new List<GameObject>();
        for (int i = 0; i < storeRoomCount; i++)
        {
            randomNumber = Random.RandomRange(2, rooms.Length);

            if (rooms[randomNumber] == centerRoom)
            {
                randomNumber = Random.RandomRange(2, rooms.Length);
            }

            StoreRoomLocation.Add(rooms[randomNumber]);
        }
        return (StoreRoomLocation);
    }

    public void SpawnStoreRooms(List<GameObject> StoreRoomLocation)
    {
        for (int i = 0; i < StoreRoomLocation.Count; i++)
        {
            Instantiate(storeRoom, StoreRoomLocation[i].transform.position, StoreRoomLocation[i].transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class RoomChecker : MonoBehaviour
{
    public GameObject[] ActiveRooms;
    public GameObject[] StoreRooms;
    public GameObject[] BossRooms;
    public GameObject[] TreasureRooms;

    public StoreClerk storeRoom;
    public BossRoom bossRoom;
    public StorageRoom storageRoom;

    public float storeRoomsPossible;
    public float bossRoomsPossible;
    public float treasureRoomsPossible;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CheckRooms", 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CheckRooms()
    {
        ActiveRooms = GameObject.FindGameObjectsWithTag("Rooms");
        StoreRooms = GameObject.FindGameObjectsWithTag("StoreClerkRooms");
        BossRooms = GameObject.FindGameObjectsWithTag("BossRooms");
        TreasureRooms = GameObject.FindGameObjectsWithTag("TreasureRooms");

        for (int i = 0; i < ActiveRooms.Length; i++)
        {
            if (StoreRooms.Length > storeRoomsPossible * ActiveRooms.Length)
            {
                storeRoom = StoreRooms[i].GetComponentInChildren<StoreClerk>();
                storeRoom.gameObject.SetActive(false);
            }
            if (BossRooms.Length > bossRoomsPossible * ActiveRooms.Length)
            {
                bossRoom = BossRooms[i].GetComponentInChildren<BossRoom>();
                bossRoom.gameObject.SetActive(false);
            }
            if (TreasureRooms.Length > storeRoomsPossible * ActiveRooms.Length)
            {
                storageRoom = TreasureRooms[i].GetComponentInChildren<StorageRoom>();
                storageRoom.gameObject.SetActive(false);
            }
        }
    }
}

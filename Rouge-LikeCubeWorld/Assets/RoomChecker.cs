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

    public float storeRoomsPossible;
    public float bossRoomsPossible;
    public float treasureRoomsPossible;

    // Start is called before the first frame update
    void Start()
    {

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

        }
    }
}

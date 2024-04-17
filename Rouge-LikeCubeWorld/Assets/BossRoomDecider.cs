using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BossRoomDecider : MonoBehaviour
{
    public GameObject CenterRoom;
    public GameObject[] Rooms;
    public float[] DistanceFromCenter;
    public RoomChecker roomChecker;
    private GameObject furthestRoom;
    public float I;
    public int J;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rooms = roomChecker.GetComponent<RoomChecker>().ActiveRooms;   
    }

    public void DistancefromCenter()
    {
        for (int i = 0; i < Rooms.Length; i++)
        {
            DistanceFromCenter[i] = ((Mathf.Abs(CenterRoom.transform.position.x - Rooms[i].transform.position.x) * Mathf.Abs(CenterRoom.transform.position.x - Rooms[i].transform.position.x)) + (Mathf.Abs(CenterRoom.transform.position.y - Rooms[i].transform.position.y) * Mathf.Abs(CenterRoom.transform.position.y - Rooms[i].transform.position.y)));
        }
        I = DistanceFromCenter.Max();
        J = DistanceFromCenter.ToList().IndexOf(I);
    }

    public void SetBossRoom()
    {
        furthestRoom = Rooms[J];
        furthestRoom.GetComponentInChildren<BossRoom>().gameObject.SetActive(true);
    }
}
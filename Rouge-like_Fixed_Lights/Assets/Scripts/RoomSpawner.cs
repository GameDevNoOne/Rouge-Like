using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDir;
    private RoomTemplate roomTemplate;
    private int random;
    public bool Spawned = false;
    private GameObject Player;

    public void Start()
    {
        roomTemplate = GameObject.FindGameObjectWithTag("Room").GetComponent<RoomTemplate>();
        Player = GameObject.FindGameObjectWithTag("Player");
        Invoke("Spawn", 0.1f);
    }

    public void Update()
    {
        float playerDistance = Mathf.Abs((Player.transform.position.x * Player.transform.position.x + Player.transform.position.y * Player.transform.position.y) - (gameObject.transform.position.x * gameObject.transform.position.x + gameObject.transform.position.y * gameObject.transform.position.y));

        if (playerDistance <= 1296)
        {
//          Spawn();
        }
    }

    public void Spawn()
    {
        if (Spawned == false)
        {
            if (openingDir == 1)
            {
                random = Random.Range(0, roomTemplate.bottomRooms.Length);
                Instantiate(roomTemplate.bottomRooms[random], transform.position, roomTemplate.bottomRooms[random].transform.rotation);
            }
            else if (openingDir == 2)
            {
                random = Random.Range(0, roomTemplate.leftRooms.Length);
                Instantiate(roomTemplate.leftRooms[random], transform.position, roomTemplate.leftRooms[random].transform.rotation);
            }
            else if (openingDir == 3)
            {
                random = Random.Range(0, roomTemplate.topRooms.Length);
                Instantiate(roomTemplate.topRooms[random], transform.position, roomTemplate.topRooms[random].transform.rotation);
            }
            else if (openingDir == 4)
            {
                random = Random.Range(0, roomTemplate.rightRooms.Length);
                Instantiate(roomTemplate.rightRooms[random], transform.position, roomTemplate.rightRooms[random].transform.rotation);
            }

            Spawned = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpawnPoint"))
        {
            if (collision.GetComponent<RoomSpawner>().Spawned == false && Spawned == false)
            {
                Instantiate(roomTemplate.closedRoom, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
            Spawned = true;
        }
    }
}

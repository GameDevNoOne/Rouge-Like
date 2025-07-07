using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnvirounment : MonoBehaviour
{
    [Header("Locations and objects")]
    public GameObject boxSpawns;
    public Transform[] boxSpawnLocs;
    public GameObject box;
    public GameObject wallSpawns;
    public Transform[] wallSpawnLocs;
    public GameObject wall;
    public GameObject chestSpawns;
    public Transform[] chestSpawnLocs;
    public GameObject chest;

    [Header("Player")]
    public GameObject Player;
    bool hasSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        boxSpawnLocs = getFirstChildren(boxSpawns.transform);
        wallSpawnLocs = getFirstChildren(wallSpawns.transform);
        chestSpawnLocs = getFirstChildren(chestSpawns.transform);
        SpawnBoxes();
        SpawnPillars();
        SpawnChests();
    }

    private void Update()
    {

    }

    private Transform[] getFirstChildren(Transform parent)
    {
        Transform[] children = parent.GetComponentsInChildren<Transform>();
        Transform[] firstChildren = new Transform[parent.childCount];
        int index = 0;
        foreach (Transform child in children)
        {
            if (child.parent == parent)
            {
                firstChildren[index] = child;
                index++;
            }
        }
        return firstChildren;
    }

    void SpawnBoxes()
    {
        int i = Random.Range(0, 101);
        if (i <= 30)
        {
            for (int j = 0; j < 2; j++)
            {
                int h = Random.Range(0, 4);
                Instantiate(box, boxSpawnLocs[h].transform);
            }
        }
        else
        {
            int h = Random.Range(0, 4);
            Instantiate(box, boxSpawnLocs[h].transform);
        }
    }

    void SpawnPillars()
    {
        int i = Random.Range(0, 101);
        if (i <= 30)
        {
            for (int j = 0; j < 4; j++)
            {
                int h = Random.Range(0, 12);
                Instantiate(wall, wallSpawnLocs[h].transform);
            }
        }
        if (30 <= i && i <= 70)
        {
            for (int j = 0; j < 6; j++)
            {
                int h = Random.Range(0, 12);
                Instantiate(wall, wallSpawnLocs[h].transform);
            }
        }
        if (i >= 70)
        {
            for (int j = 0; j < 12; j++)
            {
                int h = Random.Range(0, 12);
                Instantiate(wall, wallSpawnLocs[h].transform);
            }
        }
    }

    void SpawnChests()
    {
        int playerLevel = (int)Player.GetComponent<PlayerStats>().Level;
        for (int i = 0; i < Random.Range(0, 12); i++)
        {
            int h = Random.Range(0, 12);
            Instantiate(chest, chestSpawnLocs[h].transform);
        }
    }
}

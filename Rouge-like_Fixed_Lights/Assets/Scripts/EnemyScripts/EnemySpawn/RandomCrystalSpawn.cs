using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCrystalSpawn : MonoBehaviour
{
    public Transform[] crystalSpawns;
    public GameObject spawnCrystal;

    // Start is called before the first frame update
    void Start()
    {
        int randomSpawn1 = Random.RandomRange(0, 3);
        int randomSpawn2 = Random.RandomRange(0, 3);

        if (randomSpawn1 == randomSpawn2)
        {
            randomSpawn2 = Random.RandomRange(0, 3);
        }
        Instantiate(spawnCrystal, crystalSpawns[randomSpawn1]);
        Instantiate(spawnCrystal, crystalSpawns[randomSpawn2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

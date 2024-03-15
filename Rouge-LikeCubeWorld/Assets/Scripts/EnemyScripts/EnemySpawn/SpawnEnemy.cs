using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnEnemy : MonoBehaviour
{
    private EnemyTypes enemyType;
    public bool spawned;
    public int numberOfSpawns;
    private Vector3 center;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        center = (UnityEngine.Random.insideUnitSphere * radius) + transform.position;
        numberOfSpawns = UnityEngine.Random.Range(0, 10);
        spawned = false;
        enemyType = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyTypes>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("spawn", 0.1f);
    }

    public void spawn()
    {
        if (spawned == false)
        {
            for (int i = 0; i < numberOfSpawns; i++)
            {
                Instantiate(enemyType.GetComponent<EnemyTypes>().enemies[0]);
            }
            spawned = true;
        }
    }
}

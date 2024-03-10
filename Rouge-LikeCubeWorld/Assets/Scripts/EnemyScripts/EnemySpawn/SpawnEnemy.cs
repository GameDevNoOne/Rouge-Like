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
    public int random;
    public bool spawned;
    public int numberOfSpawns;
    private Vector3 center;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        center = (UnityEngine.Random.insideUnitSphere * radius) + transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(randomize());
        StartCoroutine(spawn());
    }

    public void Spawn()
    {

    }

    public IEnumerator randomize()
    {
        numberOfSpawns = UnityEngine.Random.Range(0, 10);
        random = UnityEngine.Random.Range(0, enemyType.enemies.Length);
        spawned = false;
        yield return new WaitForSeconds(10);
    }
    public IEnumerator spawn()
    {
        if (spawned == false)
        {
            for (int i = 0; i < numberOfSpawns; i++)
            {
                Instantiate(enemyType.enemies[random], center, Quaternion.identity);
            }
            spawned = true;
        }
        yield return new WaitForSeconds(11);
    }
}

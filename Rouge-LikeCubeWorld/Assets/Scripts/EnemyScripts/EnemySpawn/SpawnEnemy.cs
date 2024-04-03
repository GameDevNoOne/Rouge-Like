using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnEnemy : MonoBehaviour
{
    public EnemyTypes enemyType;
    public bool spawned;
    public int numberOfSpawns;
    private Vector3 center;
    public float radius;
    public int randEnemies;

    [Header("Destroyed")]
    public EdgeCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        center = (UnityEngine.Random.insideUnitSphere * radius) + transform.position;
        numberOfSpawns = UnityEngine.Random.Range(0, 10);
        spawned = false;
        enemyType = gameObject.GetComponent<EnemyTypes>();
        randEnemies = UnityEngine.Random.Range(0, enemyType.enemies.Length);
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
                Instantiate(enemyType.enemies[randEnemies], center, transform.rotation);
            }
            spawned = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CrystalSpawner"))
        {
            Destroy(gameObject);
        }
    }
}

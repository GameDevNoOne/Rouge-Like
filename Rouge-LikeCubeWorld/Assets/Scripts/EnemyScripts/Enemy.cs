using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float Health;
    private float RemainingHealth;

    // Start is called before the first frame update
    void Start()
    {
        Health = gameObject.GetComponent<EnemyStats>().Life;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health >= 0)
        {
            Destroy(gameObject);
        }
    }
}

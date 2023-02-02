using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health;
    public GameObject Bullet;
    private float RemainingHealth;

    // Start is called before the first frame update
    void Start()
    {
        Health = this.GetComponent<EnemyStats>().Life;
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Bullet = collision.collider.gameObject;
            float Damge = Bullet.GetComponent<Damage>().Damag;
            RemainingHealth = Health - Damge;
            Health = RemainingHealth;
        }
    }

    public void Death()
    {
        if (Health >= 0)
        {
            Destroy(this);
        }
    }
}

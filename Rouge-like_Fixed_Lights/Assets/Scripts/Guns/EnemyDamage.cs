using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject Gun;
    private float Damage;

    void Start()
    {
        Damage = Gun.GetComponent<GunStats>().Damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerActions>(out PlayerActions player))
        {
            player.TakeDamage(Damage);
        }
        Destroy(gameObject);
    }
}

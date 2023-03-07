using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunShot : MonoBehaviour
{
    private float Damage;

    private void Start()
    {
        Damage = gameObject.GetComponentInParent<GunStats>().Damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(Damage);
        }
    }
}

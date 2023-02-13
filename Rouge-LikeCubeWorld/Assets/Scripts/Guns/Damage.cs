using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private float Damag;
    public GameObject Gun;

    // Start is called before the first frame update
    void Start()
    {
        Damag = Gun.GetComponent<GunStats>().Damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(Damag);
        }

        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ShotgunShooting : MonoBehaviour
{
    private float Damage;
    public Collider2D shootingRange;
    private int MagSize;
    private int originalMagSize;
    public GameObject shooting;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private void Start()
    {
        shootingRange = GetComponent<Collider2D>();
        Damage = gameObject.GetComponent<GunStats>().Damage;
        MagSize = gameObject.GetComponent<GunStats>().MagSize;
        originalMagSize = MagSize;
        shooting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (MagSize == 0)
                {
                    Reload();
                }
                else if (MagSize != 0)
                {
                    Shoot();
                    timeBtwShots = startTimeBtwShots;
                }
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    public void Shoot()
    {
        shooting.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Debug.Log("Hit");
        }
    }

    public void Reload()
    {
        MagSize = originalMagSize;
    }
}

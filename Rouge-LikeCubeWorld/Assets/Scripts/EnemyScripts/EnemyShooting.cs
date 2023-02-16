using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject Bullet;
    public Transform target;
    public float minimumDistance;

    public float bulletForce;
    private float timeBtwShots;
    public float startTimeBtwShots;

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            Shoot();
            timeBtwShots = startTimeBtwShots;
            
            timeBtwShots -= Time.deltaTime;
            
        }
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(Bullet, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * bulletForce, ForceMode2D.Impulse);
    }
}

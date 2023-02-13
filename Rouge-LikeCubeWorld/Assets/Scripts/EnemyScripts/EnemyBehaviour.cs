
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float Speed;
    public Transform target;
    public float minimumDistance;

    public GameObject projectile;
    public float timeBetweenShots;
    private float nextshotTime;
    public float bulletSpeed;
    public Transform shootPoint;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextshotTime)
        {
            Instantiate(projectile, shootPoint.position, Quaternion.identity);
            nextshotTime = Time.time + timeBetweenShots; 
        }  

        if (Vector2.Distance(transform.position, target.position) < minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -Speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourShotgun : MonoBehaviour
{
    public float Speed;
    public Transform target;
    public float minimumDistance;
    public Transform enemy;

    public GameObject projectile;
    public float timeBetweenShots;
    private float nextshotTime;
    public float bulletSpeed;
    public Transform shootPoint;

    void Update()
    {

        if (Vector2.Distance(transform.position, target.position) < minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
            Rotation();

            if (Time.time > nextshotTime)
            {
                Instantiate(projectile, shootPoint.position, Quaternion.identity);
                nextshotTime = Time.time + timeBetweenShots;
            }
        }
    }

    public void Rotation()
    {
        Vector2 direction = target.position - enemy.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        enemy.rotation = rotation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform gunPoint;
    private float timebtwShots;
    public float startTimeBTWShots;

    // Update is called once per frame
    void Update()
    {
        Shooter();
    }

    public void Shooter()
    {
        if (timebtwShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, gunPoint.position, transform.rotation);
                timebtwShots = startTimeBTWShots;
            }

        }
        else
        {
            timebtwShots -= Time.deltaTime;
        }
    }
}

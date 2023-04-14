using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject Bullet;
    private GameObject Weapon;
    public int MagSize;
    private int originalMagSize;
    public TextMeshProUGUI bulletCounter;

    public float bulletForce;
    private float timeBtwShots;
    public float startTimeBtwShots;

    private void Start()
    {
        MagSize = gameObject.GetComponent<GunStats>().MagSize;
        originalMagSize = MagSize;
        bulletCounter = GetComponentInParent<UICounters>().bulletCounter;
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
                else if(MagSize != 0)
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
        GameObject bullet = Instantiate(Bullet, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * bulletForce, ForceMode2D.Impulse);

        MagSize -= 1;
    }

    public void Reload()
    {
        MagSize = originalMagSize;
    }

    public void BulletCounter()
    {
        string bulletsOut = MagSize.ToString();
        Debug.Log(bulletsOut);
        bulletCounter.text = (bulletsOut);
    }
}

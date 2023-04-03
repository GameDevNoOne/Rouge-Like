using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICounters : MonoBehaviour
{
    [SerializeField] public TMP_Text coinCounter;
    private float Money;
    [SerializeField] public TMP_Text bulletCounter;
    private float bullets;
    private GameObject Weapon;

    // Update is called once per frame
    void Update()
    {
        Coincounter();
        BulletCounter();
    }

    public void Coincounter()
    {
        Money = GetComponent<PlayerActions>().Money;
        string MoneyOut = Money.ToString();
        coinCounter.text = (MoneyOut);
    }

    public void BulletCounter()
    {
        Weapon = GetComponent<PlayerStats>().weapon;   
        bullets = Weapon.GetComponent<Shooting>().MagSize;
        string bulletsOut = bullets.ToString();
        Debug.Log(bulletsOut);
        bulletCounter.text = (bulletsOut);
    }
}

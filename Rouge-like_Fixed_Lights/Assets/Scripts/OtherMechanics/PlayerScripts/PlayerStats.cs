using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public float Health;
    [SerializeField] public GameObject weapon;
    [SerializeField] private float Money;
    public float Magsize;
    public float Stamina;
    public float Level;
    public float Exp;
    public float nextLevelRequirement;
    public float percentualValue;
    public float Ammo;

    public void Start()
    {
        percentualValue = nextLevelRequirement * 10 / 100;
    }

    private void Update()
    {
        Money = GetComponent<PlayerActions>().Money;
        Magsize = weapon.GetComponent<Shooting>().MagSize;
        Exp = GetComponent<PlayerActions>().experiencePoints;
        Ammo = weapon.GetComponent<Shooting>().bullets;

        if (Exp >= nextLevelRequirement)
        {
            nextLevelRequirement = Exp + percentualValue;
            Level += 1;
            Health += 10;
            Stamina += 10;
            Exp = 0;
        }
    }
}

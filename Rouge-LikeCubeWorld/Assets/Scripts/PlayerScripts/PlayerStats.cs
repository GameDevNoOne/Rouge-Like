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

    private void Update()
    {
        Money = GetComponent<PlayerActions>().Money;
        Magsize = weapon.GetComponent<Shooting>().MagSize;
    }
}

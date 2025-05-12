using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIUpdater : MonoBehaviour
{
    public Slider healthSlider;
    private float health;
    public Slider staminaSlider;
    private float stamina;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = GetComponent<PlayerStats>().Health;
        healthSlider.minValue = 0;
        staminaSlider.maxValue = GetComponent<PlayerStats>().Stamina;
        staminaSlider.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        health = GetComponent<PlayerActions>().Health;
        healthSlider.value = health;
        stamina = GetComponent<Movement>().Stamina;
        staminaSlider.value = stamina;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Vector3 targetPosition;
    public float Speed;

    private void Start()
    {
        targetPosition = FindObjectOfType<PlayerActions>().transform.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
}

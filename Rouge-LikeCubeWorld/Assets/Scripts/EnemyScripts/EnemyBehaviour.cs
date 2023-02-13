using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float Speed;
    public Transform target;
    public float minimumDistance;

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -Speed * Time.deltaTime);
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardScript : MonoBehaviour
{
    public float pushForce;
    public Rigidbody2D rb;
    float angle;

    void Start()
    {
        Rotate();
        Push();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Rotate()
    {
        angle = Random.Range(-90, 90);
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        gameObject.transform.rotation = rotation;
    }

    void Push()
    {
        Vector2 dir = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle));
        rb.AddForce(dir * pushForce);
    }
}

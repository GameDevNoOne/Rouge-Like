using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    public float Speed;
    public Rigidbody2D player;
    Vector3 movement;
    public Transform mouseTransform;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        mouseTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        Rotation();
    }

    public void Moving()
    {
        movement = Vector3.zero;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement != Vector3.zero)
        {
            player.MovePosition(transform.position + movement * Speed * Time.fixedDeltaTime);
        }
    }

    public void Rotation()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseTransform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
        mouseTransform.rotation = rotation;
    }
}

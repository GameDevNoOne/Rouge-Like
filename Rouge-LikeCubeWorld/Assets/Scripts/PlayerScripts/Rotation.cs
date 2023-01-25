using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public Transform mouseTransform;

    // Start is called before the first frame update
    void Start()
    {
        mouseTransform = this.transform;   
    }

    // Update is called once per frame
    void Update()
    {
        Rotational();
    }

    public void Rotational()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseTransform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
        mouseTransform.rotation = rotation;
    }
}

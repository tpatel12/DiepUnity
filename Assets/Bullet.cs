using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float damage;
    public float speed;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.up);
        transform.Rotate(0, 0, angle * Mathf.Pow(Random.Range(-1.0f, 1.0f), 1));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Vector3 movement = new Vector3(Mathf.Cos(transform.rotation.z), Mathf.Sin(transform.rotation.z), 0);
        Vector3 movement = Vector3.up;
        movement *= speed * Time.fixedDeltaTime;
        transform.Translate(movement);
    }
}

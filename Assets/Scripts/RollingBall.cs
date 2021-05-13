using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public Rigidbody rb;
    public float horizontal;
    public float vertical;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);

        rb.AddForce(direction * speed);
    }

}

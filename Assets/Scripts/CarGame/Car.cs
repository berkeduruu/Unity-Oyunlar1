using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float vertical_velocity, assumed_velocity,horizontal_velocity;
    private float vertical_movement, horizontal_movement;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        vertical_movement = Input.GetAxis("Vertical");
        horizontal_movement = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(horizontal_movement * 100 * horizontal_velocity * Time.deltaTime,
            assumed_velocity + vertical_movement * 100 * vertical_velocity * Time.deltaTime);

        if(transform.position.x > 7.6f)
        {
            Vector3 right_limit = new Vector3(7.6f, transform.position.y);
            transform.position = right_limit;
        }
        if (transform.position.x < -8.37)
        {
            Vector3 left_limit = new Vector3(-8.37f,transform.position.y);
            transform.position = left_limit;
        }

    }
}

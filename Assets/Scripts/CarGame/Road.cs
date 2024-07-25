using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject road;
    bool is_road_done = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainCar" && is_road_done == false) {
            Vector3 spawn_location = new Vector3(transform.position.x, transform.position.y + 40, 0);
            Instantiate(road, spawn_location, Quaternion.identity);
            is_road_done = true;
            Destroy(this.gameObject, 6);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Lab2 : MonoBehaviour {
    public float speed = 5f;
    void Update() {
        float moveX = Input.GetAxis("Horizontal"); 
        float moveZ = Input.GetAxis("Vertical"); 
        Vector3 move = new Vector3(moveX, 0f, moveZ);
        transform.Translate(move * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Obstacle")) {
            Debug.Log("Obstacle Found!");
        }
    }
}
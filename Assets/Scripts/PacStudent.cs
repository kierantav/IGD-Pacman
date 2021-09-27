using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PacStudent : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move Pac-Student
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(x, y);
        float magnitude = Mathf.Clamp01(movement.magnitude);
        movement.Normalize();

        transform.Translate(movement * speed * magnitude * Time.deltaTime, Space.World);

        if (movement != Vector2.zero) {
            Quaternion direction = Quaternion.LookRotation(Vector3.forward, -movement);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, direction, rotationSpeed * Time.deltaTime);
        }
        // Rotate Pac-Student
        /*if (Input.GetKey(KeyCode.W)) {
            transform.Rotate(0, 0, 180, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 90, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -90, Space.World);
        }*/
    }

    private void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "Walls") {
            Debug.Log("Collision Detected!");
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Pelettes")
        {
            Tilemap map = col.gameObject.GetComponentInParent<Tilemap>();
            Vector3Int removePos = map.WorldToCell(transform.position);
            map.SetTile(removePos, null);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PLayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    Rigidbody rb;
    
    void Start()
    {
        rb= this.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(x, 0f, z);
        direction.Normalize();
        this.transform.position = this.transform.position
                + direction * speed * Time.deltaTime;

    }
}

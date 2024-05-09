using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
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
        if (Input.GetKeyDown(KeyCode.Space)){ rb.AddForce(0, 5f, 0, ForceMode.Impulse); }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.tag == "Item") { Destroy(other.gameObject); }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    [SerializeField]
    private Transform RefTransform;
    [SerializeField]
    private float xSpeed = 0.01f;
    void Start()
    {
        Debug.Log("start"); // ����

        //RefTransform = this.GetComponent<Transform>();
        RefTransform = transform;
        RefTransform.Translate(new Vector3(1f,0f,0f));
    }

    
    void Update()
    {
        Debug.Log("update"); // ������Ʈ
        RefTransform.Translate(new Vector3(xSpeed, 0f, 0f)); // ������ ���� �̵�
    }
}

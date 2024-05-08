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
        Debug.Log("start"); // 시작

        //RefTransform = this.GetComponent<Transform>();
        RefTransform = transform;
        RefTransform.Translate(new Vector3(1f,0f,0f));
    }

    
    void Update()
    {
        Debug.Log("update"); // 업데이트
        RefTransform.Translate(new Vector3(xSpeed, 0f, 0f)); // 프레임 마다 이동
    }
}

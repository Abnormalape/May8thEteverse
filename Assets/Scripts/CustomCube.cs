using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    [SerializeField]
    private Transform RefTransform;
    [SerializeField]
    private float xSpeed = 1f;
    [SerializeField]
    private float zSpeed = 1f;

    [SerializeField] // 초당 360도
    private float rSpeed = 360f;
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

        //방향키를 입력받아 이동하려면?
        float horizontal = Input.GetAxis("Horizontal"); // projectsettings -> inputmanager
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log(horizontal);//C#의 모든 개체는 다 toString을 가지고 있다.
        RefTransform.Translate(new Vector3(xSpeed * Time.deltaTime * horizontal, 0 , zSpeed * Time.deltaTime * vertical)); // 프레임 마다 이동
                                                                                                                           // RefTransform.position = RefTransform.position + new Vector3(0f,0f,horizontal * Time.deltaTime); <- 위치를 이전 위치에서 조금더 이동한다.

        // 단체 주석 ctrl + k -> ctrl + c

        RefTransform.Rotate(new Vector3(0f, - vertical * rSpeed * Time.deltaTime, 0f));

    }
}

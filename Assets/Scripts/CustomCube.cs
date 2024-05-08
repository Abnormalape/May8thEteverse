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

        //����Ű�� �Է¹޾� �̵��Ϸ���?
        float horizontal = Input.GetAxis("Horizontal"); // projectsettings -> inputmanager
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log(horizontal);//C#�� ��� ��ü�� �� toString�� ������ �ִ�.
        RefTransform.Translate(new Vector3(xSpeed * Time.deltaTime * horizontal, 0 , zSpeed * Time.deltaTime * vertical)); // ������ ���� �̵�

        

    }
}

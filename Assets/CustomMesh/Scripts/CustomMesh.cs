using System;
using UnityEngine;

namespace CustomMesh
{
    [ExecuteInEditMode]


    public class CustomMesh : MonoBehaviour
    {
        //Meshfilter ������Ʈ
        //Mesh �����͸� ������
        [SerializeField]
        private MeshFilter meshFilter;

        //Meshrenderer ������Ʈ
        //Material �� ����� Mesh�� �׸��� ĥ��
        [SerializeField]
        private MeshRenderer meshRenderer;

        private void Awake()
        {
            meshFilter = GetComponent<MeshFilter>();
            if (meshFilter == null ) { meshFilter = gameObject.AddComponent<MeshFilter>(); }
            meshRenderer = GetComponent<MeshRenderer>();
            if (meshRenderer == null) { meshRenderer = gameObject.AddComponent<MeshRenderer>(); }
            //�޽� ����
            Mesh mesh = new Mesh();
            Vector3[] vects = new Vector3[] {new Vector3(-0.5f,0.5f,0f), new Vector3(0.5f, 0.5f, 0f), new Vector3(-0.5f, -0.5f, 0f), new Vector3(0.5f,-0.5f,0f) }; // �ﰢ��, �� ����
            
            mesh.SetVertices(vects);    // �޽��� �������� => ��������� �ϸ� ������ �����ǰ� ���� ���� ���°� �ȴ�
                                        // ����Ƽ���� ���⼭ �� �ܰ踦 �� �ؾ� ���� �׷�����. ����Ƽ�� ������ �迭���� ������ �䱸�Ѵ�.
            int[] indices = new int[] { 0, 1, 2, 2, 1, 3 }; // ��������, �̰� �޽��� �־��ش�. �ε����� 3���� �˾Ƽ� �߶� ����
            mesh.SetIndices(indices, MeshTopology.Triangles, 0);    // (�ε��� �迭, ���� ���� ���, ���� �޽� �ε���)
                                                                    // ����޽� �ε��� => ������ ���� ���� �޽��� �����Ҷ� �κк��� �ٸ� �޽��� �����Ҷ� ����.
            Vector3[] normals = new Vector3[]{new Vector3(0f,0f,-1f), new Vector3(0f, 0f, -1f) , new Vector3(0f, 0f, -1f), new Vector3(0f, 0f, -1f) }; // ���� ����� ���߱� ���� �׷���, ���� ������ �����̱� ������

            mesh.SetNormals(normals);

            //uv���� => 2���� ��ǥ�� �迭
            Vector2[] uvs = new Vector2[] { new Vector2(0f,1f) ,new Vector2(1f,1f), new Vector2(0f,0f), new Vector2(1f, 0f) }; // ������ �޾Ƽ� �¸� �ϳ��� ������ ����, �̹����� �ű�� ���ִܳ´�.
            mesh.SetUVs(0, uvs);

            meshFilter.mesh = mesh;
        }
    }
}

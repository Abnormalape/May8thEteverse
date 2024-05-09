using System;
using UnityEngine;

namespace CustomMesh
{
    [ExecuteInEditMode]


    public class CustomMesh : MonoBehaviour
    {
        //Meshfilter 컴포넌트
        //Mesh 데이터를 관리함
        [SerializeField]
        private MeshFilter meshFilter;

        //Meshrenderer 컴포넌트
        //Material 을 사용해 Mesh를 그리고 칠함
        [SerializeField]
        private MeshRenderer meshRenderer;

        private void Awake()
        {
            meshFilter = GetComponent<MeshFilter>();
            if (meshFilter == null ) { meshFilter = gameObject.AddComponent<MeshFilter>(); }
            meshRenderer = GetComponent<MeshRenderer>();
            if (meshRenderer == null) { meshRenderer = gameObject.AddComponent<MeshRenderer>(); }
            //메쉬 생성
            Mesh mesh = new Mesh();
            Vector3[] vects = new Vector3[] {new Vector3(-0.5f,0.5f,0f), new Vector3(0.5f, 0.5f, 0f), new Vector3(-0.5f, -0.5f, 0f), new Vector3(0.5f,-0.5f,0f) }; // 삼각형, 세 정점
            
            mesh.SetVertices(vects);    // 메쉬에 정점설정 => 여기까지만 하면 정점만 생성되고 면이 없는 상태가 된다
                                        // 유니티에선 여기서 한 단계를 더 해야 면이 그려진다. 유니티는 정점의 배열에서 순서를 요구한다.
            int[] indices = new int[] { 0, 1, 2, 2, 1, 3 }; // 순서설정, 이걸 메쉬에 넣어준다. 인덱스를 3개씩 알아서 잘라서 쓴다
            mesh.SetIndices(indices, MeshTopology.Triangles, 0);    // (인덱스 배열, 만들 면의 모양, 서브 메쉬 인덱스)
                                                                    // 서브메쉬 인덱스 => 복잡한 형상에 대해 메쉬를 적용할때 부분별로 다른 메쉬를 적용할때 쓴다.
            Vector3[] normals = new Vector3[]{new Vector3(0f,0f,-1f), new Vector3(0f, 0f, -1f) , new Vector3(0f, 0f, -1f), new Vector3(0f, 0f, -1f) }; // 면의 방향과 맞추기 위해 그렇다, 면의 방향이 내쪽이기 때문에

            mesh.SetNormals(normals);

            //uv생성 => 2차원 좌표의 배열
            Vector2[] uvs = new Vector2[] { new Vector2(0f,1f) ,new Vector2(1f,1f), new Vector2(0f,0f), new Vector2(1f, 0f) }; // 네점을 받아서 걔를 하나의 면으로 놓고, 이미지를 거기다 구겨넣는다.
            mesh.SetUVs(0, uvs);

            meshFilter.mesh = mesh;
        }
    }
}

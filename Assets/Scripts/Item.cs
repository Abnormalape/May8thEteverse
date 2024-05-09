using UnityEngine;

namespace RollABall
{
    //������ ��ũ��Ʈ
    public class Item : MonoBehaviour
    {
        [SerializeField]
        private GameManager gameManager;

        private void Awake()
        {
            gameManager = FindFirstObjectByType<GameManager>();
        }
        //�ı��ɶ� ����Ǵ� �޼���
        private void OnDestroy()
        {
            gameManager.AddScore();
        }
    }
}
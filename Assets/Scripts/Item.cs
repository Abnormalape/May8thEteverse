using UnityEngine;

namespace RollABall
{
    //아이템 스크립트
    public class Item : MonoBehaviour
    {
        [SerializeField]
        private GameManager gameManager;

        private void Awake()
        {
            gameManager = FindFirstObjectByType<GameManager>();
        }
        //파괴될때 실행되는 메서드
        private void OnDestroy()
        {
            gameManager.AddScore();
        }
    }
}
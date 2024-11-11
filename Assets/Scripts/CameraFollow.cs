using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Transform player;  // 플레이어의 Transform
    public float smoothSpeed = 0.125f;  // 카메라의 부드러운 이동 속도
    public Vector3 cameraPos = new Vector3(0, 10, -10);  // 카메라와 플레이어 간의 오프셋
    public Vector3 fixedRotation = new Vector3(20f, 0f, 0f);

    void Start()
    {
        // "Player" 태그를 가진 오브젝트를 찾아서 player 변수에 할당
        player = GameObject.FindWithTag("Player")?.transform;

        if (player == null)
        {
            Debug.LogError("Player with tag 'Player' not found in the scene!");
        }
    }

    void LateUpdate()
    {
        // 만약 player가 null이면 더 이상 진행하지 않음
        if (player == null)
        {
            return;
        }

        transform.position = player.position + cameraPos;

        // 카메라 회전 고정 (20, 0, 0)
        transform.rotation = Quaternion.Euler(fixedRotation);
    }
}
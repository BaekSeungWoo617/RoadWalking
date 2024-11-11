using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Transform player;  // �÷��̾��� Transform
    public float smoothSpeed = 0.125f;  // ī�޶��� �ε巯�� �̵� �ӵ�
    public Vector3 cameraPos = new Vector3(0, 10, -10);  // ī�޶�� �÷��̾� ���� ������
    public Vector3 fixedRotation = new Vector3(20f, 0f, 0f);

    void Start()
    {
        // "Player" �±׸� ���� ������Ʈ�� ã�Ƽ� player ������ �Ҵ�
        player = GameObject.FindWithTag("Player")?.transform;

        if (player == null)
        {
            Debug.LogError("Player with tag 'Player' not found in the scene!");
        }
    }

    void LateUpdate()
    {
        // ���� player�� null�̸� �� �̻� �������� ����
        if (player == null)
        {
            return;
        }

        transform.position = player.position + cameraPos;

        // ī�޶� ȸ�� ���� (20, 0, 0)
        transform.rotation = Quaternion.Euler(fixedRotation);
    }
}
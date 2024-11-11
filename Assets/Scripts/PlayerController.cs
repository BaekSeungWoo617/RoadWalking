using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 moveInput;

    // Player Input���κ��� Move �׼� �ޱ�
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void Update()
    {
        // �̵� ���� ���
        Vector3 moveDirection = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
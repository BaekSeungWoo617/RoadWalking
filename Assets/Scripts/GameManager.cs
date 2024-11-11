using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // ������ ������Ʈ���� ������ ����Ʈ
    public List<GameObject> roadObjects = new List<GameObject>();
    public List<GameObject> treeObjects = new List<GameObject>();
    public List<GameObject> carObjects = new List<GameObject>();

    public Vector3 playerStartPosition = new Vector3(0f, 1f, 0f);


    void Awake()
    {
        if (instance == null) // �̱��� ����
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject); // �ߺ��� �ν��Ͻ��� ����
            return;
        }

        // �÷��̾� ������Ʈ ����
        CreatePlayer();
    }

    // �÷��̾� ���� �Լ�
    void CreatePlayer()
    {
        // Resources �������� Player ������ �ε�
        GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/Player");

        // �������� �ε�Ǿ����� Ȯ��
        if (playerPrefab != null)
        {
            // �÷��̾� ������Ʈ�� �������� ����
            Instantiate(playerPrefab, playerStartPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Player Prefab is not found in Resources/Prefabs folder!");
        }
    }
}

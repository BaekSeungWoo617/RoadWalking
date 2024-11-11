using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // Ǯ�� ������ ������Ʈ�� �⺻ Prefab
    public GameObject objectPrefab;

    // Ǯ�� ������ ������Ʈ�� ����Ʈ
    private List<GameObject> objectPool = new List<GameObject>();

    // ������Ʈ Ǯ�� �ʱ� ũ��
    public int initialPoolSize = 10;

    // ������Ʈ�� Ȱ��ȭ�Ͽ� ��ȯ�ϴ� �Լ�
    public GameObject GetObject()
    {
        // Ǯ�� ��ȯ ������ ������Ʈ�� �ִٸ� �� ������Ʈ�� ��ȯ
        foreach (var obj in objectPool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        // Ǯ�� ��ȯ ������ ������Ʈ�� ���ٸ�, ���ο� ������Ʈ�� �����Ͽ� ��ȯ
        GameObject newObject = Instantiate(objectPrefab);
        objectPool.Add(newObject);
        return newObject;
    }

    // ������Ʈ�� ��Ȱ��ȭ�Ͽ� Ǯ�� ��ȯ�ϴ� �Լ�
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    // Ǯ�� �ʱ�ȭ
    private void Start()
    {
        // �̸� ������Ʈ�� Ǯ�� �ʱ�ȭ
        for (int i = 0; i < initialPoolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false); // �ʱ⿡�� ��Ȱ��ȭ ���·� Ǯ�� �߰�
            objectPool.Add(obj);
        }
    }
}
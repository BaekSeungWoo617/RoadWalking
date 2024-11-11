using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // ������ ������Ʈ���� Prefab (���ҽ� �������� �ҷ�����)
    private GameObject carPrefab;
    private GameObject treePrefab;
    private GameObject roadPrefab;
    private GameObject grassPrefab;

    private void Awake()
    {
        // Resources �������� Prefab�� �������� �ҷ�����
        carPrefab = Resources.Load<GameObject>("Prefabs/Car");
        treePrefab = Resources.Load<GameObject>("Prefabs/Tree");
        roadPrefab = Resources.Load<GameObject>("Prefabs/Road");
        grassPrefab = Resources.Load<GameObject>("Prefabs/Grass");
        
    }
    void Start()
    {
        SpawnRoad(new Vector3(0, 0, 0));
    }

    // �ڵ��� ����
    void SpawnCar(Vector3 position)
    {
        if (carPrefab != null)
        {
            GameObject car = Instantiate(carPrefab, position, Quaternion.identity);
            GameManager.instance.carObjects.Add(car);  // ������ �ڵ����� ����Ʈ�� �߰�
        }
    }

    // ���� ����
    void SpawnTree(Vector3 position)
    {
        if (treePrefab != null)
        {
            GameObject tree = Instantiate(treePrefab, position, Quaternion.identity);
            GameManager.instance.treeObjects.Add(tree);  // ������ ������ ����Ʈ�� �߰�
        }
    }

    // ���� ����
    void SpawnRoad(Vector3 position)
    {
        if (roadPrefab != null)
        {
            GameObject road = Instantiate(roadPrefab, position, Quaternion.identity);
            GameManager.instance.roadObjects.Add(road);  // ������ ���θ� ����Ʈ�� �߰�
        }
    }
}

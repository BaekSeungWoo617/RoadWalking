using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // ������ ������Ʈ���� Prefab (���ҽ� �������� �ҷ�����)
    private GameObject ambulPrefab;
    private GameObject treePrefab;
    private GameObject roadPrefab;
    private GameObject grassPrefab;

    private void Awake()
    {
        // Resources �������� Prefab�� �������� �ҷ�����
        ambulPrefab = Resources.Load<GameObject>("Prefabs/Ambulance");
        treePrefab = Resources.Load<GameObject>("Prefabs/Tree");
        roadPrefab = Resources.Load<GameObject>("Prefabs/Road");
        grassPrefab = Resources.Load<GameObject>("Prefabs/Grass");
        
    }
    void Start()
    {
        for(int i=0;i<10;i++)
        {
            for (int j=0;j<10;j++)
            {
                SpawnObject(roadPrefab, new Vector3(20 * i, 0, 20 * j));

            }
        }
        SpawnObjects(ambulPrefab);
    }
    void SpawnObject(GameObject gamePrefab, Vector3 position)
    {
        if (gamePrefab != null)
        {        
                GameObject thisPrefab = Instantiate(gamePrefab, position, Quaternion.identity);
                GameManager.instance.roadObjects.Add(thisPrefab);  // ������ �ڵ����� ����Ʈ�� �߰�
        }
    }
    void SpawnObjects(GameObject gamePrefab)
    {

        if (gamePrefab != null)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject thisPrefab = Instantiate(gamePrefab, Vector3.zero, Quaternion.identity);
                GameManager.instance.carObjects.Add(thisPrefab);  // ������ �ڵ����� ����Ʈ�� �߰�
                thisPrefab.SetActive(false);
            }

        }
    }
}

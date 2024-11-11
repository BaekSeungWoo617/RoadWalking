using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // 생성할 오브젝트들의 Prefab (리소스 폴더에서 불러오기)
    private GameObject carPrefab;
    private GameObject treePrefab;
    private GameObject roadPrefab;
    private GameObject grassPrefab;

    private void Awake()
    {
        // Resources 폴더에서 Prefab을 동적으로 불러오기
        carPrefab = Resources.Load<GameObject>("Prefabs/Car");
        treePrefab = Resources.Load<GameObject>("Prefabs/Tree");
        roadPrefab = Resources.Load<GameObject>("Prefabs/Road");
        grassPrefab = Resources.Load<GameObject>("Prefabs/Grass");
        
    }
    void Start()
    {
        SpawnRoad(new Vector3(0, 0, 0));
    }

    // 자동차 생성
    void SpawnCar(Vector3 position)
    {
        if (carPrefab != null)
        {
            GameObject car = Instantiate(carPrefab, position, Quaternion.identity);
            GameManager.instance.carObjects.Add(car);  // 생성된 자동차를 리스트에 추가
        }
    }

    // 나무 생성
    void SpawnTree(Vector3 position)
    {
        if (treePrefab != null)
        {
            GameObject tree = Instantiate(treePrefab, position, Quaternion.identity);
            GameManager.instance.treeObjects.Add(tree);  // 생성된 나무를 리스트에 추가
        }
    }

    // 도로 생성
    void SpawnRoad(Vector3 position)
    {
        if (roadPrefab != null)
        {
            GameObject road = Instantiate(roadPrefab, position, Quaternion.identity);
            GameManager.instance.roadObjects.Add(road);  // 생성된 도로를 리스트에 추가
        }
    }
}

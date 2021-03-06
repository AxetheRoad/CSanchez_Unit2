using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xPositionRange = 13;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

               

    }

    void SpawnRandomAnimal()
    {
        float RanXPos = Random.Range(-xPositionRange, xPositionRange);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 RanPos = new Vector3(RanXPos, 0, 21);
        Instantiate(animalPrefabs[animalPrefabIndex], RanPos,
            animalPrefabs[animalPrefabIndex].transform.rotation);

    }
}

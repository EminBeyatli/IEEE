using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject elmaPrefab;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(elmaPrefab, Spawner.transform.position,Quaternion.identity);

        }
    }
}

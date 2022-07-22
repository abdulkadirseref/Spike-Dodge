using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject spike;

    private void Start()
    {
        Instantiate(spike, transform.position, Quaternion.identity);
    }

}

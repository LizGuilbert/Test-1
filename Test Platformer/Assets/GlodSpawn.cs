using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlodSpawn : MonoBehaviour
{
    public int gold;
    void Start()
    {
        transform.position = new Vector3(Random.Range(-4.0f, 5.0f), transform.position.y,Random.Range(-6.5f,2.6f));
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        transform.position = new Vector3(Random.Range(-4.0f, 5.0f), transform.position.y,Random.Range(-6.5f,2.6f));
        gold += 1;
    }
}

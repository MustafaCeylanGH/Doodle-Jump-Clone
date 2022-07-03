using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<GameObject> platforms = new List<GameObject>();
    [SerializeField] private GameObject Doodle;
    [SerializeField] private float interval;
    [SerializeField] private float spawnMoveSpeed = 1;
    private float xLimit = 2.20f;   
    private float yLimit = 2.0f;    


    private void Start()
    {
        InvokeRepeating("SpawnPlatform", 0f, interval);
    }

    private void SpawnPlatform()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            Instantiate(platforms[i],PlatformSpawnPosition(),transform.rotation);
        }
    }
         
    private Vector2 PlatformSpawnPosition()
    {
        float xBoundary = Random.Range(-xLimit, xLimit);
        float yBoundary = Random.Range(transform.position.y, transform.position.y+yLimit);

        Vector2 boundary = new Vector2(xBoundary, yBoundary);

        return boundary;
    }

    private void Update()
    {
        transform.Translate(0, spawnMoveSpeed*Time.deltaTime, 0);
    }

}

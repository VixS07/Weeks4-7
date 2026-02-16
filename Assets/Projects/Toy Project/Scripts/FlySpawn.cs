using System.Collections.Generic;
using UnityEngine;

public class FlySpawn : MonoBehaviour
{
    public GameObject flyPrefab;
    public GameObject spawnedFly;
    public List<GameObject> flies;
    public float t;
    Vector2 bottomLeft;
    Vector2 topRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //get screen limits
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        //spawn flies every 5 seconds
        t += Time.deltaTime;

        //get fly pos
        Vector2 flyPos = transform.position;

        if (t >= 1.5 && flies.Count <= 100)
        {
            //spawn at random pos
            flyPos.x = Random.Range(bottomLeft.x-1, topRight.x+1);
            //make it spawn above the screen so the spawning looks organic
            flyPos.y = topRight.y + 1;
            transform.position = flyPos;
            spawnedFly = Instantiate(flyPrefab, transform.position, Quaternion.identity);
            flies.Add(spawnedFly);
            t = 0;
        }
    }
}

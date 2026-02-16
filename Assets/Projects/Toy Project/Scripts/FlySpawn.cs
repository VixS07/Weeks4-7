using System.Collections.Generic;
using UnityEngine;

public class FlySpawn : MonoBehaviour
{
    public GameObject flyPrefab;
    public GameObject spawnedFly;
    public List<GameObject> flies;
    public float t;
    public Flies flyScript;
    public int fliesKilled;
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

        if (t >= 2 && flies.Count <= 100)
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

        //loop through list of flies
        for (int i = flies.Count - 1; i >=0; i--)
        {
            //get the script for each item in the list
            flyScript = flies[i].GetComponent<Flies>();
            //check if the health is at 0 (the fly is dead)
            //if so, destory the object
            if (flyScript.health == 0)
            {
                //Debug.Log(i + "dead");
                GameObject fly = flies[i];
                flies.Remove(fly);
                Destroy(fly);
                fliesKilled += 20;
            }

        }
    }
}

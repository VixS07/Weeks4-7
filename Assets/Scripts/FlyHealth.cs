using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyHealth : MonoBehaviour
{

    public Slider flyHealth;
    public GameObject flyPrefab;
    public GameObject spawnedFly;
    public List<GameObject> flies;

    public float t;
    public float speed = 2f;

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

        if (t >= 5 && flies.Count <= 10)
        {
            Vector2 flyPos = transform.position;
            spawnedFly = Instantiate(flyPrefab, transform.position, Quaternion.identity);
            flies.Add(spawnedFly);
            t = 0;
        }

        //get mouse pos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //is it inside the sprite?, are they clicking?
    }
}

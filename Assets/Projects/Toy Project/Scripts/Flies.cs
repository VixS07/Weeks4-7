using UnityEngine;

public class Flies : MonoBehaviour
{
    public float speedX;
    public float speedY;
    float t = 3;

    Vector2 bottomLeft;
    Vector2 topRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 flyPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //get screen limits
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        //increase time by seconds
        t += Time.deltaTime;

        //get fly position
        Vector2 flyPos = transform.position;

        //every 3 seconds, set a random direction using speed
        if (t > 3)
        {
            speedX = Random.Range(-2, 3);
            speedY = Random.Range(-2, 3);
            t = 0;
        }

        //add the speed onto the position
        flyPos.x += speedX * Time.deltaTime;
        flyPos.y += speedY * Time.deltaTime;
        //update position
        transform.position = flyPos;

        //when fly hits the wall, randomize speed again in appropiate axis
        if (flyPos.x <= bottomLeft.x)
        {
            speedX = Random.Range(1, 2);
        }
        else if (flyPos.x >= topRight.x)
        {
            speedX = Random.Range(-1, -2);
        }
        else if (flyPos.y >= topRight.y)
        {
            speedY = Random.Range(-1, -2);
        }
        else if (flyPos.y <= bottomLeft.y)
        {
            speedY = Random.Range(1, 3);
        }


    }
}

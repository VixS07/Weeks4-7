using UnityEngine;

public class SpikeBall : MonoBehaviour
{
    public SpriteRenderer ball;
    public int speed = 4;
    public bool isInBall = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fall(bool fallDown)
    {

        Vector2 ballPos = transform.position;
        if (fallDown)
        {
            if (ballPos.y >= 2.2)
            {
                ballPos.y -= 1 * speed * Time.deltaTime;
            }
        }
        transform.position = ballPos;
    }
}

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class FroggerMove : MonoBehaviour
{
    public int speed = 2;
    public GameObject win;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        //movement

        //up and down
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }

        //left and right
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Keyboard.current.dKey.wasPressedThisFrame) 
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if(pos.y > 4)
        {
            win.SetActive(true);
        }
        {

        }
    }
}

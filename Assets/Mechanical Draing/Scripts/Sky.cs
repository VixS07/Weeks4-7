using UnityEngine;

public class Sky : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {


        //scale the sky colour based on the screen size
        Vector2 newSize = transform.localScale;

        //make it dependent on the height and width
        newSize.x = Screen.width;
        newSize.y = Screen.height;

        //update scale
        transform.localScale = newSize;
    }
}

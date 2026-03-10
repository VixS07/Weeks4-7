using UnityEngine;

public class Strategies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (float i = 0; i < 10; i++)
        {
            //instantiate a prefab
            //at a x position thats increasing by 1
            //a y position thats increasing by 0.1
            //and 0 in z, no rotation

            float x = i;
            Debug.Log(i + "/" + 10 + " = " + i/10);
            float y = i/10;
            Debug.Log("Y = " + y);

            float z = 0;

            Instantiate(prefab, new Vector3 (x,y,z), Quaternion.identity);

            Instantiate(prefab, new Vector3 (x, y,z), Quaternion.identity);
        }
    }

}

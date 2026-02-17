using UnityEngine;

public class Strategies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        //loop ten times
        for (int i = 0; i < 10; i++)
        {
            //instantiate a prefab
            //at a x position thats increasing by 1
            //and a y position thats increasing by 0.1
            //and 0 in z, no rotation

            float x = i; //this shouldnt be 0
            float y = i / 10; //this shouldnt be 0
            float z = 0; //this one is fine

            Instantiate(prefab, new Vector3 (x, y,z), Quaternion.identity);
        }
    }

}

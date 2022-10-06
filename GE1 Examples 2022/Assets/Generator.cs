using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int loops = 10;
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        float radius = 1;
        for(int i = 0; i <= loops; i++) {
            int noOfPrefabs = (int)(2 * Mathf.PI * radius * i);
            float theta = 2.0f*Mathf.PI/((float)noOfPrefabs);
            for(int j = 0; j < noOfPrefabs; j++) {
                float angle = theta*j;
                float x = Mathf.Cos(angle);
                float y = Mathf.Sin(angle);
                GameObject g = Instantiate(myPrefab, new Vector3(x*i*radius, y*i*radius, 0), Quaternion.identity);
                g.GetComponent<Renderer>().material.color = Color.HSVToRGB(j/(float)noOfPrefabs, i, i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

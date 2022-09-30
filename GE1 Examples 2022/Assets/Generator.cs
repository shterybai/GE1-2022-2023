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
                Instantiate(myPrefab, new Vector3(x*i*radius, y*i*radius, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 255; i++) {
            Color c = new Color(0.5f, 0.5f, 0.5f);
            gameObject.GetComponent<Renderer>().material.color = c;
        }
    }
}

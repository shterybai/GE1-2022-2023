using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public Transform head;
    public Transform tail;
    [Range(0, 5)]
    public float frequency;
    public int headAmplitude;
    public int tailAmplitude;
    public float theta;
    // Start is called before the first frame update
    void Start()
    {
        frequency = 0.5f;
        headAmplitude = 40;
        tailAmplitude = 60;
    }

    // Update is called once per frame
    void Update()
    {
        theta = frequency * Time.time * 5;
        float headRotation = headAmplitude * Mathf.Sin(theta);
        float tailRotation = tailAmplitude * Mathf.Sin(theta);

        // head.localRotation = Quaternion.Euler(1, 0, 0);
        // tail.localRotation = Quaternion.Euler(1, 0, 0);

        head.localRotation = Quaternion.AngleAxis(headRotation, Vector3.forward);
        tail.localRotation = Quaternion.AngleAxis(tailRotation, Vector3.forward);

        // head.Rotate(0, 0, headRotation * Time.deltaTime);
        // tail.Rotate(0, 0, tailRotation * Time.deltaTime);
    }
}

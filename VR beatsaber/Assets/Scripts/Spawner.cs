using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;

    public float beat = (60/130.0f) * 2;
    float timer;


    // Update is called once per frame
    void Update()
    {
        if(timer > beat)
        {
            timer -= beat;
            GameObject cube = Instantiate(cubes[Random.Range(0,2)], points[Random.Range(0,4)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90*Random.Range(0,4));
        }
        timer += Time.deltaTime;
    }
}
 
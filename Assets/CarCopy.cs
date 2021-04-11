using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCopy : MonoBehaviour
{
    public GameObject car; // car prefab asset
    public float copyDelay = .3f;
    float nextTimeToCopy = 0f; // at the beginning time for coping a car is zero
    public Transform[] CopyPoints;
    // Update is called once per frame
    void Update()
    {
        if (nextTimeToCopy <= Time.time) //when time will increases it will go inside if and then copy a car
        {
            int randomIndex = Random.Range(0, CopyPoints.Length); // getting random num between 0-3
            Transform CopyPoint = CopyPoints[randomIndex];
            Instantiate(car , CopyPoint.position , CopyPoint.rotation);
            nextTimeToCopy = Time.time + copyDelay; //current time + delay
        }
    }
}

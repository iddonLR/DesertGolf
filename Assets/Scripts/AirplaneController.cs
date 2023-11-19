using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    public Transform airplanePivot; // Reference to the empty GameObject acting as the pivot
    public float rotationSpeed = -50f; // Adjust the speed of rotation

    void Update()
    {
        RotateAirplane();
    }

    void RotateAirplane()
    {
        // Rotate the airplane around the pivot point
        transform.RotateAround(airplanePivot.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

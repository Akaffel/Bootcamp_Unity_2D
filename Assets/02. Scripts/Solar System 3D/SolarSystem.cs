using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotationSpeed = -30f;
    public float revolutionSpeed = -20f;
    public bool isRevolution = false;

    void Update()
    {

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        if(isRevolution == true)
        {
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
    }
}

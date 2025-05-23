using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    void Awake()
    {
        Destroy(gameObject, 1);
    }

    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}

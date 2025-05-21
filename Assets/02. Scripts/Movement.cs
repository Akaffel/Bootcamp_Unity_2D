using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    void Start()
    {
        
    }

    void Update()
    {
        this.transform.position = this.transform.position + Vector3.forward*moveSpeed*Time.deltaTime;
    }
}

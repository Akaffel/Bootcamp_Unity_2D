using UnityEngine;
 
public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
     
    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        Vector3 direction = new Vector3(h, 0, v).normalized;
        
        transform.position += direction * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + direction);
        
        
        float currentSpeed = direction.magnitude * moveSpeed;
        Debug.Log("현재 속도: " + currentSpeed);
    }
}
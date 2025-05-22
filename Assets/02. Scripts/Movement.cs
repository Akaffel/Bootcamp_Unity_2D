using UnityEngine;
 
public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
     
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {direction}");
        
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
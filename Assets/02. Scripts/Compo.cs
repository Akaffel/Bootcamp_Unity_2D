using UnityEngine;

public class Compo : MonoBehaviour
{
    public GameObject obj;
    
    public Transform objTf;
    public Component objCompo;
    void Start()
    { 
        obj = GameObject.FindGameObjectWithTag("CubeName"); 
        
        objTf = GameObject.FindGameObjectWithTag("CubeName").GetComponent<Transform>();
        objTf.gameObject.SetActive(false);

        objCompo.gameObject.SetActive(false);
        
        Debug.Log($"<color=#155700>이름 : {obj.name}</color>");
        Debug.Log($"태그 : {obj.tag}");
        Debug.Log($"위치 : {obj.transform.position}");
        Debug.Log($"회전 : {obj.transform.rotation}");
        Debug.Log($"크기 : {obj.transform.localScale}");

        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");
        
        obj.GetComponent<MeshRenderer>().enabled = false;
        
        obj.SetActive(false);
    }
}

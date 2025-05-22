using System;
using Unity.VisualScripting;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;
    
    void Start()
    {
        Debug.Log("창조");
        Create();
        
        Destroy(destroyObj, 3f);
    }

    void OnDestroy()
    {
        Debug.Log("파괴");
    }

    void Create()
    {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "Hoshi";
        
        Transform objTf = obj.transform;
        int cnt = objTf.childCount;
        
        Debug.Log($"캐릭터의 자식 오브젝트 수 : {cnt}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(cnt-1).name}");
    }

}

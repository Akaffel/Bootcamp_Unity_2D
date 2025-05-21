using UnityEngine;

public class Compo : MonoBehaviour
{
    public GameObject obj;
    public string changeName;
    void Start()
    {
        obj = GameObject.Find("Main Camera");
        
        obj.name = changeName;
    }

}

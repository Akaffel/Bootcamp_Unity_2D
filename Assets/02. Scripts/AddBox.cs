using UnityEngine;

public class AddBox : MonoBehaviour
{
    public GameObject cube;
    public Mesh cubeMesh;
    public Material cubeMaterial;
    void Start()
    {
        CreateCube("Cube");
    }

    public void CreateCube(string name)
    {
        cube = new GameObject(name);

        cube.AddComponent<MeshFilter>();
        cube.GetComponent<MeshFilter>().mesh = cubeMesh;
        
        cube.AddComponent<MeshRenderer>();
        cube.GetComponent<MeshRenderer>().material = cubeMaterial;
        
        cube.AddComponent<BoxCollider>();
    }
}


using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace _02._Scripts
{
    public class NewMonoBehaviourScript : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log("Start 함수 실행");
            Debug.LogWarning("Start 함수 실행");
            Debug.LogError("Start 함수 실행");
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}
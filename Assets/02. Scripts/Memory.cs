using System;
using UnityEngine;

public class MemoryClass
{
    public int number;

    public MemoryClass(int number)
    {
        this.number = number;
    }
}

public struct MemoryStruct
{
    public int number;

    public MemoryStruct(int number)
    {
        this.number = number;
    }
}

public class Memory : MonoBehaviour
{
    void Start()
    {
        Debug.Log("클래스 ----------");
        MemoryClass memoryClass = new MemoryClass(10);
        MemoryClass memoryClass2 = memoryClass;
        Debug.Log($"memoryClass : {memoryClass.number} / memoryClass2 : {memoryClass2.number}");
        memoryClass2.number++;
        Debug.Log($"memoryClass : {memoryClass.number} / memoryClass2 : {memoryClass2.number}");
        
        Debug.Log("구조체 ----------");
        MemoryStruct memoryStruct = new MemoryStruct(10);
        MemoryStruct memoryStruct2 = memoryStruct;
        Debug.Log($"memoryStruct : {memoryStruct.number} / memoryStruct2 : {memoryStruct2.number}");
        memoryStruct2.number++;
        Debug.Log($"memoryStruct : {memoryStruct.number} / memoryStruct2 : {memoryStruct2.number}");
    }
}

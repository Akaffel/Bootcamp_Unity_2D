using UnityEngine;

public class Calc : MonoBehaviour
{
    public int number1 = 5, number2 = 7;
    
    void Start()
    {
        AddMethod();
        MinusMethod();
    }

    void AddMethod()
    {
        int result = number1 + number2;
        Debug.Log($"더한 값 : {result}");
    }

    void MinusMethod()
    {
        int result = number1 - number2;
        Debug.Log($"뺀 값 : {result}");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calc : MonoBehaviour
{
    public InputField Value1, Value2;
    public Text Result;
    public void Addidion()
    {
        float a, b, c;
        a = float.Parse(Value1.text);
        b = float.Parse(Value2.text);
        c = a + b;
        Result.text = c.ToString();
    }
    public void Subtraction()
    {
        float a, b, c;
        a = float.Parse(Value1.text);
        b = float.Parse(Value2.text);
        c = a - b;
        Result.text = c.ToString();
    }
    public void Multiplication()
    {
        float a, b, c;
        a = float.Parse(Value1.text);
        b = float.Parse(Value2.text);
        c = a * b;
        Result.text = c.ToString();
    }
    
    public void Exponentiation()
    {
        float a, b, c;
        a = float.Parse(Value1.text);
        b = float.Parse(Value2.text);
        c = Mathf.Pow(a,b);
        Result.text = c.ToString();
    }
    public void Max()
    {
        float a, b, c;
        a = float.Parse(Value1.text);
        b = float.Parse(Value2.text);
        c = Mathf.Max(a,b);
        Result.text = c.ToString();
    }
    public void Min()
    {
        float a, b, c;
        a = float.Parse(Value1.text);
        b = float.Parse(Value2.text);
        c = Mathf.Min(a,b);
        Result.text = c.ToString();
    }
    public void Division()
    {
        float a, b, c;
        a = float.Parse(Value1.text);
        b = float.Parse(Value2.text);
        if(b == 0)
        {
            Result.text = ("NONONO");
        }
        else 
        {
        c = a / b;
        Result.text = c.ToString();
        }
    }
}

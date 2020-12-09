using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int a = 1;
    public float b = 1.1f;
    const float vc = 2;

    char c;
    public string d = "abc";

    bool t = false;

    // Start is called before the first frame update
    void Start()
    {
        //Сложение
        //b = a + b;
        //b += a;
        print("Сложение " + (b + a));

        //Вычитание
        //b = b - a;
        //b -= a;
        print("Вычитание " + (b - a));

        //Деление
        //b = b / a;
        //b /= a;
        print("Деление " + (b / a));

        //Умножение
        //b = b * a;
        //b *= a;
        print("Умножение " + (b * a));
    
            }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    private void FixedUpdate()
    {

    }
    
    private void OnEnable()
    {

    }
    
    private void OnDisable()
    {

    }
    
    private void Awake()
    {

    }
    
    private void OnDestroy()
    {

    }
}

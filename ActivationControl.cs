using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationControl : MonoBehaviour
{
    //Объект, на который мы воздействуем
    public GameObject Cube;

    //Место объекта для создания
    public GameObject ExampleCube;

    //Место создания объекта
    public Transform SpawnPoint;

    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        Instant();
    }

    // Update is called once per frame
    void Update()
    {

        //Проверка на нажатие клавиш
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WorkWithComponents();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            EnbleControll();
        }
    }

    //Создание объектов и компонентов
    void Instant()
    {
        //Объекты

        //Создание объект в корне сцены на координатах 0.0.0
        //Instantiate(ExampleCube);

        //Создание объект в дочерних к "transform" на координатах 0.0.0 относительно родителей
        //Instantiate(ExampleCube, transform);

        //Создание объект в корне сцены на координатах заданных координатах и повороте
        //Instantiate(ExampleCube, SpawnPoint.position, SpawnPoint.rotation);

        //Создание объект в дочених к "transform" на заданных координатах и повороте
        //Instantiate(ExampleCube, SpawnPoint.position, SpawnPoint.rotation, transform);


        //Компоненты

        //Добавление компонентов к объекту
        Rigidbody rigidbody = Cube.AddComponent<Rigidbody>();
        rigidbody.useGravity = false;


    }

    void Destr()
    {
        //Моментальное уничтожение объекта
        //Destroy(Cube);

        //Уничтожение объекта через время
        //Destroy(Cube, 2);


        //Компоненты

        //Моментальное уничтожение компонента
        //Destroy(Cube.GetComponent<Rigidbody>());

        //Уничтожение компонента через время
        Destroy(Cube.GetComponent<Rigidbody>());

    }

    void EnbleControll()
    {
        //Объекты

        //Сохранение старого состояния объекта
        //bool Enable = Cube.activeSelf;

        //Изменение состояния на противоположное
        //Cube.SetActive(!Enable);


        //Компоненты

        //Сохранение старого состояния объекта
        bool Enable = Cube.GetComponent<MeshRenderer>().enabled;

        //Изменение состояния на противоположное
        Cube.GetComponent<MeshRenderer>().enabled = !Enable;

    }

    void WorkWithComponents()
    {
        //Собственные

        //Доступ к объекту с данным компонентом
        //gameObject

        //Доступ к transform с данным компонентом (Transform хранит в себе данные о позиции, вращении, размере, родителях и детях..)
        //transform

        //Доступ к другому компоненту с данным компонентом
        //GetComponent<YourComponent>()

        //Заданные

        //Доступ к заданному (Cube) объекту с данным компонентом
        //Cube

        //Доступ к заданному (Cube) transform с данным компонентом (Transform хранит в себе данные о позиции, вращении, размере, родителях и детях..)
        //Cube.transform

        //Доступ к заданному (Cube) другому компоненту с данным компонентом
        //Cube.GetComponent<YourComponent>()

        //Cube.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);

        Cube.GetComponent<MeshRenderer>().material.SetColor("_Color", color);
    }


}

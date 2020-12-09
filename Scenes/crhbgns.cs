using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test1 : MonoBehaviour
{
    public GameObject Object;

    public float speed = 1;

    public Transform PosA;

    public Transform PosB;

    // Start is called before the first frame update
    void Start()
    {
        //Object.SetActive(false);

        //Object.GetComponent<MeshRenderer>().enabled = false;

        //Destroy(Object);

        //Destroy(Object.GetComponent<MeshRenderer>());

        FirstChangePos();

    }
    void FirstChangePos()
    {
        //Object.transform.position = Vector3.zero;

        //Object.transform.position = new Vector3(2,1,2);

        Object.transform.position = PosA.position;
    }
    void FirstChangeRot()
    {
        //Object.transform.rotation = Quaternion.Euler(45, 90, 180);

        //Object.transform.eulerAngles = new Vector3(45, 90, 180);

        Object.transform.position = PosA.position;
    }

    void ConstantChangeRot()
    {
          //Object.transform.Rotate(new Vector3(45, 90, 180) * Time.deltaTime * speedRot();

         //Object.transrorm.position += Object.transrorm.forward * Time.deltaTime * speed;

          Object.transform.position = Vector3.MoveTowards(Object.transform.position, PosB.position, speed * Time.deltaTime);
    }

    void ConstantChangePos()
    {
        //Object.transform.position += new Vector3(0, 1, 0) * Time.deltaTime;

        //Object.transrorm.position += Object.transrorm.forward * Time.deltaTime * speed;

        Object.transform.position = Vector3.MoveTowards(Object.transform.position, PosB.position, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        ConstantChangePos();
        ConstantChangeRot();
    }
}

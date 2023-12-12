using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class salt : MonoBehaviour
{
    public GameObject prefab;
    public GameObject saltglass;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.rotation.eulerAngles.z >= 100f && this.transform.rotation.eulerAngles.z <= 270f)
        {
           
            Instantiate(prefab, target.position, target.rotation);
        }
        if (transform.rotation.eulerAngles.z <= -100f && transform.rotation.eulerAngles.z >= -270f)
        {
            Instantiate(prefab, target.position, target.rotation);
        }
    }

   
}

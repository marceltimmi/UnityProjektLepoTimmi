using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Update", 2.0f, 3f);



    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject a = Instantiate(Prefab, gameObject.transform);
        
        Debug.Log(a.transform.position);
    }
}

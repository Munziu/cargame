using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        for(float z = 10; z <300; z+= Random.Range(6f, 10f))
        {
            GameObject Tree = Instantiate(GameObject);
            Tree.transform.position = new Vector3(Random.Range(-7.5f,7.5f),0,z);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

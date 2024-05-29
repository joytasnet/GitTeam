using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] objs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            int idx = Random.Range(0, objs.Length);
            Instantiate(
                objs[idx],
                transform.position,
                Quaternion.identity
            );
        }

    }
}

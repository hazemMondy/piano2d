using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float width = 10f;
    public float height = 5f;
    public GameObject pianotile;
    public float delay = 0.5f;
    public float min=-5f;
    public float max=10f;
    // Start is called before the first frame update
    void Start()
    {
        spwanuntil();
    }
    
    // Update is called once per frame
    void spwanuntil()
    {
        Transform position = freepos();
        float ran = Random.Range(min, max);
        Vector3 offset = new Vector3(0,ran,0);
        if (position)
        {
            GameObject piano = Instantiate(pianotile,position.transform.position+offset, Quaternion.identity);
            piano.transform.parent = position;
        }
        if (freepos())
        {
            Invoke("spwanuntil",delay);
        }
    }
    void spawner()
    {
        foreach(Transform child in transform)
        {
            GameObject piano = Instantiate(pianotile, child.position, Quaternion.identity);
            piano.transform.parent = child;
        } 
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }

    bool checkempty()
    {
        foreach(Transform child in transform)
        {
            if (child.childCount>0)
            {
                return false;
            }
           
        }
        return true;
    }
     void Update()
    {
        if (checkempty())
        {
            spwanuntil(); 
        }
    }
    Transform freepos()
    {
            foreach (Transform child in transform)
            {
                if (child.childCount == 0)
                {
                    return child;
                }

            }
            return null;
    }


}

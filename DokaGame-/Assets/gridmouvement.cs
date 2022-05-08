using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridmouvement : MonoBehaviour
{
    public float Mouvementnumber = 2;
    public float MouvementMouved;

    private float turnNumber;
    void Start()
    {
        MouvementMouved = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
                    {
                    MouvementMouved = 0;
                    }

        if (Mouvementnumber != MouvementMouved)
             {
                if (Input.GetKeyDown(KeyCode.W)) 
                    {
                    transform.position += Vector3.forward;
                    MouvementMouved += 1;
                    
                    }
                if (Input.GetKeyDown(KeyCode.S)) 
                    {
                    transform.position += Vector3.back;
                    MouvementMouved += 1;
                    }
                if (Input.GetKeyDown(KeyCode.A)) 
                    {
                    transform.position += Vector3.left;
                    MouvementMouved += 1;
                    }
                if (Input.GetKeyDown(KeyCode.D)) 
                    {
                    transform.position += Vector3.right;
                    MouvementMouved += 1;
                    }
                
             }
    }   
}

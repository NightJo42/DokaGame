using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gridmouvement : MonoBehaviour
{
    public int Mouvementnumber;
    public int MouvementMouved;

    private float turnNumber;
    void Start()
    {
        MouvementMouved = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
                    {
                    Mouvementnumber = Random.Range(1,11);
                    }
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
    void OnTriggerEnter(Collider other)
        {
              if (Mouvementnumber == MouvementMouved)
                    {
                        if (gameObject.tag == "test")
                        Debug.Log("we are loading the scene");
                        SceneManager.LoadScene("figthing", LoadSceneMode.Additive);
                    } 
        }

}

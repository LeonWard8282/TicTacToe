using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCollider :  KeepScore 
{
    
    public int pinValue;
    [SerializeField] private Vector3 _rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }

     void OnCollisionEnter(Collision col)
    {

       if( col.gameObject.tag == "Ball")
        {
            KeepScore.Score += pinValue;
            ScoreBoardMethod();

        }

       

    }

}

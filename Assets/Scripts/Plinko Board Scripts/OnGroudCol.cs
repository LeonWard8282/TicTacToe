using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace clicker
{
    public class OnGroudCol : MonoBehaviour
    {
        public  ClickPositionManager clickpositionmanager;
        public KeepScore keepScore;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        void OnCollisionEnter(Collision col)
        {

            if (col.gameObject.tag == "Ball")
            {
                clickpositionmanager.toggleclick = false;
                keepScore.togglereset = true;

            }



        }


    }
}
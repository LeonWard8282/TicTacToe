using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace clicker
{

    public class ClickPositionManager : MonoBehaviour
    {
        public float distanceFC = 5f;
        public GameObject ball;
        public LayerMask clickMask;
        public Vector3 ballposition;
        public bool toggleclick = false;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (toggleclick == false)
            {
                OnClick();
            }

        }

        private void OnClick()
        {
            if (Input.GetMouseButtonDown(0))
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100f, clickMask))
                {
                    Vector3 clickPosition = hit.point;
                    Instantiate(ball, clickPosition + new Vector3(ballposition.x, ballposition.y, ballposition.z), Quaternion.identity);

                }
                toggleclick = true;

            }
        }
    }

}
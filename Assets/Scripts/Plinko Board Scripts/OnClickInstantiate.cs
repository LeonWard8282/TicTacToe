using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickInstantiate : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    public GameObject ball ;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        //if(Physics.Raycast(ray, out RaycastHit raycastHit))
        //{
        //    transform.position = raycastHit.point;
        //}

       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerMovement : MonoBehaviour
{
    NavMeshAgent playerAgent;
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveToMouse();
        }
       
    }

    void MoveToMouse()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            playerAgent.SetDestination(hit.point);
        }
    }
}

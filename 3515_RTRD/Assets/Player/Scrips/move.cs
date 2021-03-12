using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class move : MonoBehaviour
{
    private LayerMask clicable;
    private Vector3 mark;
    public Animator anim;
    private NavMeshAgent agent;
    private Camera cam;
    public GameObject marker;
    public bool tuta;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (hit.collider.gameObject.tag == ("floor"))
                {
                    mark = hit.point;
                    marker.transform.position = new Vector3(mark.x, mark.y, mark.z);
                    agent.SetDestination((mark));
                }
            }
        }
        if (tuta)
        {
            anim.SetTrigger("stop");
        }
        else
        {
            anim.SetTrigger("move");
        }
    }
    private void OnTriggerEnter(Collider marker)
    {
        if (marker.name == ("marker"))
            tuta = true;
    }
    private void OnTriggerExit(Collider marker)
    {
        if (marker.name == ("marker"))
            tuta = false;
    }
}

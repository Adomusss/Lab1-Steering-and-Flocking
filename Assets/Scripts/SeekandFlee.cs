using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeekandFlee : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target;
    public float distance = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Seek(Vector3 location)
    {
        agent.SetDestination(location);
    }

    void Flee(Vector3 location) 
    { 
        Vector3 fleeVector = location - this.transform.position;
        agent.SetDestination(this.transform.position - fleeVector);
    }



    // Update is called once per frame
    void Update()
    {

        float vectordistance = Vector3.Distance(agent.transform.position, target.transform.position);

        if (vectordistance > distance)
        {
            Seek(target.transform.position);
        }
        else
        {
            Flee(target.transform.position);
        }
            
    }
}

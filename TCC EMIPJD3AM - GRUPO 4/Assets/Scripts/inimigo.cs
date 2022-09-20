using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]

public class inimigo : MonoBehaviour
{

    public GameObject player;
    private NavMeshAgent navMesh;
    public float distance;
    public float areaDeSeguir;
    public GameObject pInicial;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        navMesh = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        if(distance <= areaDeSeguir)
        {

            navMesh.destination = player.transform.position;

            anim.SetTrigger("run");

        }
        else
        {
            navMesh.destination = pInicial.transform.position;


        }
    }
}

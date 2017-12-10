using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AI;
public class MovePath : MonoBehaviour {
    public Path PathToFollow;
    public int CurrentWayPointID = 0;
    public float speed;
    private float reachDistance = 1.0f;
    public float rotationSpeed = 5.0f;
    public string pathName;
    Vector3 last_position;
    Vector3 current_position;
    private void Start()
    {
       // PathToFollow = GameObject.Find(pathName).GetComponent<Path>();
           last_position = transform.position;
    }
    private void Update()
    {
        float distance = Vector3.Distance(PathToFollow.path_objs[CurrentWayPointID].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, PathToFollow.path_objs[CurrentWayPointID].position, Time.deltaTime * speed);
        if (distance<= reachDistance)
        {
            CurrentWayPointID++;
        }
        if (CurrentWayPointID >= PathToFollow.path_objs.Count)
        {
            CurrentWayPointID = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {
    public Color RayColor = Color.green;
    public List<Transform> path_objs = new List<Transform>();
    Transform   theArray;
	
	void OnDrawGizmos()
    {
        Gizmos.color = RayColor;
        theArray = GetComponentInChildren<Transform> ();
        path_objs.Clear ();

        foreach (Transform path_obj in theArray)
        {
            if (path_obj != this.transform)
            {
                path_objs.Add(path_obj);
            }
        }
        for (int i = 0; i < path_objs.Count; i++)
        {
            Vector3 Position = path_objs[i].position;
            if (i>0)
            {
                Vector3 previus = path_objs[i - 1].position;
                Gizmos.DrawLine(previus, Position);
                Gizmos.DrawWireSphere(Position, 0.3f);
            }
        }
    }
}

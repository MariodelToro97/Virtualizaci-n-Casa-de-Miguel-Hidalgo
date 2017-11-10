using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaciónEscaleraBase : MonoBehaviour {

	Mesh mesh;

	MeshRenderer meshRenderer;

	MeshFilter meshFilter;

	Vector3[] vertices;

	int[] triangles;

	public Material material;

	// Use this for initialization
	void Start () {
		
		meshFilter = gameObject.AddComponent<MeshFilter>();

		meshRenderer = gameObject.AddComponent<MeshRenderer>();

		meshRenderer.material = material;
		meshFilter.transform.RotateAround (Vector3.zero, Vector3.left, 90);
		meshFilter.transform.localPosition = new Vector3 (5.3f, 0f, 10.57f);

		mesh = new Mesh();

		meshFilter.mesh = mesh;

		vertices = new[] {

			new Vector3(0,0,0),

			new Vector3(0,0.3f,0), 

			new Vector3(1.7f,0,0),

			new Vector3(1.7f,0.3f,0)
		};

		mesh.vertices = vertices;

		triangles = new[]{

			0, 1, 2,

			2, 1, 3
		};

		mesh.triangles = triangles;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

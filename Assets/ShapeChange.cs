using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChange : MonoBehaviour
{
  
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Cylinder;


    Mesh cubeMesh;
    Mesh sphereMesh;
    Mesh cylinderMesh;

    // Start is called before the first frame update
    void Start()
    {
        cubeMesh = Cube.GetComponent<MeshFilter>().sharedMesh;
        sphereMesh = Sphere.GetComponent<MeshFilter>().sharedMesh;
        cylinderMesh = Cylinder.GetComponent<MeshFilter>().sharedMesh;
    }

    public void CubeSelected()
    {
        gameObject.GetComponent<MeshFilter>().mesh = cubeMesh;
    }
    public void SphereSelected()
    {
        gameObject.GetComponent<MeshFilter>().mesh = sphereMesh;
    }
    public void CylinderSelected()
    {
        gameObject.GetComponent<MeshFilter>().mesh = cylinderMesh;
    }
    
}

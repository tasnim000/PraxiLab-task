using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDesign
{
    public class ShapeCreation : MonoBehaviour
    {
     
        public GameObject currentShape;
        ShapeFactory ShapeFactory = new ShapeFactory();


        public void CubeSelected()
        {
            Destroy(currentShape);
            Shape cube = ShapeFactory.GetShape("cube");
            currentShape=cube.CreateShape();
          
            currentShape.AddComponent<RotateObj>();
        }
        public void SphereSelected()
        {
            Destroy(currentShape);
            Shape sphere = ShapeFactory.GetShape("sphere");
            currentShape = sphere.CreateShape();
            currentShape.AddComponent<RotateObj>();
        }

        public void CylinderSelected()
        {
            Destroy(currentShape);
            Shape cylinder = ShapeFactory.GetShape("cylinder");
            currentShape = cylinder.CreateShape();
          
            currentShape.AddComponent<RotateObj>();
        }
        public void RedColor()
        {
            if (currentShape.GetComponent<MeshRenderer>() != null)
            currentShape.GetComponent<MeshRenderer>().material.color = Color.red; 
        }
        public void GreenColor()
        {
            if (currentShape.GetComponent<MeshRenderer>() != null)
                currentShape.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        public void BlueColor()
        {
            if (currentShape.GetComponent<MeshRenderer>() != null)
                currentShape.GetComponent<MeshRenderer>().material.color = Color.blue;
        }

        
     
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDesign
{
    public interface Shape
    {
        GameObject CreateShape();
    }

    public class Sphere : Shape
    {
        public GameObject sphere;
        public GameObject CreateShape()
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(0, 1, 0);
            return sphere;
        }
    }

    public class Cylinder : Shape
    {
        public GameObject cylinder;

        public GameObject CreateShape()
        {
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.position = new Vector3(0, 1, 0);
            return cylinder;
        }
    }

    public class Cube : Shape
    {
        public GameObject cube;
        public GameObject CreateShape()
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 1, 0);
            return cube;
        }
    }

    public class ShapeFactory
    {
        public Shape GetShape(string shapename)
        {
            switch (shapename)
            {
                case "cube":
                    return new Cube();
                case "sphere":
                    return new Sphere();
                case "cylinder":
                    return new Cylinder();
                default:
                    return null;
            }
                

        }
    }
}

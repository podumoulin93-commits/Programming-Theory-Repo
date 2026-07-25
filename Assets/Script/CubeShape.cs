using UnityEngine;

// INHERITANCE
public class CubeShape : Shape
{
    private void Start()
    {
        ShapeName = "Cube";
    }

    // POLYMORPHISM
    public override void DisplayInfo()
    {
        Debug.Log("You clicked the " + ShapeName + ".");
    }

    // POLYMORPHISM
    public override void PerformAction()
    {
        RotateCube();
        Debug.Log("The " + ShapeName + " rotates.");
    }

    // ABSTRACTION
    private void RotateCube()
    {
        transform.Rotate(0f, 45f, 0f);
    }
}
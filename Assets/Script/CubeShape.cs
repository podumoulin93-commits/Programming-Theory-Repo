using UnityEngine;

public class CubeShape : Shape
{
    private void Start()
    {
        ShapeName = "Cube";
    }

    public override void DisplayInfo()
    {
        Debug.Log("You clicked the Cube.");
    }

    public override void PerformAction()
    {
        transform.Rotate(0f, 45f, 0f);
        Debug.Log("The Cube rotates.");
    }
}
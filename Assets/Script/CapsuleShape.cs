using UnityEngine;

public class CapsuleShape : Shape
{
    private void Start()
    {
        ShapeName = "Capsule";
    }

    public override void DisplayInfo()
    {
        Debug.Log("You clicked the Capsule.");
    }

    public override void PerformAction()
    {
        transform.position += Vector3.up * 0.5f;
        Debug.Log("The Capsule moves upward.");
    }
}
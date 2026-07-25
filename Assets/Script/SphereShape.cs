using UnityEngine;

public class SphereShape : Shape
{
    private void Start()
    {
        ShapeName = "Sphere";
    }

    public override void DisplayInfo()
    {
        Debug.Log("You clicked the Sphere.");
    }

    public override void PerformAction()
    {
        transform.localScale += Vector3.one * 0.2f;
        Debug.Log("The Sphere grows.");
    }
}
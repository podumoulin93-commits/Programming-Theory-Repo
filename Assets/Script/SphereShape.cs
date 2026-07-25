using UnityEngine;

public class SphereShape : Shape
{
    [SerializeField] private float growthAmount = 0.2f;

    private void Start()
    {
        ShapeName = "Sphere";
    }

    public override void DisplayInfo()
    {
        Debug.Log("You clicked the " + ShapeName + ".");
    }

    public override void PerformAction()
    {
        Grow();
        Debug.Log("The " + ShapeName + " grows.");
    }

    private void Grow()
    {
        transform.localScale += Vector3.one * growthAmount;
    }
}
using UnityEngine;

// INHERITANCE
public class SphereShape : Shape
{
    [SerializeField] private float growthAmount = 0.2f;

    private void Start()
    {
        ShapeName = "Sphere";
    }

    // POLYMORPHISM
    public override void DisplayInfo()
    {
        Debug.Log("You clicked the " + ShapeName + ".");
    }

    // POLYMORPHISM
    public override void PerformAction()
    {
        Grow();
        Debug.Log("The " + ShapeName + " grows.");
    }

    // ABSTRACTION
    private void Grow()
    {
        transform.localScale += Vector3.one * growthAmount;
    }
}
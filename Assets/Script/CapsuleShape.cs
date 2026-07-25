using UnityEngine;

// INHERITANCE
public class CapsuleShape : Shape
{
    [SerializeField] private float moveDistance = 0.5f;

    private void Start()
    {
        ShapeName = "Capsule";
    }

    // POLYMORPHISM
    public override void DisplayInfo()
    {
        Debug.Log("You clicked the " + ShapeName + ".");
    }

    // POLYMORPHISM
    public override void PerformAction()
    {
        MoveUpward();
        Debug.Log("The " + ShapeName + " moves upward.");
    }

    // ABSTRACTION
    private void MoveUpward()
    {
        transform.position += Vector3.up * moveDistance;
    }
}
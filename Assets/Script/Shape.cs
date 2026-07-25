using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] private string shapeName = "Shape";

    // ENCAPSULATION
    public string ShapeName
    {
        get { return shapeName; }

        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                shapeName = "Unnamed Shape";
            }
            else
            {
                shapeName = value;
            }
        }
    }

    private void OnMouseDown()
    {
        HandleClick();
    }

    // ABSTRACTION
    private void HandleClick()
    {
        DisplayInfo();
        PerformAction();
    }

    public virtual void DisplayInfo()
    {
        Debug.Log("You clicked on " + ShapeName);
    }

    public virtual void PerformAction()
    {
        Debug.Log(ShapeName + " performs a basic action.");
    }
}
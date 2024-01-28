using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCollector2D : MonoBehaviour
{
    public List<GameObject> collectedShapes;
    public GameObject drawingPrefab; // Reference to the prefab representing the drawing.

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("home"))
        {
            // Handle collected shape
            CollectShape(other.gameObject);
        }
    }

    void CollectShape(GameObject shape)
    {
        // Add the collected shape to the list
        collectedShapes.Add(shape);

        // Check if the collected shapes match the drawing requirements
        CheckDrawingCompletion();
    }

    void CheckDrawingCompletion()
    {
        // Example: Check if collected shapes match the drawing requirements
        if (CheckShapesMatchDrawing())
        {
            CompleteDrawing();
        }
    }

    bool CheckShapesMatchDrawing()
    {
        // Compare the collected shapes with the shapes needed for the drawing
        // You'll need to implement this logic based on your specific drawings
        // For example, compare the types or names of shapes.
        // Return true if the collected shapes match the requirements.

        // Example: Check if the collected shapes match the shapes needed for a house drawing
        if (collectedShapes.Contains(square) && collectedShapes.Contains(triangle))
        {
            return true;
        }

        return false;
    }

    void CompleteDrawing()
    {
        // Instantiate the prefab representing the completed drawing
        Instantiate(drawingPrefab, transform.position, Quaternion.identity);

        // Clear the collected shapes for the next drawing
        collectedShapes.Clear();
    }
}

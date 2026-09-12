using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float changeInterval = 1.0f;

    private Renderer objectRenderer;
    private float timer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer == null)
        {
            Debug.LogError("ColorChanger requires a Renderer component.");
            enabled = false;
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeInterval)
        {
            ChangeToRandomColor();
            timer = 0f;
        }
    }

    private void ChangeToRandomColor()
    {
        Color newColor = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );

        objectRenderer.material.color = newColor;
    }
}
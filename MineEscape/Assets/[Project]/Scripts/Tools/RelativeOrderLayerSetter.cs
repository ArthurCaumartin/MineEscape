using UnityEngine;
using UnityEngine.Rendering.Universal;

[ExecuteInEditMode]
public class RelativeOrderLayerSetter : MonoBehaviour
{
    [SerializeField] private int _relativeOrderLayer;
    [SerializeField] private Component _referenceRenderer;
    [SerializeField] private Component _targetRenderer;

    private void Update()
    {
        if (Application.IsPlaying(this)) return;
        if (TryGetOrder(_referenceRenderer, out int referenceOrder))
        {
            int targetOrder = referenceOrder + _relativeOrderLayer;
            TrySetOrder(_targetRenderer, targetOrder);
        }
    }

    private bool TryGetOrder(Component target, out int order)
    {
        order = 0;
        if (target is Light2D light2D)
        {
            order = light2D.lightOrder;
            return light2D;
        }

        if (target is SpriteRenderer spriteRenderer)
        {
            order = spriteRenderer.sortingOrder;
            return spriteRenderer;
        }

        if (target is Canvas canvas)
        {
            order = canvas.sortingOrder;
            return canvas;
        }

        return false;
    }

    private void TrySetOrder(Component target, int order)
    {
        if (target is Light2D light2D)
        {
            light2D.lightOrder = order;
            return;
        }

        if (target is SpriteRenderer spriteRenderer)
        {
            spriteRenderer.sortingOrder = order;
            return;
        }

        if (target is Canvas canvas)
        {
            canvas.sortingOrder = order;
            return;
        }
    }
}
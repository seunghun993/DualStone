using UnityEngine;

// 3D 본체는 MeshRenderer.sortingOrdeer로 제어
// UI(Canvas)는 Canvas.sortingOrder로 제어
public class Order : MonoBehaviour
{
    // 3D 렌더러
    [SerializeField] private Renderer[] renderers;
    // UI 캔버스
    [SerializeField] private Canvas frontCanvas;
    // 공통
    [SerializeField] private string sortingLayerName;
    
    private int originOrder;

    // 초기 정렬 순서 저장, 적용
    public void SetOriginOrder(int originOrder)
    {
        this.originOrder = originOrder;
        SetOrder(originOrder);
    }
    
    public void SetMostFrontOrder(bool isMmostFront)
    {
        SetOrder(isMmostFront ? 100 : originOrder);
    }

    public void SetOrder(int order)
    {
        int mulOrder = order * 10;

        // 3D
        foreach (var renderer in renderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = mulOrder;
        }
        
        // UI
        if (frontCanvas != null)
        {
            frontCanvas.sortingLayerName = sortingLayerName;
            frontCanvas.sortingOrder = mulOrder + 1;
        }
    }
}

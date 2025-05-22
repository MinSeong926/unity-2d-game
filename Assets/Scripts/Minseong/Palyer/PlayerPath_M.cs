using UnityEngine;

public class PlayerPath : MonoBehaviour
{
    [SerializeField] private float arrivalRadius = 1.2f;   // �ʿ�� ����

    private void Update()
    {
        var dm = DestinationManager.Instance;
        if (dm == null) return;

        Transform dest = dm.DestinationMarker;
        if (dest == null) return;

        if (Vector3.Distance(transform.position, dest.position) <= arrivalRadius)
        {
            dm.MoveDestination();
        }
    }
}

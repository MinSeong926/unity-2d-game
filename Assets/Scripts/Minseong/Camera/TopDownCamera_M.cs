using UnityEngine;

public class TopDownCamera_M : MonoBehaviour
{
    public Transform target; // �ڵ���
    public Vector3 offset = new Vector3(0, 10, 0); // ������ �Ʒ��� ����

    public float followSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        // �÷��̾� ������ offset��ŭ ��ġ
        Vector3 targetPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);

        // �׻� ������(90��)���� ����
        transform.rotation = Quaternion.Euler(90f, target.eulerAngles.y, 0f);
    }
}

using UnityEngine;

// ��ư�� onClick ����� ����, ��/������ �̵�

public class SkeletonController : MonoBehaviour
{ 
    public GameObject Skeleton;
    public void OnLBTEnter() // OnLBTEnter : �޼ҵ��
    {
        Skeleton.transform.Translate(1, 0, 0);
    }
    public void OnRBTEnter()
    {
        Skeleton.transform.Translate(-1, 0, 0);
    }
 /* ��ư��  OnClick Event how to use (EventSystem �� ������ ���� �Ǿ� �־�� ��)
    1. Button object Click 
    2. Find On Click() + button Click
    3. Apply Object then can use the Function which objcects have componnets
     */

}
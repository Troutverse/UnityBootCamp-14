using UnityEngine;

// 버튼에 onClick 기능을 전달, 왼/오른쪽 이동

public class SkeletonController : MonoBehaviour
{ 
    public GameObject Skeleton;
    public void OnLBTEnter() // OnLBTEnter : 메소드명
    {
        Skeleton.transform.Translate(1, 0, 0);
    }
    public void OnRBTEnter()
    {
        Skeleton.transform.Translate(-1, 0, 0);
    }
 /* 버튼의  OnClick Event how to use (EventSystem 은 무조건 생성 되어 있어야 함)
    1. Button object Click 
    2. Find On Click() + button Click
    3. Apply Object then can use the Function which objcects have componnets
     */

}
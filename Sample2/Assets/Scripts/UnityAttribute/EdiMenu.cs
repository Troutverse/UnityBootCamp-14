using UnityEngine;
// 에디터 모드 상태에서 Update, OnEnable, OnDisable의 실행을 진행 할 수 있습니다.
// Play를 누르지 않아도 Editor 에서 Update 등을 설게한 기능들을 실행 해볼 수 있습니다.
// [ExecuteInEditMode]
public class EdiMenu : MonoBehaviour
{   
    private void Update()
    {
        if (!Application.isPlaying)
        {
            Vector3 Pos = transform.position;
            Pos.y = 0;
            transform.position = Pos;
            Debug.Log("Editor Test.. 이 스크립트를 낀 오브젝트는 Y축이 0으로 고정됩니다.");
        }
    }
    
}

using UnityEngine;
// 키(Key)와 값(Value)
// 키(Key)   : 값에 접근하기 위한 데이터, 키는 고유한 이름을 가지게 됨
// 값(Value) : 키를 통해서 얻을 수 있는 실질적인 값

// 키와 값이 한 쌍으로 관리되는 데이터는 키가 삭제되면, 값도 같이 삭제
// "키"를 통해 값을 조회하고, 추가하고, 삭제하는 과정을 매우 빠르게 진행할 수 있음

// Unity 내에서 사용 되는 해당 형태의 데이터
// 1. Dictionary<K,V> : C#에서 제공되는 표준 자료 구조
// 2. PlayerPrefs : Unity에서 제공하는 키-값 저장 시스템(클래스)
// 3. JSON : 외부에서 작성된 json 파일도 키-값의 형태로 작성할 수 있
// 4. ScriptableObject : 자체적으로는 제공이 안되나 Dictionary와 섞여서 사용

// PlayerPrefs
// 간단한 데이터를 저장할 때 사용되는 데이터 저장 시스템
// 복잡한 데이터나 큰 용량을 요구하는 데이터 저장에는 부적합

// 주로 고려되는 상황 : 점수, 플레이어의 진행 상태, 게임 설정 값(해상도, 컨트롤, 볼륨..)

// 장점 : 즉각적이고 간편한 저장 / 로드에 대한 구현에서는 편함
//       플렛폼 별로의 저장 경로, 포맷 걱정 없이 사용
//       ex) Window -> 레지스트리 경로, Mac -> /Library/Preferences/Unity.[company].[projectname].plist (plist 파일)
//           IOS -> ios 내부 저장소, Android -> XML 파일(앱 데이터), WebGL -> 플랫폼별 브라우저 지원에 맞는 저장소
// 단점 : 플레이가 편집이 가능한 영역 => 보안성이 낮음
public class PlayerPrefsTester : MonoBehaviour
{
    public int score;
    public int max_score = 10;
    private void Start()
    {
        score = PlayerPrefs.GetInt("score"); // 해당 키가 존재하지 않는다면 적어준 값이 return 됩
        PlayerPrefs.SetInt("MaxScore", max_score); // Key = MaxScore, Value = max_score

        PlayerPrefs.Save(); // 스크립트에 의한 저장을 강제로 호출, 없어도 자동으로 저장은 됨
        
        Debug.Log(score);
        Debug.Log(PlayerPrefs.GetInt("MaxScore"));
    }
    public void ResetPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}

using UnityEngine;

public class LifeCylce : MonoBehaviour
{
    void Awake() // 게임 오브젝트 실행될때, 최초 실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
    void OnEnable() // 오브젝트 활성화
    {
        Debug.Log("플레이어 로그인");
    }
    void Start() // 업데이트 시작 직전, 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() // 물리 연산 업데이트 , 고정된 실행 주기로 CPU를 많이 사용한다.
    {
        Debug.Log("이동");
    }
    void Update() // 게임 로직 업데이트, 환경에 따라 실행 주기가 달라진다
    {
        Debug.Log("몬스터 사냥");
    }

    void LateUpdate() // 모든 업데이트가 끝난 후 호출, 카메라, 후처리 등
    {
        Debug.Log("경험치 획득.");
    }
    void OnDisable()  // 게임 오브젝트 비활성화
    {
        Debug.Log("플레이어 로그아웃");
    }

    void OnDestroy() // 게임 오브젝트가 삭제될 때 
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}

using UnityEngine;

public class LifeCylce : MonoBehaviour
{
    /*private void Start()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); // 벡터 값
        transform.Translate(vec);   // 벡터 값을 현재 위치에 더하는 함수
    }*/


    void Update() // 게임 로직 업데이트, 환경에 따라 실행 주기가 달라진다
    {
        // 업데이트에서 실행시 계속 실행 
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); // 벡터 값
        transform.Translate(vec);   // 벡터 값을 현재 위치에 더하는 함수

        

        /*if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        //Down, Stay , UP 

        if (Input.GetKeyDown(KeyCode.Return))  // 누르면 한번 호출 // Return = 엔터
        {
            Debug.Log("아이템을 구입하였습니다.");
        }
        if (Input.GetKey(KeyCode.LeftArrow))  // 누르고 있으면 호출
            Debug.Log("왼쪽으로 이동중");
        if (Input.GetKeyUp(KeyCode.RightArrow))   // 떼면 호출
            Debug.Log("오른쪽으로 이동을 멈추었습니다.");

        if (Input.GetMouseButtonDown(0))  //누르면 한번 호출
            Debug.Log("미사일 발사!");
        if (Input.GetMouseButton(0))   // 누르고 있으면 호출
            Debug.Log("미사일 모으는 중");
        if (Input.GetMouseButtonUp(0))  // 떼면 호출
            Debug.Log("슈퍼 미사일 발사");

        //버튼 방식
        // Edit -> Input Manager 에서 확인 가능
        if (Input.GetButtonDown("Jump"))  // Jump와 같은 이름은 변경 가능
            Debug.Log("점프");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중..");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));// 수평, 수직 버튼을 입력 받으면 Float
        }                    // GetAxis -> 가중치를 가짐 (꾹 눌러야 상승)
         // GetAxisRaw() : 무조건 -1, 1을 반환 동시에 누르면 0 */



}


}

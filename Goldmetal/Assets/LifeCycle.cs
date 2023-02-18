using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Awake() 오브젝트가 장면안에 생성될때 최초로 실행되는 함수, 한번만 실행됨
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    // 업데이트 시작 직전, 최초 실행, 한번만 실행됨
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // 물리 연산 업데이트될때 실행, 고정적으로 꾸준히 실행됨, 자원을 많이 사용
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    // 게임 로직 업데이트, 주기적으로 변하는 로직을 넣을때 사용, 환경에 따라서 실행 주기가 바뀔 수 있음, 프레임마다 실행
    void Update()
    {
        Debug.Log("몬스터 사냥~");
    }

    // Update영역 후에 실행, 캐릭터 따라가는 카메라같은것이나 Update 후처리 등 사용
    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }
    
    // 오브젝트 삭제 직전에 실행됨
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}

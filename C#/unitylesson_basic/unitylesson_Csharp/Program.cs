// using 키워드
// using 뭔가를 사용하겠다 라고 선언하는 키워드
// System 이라는걸 사용하겠다. 라는 뜻
// using은 언제쓰냐?
// 예시) 네임스페이스 정의
// 만약에 unitylesson_Csharp 라는 namespace의 클래스 등 정보를 가져와 쓰고싶다
// -> using unitylesson_Csharp라고 스크립트 최상단에 선언해줌
// 예시2) 우선순위가 차순위인 함수 호출
// Unityengine.Physics, Unity.Physics
// 두가지 중 기본적으로는 Unityengine.Physics가 우선순위
// 두 네임스페이스 모두 Raycast()라는 함수를 포함하고 있다.
// But 나는 Unity.Physics.Raycast()를 쓰고 싶다
// 일반적으로 Raycast()를 호출하면 Unityengine.Physics.Raycast() 가 호출됨
// using Raycast = Unity.Physics.Raycast;
// 라고 해주면 Raycast() 호출했을 때 Unity.Physics.Raycast()가 호출됨
using System;

// namespace 키워드
// 클래스 간의 멤버 이름 충돌을 방지함
namespace unitylesson_Csharp
{
    // Program class
    // 모든 프로젝트는 처음 실행파일(.exe)을 통해 실행될 때에
    // Main() 함수를 실행하며
    // C# 에서는 Main  함수조차도 객체지향컨셉에 맞게 Program이라는 클래스 안에 선언되어 있음
    static class Program
    {
        // static 키워드
        // static(정적)은 dynamic(동적)의 반대 개념 키워드
        // static은 상황, 조건에 따라 메모리에 할당할 수 없는 성질
        // dynamic은 상황, 조건에 따라 메모리에 할당할 수 있는 성질
        // Main 함수는 static으로 정의되었으므로 하나만 존재할 수 있다.
        //
        // 만약에 class에 static이 붙는다.
        // 그러면 그에 딸린 모든 변수나 함수도 static 이어야함.
        // 

        // void 자료형
        // void 반환값이 없다.
        // 함수의 기본형태 : 입력 -> 기능수행 -> 출력
        // void를 반환하는 함수는 :입력 -> 기능수행

        // args ?
        // arguments 인자, 인수
        // 함수에서 받을 입력
        // 표기방법은 함수 이름 뒤에 괄호열고 "자료형" "인자이름" 형태로 써준다.
        static void Main(string[] args)
        {
            // console ?
            // Using으로 선언했던 System 이라는 namespace 안에 있는 클래스 
            Console.WriteLine(1.90);
        }
    }
}

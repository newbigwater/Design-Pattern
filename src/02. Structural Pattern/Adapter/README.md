# Adapter Pattern - 단계별 개선

## Ver1
- 파일: `Adapter_Print_Ver1`, `Adapter_PrintBanner_Ver1`
- 특징: 기존 `abstract class` 기반 Target에 맞춰 Adapter 구현
- 목적: 기존 코드(클래스 계층)와 호환되게 어댑팅

## Ver2 (상속 방법, Class Adapter)
- 파일: `Adapter_IPrint_Ver2`, `Adapter_PrintBanner_ClassAdapter_Ver2`
- 방식: `Adapter_Banner`를 상속하고 Target 인터페이스를 구현
- 장점: 코드가 단순하고 위임 코드가 적음
- 제약: C# 단일 상속 제약으로 다른 기반 클래스와 동시 상속 불가

## Ver3 (합성 방법, Object Adapter)
- 파일: `Adapter_PrintBanner_ObjectAdapter_Ver3`
- 방식: `Adapter_Banner`를 필드로 보유하고 위임(Composition)
- 장점: 상속 제약이 없고 런타임 교체/테스트가 쉬움
- 개선점: `null` adaptee 방어 코드 추가

## 테스트
- `src/unitTest/02. Structural Pattern/02. Structural Pattern - Adapter.cs`
  - Ver1 동작 검증
  - Ver2(상속) 동작 검증
  - Ver3(합성) 동작 + null 방어 검증

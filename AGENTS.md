# 저장소 가이드라인

## 워크플로우 참조
상세 실행 단계, 체크리스트, 문서 작성 절차는 [`WORKFLOW.md`](D:\20. Areas\Design-Pattern\WORKFLOW.md)를 따른다.

`WORKFLOW.md`와 `AGENTS.md` 규칙이 충돌하면 `AGENTS.md`를 우선 적용한다.

- `AGENTS.md` 문서는 한국어 기준으로 작성 및 유지한다.

## 프로젝트 구조 및 모듈 구성
`src/`에는 Visual Studio 솔루션 [`_buildAll.sln`](D:\20. Areas\Design-Pattern\src\_buildAll.sln)과 C# 프로젝트가 있다. 패턴 예제는 `01. Creational Pattern/`, `02. Structural Pattern/`, `03. Behavioral Pattern/`으로 구분한다. 콘솔 진입점은 `src/app/`에 둔다. 단위 테스트는 `src/unitTest/`에 패턴 구조를 반영해 배치한다. 저장소 문서는 `doc/`, 재사용 템플릿/참고 자료는 `00. System/`에 둔다.

초기 학습 자료는 패턴별 `Version 01/` 폴더에 둔다. 예: `src/01. Creational Pattern/AbstractFactory/Version 01/`.
패턴 개선 시 `Version 02/`, `Version 03/`처럼 버전을 순차 추가한다. 각 버전은 반드시 독립적으로 유지하며, 동일 클래스가 여러 버전에 존재하면 버전별 파일을 각각 두고 버전 간 소스 참조를 만들지 않는다.

## 작업 진행 표준 순서
특정 경로와 함께 `작업 진행` 요청이 들어오면 아래 순서를 반드시 따른다.

1. 코드 리뷰
2. 개선된 버전 기능 추가
3. 관련 코드 유닛 테스트 코드 작성
4. Scenario Unit Test 추가/확장
5. Doc 작성
6. README 작성

## 외부 레퍼런스 저장소 검토 규칙
사용자가 GitHub 저장소 URL(예: `https://github.com/...`)을 함께 제공하면 아래를 반드시 수행한다.

1. 원격 저장소의 패턴별 `Main`/`*Test`/실행 예제를 우선 검토한다.
2. 현재 저장소의 동일 패턴 Unit Test에 기본 로직 테스트 + Scenario 테스트를 모두 반영한다.
3. 시나리오 테스트는 단순 타입 검증이 아니라 실행 흐름(입력/연쇄/상태 전이/결과 순서)을 검증한다.
4. 반영한 시나리오 기준(원본 파일 경로 또는 동등 시나리오)을 문서(`doc/`)에 요약한다.

## 에이전트 책임
사용자가 특정 패턴 폴더를 제공하면 해당 폴더를 기준 학습 버전으로 먼저 검토하고, 아래 산출물을 제공한다.

- `Version 02/`부터 시작하는 점진적 개선 버전
- 구조 변경이 큰 경우 버전당 하나의 구조 변경
- 단계별 개선 내용을 설명하는 `doc/` 문서
- 대응되는 `src/unitTest/` MSTest 커버리지

하나의 큰 변경을 작은 단계로 설명할 수 있다면 중간 설계 단계를 생략하지 않는다.

## 빌드/테스트/개발 명령
특별한 지시가 없으면 저장소 루트에서 실행한다.

- `msbuild src\\_buildAll.sln /p:Configuration=Debug`: Debug 전체 빌드
- `msbuild src\\_buildAll.sln /p:Configuration=Release`: Release 전체 빌드
- `vstest.console.exe src\\unitTest\\bin\\Debug\\unitTest.dll`: Debug 빌드 후 MSTest 실행
- `devenv src\\_buildAll.sln`: Visual Studio에서 솔루션 열기

패키지 복원 오류가 발생하면 Visual Studio에서 `packages/` 의존성을 복원한 뒤 다시 빌드한다.

## 코딩 스타일 및 네이밍 규칙
들여쓰기는 공백 4칸, 중괄호 스타일은 기존 C# 규칙을 따른다. 네이밍은 저장소 기존 스타일을 유지한다.

- 타입: `Adapter_PrintBanner_Ver1`처럼 PascalCase + 패턴 접두어
- private 필드: `_banner`처럼 언더스코어 접두어
- 테스트 메서드: `Adapter_Ver3_Throws_On_Null_Adaptee`처럼 동작 중심 PascalCase
- 신규 파일은 해당 패턴 폴더와 네임스페이스에 맞춰 배치

기존 클래스를 수정할 때는 기존 `#region` 구조를 유지한다.

## 테스트 가이드라인
테스트 프레임워크는 .NET Framework 4.8 대상 MSTest(`Microsoft.VisualStudio.TestTools.UnitTesting`)를 사용한다. 관련 partial 테스트 클래스와 같은 위치의 `src/unitTest/<pattern group>/`에 테스트를 추가/수정한다. 정상 동작과 null/잘못된 상태 같은 경계 케이스를 모두 다룬다. 테스트 하나당 검증 주제는 가급적 하나로 유지하고, 메서드 이름은 검증 동작을 드러내도록 작성한다.

동일 패턴에 여러 버전 폴더가 있으면 버전별 독립 검증이 가능하도록 테스트를 추가/확장한다.

- 패턴별로 최소 1개 이상의 Scenario Unit Test를 유지한다.
- Scenario Unit Test는 가능하면 원본 학습 코드의 `Main` 흐름과 입력 시퀀스를 재현한다.
- Scenario Unit Test 추가 시 기존 기본 로직 테스트를 대체하지 말고 함께 유지한다.

## 문서 동기화
- `doc/`에 신규 문서를 추가하면 반드시 `README.md`의 해당 패턴 카테고리 목록에도 링크를 추가한다.

## 커밋 및 Pull Request 가이드라인
최근 커밋 스타일은 `Refactor pattern docs to unified format`, `Normalize angle-bracket notation in docs and template`처럼 짧은 명령형 제목이다. 커밋 제목은 간결하고 동작 중심으로 작성한다.

- Commit Log는 한국어로 상세히 작성한다.
- Commit Log 및 문서/설명 문구에 `AI가 작업한 결과물` 또는 유사 표현을 절대 추가하지 않는다.
- 모든 설명과 산출물 서술은 한국어 기반으로 작성한다.
- 한국어 인코딩 깨짐 여부를 반드시 확인하고, 깨짐이 발견되면 정상화될 때까지 재작업 후 완료 처리한다.

Pull Request에는 아래 내용을 포함한다.

- 패턴 또는 문서 변경 요약
- 변경 사유 또는 연계 이슈
- 코드 변경 시 테스트 결과
- Markdown 첨부물/렌더링 문서가 실질적으로 바뀐 경우에만 스크린샷 첨부

## 금일 작업 방식 (2026-04-15)
Builder 패턴 작업을 기준으로 아래 방식을 저장소 표준으로 추가한다.

1. 외부 GitHub 레퍼런스 사용 시 원본 `Main`/`*Test`/실행 예제를 먼저 확인하고, 변환 기준 파일 경로를 `doc/`에 명시한다.
2. 버전 폴더는 `Version 01`만 예외로 두지 않고 `Version 01`, `Version 02`, `Version 03` 모두 동일한 하위 구조(예: `effecivejava/`, `GOF/`)를 유지한다.
3. 버전별 코드는 단일 대형 파일 대신 클래스 단위 파일 분리를 기본으로 한다.
4. 버전 간 소스 참조를 만들지 않고, 동일 클래스는 버전별로 독립 파일을 유지한다.
5. Unit Test는 버전별 기본 로직 테스트와 Scenario 테스트를 함께 유지한다.
6. Scenario 테스트는 원본 실행 흐름의 입력 순서/연쇄 호출/상태 전이/결과 순서를 검증한다.
7. 패턴 문서는 버전별로 `Pseudo Code`와 `PlantUML`을 모두 포함한다.
8. 문서/README/MOC 링크를 같은 작업 단위에서 동기화한다.
9. Git 작업 전 사용자 환경(`user.name`, `user.email`, branch, staged 파일 범위)을 확인하고, 개인 환경 파일(예: `.obsidian/workspace.json`)은 기본적으로 커밋에서 제외한다.

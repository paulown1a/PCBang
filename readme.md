# 개관


# 기능
피씨방의 고객과 관리자 사이의 소통 프로그램으로
기본적으로 인기게임 및 게임장르에 따른 빠른 접속 기능과 고객과 관리자 사이의 실시간 채팅이 가능하며 
추가적으로 고객측에서는 음식주문과 시간추가를 자리에서 요청 할 수 있으며, 관리자의 자리에서는
전체 손님의 현황과 매출을 실시간으로 확인 할 수 있게 해주는 프로그램입니다.



# 사용기술
### 언어
* C# 3.0+

### 프레임워크
* .NET Framework 4.8
* Winform
* Entity Framework

### 서드파티 컨트롤
* DevExpress

### 데이터베이스
* MS-SQL Server 2019

# 데이터베이스 스키마
![Schema](Documents/schema.png)



# Point of Interest
* 고객과 관리자간의 실시간 채팅 가능
![Chatting](Documents/chatting.png)
* 관리자 프로그램 분리, 관리 효율 증대
![Managerform](Documents/managerform.png)
* 음식 주문에 따른 금액 동기화
* ![Foodorder](Documents/foodorder.png)
* 사용 금액을 토대로 나눈 회원 등급
* 인기 게임 순위 목록
* 타이머를 이용한 남은 시간 계산 (현재 단위는 분으로 설정되어있지만 개발과정의 편리성을 위해 2초에 1분씩 줄어들게 설계)
* 각 게임 장르로 구분된 폴더에 빠른 접속기능
* ![Main Form](Documents/MainForm.png)

# 미해결 부분
* 월간 게임순위
* 환불 계산
* 결제방법 선택
* 음식주문 창 열시 전체화면 축소
* 관리자가 고객 강제사용종료 기능 미구현
* 클라이언트의 빠른 로그아웃 기능 미구현
* 메인폼 여백 미구현
* 
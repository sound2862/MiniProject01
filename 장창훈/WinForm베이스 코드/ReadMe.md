##사용법

사전 조건.
- sql에 DB가 작성되어있을것. SQL (테이블 제작) 파일 복붙해서 작성.
- DatabaseUtil클래스 내의 sql아이디 비번 확인할것 (제것과 다를가능성 있으므로).

0. sql의 DB를 가져올 DataGridView1,2,3,4를 만든다.
1. 29줄~ 의 DatabaseUtil 클래스를 가져온다.
2. 10줄 의 private DatabaseUtil Util = new DatabaseUtil(); 코드를 가져와서 객체를 만든다.
3. 24,25 처럼 변수에 저장해서 사용한다.
   이때, Util.GetCellValue()는 (원하는 테이블명, 행, 열) 순으로 채워넣는다

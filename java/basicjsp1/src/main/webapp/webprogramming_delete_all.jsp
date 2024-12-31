<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.sql.Connection" %>
<%@ page import="java.sql.DriverManager" %>
<%@ page import="java.sql.PreparedStatement" %>
<%@ page import="java.sql.SQLException" %>
<%@ page import="java.sql.ResultSet" %>
<%@ page import="com.company1.DBManager" %>
<%
	// 한글 처리
	request.setCharacterEncoding("UTF-8");

	// 실제 DB에서 삭제하는 코드
	Connection conn = DBManager.getDBConnection();
	
	String sql = "DELETE FROM study1";
	int rows = 0;
	try {
		// 실제 DELETE SQL쿼리 실행
		//PreparedStatement 얻기 및 값 지정
		PreparedStatement pstmt = conn.prepareStatement(sql);
		
		// SQL문을 진짜 실행
		rows = pstmt.executeUpdate(); // 리턴값은 실제 delete한 행의 개수
		
		// DB자원 정리
		DBManager.dbClose(conn, pstmt, null);
	} catch (Exception e) {
		e.printStackTrace();
		//exit();
	}
%>
모두 삭제되었습니다.
<script>
	location.href = './webprogramming.jsp';
</script>


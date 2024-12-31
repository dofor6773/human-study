package ch20.oracle.sec05;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConnectionExample {
	public static void main(String[] args) {
		Connection conn = null;
		
		try {
			// JDBC 드라이버 등록
			Class.forName("oracle.jdbc.OracleDriver");
			// 등록된 드라이버를 실제 Connection 클래스 변수에 연결
			conn = DriverManager.getConnection(
					"jdbc:oracle:thin:@localhost:1521/orcl",
					"test3",
					"1234"
			);
			// DB연결 성공 출력
			System.out.println("연결 성공");
		} catch(ClassNotFoundException cnfe) {
			cnfe.printStackTrace();
			System.err.println("Class.forName에서 에러 발생");
		} catch(SQLException se) {
			se.printStackTrace();
			System.err.println("DriverManager.getConnection에서 에러 발생");
		} finally {
			try {
				if (conn != null) {
					// DB연결 끊기
					conn.close();
				}
				System.out.println("연결 끊기");
			} catch(SQLException se) {
				se.printStackTrace();
				System.err.println("conn.close에서 에러 발생");
			}
		}
	}
}

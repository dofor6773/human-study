package ch11.sec06;

// 사용자 정의 예외 클래스
public class InsufficientException extends Exception {
	public InsufficientException() {
		
	}
	
	public InsufficientException(String message) {
		super(message);
	}
}

package ch06.exercise;

public class Account {
	// balance필드는 음수값이 될 수 없다
	// balance필드는 최대 백만까지 지정 가능
	// balance필드는 0 ~ 1,000,000까지의 값만 저장 가능
	// 외부에서 balance필드를 마음대로 변경 불가능
	// getter, setter메소드 이용
	private int balance = 0;
	static final int MIN_BALANCE = 0;
	static final int MAX_BALANCE = 1000000;
	
	public int getBalance() {
		return balance;
	}
	
	public void setBalance(int balance) {
		if(balance >= MIN_BALANCE && balance <= MAX_BALANCE) {
			this.balance = balance;
		}
	}	
}

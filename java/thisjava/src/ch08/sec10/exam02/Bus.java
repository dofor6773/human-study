package ch08.sec10.exam02;

public class Bus implements Vehicle {
	// Vehicle에 있는 추상 메소드를 재정의
	@Override
	public void run() {
		System.out.println("버스가 달린다");
	}
	
	public void checkFare() {
		System.out.println("승차요금을 체크합니다");
	}
}

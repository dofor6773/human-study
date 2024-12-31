package ch06.sec07.exam05;

public class Car {
	// 필드 선언
	String company = "현대";  // 회사이름
	String model;
	String color;
	int maxSpeed;
	
	int gas;	// 남아있는 연료량
	
	// 생성자 선언(생성자 오버로딩을 이용)
	Car() { // 기본 생성자
		
	}
	Car(String model) {
		this(model, "은색", 250);
	}
	Car(String model, String color) {
		this(model, color, 250);
	}
	Car(String model, String color, int maxSpeed) {
		this.model = model;
		this.color = color;
		this.maxSpeed = maxSpeed;
	}
	
	// 메소드 선언
	boolean isLeftGas() {
		if(gas == 0) { // 연료량 0이면
			System.out.println("gas가 없습니다");
			return false;
		}
		System.out.println("gas가 있습니다");
		return true;
	}
}

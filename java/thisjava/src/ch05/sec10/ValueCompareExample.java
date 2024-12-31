package ch05.sec10;

public class ValueCompareExample {
	public static void main(String[] args) {
		//-128~127 초과값일 경우(false)
		Integer obj1 = 300;
		Integer obj2 = 300;
		System.out.println("==: " + (obj1 == obj2)); // false
		System.out.println("equals(): " + obj1.equals(obj2)); // true
		System.out.println();

		//-128~127 범위값일 경우(true)
		Integer obj3 = 10;
		Integer obj4 = 10;
		System.out.println("==: " + (obj3 == obj4));   // true
		System.out.println("equals: " + obj3.equals(obj4));  // true
		
		// 결론은 값 비교시에는 equals메소드만 쓰자!!!!!
	}
}

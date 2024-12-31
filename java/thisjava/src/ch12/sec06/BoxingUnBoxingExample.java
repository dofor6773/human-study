package ch12.sec06;

public class BoxingUnBoxingExample {

	public static void main(String[] args) {
		//Boxing
		Integer obj = 100;
		System.out.println("value: " + obj.intValue());
		Double objDouble = 1.0;
		System.out.println("value: " + objDouble.doubleValue());
		
		//Unboxing
		int value = obj;
		System.out.println("value: " + value);
		
		//연산 시 Unboxing
		int result = obj + 100;
		System.out.println("result: " + result);
		
		String a = "1";
		String b = "1";
		
		System.out.println(a.hashCode());  // 49
		System.out.println(b.hashCode());  // 49 
	}

}

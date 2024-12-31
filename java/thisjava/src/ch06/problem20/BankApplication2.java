package ch06.problem20;

import java.util.Scanner;

public class BankApplication2 {

	static Scanner scanner = new Scanner(System.in);
	static Account[] accountArray = new Account[100];
	
	public static void main(String[] args) {
		boolean run = true;
		while(run) {
			System.out.println("--------------------------------------------------------------");
			System.out.println("1. 계좌생성 | 2. 계좌목록 | 3. 예금 | 4. 출금 | 5. 종료 | 10. 계좌삭제");
			System.out.println("--------------------------------------------------------------");
			System.out.print("선택> ");
			
			// switch문에 Enum Type으로 사용을 하여 코드 작성(189페이지 코드 참고)
			
		}
		System.out.println("프로그램 종료");
	}
	
	/**
	 * 계좌 생성 메소드
	 * @return
	 */
	private static boolean createAccount() {  // return값은 계좌가 성공적으로 개설시 true, 실패면 false
		boolean isCreateAccountSuccess = true;
		
		System.out.println("----------");
		System.out.println("계좌생성");
		System.out.println("----------");
		
		System.out.print("계좌번호: ");
		String accountNo = scanner.nextLine();
		System.out.print("계좌주: ");
		String accountMasterName = scanner.nextLine();
		System.out.print("초기입금액: ");
		int balance = Integer.parseInt(scanner.nextLine());
		
		for(int i = 0; i < accountArray.length; i++) {
			if(accountArray[i] == null) {
				accountArray[i] = new Account(accountNo, accountMasterName, balance);
				break;
			} else {
				while(accountArray[i].getAmn().equals(accountNo)) { // 기존의 계좌번호가 같으면 다시 만드는 작업
					System.out.print("중복된 계좌번호가 있습니다. 다시 계좌번호 입력해 주세요.");
					accountNo = scanner.nextLine();
					
					if(!accountArray[i].getAmn().equals(accountNo)) {
						System.out.println("결과: 계좌가 생성되었습니다.");
						return isCreateAccountSuccess;
					}
				}
			}
		}
		System.out.println("결과: 계좌가 생성되었습니다.");
		
		return isCreateAccountSuccess;
	}
	
	/**
	 * 계좌 목록 가져오기
	 */
	private static void listAccount() {
		System.out.println("----------");
		System.out.println("계좌목록");
		System.out.println("----------");
		
		for(int i = 0; i < accountArray.length; i++) {
			if(accountArray[i] != null) {
				System.out.println(
					accountArray[i].getAno() + "   " + 
					accountArray[i].getAmn() + "   " + 
					accountArray[i].getBalance()
				);
			}
		}
	}
	
	/**
	 * 예금하기
	 */
	private static void deposit() {
		System.out.println("----------");
		System.out.println("예금");
		System.out.println("----------");
		System.out.print("계좌번호: ");
		String ano = scanner.nextLine();
		System.out.print("예금액: "); // ex) 1000
		int money = Integer.parseInt(scanner.nextLine());
		
		// 100개의 account에서 계좌번호가 일치하는 계좌만 가져오기
		for(int i = 0; i < accountArray.length; i++) {
			// 계좌번호가 일치하는 계좌를 찾을 경우
			if(accountArray[i] != null 						     // 계좌번호가 있는 계좌일 경우
				&& ano.equals(accountArray[i].getAno())			 // 입력한 계좌번호가 있는 경우
				&& (accountArray[i].getBalance() + money) >= 0   // 예금액 0원 이상일 경우
			) {
				accountArray[i].setBalance(money);
				break;
			}
		}
	}

	/**
	 * 출금하기
	 */
	private static void withdraw() {
		System.out.println("----------");
		System.out.println("출금");
		System.out.println("----------");
		System.out.print("계좌번호: ");
		String ano = scanner.nextLine();
		System.out.print("예금액: "); // ex) 1000
		int money = -Integer.parseInt(scanner.nextLine());
		
		// 100개의 account에서 계좌번호가 일치하는 계좌만 가져오기
		for(int i = 0; i < accountArray.length; i++) {
			// 계좌번호가 일치하는 계좌를 찾을 경우
			if(accountArray[i] != null 						     // 계좌번호가 있는 계좌일 경우
				&& ano.equals(accountArray[i].getAno())			 // 입력한 계좌번호가 있는 경우
				&& (accountArray[i].getBalance() + money) >= 0   // 출금금액을 하고 난 이후 0원 이상일 경우
			) {
				accountArray[i].setBalance(money);
				break;
			}
		}
	}
}

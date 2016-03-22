package com.Hanjunchen.UnixCSVJoining;

import java.util.Scanner;

public class Program {
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		CSVScanner scanner1;
		CSVScanner scanner2;
		int joinType;
		JoinMethods joinMethods;
		
		if(args[1] == null){
			System.out.println("Please indicate the CSV files you want to load \n");
		}
		
		else if (args[3] == null){
			Scanner keyboardInput = new Scanner (System.in);
			//System.out.print("please select join type \n");
			System.out.println("Please select a join type \n");
			System.out.print("1, Nested Loop Join");
			joinType = keyboardInput.nextInt();
			scanner1 = new CSVScanner (args[1]);
			scanner2 = new CSVScanner (args[2]);
			keyboardInput.close();
			joinMethods = new JoinMethods(scanner1, scanner2, Integer.toString(joinType));
		}
		
		else {
			scanner1 = new CSVScanner (args[1]);
			scanner2 = new CSVScanner (args[2]);
			joinMethods = new JoinMethods(scanner1, scanner2,args[2]);
		}
	}

}

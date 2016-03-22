package com.Hanjunchen.UnixCSVJoining;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class CSVScanner {
	private String table;
	Scanner scanner;
	public CSVScanner(String filename) {
		try{
			scanner = new Scanner(new File(filename));
         	scanner.useDelimiter(",");
         	while(scanner.hasNext()){
         		//table.concat(scanner.next());
         		System.out.print(scanner.next()+"|");
         	}
         	scanner.close();
		}
		catch (FileNotFoundException e){
			e.printStackTrace();
		}
    }
	
	public String getTable(){ return table;}
}

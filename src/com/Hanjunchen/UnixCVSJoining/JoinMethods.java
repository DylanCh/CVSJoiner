package com.Hanjunchen.UnixCSVJoining;

public class JoinMethods {
	public JoinMethods(CSVScanner scanner1, CSVScanner scanner2, String joinType){
		switch(joinType){
		case "1":
			nestedLoopJoin(scanner1,scanner2);
			break;
		case "2":
			colocatedJoin(scanner1,scanner2);
			break;
		
		case "3":break;
		}
	}
	// codes can be found here http://theparticle.com/cs/bc/dbsys/idxjoin.pdf
	private void nestedLoopJoin(CSVScanner scanner1, CSVScanner scanner2){
		/*
		for( int i =0; i<table1.length ; i ++)
		for( int j =0; j<table2 . length ; j++)
		
		if( table1[ i ].joinkey = table2 [ j ].joinkey )
			out ( table1 [ i ] , table2 [ j ] );
			*/
	}

	private void colocatedJoin(CSVScanner scanner1,CSVScanner scanner2){
		/* 
		for(int i =0; i<table1 . length ; i ++)
			 hashkey = hash ( table1 [ i ] . id , table1 [ i ] . name ) ;
		 send_to_machine ( table1 [ i ] ,  hashkey % n);
		 */
	}
}

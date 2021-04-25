public class ModulusAnimation {
	public static void main( String[] args ) throws Exception {
		for ( int i=0; i<80; i++ ) {
			if ( i%11 == 0 )
				System.out.print("hi.......... \r");
			else if ( i%11 == 1 )
				System.out.print(".hi......... \r");
			else if ( i%11 == 2 )
				System.out.print("..hi........ \r");
			else if ( i%11 == 3 )
				System.out.print("...hi....... \r");
			else if ( i%11 == 4 )
				System.out.print("....hi...... \r");
			else if ( i%11 == 5 )
				System.out.print(".....hi..... \r");
			else if ( i%11 == 6 )
				System.out.print("......hi.... \r");
			else if ( i%11 == 7 )
				System.out.print(".......hi... \r");
			else if ( i%11 == 8 )
				System.out.print("........hi.. \r");
			else if ( i%11 == 9 )
				System.out.print(".........hi. \r");
			else if ( i%11 == 10 )
				System.out.print("..........hi \r");

			Thread.sleep(200);
		}
		
	}
}
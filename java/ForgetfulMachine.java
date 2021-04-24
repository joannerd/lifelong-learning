import java.util.Scanner;

public class ForgetfulMachine {
  public static void main( String[] args ) {
    Scanner keyboard = new Scanner(System.in);

    String word;
    String secondWord;
    int favNum;
    int secondFavNum;

    System.out.print("Give me a word! ");
    word = keyboard.next();

    System.out.print("Give me a second word! ");
    secondWord = keyboard.next();

    System.out.print("Great, now your favorite number? ");
    favNum = keyboard.nextInt();
    
    System.out.print("And your second favorite number... ");
    secondFavNum = keyboard.nextInt();

    System.out.println("Whew! Wasn't that fun?");
  }
}
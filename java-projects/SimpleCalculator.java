import java.util.Scanner;

public class SimpleCalculator {
  public static void main( String[] args ) {
    Scanner keyboard = new Scanner(System.in);
    
    float firstNum;
    float secondNum;
    float thirdNum;

    System.out.print("What is your first number? ");
    firstNum = keyboard.nextFloat();

    System.out.print("What is your second number? ");
    secondNum = keyboard.nextFloat();

    System.out.print("What is your third number? ");
    thirdNum = keyboard.nextFloat();

    float resultNum = (firstNum + secondNum + thirdNum) / 2;

    String output = "( " + firstNum + " " + secondNum + " " + thirdNum + " ) / 2 is... " + resultNum;

    System.out.println(output);
  }
}
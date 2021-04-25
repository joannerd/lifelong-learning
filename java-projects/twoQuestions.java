import javax.swing.*;

public class twoQuestions {
  public static void main ( String[] args ) {
    String questionOne = JOptionPane.showInputDialog("Question 1) Is it animal, vegetable, or mineral?");
    
    String questionTwo = JOptionPane.showInputDialog("Question 2) Is it bigger than a breadbox?");

    String guess = "";
    if (questionOne.equals("animal")) {
      guess = questionTwo.equals("yes") 
      ? "It's a squirrel."
      : "It's a moose.";
    } else if (questionOne.equals("vegetable")) {
      guess = questionTwo.equals("yes") 
      ? "It's a watermelon."
      : "It's a carrot.";
    } else if (questionOne.equals("mineral")) {
      guess = questionTwo.equals("yes") 
      ? "It's a Camaro."
      : "It's a paper clip.";
    }

    System.out.println(guess);

    System.exit(0);
  }
}
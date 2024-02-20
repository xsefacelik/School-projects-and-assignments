import java.awt.Color;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

import enigma.console.Console;
import enigma.console.TextAttributes;
import enigma.core.Enigma;

public class PrintFunctions {
	Utilities utility = new Utilities();
	static Console console = Enigma.getConsole("CENG SOLITAIRE", 80, 30, 20);
	Scanner scanner = new Scanner(System.in);
	Player player = new Player("" , 0);
	
	public void printMenu() throws InterruptedException {
		fixedBackground();
		
		//menu walls
		console.getTextWindow().setCursorPosition(25 , 8);
		System.out.println("OOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		console.getTextWindow().setCursorPosition(25 , 12);
		System.out.println("OOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		console.getTextWindow().setCursorPosition(25 , 16);
		System.out.println("OOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		console.getTextWindow().setCursorPosition(25 , 20);
		System.out.println("OOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		console.getTextWindow().setCursorPosition(25 , 24);
		System.out.println("OOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		for (int i = 8; i < 25; i++) {
			console.getTextWindow().setCursorPosition(25 , i);
			System.out.println("OO");
			console.getTextWindow().setCursorPosition(54 , i);
			System.out.println("OO");
		}
		
		
		//menu
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		console.getTextWindow().setCursorPosition(36 , 10);
		System.out.println("<< MENU >>");
		console.getTextWindow().setCursorPosition(35 , 14);
		System.out.println("1- Play Game");
		console.getTextWindow().setCursorPosition(35 , 18);
		System.out.println("2- High Score");
		console.getTextWindow().setCursorPosition(35 , 22);
		System.out.println("3- Exit Game");
		
		
		//menu input
        // Get the menu selection from user
        boolean isValidMenuInput = false;
        String validMenuInputs = "123";
        String menuInput;
        do {
        	console.getTextWindow().setCursorPosition(39 , 26);
    		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
            menuInput = scanner.nextLine();
            if (validMenuInputs.contains(menuInput) && menuInput.length() < 2)
                isValidMenuInput = true;

            else if (!isValidMenuInput) {
            	console.getTextWindow().setCursorPosition(27 , 26);
                System.out.println("Please enter a valid option");
                Thread.sleep(1000);
                console.getTextWindow().setCursorPosition(27 , 26);
                System.out.println("                           ");
            }

        } while (!isValidMenuInput);
        
        
        //menu cases
        console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
        switch (menuInput) {
            case "1": {
            	utility.cleanConsole();
            	printGameScreen();
            	console.getTextWindow().setCursorPosition(63 , 16);
            	break;
            }
            case "2": {
            	utility.cleanConsole();
            	console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
            	printHighScore();
            	break;
            }
            case "3": {
            	console.getTextWindow().setCursorPosition(26 , 26);
                System.out.println("The CENG SOLITAIRE Is Closing");
            	try {
                    Thread.sleep(3000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
                System.exit(0);
                break;
            }
        }
	}
	public void printGameScreen(){
		fixedBackground();
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		console.getTextWindow().setCursorPosition(29, 6);
		System.out.println("Please Enter Your Name: ");
		console.getTextWindow().setCursorPosition(35 , 7);
		String name = scanner.nextLine();
		scanner.close();
		player.setName(name);
		player.setScore(0);
		fixedBackground();
		//columns
		console.getTextWindow().setCursorPosition(11 , 6);
		System.out.println("OOOOO");
		console.getTextWindow().setCursorPosition(20 , 6);
		System.out.println("OOOOO");
		console.getTextWindow().setCursorPosition(29 , 6);
		System.out.println("OOOOO");
		console.getTextWindow().setCursorPosition(38 , 6);
		System.out.println("OOOOO");
		console.getTextWindow().setCursorPosition(47 , 6);
		System.out.println("OOOOO");
		for (int i = 7; i < 26; i++) {
			console.getTextWindow().setCursorPosition(11 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(15 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(20 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(24 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(29 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(33 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(38 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(42 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(47 , i);
			System.out.println("O");
			console.getTextWindow().setCursorPosition(51 , i);
			System.out.println("O");
		}
		console.getTextWindow().setCursorPosition(11 , 26);
		System.out.println("OOOOO");
		console.getTextWindow().setCursorPosition(20 , 26);
		System.out.println("OOOOO");
		console.getTextWindow().setCursorPosition(29 , 26);
		System.out.println("OOOOO");
		console.getTextWindow().setCursorPosition(38 , 26);
		System.out.println("OOOOO");
		console.getTextWindow().setCursorPosition(47 , 26);
		System.out.println("OOOOO");
		
		
		//box
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		console.getTextWindow().setCursorPosition(62 , 14);
		System.out.println("BOX");
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.WHITE));
		console.getTextWindow().setCursorPosition(60 , 15);
		System.out.println("OOOOOOO");
		console.getTextWindow().setCursorPosition(60 , 16);
		System.out.println("OO");
		console.getTextWindow().setCursorPosition(65 , 16);
		System.out.println("OO");
		console.getTextWindow().setCursorPosition(60 , 17);
		System.out.println("OOOOOOO");
		
		//score
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		console.getTextWindow().setCursorPosition(60 , 19);
		System.out.println("SCORE: " + player.getScore());
		
		//columns with numbers.
		printColumnsNumbers();
	}
	public void printColumnsNumbers() {
	
		String column1Str = Columns.column1.display();
		String column2Str = Columns.column2.display();
		String column3Str = Columns.column3.display();
		String column4Str = Columns.column4.display();
		String column5Str = Columns.column5.display();
		
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
	
		for (int i = 0; i < column1Str.split(" ").length; i++) {
			console.getTextWindow().setCursorPosition(13 , 7 + i);
			System.out.println(column1Str.split(" ")[i]);
		}
		for (int i = 0; i < column2Str.split(" ").length; i++) {
			console.getTextWindow().setCursorPosition(22 , 7 + i);
			System.out.println(column2Str.split(" ")[i]);
		}
		for (int i = 0; i < column3Str.split(" ").length; i++) {
			console.getTextWindow().setCursorPosition(31 , 7 + i);
			System.out.println(column3Str.split(" ")[i]);
		}
		for (int i = 0; i < column4Str.split(" ").length; i++) {
			console.getTextWindow().setCursorPosition(40 , 7 + i);
			System.out.println(column4Str.split(" ")[i]);
		}
		for (int i = 0; i < column5Str.split(" ").length; i++) {
			console.getTextWindow().setCursorPosition(49 , 7 + i);
			System.out.println(column5Str.split(" ")[i]);
		}
	}
	public void printHighScore() {
		fixedBackground();
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		if(player.getScore() != 0.0)
			Solitaire.dll.orderedAdd(player);
		
		String[] dllDisplayPlayers = Solitaire.dll.display1().split(":");
		for (int i = 0; i < dllDisplayPlayers.length; i++) {
			console.getTextWindow().setCursorPosition(34, 13 + i );
			String[] playerAtt = dllDisplayPlayers[i].split(" ");
			System.out.println(playerAtt[0] + " : " + playerAtt[1] + "\n");
		}
		
		try {
		      FileWriter myWriter = new FileWriter("./src/HighScoreTable.txt");
		      for (int i = 0; i < dllDisplayPlayers.length; i++) {
		    	  myWriter.write(dllDisplayPlayers[i].split(" ")[0] + " : " + dllDisplayPlayers[i].split(" ")[1] + "\n");
			}
		      myWriter.close();
		    } catch (IOException e) {
		      e.printStackTrace();
		    }
	}
	
	public void fixedBackground() {
		utility.cleanConsole();
		//fixed background
		console.getTextWindow().setCursorPosition(0 , 0);
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                 CENG SOLITAIRE                                ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		System.out.println("                                                                               ");
		
		
		//main walls
		console.setTextAttributes(new TextAttributes(Color.WHITE, Color.WHITE));
		console.getTextWindow().setCursorPosition(0 , 0);
		System.out.println("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		console.getTextWindow().setCursorPosition(0 , 4);
		System.out.println("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		console.getTextWindow().setCursorPosition(0 , 28);
		System.out.println("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		for (int i = 0; i < 29; i++) {
			console.getTextWindow().setCursorPosition(0 , i);
			System.out.println("OO");
			console.getTextWindow().setCursorPosition(77 , i);
			System.out.println("OO");
		}
	}
}

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Yahtzee {
	int turn = 1;
	SLL player1 = new SLL();
	SLL player2 = new SLL();
	int player1Score;
	int player2Score;
	
	SLL scoresNames = new SLL(); 
	SLL scores = new SLL();
	
	Yahtzee () {
		readScores();
		sortScores();
		gamePlay();
		addPlayersToScores();
		printScores();
	}
	
	
	//Game flow function.
	public void gamePlay()  {
		while(turn != 11) {  //Allows 10 rounds to advance.
			
			for (int i = 0; i < 3; i++) {       //Adds three numbers to each player.
				player1.addFromEnd(generateRandomDiceNumber());
				player2.addFromEnd(generateRandomDiceNumber());
			}
			
			checkForSet();		//Checks if a set of six is ​​formed.
			checkForSame();		//Checks if a quad match has occurred.
			
			System.out.println("Turn: " + turn);     //Print the players displays.
			System.out.println("Player 1: " + player1.display() + "\t\t Score: " + player1Score);
			System.out.println("Player 2: " + player2.display() + "\t\t Score: " + player2Score);
			turn++;
			System.out.println();
		}
		
	}
	
	
	//Checks for match.
	public void checkForSet() {
		//looks for each dice number and increments the counter when found. If it gets 6 it will delete it from the SLL.
		
		int setForPlayer1 = 0;
		int setForPlayer2 = 0;
		
		for (int i = 1; i < 7; i++) {
			if(player1.search(i) == true)
				setForPlayer1++;
			if(player2.search(i) == true)
				setForPlayer2++;
		}
		
		if (setForPlayer1 >= 6) {
			player1Score += 40;
			setRemoverForPlayer1();
		}
		if (setForPlayer2 >= 6) {
			player2Score += 40;
			setRemoverForPlayer2();
		}
		
	}
	public void checkForSame() {
		//Transfers each sll to another sll deletes the dice number and looks at change.
		//If the change is more than 3 it will delete that number 4 times.
		
		SLL temp1 = new SLL();
		SLL temp2 = new SLL();
		String[] player1Arr = player1.display().split(" ");
		String[] player2Arr = player2.display().split(" ");
		int size1 = player1.size();
		int size2 = player2.size();
		
		for (int i = 0; i < player1.size(); i++) {
			temp1.addFromEnd((Integer.parseInt(player1Arr[i])));
		}
		for (int i = 0; i < player2.size(); i++) {
			temp2.addFromEnd((Integer.parseInt(player2Arr[i])));
		}
		
		for (int i = 1; i < 7; i++) {
			temp1 = temp1.deleteAll(i);
			temp2 = temp2.deleteAll(i);
			
			if(size1 >= temp1.size() + 4) {
				sameRemoverForPlayer1(i);
				player1Score += 10;
			}
			
			if(size2 >= temp2.size() + 4) {
				sameRemoverForPlayer2(i);
				player2Score += 10;
			}
			
			
			temp1 = new SLL();
			temp2 = new SLL();
			for (int j = 0; j < player1.size(); j++) {
				temp1.addFromEnd((Integer.parseInt(player1Arr[j])));
			}
			for (int j = 0; j < player2.size(); j++) {
				temp2.addFromEnd((Integer.parseInt(player2Arr[j])));
			}
		}	
	}
	
	
	// They are used to delete when a match is made or a set occurs.
	public void setRemoverForPlayer1() {
		player1 = player1.deleteOnce(1);
		player1 = player1.deleteOnce(2);
		player1 = player1.deleteOnce(3);
		player1 = player1.deleteOnce(4);
		player1 = player1.deleteOnce(5);
		player1 = player1.deleteOnce(6);
	}
	public void setRemoverForPlayer2() {
		player2 = player2.deleteOnce(1);
		player2 = player2.deleteOnce(2);
		player2 = player2.deleteOnce(3);
		player2 = player2.deleteOnce(4);
		player2 = player2.deleteOnce(5);
		player2 = player2.deleteOnce(6);
	}	
	public void sameRemoverForPlayer1(int delete) {
		for (int i = 0; i < 4; i++) {
			player1 = player1.deleteOnce(delete);
		}
	}
	public void sameRemoverForPlayer2(int delete) {
		for (int i = 0; i < 4; i++) {
			player2 = player2.deleteOnce(delete);
		}
	}
	
	
	//Determines a random number of dice.
	public int generateRandomDiceNumber() {
		int randomDice =  (int) (Math.random() * 6 + 1);
		return randomDice;
	}
	
	
	//Reads the initial txt and adds it to the SLL.
	public void readScores() {	
		try {
            File scoresFile = new File("./src/highScore.txt");
            Scanner myReader = new Scanner(scoresFile);
            while (myReader.hasNextLine()) {
                String data = myReader.nextLine();
                scoresNames.addFromEnd(data.split(" ")[0]);
                scores.addFromEnd(Integer.parseInt(data.split(" ")[1]));
            }
            myReader.close();

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
	}
	//Sort score SLLs. 
	public void sortScores() {
		//Sorts the score sll and changes the name sll at the same time.
		
		SLL resultSllscores = new SLL();
		SLL resultSllnames = new SLL();
	    while(scores.size() != 0)              
	    {
	    	int tempValueScore = (int) scores.pop();
	    	String tempValueName = (String)scoresNames.pop();
	        while(resultSllscores.size() != 0 && (int)resultSllscores.peekFirst() > tempValueScore) {
	        	scoresNames.addFromStart(resultSllnames.pop());
	        	scores.addFromStart(resultSllscores.pop());
	        }
	        resultSllscores.addFromStart(tempValueScore);
	        resultSllnames.addFromStart(tempValueName);
	    }
	    scoresNames = resultSllnames;
	    scores = resultSllscores;
	}
	//adds the player to the scoreboard according to the score.
	public void addPlayersToScores() {
		//Adds to sll if the player's score is greater than the last player's score.
		
		if(player1Score > (int)scores.peekLastNode()) {
			scores.addFromEnd(player1Score);
			scoresNames.addFromEnd("Player_1");
			sortScores();
		}
		if(player2Score > (int)scores.peekLastNode()) {
			scores.addFromEnd(player2Score);
			scoresNames.addFromEnd("Player_2");
			sortScores();
		}
	}
	//Prints scores by reading SLLs.
	public void printScores() {
		//Transfers slls to two other slls and pops cleans and prints each element from temp slls.
		
		SLL resultSllscores = new SLL();
		SLL resultSllnames = new SLL();
	    while(scores.size() != 0)              
	    {
	    	int tempValueScore = (int) scores.pop();
	    	String tempValueName = (String)scoresNames.pop();
	    	resultSllscores.addFromStart(tempValueScore);
	        resultSllnames.addFromStart(tempValueName);
	    }
	    resultSllscores = resultSllscores.reverse();
	    resultSllnames = resultSllnames.reverse();
	    
	    for (int i = 1; i < 11; i++) {
			System.out.println(i + "- " + resultSllnames.pop() + "\t\t" + resultSllscores.pop());
		}
	}
	
	
	
}

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Random;
import java.util.Scanner;

public class WheelOfFortune {

	Stack countriesStack = new Stack(12);
	Stack lettersStack = new Stack(26);
	Stack wheelStack = new Stack(8);
	Stack nameStack = new Stack(10);
	Stack scoreStack= new Stack(10);
	public String step = "1";
	public int score = 0;
	
	public WheelOfFortune() {
		getCountriesInFile();
		createLettersStack();
		countriesStack = sortStack(countriesStack);		
		createWheelStack(wheelStack);
		getScoresFromFile();
		printMenu();
		
		// searchElementInQueue, queueReader, isThereAnyDash is not working.
		
	}
	void getCountriesInFile() {									//I add the word in each line to the stack of cities.
		try {
		      File myObj = new File("./src/countries.txt");
		      Scanner myReader = new Scanner(myObj);
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        countriesStack.push(data);
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
	}
	void createLettersStack() {									//I read the letters as an index and add them to the stack one by one.

		String letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		for (int i = 0; i < letters.length(); i++) {
			lettersStack.push(letters.substring(i, i + 1));
		}
		lettersStack = sortStack(lettersStack);
	}
	void createWheelStack(Stack wheelStack) {					//I add wheel stack items to wheel stack.
		//10, 50, 100, 250, 500, 1000, Double Money, and Bankrupt
		wheelStack.push(10);
		wheelStack.push(50);
		wheelStack.push(100);
		wheelStack.push(250);
		wheelStack.push(500);
		wheelStack.push(1000);
		wheelStack.push("Double Money");
		wheelStack.push("Bankrupt");
	}
	void getScoresFromFile() {									//I split each line in the score text from spaces and add it to the name and score stack.
		try {
		      File myObj = new File("./src/scores.txt");
		      Scanner myReader = new Scanner(myObj);
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        String[] splittedData = data.split(" ");
		        nameStack.push(splittedData[0]);
		        scoreStack.push(splittedData[1]);
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
	}
	
	void printMenu() {
		///////////////////////////////////////////////get input for menu
		System.out.println("Menu:\n1- Start Game\n2-High Score Table\n3-Exit\nPlease select an options...");
		Scanner scanner = new Scanner(System.in);
		// Get the menu selection from user
		boolean isValidMenuInput = false;
		String validMenuInputs = "123";
		String menuInput;
		do {
			menuInput = scanner.nextLine();
			if (validMenuInputs.contains(menuInput) && menuInput.length() < 2) //I'm checking the input.
				isValidMenuInput = true;
			else if (!isValidMenuInput) {
				System.out.println("Please enter a valid option");
			}
			
		} while (!isValidMenuInput);
		
		switch (menuInput){								
		case "1":
			System.out.println("WELCOME TO WHEEL OF FORTUNE!");
			Queue country = randomCountryQueueCreater(countriesStack);
			Queue nullQ = dashQCreater(country.size());
			
			
			while(isThereAnyDash(nullQ)) {
				
				String wheel = randomWheel(wheelStack);
				printLevel(nullQ, lettersStack, step, score, wheel);

				
		        //////////////////////////////////////////////////////guess input
				Scanner scanner2 = new Scanner(System.in);
				// Get the menu selection from user
				boolean isValidGuessInput = false;
				String validGuessInputs = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
				String guess;
				do {
					guess = scanner2.nextLine();
					if (validGuessInputs.contains(guess) && guess.length() < 2)   //I'm checking the input.
						isValidGuessInput = true;
						
					else if (!isValidGuessInput) {
						System.out.println("Please enter a valid letter...");
					}
				} while (!isValidGuessInput);
				scanner2.close();
				scanner.close();
				
				//I scan the guessed letter in queue.
				String guessIndex = searchElementInQueue(country, guess);		           
				String[] guessIndexArr = guessIndex.split(",");					 
				for (String index : guessIndexArr) {
					if (!guessIndex.equals(""))
						nullQ = changeQueueIndex(nullQ, Integer.parseInt(index), guess);   //I am changing the objects in the queue according to the incoming indexes.
				}
				
				///////////////////////////////////////////I change the score according to the wheel output.
				if(wheel.equals("Double Money"))
					score *= 2;
				else if(wheel.equals("Bankrupt"))
					score = 0;
				else
					score *= Integer.parseInt(wheel);
				
				///////////////////////////////////////////I increase step for new level.
				int tampStep = Integer.parseInt(step) + 1;
				step = String.valueOf(tampStep);
				
				///////////////////////////////////////////I'm removing the used letter from the stack.
				delIndexFromStack(lettersStack, convertLetterToIndex(guess.charAt(0)));
			}
			break;
		case "2":
			System.out.println("High Score");		//Could not be completed.
			break;
		case "3":
			System.out.print("\n> Thanks for playing!");
			try {
				Thread.sleep(3000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			System.exit(0);
			break;
		}
	}
	//The function where I suppress the values ​​and texts that are constant for each level.
	void printLevel(Queue nullQ, Stack lettersStack, String step, int score, String wheel) {
	
		System.out.println("Word:  " + String.valueOf(queueReader(nullQ)) + "     Step: " + step + "     Score: " + score + "     " + stackReader(lettersStack));
		System.out.println(wheel);
		System.out.println("Guess: ");
	}
	//The function where I sort the stack.
	Stack sortStack(Stack main) {
	
	    Stack resultStack = new Stack(main.size());			 //The result stack.
	    while(!main.isEmpty())                               //I check and replace or add an element in the result stack until the main stack is empty.
	    {
	    	String tempValue = String.valueOf(main.pop());
	        while(!resultStack.isEmpty() && String.valueOf(resultStack.peek()).compareTo(tempValue) < 0) {
	        	main.push(resultStack.pop());
	        }
	        resultStack.push(tempValue);
	    }
	    return resultStack;
	}
	//The function where I suppress the value of an index on the stack.
	Object returnIndexFromStack(Stack main, int index) {
		Object result;
		
		Stack tempStack = new Stack(index + 1);
		while (!tempStack.isFull()) {			//I transfer elements to a stack one more length than the index I'm peeking for and return the last element I added.
			tempStack.push(main.pop());
		}
		result = tempStack.peek();
		while(!tempStack.isEmpty()) {
			main.push(tempStack.pop());
		}
	    
		return result;
	}
	Stack delIndexFromStack(Stack main, int index) {
		Stack resultStack = new Stack(main.size() - 1);
		Stack tempStack = new Stack(index);
	    
	    while (!tempStack.isFull()) {
			tempStack.push(main.pop());
		}
	    main.pop();
	    while (!tempStack.isEmpty()) {
	    	main.push(tempStack.pop());
		}
	    
	    while(!main.isEmpty()) {
	    	resultStack.push(main.pop());
	    }
	    resultStack = sortStack(resultStack);
	    
		return resultStack;
	}
	//Function that returns a random wheel element.
	String randomWheel(Stack main) {
		String randomWheel = "";
		int random = getRandomNumber(0,8);
		randomWheel = String.valueOf(returnIndexFromStack(wheelStack, random));
		return randomWheel;
	}
	//The function where I combine all the elements in the stack with the help of an empty auxiliary stack.
	String stackReader(Stack main) {
		Stack tempStack = new Stack(main.size());
		String result = "";
		while(!main.isEmpty()) {
			result += main.peek();
			tempStack.push(main.pop());
		}
		while(!main.isFull())
			main.push(tempStack.pop());
		return result;
	}
	
	//Random integer generating function.
	public int getRandomNumber(int min, int max) {
		Random random = new Random();
		int value = random.nextInt(max + min) + min;

		return value;
	}
	//Function that returns the alphabetical order of the letter.
	public static int convertLetterToIndex(char letter) {
		String alphabet = "abcdefghijklmnopqrstuvwxyz";
		return alphabet.indexOf(letter);
	}
	
	//Function that takes a random element from the country stack and assigns it to a queue.
	Queue randomCountryQueueCreater(Stack countriesStack) {
		String country = String.valueOf(returnIndexFromStack(countriesStack, getRandomNumber(0, countriesStack.size())));
		Queue couuntryQueue = new Queue(country.length());
		
		for (int i = 0; i < country.length(); i++) {
			couuntryQueue.enqueue("" + country.charAt(i));
		}
		
		return couuntryQueue;
	}

	//Function that changes the specific index in queue.
	Queue changeQueueIndex(Queue main, int index, Object element) {
		Queue tempQueue = new Queue(main.size());

		int i = 0;
	    while(!tempQueue.isFull()) {
	    	if(i != index) {
	    		tempQueue.enqueue(main.dequeue());
	    		i++;
	    	}
	    	else {
	    		tempQueue.enqueue(element);
	    		main.dequeue();
	    		i++;
	    	}
	    }
	    return tempQueue;
	}
	//Function that scans the elements in the queue and returns the searched indexes.(The function gives a queue overflow error and unfortunately I couldn't figure it out.)
	String searchElementInQueue(Queue main, Object element) {
		String indexes = "";
		Queue tempQueue = new Queue(main.size());
		
		int i = 0;
		while(!tempQueue.isFull()) {
			Object objectToBeCompared = main.peek();
			tempQueue.enqueue(main.dequeue());

			if (objectToBeCompared.equals(element))
				if (indexes.equals(""))
					indexes += i;
				else	
					indexes += "," + i; 
			i++;
		}
		main = tempQueue;

		return indexes;
	}
	//Function that iterates the elements in the queue and converts them to a string.(The function gives the same queue overflow error and unfortunately I couldn't figure it out.)
	String queueReader(Queue main) {
		Queue tempQueue = new Queue(main.size());
		String result = "";
		while(!main.isEmpty()) {
			result = result + main.peek();
			tempQueue.enqueue(main.dequeue());
		}
		while(!tempQueue.isEmpty())
			main.enqueue(tempQueue.dequeue());
		return result;
	}
	//Function that creates a queue of dashes of the entered length.
	Queue dashQCreater(int size) {
		Queue result = new Queue(size);
		for (int i = 0; i < size; i++) {
			result.enqueue("-");
		}
		return result;
	}
	//Function that returns true if there is a dash in the queue.(The function gives the same queue overflow error and unfortunately I couldn't figure it out.)
	boolean isThereAnyDash(Queue main) {
		Queue tempQueue = new Queue(main.size());
		boolean isThereDash = false;
		while(!main.isEmpty()) {
			if (main.peek().equals("-")) {
				isThereDash = true;
				tempQueue.enqueue(main.dequeue());
			}
			else
				tempQueue.enqueue(main.dequeue());
		}
		
		while(!tempQueue.isEmpty())
			main.enqueue(tempQueue.dequeue());
		
		return isThereDash;
	}
}

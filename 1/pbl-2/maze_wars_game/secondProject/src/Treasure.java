import java.awt.Color;

import enigma.console.Console;
import enigma.console.TextAttributes;
import enigma.core.Enigma;
import secondProject.Utilities;

public class Treasure {
    // properties
    private char sign;
    private int value;
    private boolean movingAbility;
    
    //Game Game = new Game();
    public Object[] treasurePossibilityArray = new Object[40];
    Console console = Enigma.getConsole("Star Trek Warp Wars", 250, 55,10);
    Utilities utilities = new Utilities();
    Print print = new Print();
    ArrayFunction arrayFunctions = new ArrayFunction();
    FileRead fileReader = new FileRead();

    // constructor
    public Treasure(char sign, int value, boolean movingAbility) {
        this.sign = sign;
        this.value = value;
        this.movingAbility = movingAbility;
    }
    
    public Treasure() {
        
    }


    // getters and setters
    public char getSign() {
        return sign;
    }
    public void setSign(char sign) {
        this.sign = sign;
    }

    public int getValue() {
        return value;
    }
    public void setValue(int value) {
        this.value = value;
    }

    public boolean isMovingAbility() {
        return movingAbility;
    }
    public void setMovingAbility(boolean movingAbility) {
        this.movingAbility = movingAbility;
    }
    
    //this method controls the timing of 4 and 5
    public void controlTheSpeedOf4And5(long t){


        Game.endTime4And5 = utilities.countTime(t);
        if ((Game.endTime4And5 - Game.startTime4And5) >= 1){
            move4And5();
            Game.computer.computerMove();
            Game.startTime4And5 = utilities.countTime(t);
        }
    }
    //this method moves 4 and 5
    public void move4And5(){
        for (int i = 0; i < Game.indexNumbersOf4And5.length; i++) {

            boolean flag = false;

            int direction;
            String[] indexes = Game.indexNumbersOf4And5[i].split(",");
            int row = Integer.parseInt(indexes[0]);
            int column = Integer.parseInt(indexes[1]);

            if(Game.mapArr[row][column] instanceof Player) {
            	arrayFunctions.dellIndexInArray(Game.indexNumbersOf4And5,i);
                continue;
            }

        	/*
        	int direction;
        	String[] indexes;
        	int row;
            int column;
        	do
        	{
        		direction = generateRandomNumber(4);
        		indexes = indexNumbersOf4And5[i].split(",");
        		row = Integer.parseInt(indexes[0]);
                column = Integer.parseInt(indexes[1]);
        	}while(!((char)mapArr[row][column] == '4' || (char)mapArr[row][column] == '5'));
            */
            do
            {
                direction = utilities.generateRandomNumber(4);
                if (direction == 0 && !(Game.mapArr[row - 1][column] instanceof Treasure || Game.mapArr[row - 1][column] instanceof Computer || Game.mapArr[row - 1][column] instanceof Player) &&(char) Game.mapArr[row - 1][column] == ' ') {
                	Game.moveTheSign("up", Game.mapArr[row][column],column + 80,row + 16,new TextAttributes(Color.MAGENTA));
                    row--;
                    flag = true;
                } else if (direction == 1 && !(Game.mapArr[row + 1][column] instanceof Treasure || Game.mapArr[row + 1][column] instanceof Computer || Game.mapArr[row + 1][column] instanceof Player) && (char) Game.mapArr[row + 1][column] == ' ') {
                	Game.moveTheSign("down", Game.mapArr[row][column],column + 80,row + 16,new TextAttributes(Color.MAGENTA));
                    row++;
                    flag = true;
                } else if (direction == 2 && !(Game.mapArr[row][column - 1] instanceof Treasure || Game.mapArr[row][column - 1] instanceof Computer || Game.mapArr[row][column-1] instanceof Player) && (char) Game.mapArr[row][column - 1] == ' ') {
                	Game.moveTheSign("left", Game.mapArr[row][column],column + 80,row + 16,new TextAttributes(Color.MAGENTA));
                    column--;
                    flag = true;
                } else if (direction == 3 && !(Game.mapArr[row][column + 1] instanceof Treasure || Game.mapArr[row][column + 1] instanceof Computer || Game.mapArr[row][column+1] instanceof Player) && (char) Game.mapArr[row][column + 1] == ' ') {
                	Game.moveTheSign("right", Game.mapArr[row][column],column + 80,row + 16,new TextAttributes(Color.MAGENTA));
                    column++;
                    flag = true;
                }
            }while(!flag);

            Game.indexNumbersOf4And5[i] = row + "," + column;
        }
        console.setTextAttributes(new TextAttributes(Color.WHITE));
    }
    //this method is for adjusting possibilities of treasures
    public void createTreasurePossibilityArray() {

        for (int i = 0; i < 40; i++) {
            if(i<12)
                treasurePossibilityArray[i] = '1';
            else if(i<20)
                treasurePossibilityArray[i] = '2';
            else if(i<26)
                treasurePossibilityArray[i] = '3';
            else if(i<31)
                treasurePossibilityArray[i] = '4';
            else if(i<35)
                treasurePossibilityArray[i] = '5';
            else if(i<37)
                treasurePossibilityArray[i] = '=';
            else if(i<38)
                treasurePossibilityArray[i] = '*';
            else if(i<40)
                treasurePossibilityArray[i] = 'C';
        }
        // creating input queue
        for (int i = 0; i < 15; i++){
            int number = utilities.generateRandomNumber(40);
            char sign = (char)treasurePossibilityArray[number];
            int value = 0;
            boolean movementAbility = false;
            if(sign != 'C')
            {
            	switch(sign)
                {
                	case '1':
                		value = 1;
                		break;
                	case '2':
                		value = 5;
                		break;
                	case '3':
                		value = 15;
                		break;
                	case '4':
                		value = 50;
                		movementAbility = true;
                		break;
                	case '5':
                		value = 150;
                		movementAbility = true;
                		break;
                }
            	Treasure treasure = new Treasure(sign, value, movementAbility);
            	Game.inputQueue.enqueue(treasure);
            }
            else 
            {
            	Computer computer = new Computer('C');
            	Game.inputQueue.enqueue(computer);
            }
        }
    }
    //this method creates 20 elements at the beginning of the game.
    public void createTwentyElementForStart () {
        for (int i = 0; i < 20; i++) {
            int randomTreasureIndex = utilities.generateRandomNumber(40);
            int randomMapIndex = utilities.generateRandomNumber(Game.spaceAreaIndex.length);
            String[] positionArr = Game.spaceAreaIndex[randomMapIndex].split(",");
            
            Game.spaceAreaIndex = arrayFunctions.dellIndexInArray(Game.spaceAreaIndex, randomMapIndex);
            char sign = (char)treasurePossibilityArray[randomTreasureIndex];
            int value = 0;
            boolean movementAbility = false;
            if(sign != 'C')
            {
            	switch(sign)
                {
                	case '1':
                		value = 1;
                		break;
                	case '2':
                		value = 5;
                		break;
                	case '3':
                		value = 15;
                		break;
                	case '4':
                		value = 50;
                		movementAbility = true;
                		break;
                	case '5':
                		value = 150;
                		movementAbility = true;
                		break;
                }
            	Treasure treasure = new Treasure((char)treasurePossibilityArray[randomTreasureIndex], value, movementAbility);
                Game.mapArr[Integer.parseInt(positionArr[0])][Integer.parseInt(positionArr[1])] = treasure;
            }
            else 
            {
            	Computer computer = new Computer('C');
                Game.mapArr[Integer.parseInt(positionArr[0])][Integer.parseInt(positionArr[1])] = computer;
            }
            
            
        }
    }
    


}

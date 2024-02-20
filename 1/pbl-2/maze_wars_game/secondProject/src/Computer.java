import java.awt.Color;

import enigma.console.Console;
import enigma.console.TextAttributes;
import enigma.core.Enigma;
import secondProject.Utilities;

public class Computer {
    // properties
    private char sign;
    private int score;
    private Coordinate coordinates;
    private String target;

    //Game Game = new Game();
    Console console = Enigma.getConsole("Star Trek Warp Wars", 250, 55,10);
    Utilities utilities = new Utilities();
    Print print = new Print();
    ArrayFunction arrayFunctions = new ArrayFunction();
    FileRead fileReader = new FileRead();
    
    String[] indexesAndGainsOf1;
    String[] indexesAndGainsOf2;
    String[] indexesAndGainsOf3;
    String[] indexesAndGainsOf4;
    String[] indexesAndGainsOf5;
    String[] indexesAndGainsOfAll;
    
    

    // constructor
    public Computer(char sign) {
        this.sign = sign;
        coordinates = new Coordinate(1,1);
        //target = targetLocaterForComputer();
    }


    // getters and setters
    public char getSign() {
        return sign;
    }
    public void setSign(char sign) {
        this.sign = sign;
    }
    
    public Coordinate getCoordinate()
    {
    	return coordinates;
    }
    
    public void setCoordinate(Coordinate coordinates)
    {
    	this.coordinates = coordinates;
    }

    public int getScore() {
        return score;
    }
    public void setScore(int score) {
        this.score = score;
    }

    public String getTarget() {
        return target;
    }
    public void setTarget(String target) {
        this.target = target;
    }


    
    //finding a target to the computer.
    public void gainPerDistanceCalculater () {
        for (int i = 0; i < 23; i++) {
            for (int j = 0; j < 55; j++) {
                if(Game.mapArr[i][j].equals('1')) {
                    Double distanceToComputer = Math.sqrt(Math.pow(i - getCoordinate().getY(),2) + Math.pow(j - getCoordinate().getX(),2));
                    int pointsToEarn = 2;
                    Double gainPerDistance = pointsToEarn / distanceToComputer;
                    indexesAndGainsOf1 = arrayFunctions.addItemToArray(indexesAndGainsOf1, (i + "," + j + "," + gainPerDistance));
                }
                else if(Game.mapArr[i][j].equals('2')) {
                    Double distanceToComputer = Math.sqrt(Math.pow(i - getCoordinate().getY(),2) + Math.pow(j - getCoordinate().getX(),2));
                    int pointsToEarn = 10;
                    Double gainPerDistance = pointsToEarn / distanceToComputer;
                    indexesAndGainsOf2 = arrayFunctions.addItemToArray(indexesAndGainsOf2, (i + "," + j + "," + gainPerDistance));
                }
                else if(Game.mapArr[i][j].equals('3')) {
                    Double distanceToComputer = Math.sqrt(Math.pow(i - getCoordinate().getY(),2) + Math.pow(j - getCoordinate().getX(),2));
                    int pointsToEarn = 30;
                    Double gainPerDistance = pointsToEarn / distanceToComputer;
                    indexesAndGainsOf3 = arrayFunctions.addItemToArray(indexesAndGainsOf3, (i + "," + j + "," + gainPerDistance));
                }
                else if(Game.mapArr[i][j].equals('4')) {
                    Double distanceToComputer = Math.sqrt(Math.pow(i - getCoordinate().getY(),2) + Math.pow(j - getCoordinate().getX(),2));
                    int pointsToEarn = 100;
                    Double gainPerDistance = pointsToEarn / distanceToComputer;
                    indexesAndGainsOf4 = arrayFunctions.addItemToArray(indexesAndGainsOf4,(i + "," + j + "," + gainPerDistance));
                }
                else if(Game.mapArr[i][j].equals('5')) {
                    Double distanceToComputer = Math.sqrt(Math.pow(i - getCoordinate().getY(),2) + Math.pow(j - getCoordinate().getX(),2));
                    int pointsToEarn = 150;
                    Double gainPerDistance = pointsToEarn / distanceToComputer;
                    indexesAndGainsOf5 = arrayFunctions.addItemToArray(indexesAndGainsOf5, (i + "," + j + "," + gainPerDistance));
                }
            }
        }
    }
    public void createindexesAndGainsOfAllArray() {
        indexesAndGainsOfAll = arrayFunctions.arrayCombiner(indexesAndGainsOf1, indexesAndGainsOf2);
        indexesAndGainsOfAll = arrayFunctions.arrayCombiner(indexesAndGainsOfAll, indexesAndGainsOf3);
        indexesAndGainsOfAll = arrayFunctions.arrayCombiner(indexesAndGainsOfAll, indexesAndGainsOf4);
        indexesAndGainsOfAll = arrayFunctions.arrayCombiner(indexesAndGainsOfAll, indexesAndGainsOf5);
    }
    public String targetLocaterForComputer() {
        String target = null;
        Double maxGainPerDistance = 0.0;
        String maxGainIndex = "";
        gainPerDistanceCalculater();
        createindexesAndGainsOfAllArray();
        for (int i = 0; i < indexesAndGainsOfAll.length; i++) {
            String[] splittedindexesAndGainsOfAllTreasure = indexesAndGainsOfAll[i].split(",");
            if(Double.parseDouble(splittedindexesAndGainsOfAllTreasure[2]) > maxGainPerDistance) {
                maxGainPerDistance = Double.parseDouble(splittedindexesAndGainsOfAllTreasure[2]);
                maxGainIndex = splittedindexesAndGainsOfAllTreasure[0] + "," + splittedindexesAndGainsOfAllTreasure[1];
            }
        }
        target = maxGainIndex;
        return target;
    }
    
    public void computerMove() {
        if (Game.computerIndexArray != null) {
            for (int i = 0; i < Game.computerIndexArray.length; i++) {

                boolean flag = false;

                int direction;
                String[] indexes = Game.computerIndexArray[i].split(",");
                int row = Integer.parseInt(indexes[0]);
                int column = Integer.parseInt(indexes[1]);

                do {
                    direction = utilities.generateRandomNumber(4);
                    if (direction == 0 && !(Game.mapArr[row - 1][column] instanceof Player || Game.mapArr[row - 1][column] instanceof Treasure || Game.mapArr[row - 1][column] instanceof Computer)&&  (char) Game.mapArr[row - 1][column] != '#') {
                    	Game.moveTheSign("up", Game.computer, column + 80, row + 16, new TextAttributes(Color.RED));
                        row--;
                        flag = true;
                    } else if (direction == 1 && !(Game.mapArr[row + 1][column] instanceof Player || Game.mapArr[row + 1][column] instanceof Treasure || Game.mapArr[row + 1][column] instanceof Computer) && (char) Game.mapArr[row + 1][column] != '#') {
                    	Game.moveTheSign("down", Game.computer, column + 80, row + 16, new TextAttributes(Color.RED));
                        row++;
                        flag = true;
                    } else if (direction == 2 && !(Game.mapArr[row][column-1] instanceof Player || Game.mapArr[row][column-1] instanceof Treasure || Game.mapArr[row][column-1] instanceof Computer) && (char) Game.mapArr[row][column - 1] != '#') {
                    	Game.moveTheSign("left", Game.computer, column + 80, row + 16, new TextAttributes(Color.RED));
                        column--;
                        flag = true;
                    } else if (direction == 3 && !(Game.mapArr[row][column+1] instanceof Player || Game.mapArr[row][column+1] instanceof Treasure || Game.mapArr[row][column+1] instanceof Computer) && (char) Game.mapArr[row][column + 1] != '#') {
                    	Game.moveTheSign("right", Game.computer, column + 80, row + 16, new TextAttributes(Color.RED));
                        column++;
                        flag = true;
                    }
                } while (!flag);

                Game.computerIndexArray[i] = row + "," + column;
            }
            console.setTextAttributes(new TextAttributes(Color.WHITE));
        }
    }
}

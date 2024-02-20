import java.awt.*;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import enigma.console.Console;
import enigma.console.TextAttributes;
import enigma.core.Enigma;
import secondProject.Utilities;

public class Game {

    static Console console = Enigma.getConsole("Star Trek Warp Wars", 250, 55,10);
    static Utilities utilities = new Utilities();
    static ArrayFunction arrayFunctions = new ArrayFunction();
    static FileRead fileReader = new FileRead();
    static Treasure treasure = new Treasure();
    static Print print = new Print();
    static Backpack backpack1 = new Backpack();
    
    
    public static KeyListener klis;
    // ------ standard variables for mouse and keyboard ------
    public static int keyprMovement = 0;   // key pressed?
    public static int keyprBackpack = 0;
    public static int rkeyMovement;    // key   (for press/release)
    public static int rkeyBackpack;
    // ----------------------------------------------------

    static long startTimeQueue;
    static long endTimeQueue;
    static long startTime4And5;
    static long endTime4And5;
    static long startTimeEnergy;
    static long endTimeEnergy;

    static Player player = new Player('P');
    static Computer computer = new Computer('C');

    static Stack backpack = new Stack(8);
    public static CircularQueue inputQueue = new CircularQueue(15);
    static Treasure[] treasureArr;

    static Object[][] mapArr = fileReader.getMapInFile();
    static String[] spaceAreaIndex;
    
    String[] trapDevicesIndex;
    String[] warpDevicesIndex;
    static String[] indexNumbersOf4And5;
    static String [] computerIndexArray;
    
    //the game starts by calling this method
    public void run() throws InterruptedException {
        fileReader.getMapInFile();
        treasure.createTreasurePossibilityArray();
        treasure.createTwentyElementForStart();
        spawnPlayer();
        spawnComputers();
        print.printMenu();
    }
    
    //this method includes game process.
    public static void gamePlay() throws InterruptedException {

        player.setBackpack(backpack);
        player.setLive(5);
        player.setEnergy(50);
        print.printEnergy();
        player.setIsFastSpeed(true);
        player.setScore(0);
        print.printPlayerScore();

        klis=new KeyListener() {
            public void keyTyped(KeyEvent e) {}
            public void keyPressed(KeyEvent e) {
                if(keyprMovement ==0) {
                    keyprMovement =1;
                    rkeyMovement =e.getKeyCode();
                }
            }
            public void keyReleased(KeyEvent e) {}
        };
        console.getTextWindow().addKeyListener(klis);

        // time operation
        long t = System.currentTimeMillis();
        long startTimeQueueForNotMoving = utilities.countTime(t),endTimeQueueForNotMoving;
        long startTime4And5ForNotMoving = utilities.countTime(t),endTime4And5ForNotMoving;
        startTimeQueue = utilities.countTime(t);
        startTime4And5 = utilities.countTime(t);
        startTimeEnergy = utilities.countTime(t);
        while(true) {
        	utilities.countTime(t);

            if (keyprMovement == 1) { // if keyboard button pressed

                if (rkeyMovement == KeyEvent.VK_LEFT)
                    player.movePlayerLeft(t);
                if (rkeyMovement == KeyEvent.VK_RIGHT)
                    player.movePlayerRight(t);
                if (rkeyMovement == KeyEvent.VK_UP)
                    player.movePlayerUp(t);
                if (rkeyMovement == KeyEvent.VK_DOWN)
                    player.movePlayerDown(t);
                if (rkeyMovement == KeyEvent.VK_W || rkeyMovement == KeyEvent.VK_A || rkeyMovement == KeyEvent.VK_S || rkeyMovement == KeyEvent.VK_D) {
                    if (!backpack.isEmpty())
                        backpack1.dropBackpackItem(player.getCoordinate().getX()+80, player.getCoordinate().getY()+16);
                }
                //keyprMovement = 0;    // last action
                startTimeQueueForNotMoving = utilities.countTime(t);
            }

            endTimeQueueForNotMoving = utilities.countTime(t);
            endTime4And5ForNotMoving = utilities.countTime(t);
            if ((endTime4And5ForNotMoving - startTime4And5ForNotMoving) >= 1){
                treasure.move4And5();
                computer.computerMove();
                
                startTime4And5ForNotMoving = utilities.countTime(t);
            }
            if ((endTimeQueueForNotMoving - startTimeQueueForNotMoving) >= 3){
                addInputQueueElementToTheMaze();
                print.printCircularQueue(inputQueue);
                startTimeQueueForNotMoving = utilities.countTime(t);
            }

            keyprMovement = 0; // refresh the key pressed
        }
    }
    
    //this method allows us to move an object in the game field.
    public static void moveTheSign(String direction, Object object,int px, int py,TextAttributes attributes){
        console.getTextWindow().output(px, py, ' ');
        
        mapArr[py - 16][px - 80] = ' ';
        
        if (direction.equalsIgnoreCase("left"))
            px--;
        else if (direction.equalsIgnoreCase("right"))
            px++;
        else if (direction.equalsIgnoreCase("up"))
            py--;
        else if (direction.equalsIgnoreCase("down"))
            py++;

        if (object == player)
        {
        	backpack1.getTheItemIntoTheBackpack(px,py);
        }
        
        mapArr[py - 16][px - 80] = object;
        
        char sign;
        if(mapArr[py - 16][px - 80] instanceof Treasure)
        {
        	sign = ((Treasure)object).getSign();
            console.getTextWindow().output(px,py, sign, attributes);
        }
        	
        else if(mapArr[py - 16][px - 80] instanceof Computer)
        {
        	sign = ((Computer)object).getSign();
        	console.getTextWindow().output(px,py, sign, attributes);
        }
            
        else if(mapArr[py - 16][px - 80] instanceof Player)
        {
        	sign = ((Player)object).getSign();
        	console.getTextWindow().output(px,py, sign, attributes);
        }
        	
    }
    
    //this method spawns computers at the beginning of the game.
    
    public void spawnComputers() {
        int random = utilities.generateRandomNumber(spaceAreaIndex.length);
        String[] spaceIndex = spaceAreaIndex[random].split(",");
        mapArr[Integer.parseInt(spaceIndex[0])][Integer.parseInt(spaceIndex[1])] = computer;
        computer.getCoordinate().setX(Integer.parseInt(spaceIndex[1]));
        computer.getCoordinate().setY(Integer.parseInt(spaceIndex[0]));
        computerIndexArray = arrayFunctions.addItemToArray(computerIndexArray,Integer.parseInt(spaceIndex[0]) + "," + Integer.parseInt(spaceIndex[1]));
    }
    
    
  //this method spawns player at the beginning of the game.
    public void spawnPlayer() {
        int random = utilities.generateRandomNumber(spaceAreaIndex.length);
        String[] spaceIndex = spaceAreaIndex[random].split(",");
        mapArr[Integer.parseInt(spaceIndex[0])][Integer.parseInt(spaceIndex[1])] = player;
        player.getCoordinate().setX(Integer.parseInt(spaceIndex[1]));
        player.getCoordinate().setY(Integer.parseInt(spaceIndex[0]));
    }
    
    //this method adds an input queue element to the maze.
    public static void addInputQueueElementToTheMaze(){
        int randomArrayIndex = utilities.generateRandomNumber(40);
        int randomMapIndex = utilities.generateRandomNumber(spaceAreaIndex.length);
        String[] positionArr = spaceAreaIndex[randomMapIndex].split(",");
        int randomY = Integer.parseInt(positionArr[0]);
        int randomX = Integer.parseInt(positionArr[1]);
        console.getTextWindow().setCursorPosition(randomX + 80, randomY + 16);

        if(inputQueue.peek() instanceof Treasure)
        {
        	if (((Treasure)inputQueue.peek()).getSign() == '4' || ((Treasure)inputQueue.peek()).getSign() == '5') {
                indexNumbersOf4And5 = arrayFunctions.addItemToArray(indexNumbersOf4And5, (randomY + "," + randomX));
                console.setTextAttributes(new TextAttributes(Color.MAGENTA));
                System.out.println(((Treasure)inputQueue.peek()).getSign());
            }
            else if (((Treasure)inputQueue.peek()).getSign() == '=') {
                console.setTextAttributes(new TextAttributes(Color.YELLOW));
                System.out.println(((Treasure)inputQueue.peek()).getSign());
                print.trapDevicesIndex = arrayFunctions.addItemToArray(print.trapDevicesIndex, (randomY + "," + randomX));
            }
            else if (((Treasure)inputQueue.peek()).getSign() == '*') {
                console.setTextAttributes(new TextAttributes(Color.YELLOW));
                System.out.println(((Treasure)inputQueue.peek()).getSign());
                print.warpDevicesIndex = arrayFunctions.addItemToArray(print.warpDevicesIndex, (randomY + "," + randomX));
            }
            else
                System.out.println(((Treasure)inputQueue.peek()).getSign());
        }
        
        
        else 
        {
            console.setTextAttributes(new TextAttributes(Color.RED));
            System.out.println(((Computer)inputQueue.peek()).getSign());
            computerIndexArray = arrayFunctions.addItemToArray(computerIndexArray,randomY + "," + randomX); // update the index array
        }
        

        console.setTextAttributes(new TextAttributes(Color.WHITE));

        mapArr[randomY][randomX] = inputQueue.dequeue();
        
        
        
        
        char sign = (char)treasure.treasurePossibilityArray[randomArrayIndex];
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
        
        
        spaceAreaIndex = arrayFunctions.dellIndexInArray(spaceAreaIndex, randomMapIndex);
    }
    //this method arranges timing of queue process.
    public static void inputQueueProcess(long t){
        endTimeQueue = utilities.countTime(t);
        if ((endTimeQueue - startTimeQueue) >= 3){
            addInputQueueElementToTheMaze();
            print.printCircularQueue(inputQueue);
            startTimeQueue = utilities.countTime(t);
        }
    }
    
    
    
    
    
                
}
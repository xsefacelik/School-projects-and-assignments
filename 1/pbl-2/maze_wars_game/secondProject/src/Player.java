import java.awt.Color;
import java.awt.event.KeyEvent;

import enigma.console.Console;
import enigma.console.TextAttributes;
import enigma.core.Enigma;
import secondProject.Utilities;

public class Player {
    // properties
    private char sign;
    private int energy;
    private int score;
    private int live;
    private Stack backpack;
    private Coordinate coordinates;
    private int speed;
    private boolean fastSpeed;
    
    
    
    //Game game1 = new Game();
    Console console = Enigma.getConsole("Star Trek Warp Wars", 250, 55,10);
    Utilities utilities = new Utilities();
    Print print = new Print();
    ArrayFunction arrayFunctions = new ArrayFunction();
    FileRead fileReader = new FileRead();
    Treasure treasure = new Treasure();
    Backpack backpack1 = new Backpack();
    


    // constructor
    public Player(char sign) {
        this.sign = sign;
        coordinates = new Coordinate(1,1);
        
    }


    // getters and setters
    public char getSign() {
        return sign;
    }
    public void setSign(char sign) {
        this.sign = sign;
    }

    public int getEnergy() {
        return energy;
    }
    public void setEnergy(int energy) {
        this.energy = energy;
    }

    public int getScore() {
        return score;
    }
    public void setScore(int score) {
        this.score = score;
    }

    public int getLive() {
        return live;
    }
    public void setLive(int live) {
        this.live = live;
    }

    public Stack getBackpack() {
        return backpack;
    }
    
    public void setBackpack(Stack backpack) {
        this.backpack = backpack;
    }
    
    public Coordinate getCoordinate()
    {
    	return coordinates;
    }
    
    public void setCoordinate(Coordinate coordinates)
    {
    	this.coordinates = coordinates;
    }

    public int getSpeed() {
        return speed;
    }
    public void setSpeed(int speed) {
        this.speed = speed;
    }

    public boolean isFastSpeed() {
        return fastSpeed;
    }
    public void setIsFastSpeed(boolean fastSpeed) {
        this.fastSpeed = fastSpeed;
    }


    //moving methods
    public void movePlayerLeft(long t) throws InterruptedException {
        while (Game.rkeyMovement == KeyEvent.VK_LEFT && !(Game.mapArr[Game.player.getCoordinate().getY()][Game.player.getCoordinate().getX()-1] instanceof Computer) && (Game.mapArr[Game.player.getCoordinate().getY()][Game.player.getCoordinate().getX()-1] instanceof Treasure || (char)Game.mapArr[Game.player.getCoordinate().getY()][Game.player.getCoordinate().getX()-1] != '#')) {
            print.printEnergy();
            Game.moveTheSign("left", Game.player,Game.player.getCoordinate().getX()+80,Game.player.getCoordinate().getY()+16,new TextAttributes(Color.GREEN));
            Game.player.getCoordinate().setX(Game.player.getCoordinate().getX()-1);
            treasure.controlTheSpeedOf4And5(t);
            controlAndAdjustTheEnergy (t);
            //keyprMovement = 0;
            backpack1.dropAnItemFromBackpackAndControlDirection(KeyEvent.VK_LEFT,KeyEvent.VK_A, t);
            Game.inputQueueProcess(t);
            Game.keyprMovement = 0;

        }
    }
    public void movePlayerRight(long t) throws InterruptedException {
        while (Game.rkeyMovement == KeyEvent.VK_RIGHT && !(Game.mapArr[Game.player.getCoordinate().getY()][Game.player.getCoordinate().getX()+1] instanceof Computer) && (Game.mapArr[Game.player.getCoordinate().getY()][Game.player.getCoordinate().getX()+1] instanceof Treasure || (char)Game.mapArr[Game.player.getCoordinate().getY()][Game.player.getCoordinate().getX()+1] != '#')) {
            print.printEnergy();
            Game.moveTheSign("right",Game.player,Game.player.getCoordinate().getX()+80,Game.player.getCoordinate().getY()+16,new TextAttributes(Color.GREEN));
            Game.player.getCoordinate().setX(Game.player.getCoordinate().getX()+1);
            treasure.controlTheSpeedOf4And5(t);
            controlAndAdjustTheEnergy (t);
            //keyprMovement = 0;
            backpack1.dropAnItemFromBackpackAndControlDirection(KeyEvent.VK_RIGHT,KeyEvent.VK_D, t);
            Game.inputQueueProcess(t);
            Game.keyprMovement = 0;
        }
    }
    public void movePlayerUp(long t) throws InterruptedException{
        while (Game.rkeyMovement == KeyEvent.VK_UP && !(Game.mapArr[Game.player.getCoordinate().getY()-1][Game.player.getCoordinate().getX()] instanceof Computer) && (Game.mapArr[Game.player.getCoordinate().getY()-1][Game.player.getCoordinate().getX()] instanceof Treasure || (char)Game.mapArr[Game.player.getCoordinate().getY()-1][Game.player.getCoordinate().getX()] != '#')) {
            print.printEnergy();
            Game.moveTheSign("up",Game.player,Game.player.getCoordinate().getX()+80,Game.player.getCoordinate().getY()+16,new TextAttributes(Color.GREEN));
            Game.player.getCoordinate().setY(Game.player.getCoordinate().getY()-1);
            treasure.controlTheSpeedOf4And5(t);
            controlAndAdjustTheEnergy (t);
            //keyprMovement = 0;
            backpack1.dropAnItemFromBackpackAndControlDirection(KeyEvent.VK_UP,KeyEvent.VK_W, t);
            Game.inputQueueProcess(t);
            Game.keyprMovement = 0;
        }
    }
    public void movePlayerDown(long t) throws InterruptedException{
        while (Game.rkeyMovement == KeyEvent.VK_DOWN && !(Game.mapArr[Game.player.getCoordinate().getY()+1][Game.player.getCoordinate().getX()] instanceof Computer) && (Game.mapArr[Game.player.getCoordinate().getY()+1][Game.player.getCoordinate().getX()] instanceof Treasure || (char)Game.mapArr[Game.player.getCoordinate().getY()+1][Game.player.getCoordinate().getX()] != '#')) {
            print.printEnergy();
            Game.moveTheSign("down",Game.player,Game.player.getCoordinate().getX()+80,Game.player.getCoordinate().getY()+16,new TextAttributes(Color.GREEN));
            Game.player.getCoordinate().setY(Game.player.getCoordinate().getY()+1);
            treasure.controlTheSpeedOf4And5(t);
            controlAndAdjustTheEnergy (t);
            //keyprMovement = 0;
            backpack1.dropAnItemFromBackpackAndControlDirection(KeyEvent.VK_DOWN,KeyEvent.VK_S, t);
            Game.inputQueueProcess(t);
            Game.keyprMovement = 0;
        }
    }
    
    //this method controls and adjusts player's energy.
    public void controlAndAdjustTheEnergy (long t) throws InterruptedException {
        if (Game.player.getEnergy() > 0) // player fast speed (2 frames in a second)
            Thread.sleep(500);
        else
            Thread.sleep(1000);
        Game.endTimeEnergy = utilities.countTime(t);
        if (Game.player.getEnergy() > 0 && (Game.endTimeEnergy - Game.startTimeEnergy) >= 1){
        	Game.player.setEnergy(Game.player.getEnergy() - 1);
        	Game.startTimeEnergy = utilities.countTime(t);
        }
    }
    
    //this method updates score of player.
    public void updateTheScoreForPlayer(int px, int py){
        if (Game.mapArr[py - 16][px - 80] instanceof Treasure)
        	Game.player.setScore(Game.player.getScore() + ((Treasure)Game.mapArr[py - 16][px - 80]).getValue());
        print.printPlayerScore();
    }
    


}


import java.awt.Color;
import java.awt.event.KeyEvent;
import enigma.console.Console;
import enigma.console.TextAttributes;
import enigma.core.Enigma;

public class Backpack {
	//Game game1 = new Game();
	Console console = Enigma.getConsole("Star Trek Warp Wars", 250, 55,10);
	ArrayFunction arrayFunctions = new ArrayFunction();
	//Print print1 = new Print();
	int nonChange = 0;
	int indexDecreaseNumber = -1;
	int indexIncreaseNumber = +1;
	//this method drops an item of backpack
	public void dropBackpackItem(int px, int py){
		Game.rkeyBackpack = Game.rkeyMovement;
        // check the direction if available by keys and if available pop the backpack item
        if (Game.player.getBackpack().peek() != null) {
            if (Game.rkeyBackpack == KeyEvent.VK_W && px != 17 && !(Game.mapArr[py - 17][px - 80] instanceof Treasure) && Game.mapArr[py - 17][px - 80].equals(' ')) {
                droppingProcess(px, py, nonChange, indexDecreaseNumber);
            }
            if (Game.rkeyBackpack == KeyEvent.VK_S && px != 38 && !(Game.mapArr[py - 15][px - 80] instanceof Treasure) &&  Game.mapArr[py - 15][px - 80].equals(' ')) {
                droppingProcess(px, py, nonChange, indexIncreaseNumber);
            }
            if (Game.rkeyBackpack == KeyEvent.VK_A && py != 81 && !(Game.mapArr[py - 16][px - 81] instanceof Treasure) && Game.mapArr[py - 16][px - 81].equals(' ')) {
                droppingProcess(px, py, indexDecreaseNumber, nonChange);
            }
            if (Game.rkeyBackpack == KeyEvent.VK_D && py != 133 && !(Game.mapArr[py - 16][px - 79] instanceof Treasure) && Game.mapArr[py - 16][px - 79].equals(' ')) {
                droppingProcess(px, py, indexIncreaseNumber, nonChange);
            }
            console.getTextWindow().setCursorPosition(154,29 - backpackPrintingIndex); // print space for the used backpack item
            System.out.println(" ");
        }
        Game.keyprBackpack = 0;    // last action
    }
	//this method has two parameters that indicates the vertical and horizontal difference
    public void droppingProcess(int px, int py, int a, int b){

        if (Game.player.getBackpack().peek() instanceof Treasure && ((Treasure)Game.player.getBackpack().peek()).getSign() == '='){
        	Game.print.trapDevicesIndex = arrayFunctions.addItemToArray(Game.print.trapDevicesIndex,(py-16+b) + "," + (px-80+a)+ "," + "25");
        }
        else if (Game.player.getBackpack().peek() instanceof Treasure && ((Treasure)Game.player.getBackpack().peek()).getSign() == '*'){
        	Game.print.warpDevicesIndex = arrayFunctions.addItemToArray(Game.print.warpDevicesIndex,(py-16+b) + "," + (px-80+a) + "," + "25");
        }
        else if ((Game.player.getBackpack().peek() instanceof Treasure && ((Treasure)Game.player.getBackpack().peek()).getSign() == '4') || (Game.player.getBackpack().peek() instanceof Treasure && ((Treasure)Game.player.getBackpack().peek()).getSign() == '5')) {
        	Game.indexNumbersOf4And5 = arrayFunctions.addItemToArray(Game.indexNumbersOf4And5, (py - 16 + b) + "," + (px - 80 + a));
        }

        console.getTextWindow().output(px + a, py + b, ((Treasure)Game.player.getBackpack().peek()).getSign(), new TextAttributes(Color.PINK));
        Game.mapArr[py - 16 + b][px - 80 + a] = Game.player.getBackpack().pop();
        backpackPrintingIndex--;
    }
    //this method controls which direction to drop a backpack item
    public void dropAnItemFromBackpackAndControlDirection(int KeyEventDirection, int KeyEventWASD, long t) {
        if (Game.rkeyMovement == KeyEvent.VK_W || Game.rkeyMovement == KeyEvent.VK_A || Game.rkeyMovement == KeyEvent.VK_S || Game.rkeyMovement == KeyEvent.VK_D){
            if (!Game.backpack.isEmpty())
                dropBackpackItem(Game.player.getCoordinate().getX()+80,Game.player.getCoordinate().getY()+16);
            if (!(Game.rkeyMovement == KeyEventWASD))
            	Game.rkeyMovement = KeyEventDirection;
        }
        else if (!(Game.rkeyMovement == KeyEvent.VK_LEFT || Game.rkeyMovement == KeyEvent.VK_RIGHT || Game.rkeyMovement == KeyEvent.VK_UP || Game.rkeyMovement == KeyEvent.VK_DOWN))
        	Game.rkeyMovement = KeyEventDirection; // if the pressed key is not valid, it turns it to the direction's key
    }
    int backpackPrintingIndex = 0;
    //this method gets an item from the maze to the backpack
    public void getTheItemIntoTheBackpack(int px, int py){
        if (Game.backpack.isEmpty()){
        	if(Game.mapArr[py - 16][px - 80] instanceof Treasure)
        	{
        		if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '4' || ((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '5') {
                    Game.indexNumbersOf4And5 = arrayFunctions.dellItemInArray(Game.indexNumbersOf4And5, py + "," + px);
                    Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                    backpackPrintingIndex++;
                }else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '2' || ((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '3') {
                    Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                    backpackPrintingIndex++;
                } else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '=') {
                    Game.print.trapDevicesIndex = arrayFunctions.dellItemInArray(Game.print.trapDevicesIndex, py + "," + px);
                    Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                    backpackPrintingIndex++;
                } else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '*') {
                	Game.print.warpDevicesIndex = arrayFunctions.dellItemInArray(Game.print.warpDevicesIndex, py + "," + px);
                	Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                    backpackPrintingIndex++;
                }
        	}
        	
            
        }
        else{
            if (!Game.backpack.isFull()) {
            	if(Game.mapArr[py - 16][px - 80] instanceof Treasure)
            	{
                if (!(((Treasure)Game.backpack.peek()).getSign() == '*' || ((Treasure)Game.backpack.peek()).getSign() == '=')) {
                    if (((Treasure)Game.backpack.peek()).getSign() == ((Treasure)Game.mapArr[py - 16][px - 80]).getSign()) {
                        if (((Treasure)Game.backpack.peek()).getSign() == '2') {
                        	Game.player.setEnergy(Game.player.getEnergy() + 30);// 30 seconds energy
                        	Game.backpack.pop();
                            backpackPrintingIndex--;
                        } else if (((Treasure)Game.backpack.peek()).getSign() == '3') {
                        	Game.backpack.pop();
                        	Treasure treasure = new Treasure('=', 0, false);
                        	Game.backpack.push(treasure);
                        } else if (((Treasure)Game.backpack.peek()).getSign() == '4') {
                        	Game.player.setEnergy(Game.player.getEnergy() + 240);// energy for 240 seconds
                        	Game.indexNumbersOf4And5 = arrayFunctions.dellItemInArray(Game.indexNumbersOf4And5, py + "," + px);
                        	Game.backpack.pop();
                            backpackPrintingIndex--;
                        } else if (((Treasure)Game.backpack.peek()).getSign() == '5') {
                        	Game.backpack.pop();
                        	Treasure treasure = new Treasure('*', 0, false);
                        	Game.backpack.push(treasure);
                        	Game.indexNumbersOf4And5 = arrayFunctions.dellItemInArray(Game.indexNumbersOf4And5, py + "," + px);
                        }
                    }
                    else {
                        if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '4' || ((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '5') {
                        	Game.indexNumbersOf4And5 = arrayFunctions.dellItemInArray(Game.indexNumbersOf4And5, py + "," + px);
                        	Game.backpack.pop();
                            backpackPrintingIndex--;
                        } else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '2' || ((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '3') {
                        	Game.backpack.pop();
                            backpackPrintingIndex--;
                        } else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '=') {
                        	Game.print.trapDevicesIndex = arrayFunctions.dellItemInArray(Game.print.trapDevicesIndex, py + "," + px);
                            Game.backpack.pop();
                            Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                        } else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '*') {
                        	Game.backpack.pop();
                        	Game.print.warpDevicesIndex = arrayFunctions.dellItemInArray(Game.print.warpDevicesIndex, py + "," + px);
                            Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                        }
                    }
                }
                else if (((Treasure)Game.backpack.peek()).getSign() == '*' || ((Treasure)Game.backpack.peek()).getSign() == '='){
                    if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '4' || ((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '5') {
                    	Game.indexNumbersOf4And5 = arrayFunctions.dellItemInArray(Game.indexNumbersOf4And5, py + "," + px);
                    	Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                        backpackPrintingIndex++;
                    } else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '2' || ((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '3') {
                    	Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                        backpackPrintingIndex++;
                    } else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '=') {
                    	Game.print.trapDevicesIndex = arrayFunctions.dellItemInArray(Game.print.trapDevicesIndex, py + "," + px);
                        Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                        backpackPrintingIndex++;
                    } else if (((Treasure)Game.mapArr[py - 16][px - 80]).getSign() == '*') {
                    	Game.print.warpDevicesIndex = arrayFunctions.dellItemInArray(Game.print.warpDevicesIndex, py + "," + px);
                        Game.backpack.push(Game.mapArr[py - 16][px - 80]);
                        backpackPrintingIndex++;
                    }
                }
            	}
            }
        }
        for (int i = 0; i < 8; i++){
            console.getTextWindow().setCursorPosition(154, 22 + i);
            System.out.println("  |");
        }
        console.getTextWindow().setCursorPosition(154, 30 - backpackPrintingIndex);
        Game.print.printBackpack(Game.backpack);
        Game.player.updateTheScoreForPlayer(px,py);
    }
}

import java.awt.Color;
import java.util.Random;

import enigma.console.TextAttributes;

public class Utilities {
	//generate a random number between 0 to end
	public int generateRandomNumber(int end){
        Random random = new Random();
        return random.nextInt(end);
    }
	//cleaner for console
	public void cleanConsole() {
        for (int i = 0; i < 35; i++) {
        	PrintFunctions.console.setTextAttributes(new TextAttributes(Color.DARK_GRAY, Color.DARK_GRAY));
        	PrintFunctions.console.getTextWindow().setCursorPosition(0, i);
        	PrintFunctions.console.getTextWindow().output("                                                                               ");
        }
        PrintFunctions.console.getTextWindow().setCursorPosition(0, 0);
	}
}

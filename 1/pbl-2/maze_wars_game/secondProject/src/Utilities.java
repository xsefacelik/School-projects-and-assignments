package secondProject;

import java.util.Random;
import enigma.console.Console;
import enigma.core.Enigma;


public class Utilities {
	Console console = Enigma.getConsole("Star Trek Warp Wars", 250, 55,10);
	
	public int countTime(long t){
        int s = (int) ((System.currentTimeMillis() - t) / 1000); // current time in seconds
        console.getTextWindow().setCursorPosition(152, 38);
        System.out.println(s);
        return s;
    }
    public int generateRandomNumber(int end){
        Random random = new Random();
        return random.nextInt(end);
    }
    public void cleanConsole() { // cleans the console
        for (int i = 0; i < 55; i++) {
            console.getTextWindow().setCursorPosition(0, i);
            console.getTextWindow().output("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        }
        console.getTextWindow().setCursorPosition(0, 0);
    }
   

}

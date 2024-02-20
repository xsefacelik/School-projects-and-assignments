import java.awt.Color;
import java.util.Scanner;

import enigma.console.Console;
import enigma.console.TextAttributes;
import enigma.core.Enigma;
import secondProject.Utilities;

public class Print {
	
	Console console = Enigma.getConsole("Star Trek Warp Wars", 250, 55,10);
	Utilities utilities = new Utilities();
	//Game Game = new Game();
	ArrayFunction arrayFunctions = new ArrayFunction();
    String[] trapDevicesIndex;
    String[] warpDevicesIndex;
	
    //printing menu
	public void printMenu() throws InterruptedException {
        console.getTextWindow().setCursorPosition(0 , 0);
        System.out.println("             *                -0-          .    *o       -0-              *                            *     -0-                 *   -0-                  *                *                  -0-   o                 -0-      *         -0-      *      ");
        System.out.println("    o          -0-         *              *          o          *                    *           *                 o     *     -0-            *      o   -0-       *             *                            *              o                        *  ");
        System.out.println("                                                                               o                                                         o                                                              o                                                ");
        System.out.println("                 *       -0-     o          o                   o                                                                                         -0-                           o                     o        o                      -          ");
        System.out.println("*    -0-        -0-                              o                                               -0-                      o           o                                 o                                                               o                ");
        System.out.println("                                                    -0-      o         o                                                                          *         *                        *             *                           o                 *       ");
        System.out.println("*   o                                                                                  *                 -0-                                                               -0-                                -0-                                        ");
        System.out.println("*               *         -0-              *                                                                                                                        *                  o                   o        o         *            o             ");
        System.out.println("        *                        o                                                              o                        -0-             *         *                                                                                 o        -0-        ");
        System.out.println("   *                                               o                                  *                                                                       *                                                                                    *     ");
        System.out.println("                      *                    *                     *                                             *                                                                                                -0-               -0-                    ");
        System.out.println("   -0-       *                                                                                                                                                        -0-         *                     *                                   *     o      ");
        System.out.println("        -0-                   *                                                                                                                                                                                              *                           ");
        System.out.println("    *            o                                                                                                                                                                                                                                       ");
        System.out.println("                                                                                                                                                                                                                                      *                  ");
        System.out.println("             -0-                                                                                                                                                                                                                                   -0-   ");
        System.out.println("               *       __                                _______ _______ _______  ______      _______  ______ _______ _     _      _  _  _ _______  ______  _____       _  _  _ _______  ______ _______                                     -0-          ");
        System.out.println("                       \\ \\_____                          |______    |    |_____| |_____/         |    |_____/ |______ |____/       |  |  | |_____| |_____/ |_____]      |  |  | |_____| |_____/ |______                ^                       *       ");
        System.out.println("    o               ###[==_____>                         ______|    |    |     | |    \\_         |    |    \\_ |______ |    \\_      |__|__| |     | |    \\_ |            |__|__| |     | |    \\_ ______|                !               *            ");
        System.out.println("   *                   /_/                                                                                                                                                                                             !                                 ");
        System.out.println("                                                                                                                                                                                                                      / \\              o      *         ");
        System.out.println("    o    *                                                                                                                                                                                                           /___\\                              ");
        System.out.println("      -0-                                                                                                                                                                                                            |=  =|                              ");
        System.out.println("                                                                                                                                                                                                                     |=  =|                              ");
        System.out.println("   *       *                                                                                                   _______ _______ __   _ _     _                                                                        |    |            -0-        *      ");
        System.out.println("o   o                                                                                                          |  |  | |______ | \\  | |     |                                                                        |    |                             ");
        System.out.println("            *                                                                                                  |  |  | |______ |  \\_| |_____|                                                                        |    |                  0          ");
        System.out.println("                                        /\\                                                                                                                                                                           |    |                *            ");
        System.out.println("*      -0-                            .'  '.                                                                                                                                                                         |    |                   0     *    ");
        System.out.println("                                     /======\\                                                                                                                                                                        |    |                             ");
        System.out.println("   *                                ;:.  _   ;                                                                    1- Game Info                                                                                      /|    |\\                            ");
        System.out.println("            *                       |:. (_)  |                                                                                                                                                                     / |#!##|\\\\          *               ");
        System.out.println("o                                   |:.  _   |                                                                    2- The Story Of The Game                                                                        /  |#!##| \\\\                         ");
        System.out.println("                                    |:. (_)  |                                                                                                                                                                   /   |#!##|  \\\\                  *     ");
        System.out.println("                                    ;:.      ;                                                                    3- Start Game                                                                                  |  / ^ | ^ \\  |         -0-            ");
        System.out.println("     *                            .' \\:.    / `.                                                                                                                                                                 | /  ( | )  \\ |                   *   ");
        System.out.println("              o                  / .-'':._.'`-. \\                                                                 4- Exit                                                                                        |/   ( | )   \\|             o         ");
        System.out.println("*                                |/    /||\\    \\|                                                                                                                                                                    ((   ))                           ");
        System.out.println("     *   -0-                  _..--\"\"\"````\"\"\"--.._                                                                                                                                                                  ((  :  ))                      ");
        System.out.println("o                          _.-'``                    ``'-._                                                                                                                                                         ((  :  ))                            ");
        System.out.println("                         -'                                '-                                                                                                                                                        ((   ))                      *      ");
        System.out.println("      o                                                                                                                                                                                                               (( ))           *      -0-         ");
        System.out.println("*  -0-          -0-                                                                                                                                                                                                    ( )    -0-                        ");
        System.out.println("                              0                -0-                                                                         -0-       *               -0-                   -0-          *                0              .                                ");
        System.out.println("   *       *                                                                      *                               *                                                *                             -0-           *        .                      *         ");
        System.out.println("                0       *      *                                 -0-    *               -0-      0                                                                              0                                       .                                ");
        System.out.println("      o                                                     0                                                                           -0-      0                                                                      .             *                  ");
        System.out.println("*        -0-                          -0-   *                                 *                                    *                                                                                       *            .                  o             ");
        System.out.println("                o               *                                 *                           *        0                   0          *                   *                   -0-                      0                  *    -0-                       ");
        System.out.println("    *                                               *                     -0-                                                                                0                             *                                                   *         ");
        System.out.println("o     *                                                                                 *                                                                                                                                                                ");
        System.out.println("                              *                                                                                                                *                       *                                         *                               -0-     ");
        System.out.println("  *                                                                                                                   *                                                                                                              *                   ");
        System.out.println("            -0-                                  *            *                                *                                                        *                                   *                            *                               ");


        console.getTextWindow().setCursorPosition(114 , 38);
        System.out.println("Your Choice: ");

        console.getTextWindow().setCursorPosition(135 , 38);
        Scanner scanner = new Scanner(System.in);
        // Get the menu selection from user
        boolean isValidMenuInput = false;
        String validMenuInputs = "1234";
        String menuInput;
        do {
            menuInput = scanner.nextLine();
            if (validMenuInputs.contains(menuInput) && menuInput.length() < 2)
                isValidMenuInput = true;

            else if (!isValidMenuInput) {
                console.getTextWindow().setCursorPosition(114 , 39);
                System.out.println("Please enter a valid option");
                console.getTextWindow().setCursorPosition(127 , 38);
                System.out.println("                        ");
                console.getTextWindow().setCursorPosition(135 , 38);
            }

        } while (!isValidMenuInput);
        scanner.close();

        switch (menuInput){
            case "1":
            	utilities.cleanConsole();
                printGameInfo();
                break;
            case "2":
            	utilities.cleanConsole();
                printStory();
                break;
            case "3":
            	utilities.cleanConsole();
                printMaze();
                break;
            case "4":
            	utilities.cleanConsole();
                printExit();
                break;
        }

    }
	//printing maze
	public void printMaze() throws InterruptedException {

    	utilities.cleanConsole();
        System.out.println("             *                -0-          .    *o       -0-              *                            *     -0-                 *   -0-                  *                *                  -0-   o                 -0-      *         -0-      *      ");
        System.out.println("    o          -0-         *              *          o          *                    *           *                 o     *     -0-            *      o   -0-       *             *                            *              o                        *  ");
        System.out.println("                                                                               o                                                         o                                                              o                                                ");
        System.out.println("                 *       -0-     o          o                   o                                                                                         -0-                           o                     o        o                      -          ");
        System.out.println("*    -0-        -0-                              o                                               -0-                      o           o                                 o                                                               o                ");
        System.out.println("                                                    -0-      o         o                                                                          *         *                        *             *                           o                 *       ");
        System.out.println("*   o                                                                                  *                 -0-                                                               -0-                                -0-                                        ");
        System.out.println("*               *         -0-              *                                                                                                                        *                  o                   o        o         *            o             ");
        System.out.println("        *                        o                                                              o                        -0-             *         *                                                                                 o        -0-        ");
        System.out.println("   *                                               o                                  *                                                                       *                                                                                    *     ");
        System.out.println("                      *                    *                     *                                             *                                                                                                -0-               -0-                    ");
        System.out.println("   -0-       *                                                                                                                                                        -0-         *                     *                                   *     o      ");
        System.out.println("        -0-                   *                                                                                                                                                                                              *                           ");
        System.out.println("    *            o                                                                                                         *                                                                                                                             ");
        System.out.println("                                                     *                    *                    *                                                  *                                                                                   *                  ");
        System.out.println("             -0-                                                                                                                                                                                                       ^                           -0-   ");
        System.out.println("               *       __                *              -0-                                                                                          INPUT:                        0                  -0-                                   -0-          ");
        System.out.println("                       \\ \\_____                                                                                                                  _________________                                                                             *       ");
        System.out.println("    o               ###[==_____>                                                                                                                 |<<<<<<<<<<<<<<<|                                                     !                    *            ");
        System.out.println("   *                   /_/                           *                                                                                           |               |                                                     !                                 ");
        System.out.println("                                         -0-                                                                                                     |<<<<<<<<<<<<<<<|                                                    / \\              o      *         ");
        System.out.println("    o    *                                                  *                                                                                    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯                *                                  /___\\                              ");
        System.out.println("      -0-                                                                                                                                              |   |                                        *                |=  =|                          ");
        System.out.println("                     *            *           *                                                                                                        |   |                                                         |=  =|                          ");
        System.out.println("   *       *                                           0                                                                                               |   |                                                         |    |            -0-        *  ");
        System.out.println("o   o                                                                                                                                                  |   |                               -0-                       |    |                          ");
        System.out.println("            *                                                                                                                                          |   |                                                         |    |                   0      ");
        System.out.println("                                        /\\                                                                                                             |   |                                    0                    |    |                *        ");
        System.out.println("*      -0-                            .'  '.                 *                                                                                         |   |                      *                                  |    |                   0     *");
        System.out.println("                     *               /======\\                                                                                                          |   |                                                         |    |                         ");
        System.out.println("   *                                ;:.  _   ;                                                                                                         ¯¯¯¯¯                                                        /|    |\\                            ");
        System.out.println("            *                       |:. (_)  |               -0-                                                                                   YOUR BACKPACK                                                   / |#!##|\\\\          *               ");
        System.out.println("o                                   |:.  _   |                                                                                                                                                           *        /  |#!##| \\\\                         ");
        System.out.println("                                    |:. (_)  |                                                                                                   YOUR ENERGY:                              -0-                   /   |#!##|  \\\\                  *     ");
        System.out.println("                                    ;:.      ;           *                                                                                       YOUR SCORE:                                                     |  / ^ | ^ \\  |         -0-            ");
        System.out.println("     *                            .' \\:.    / `.                                                                                                 YOUR LIFE:                    *                                 | /  ( | )  \\ |                   *   ");
        System.out.println("              o                  / .-'':._.'`-. \\                                                                                                                                                                |/   ( | )   \\|             o         ");
        System.out.println("*                                |/    /||\\    \\|                                                                                                COMPUTER SCORE:                                                     ((   ))                           ");
        System.out.println("     *   -0-                  _..--\"\"\"````\"\"\"--.._              *                                                                                TIME:                                            *                 ((  :  ))                      ");
        System.out.println("o                          _.-'``                    ``'-._                                                                                                                          0                              ((  :  ))                            ");
        System.out.println("                         -'                                '-                                                       *                              *                                                                 ((   ))                      *      ");
        System.out.println("      o                                                                                     *                                                                                                                         (( ))           *      -0-         ");
        System.out.println("*  -0-          -0-                                                                                                                                                *                                                   ( )    -0-                        ");
        System.out.println("                              0                -0-                                                                         -0-       *               -0-                   -0-          *                0              .                                ");
        System.out.println("   *       *                                                                      *                               *                                                *                             -0-           *        .                      *         ");
        System.out.println("                0       *      *                                 -0-    *               -0-      0                                                                              0                                       .                                ");
        System.out.println("      o                                                     0                                                                           -0-      0                                                                      .             *                  ");
        System.out.println("*        -0-                          -0-   *                                 *                                    *                                                                                       *            .                  o             ");
        System.out.println("                o               *                                 *                           *        0                   0          *                   *                   -0-                      0                  *    -0-                       ");
        System.out.println("    *                                               *                     -0-                                                                                0                             *                                                   *         ");
        System.out.println("o     *                                                                                 *                                                                                                                                                                ");
        System.out.println("                              *                                                                                                                *                       *                                         *                               -0-     ");
        System.out.println("  *                                                                                                                   *                                                                                                              *                   ");
        System.out.println("            -0-                                  *            *                                *                                                        *                                   *                            *                               ");

        for (int i = 0; i < 23; i++) {
            for (int j = 0; j < 55; j++) {
                console.getTextWindow().setCursorPosition(80 + j, 16 + i);
                if(Game.mapArr[i][j] instanceof Treasure)
                {
                	if (((Treasure)Game.mapArr[i][j]).getSign() == '1') {
                        console.setTextAttributes(new TextAttributes(Color.WHITE));
                        System.out.print(((Treasure)Game.mapArr[i][j]).getSign());
                    }
                    else if (((Treasure)Game.mapArr[i][j]).getSign() == '2') {
                        console.setTextAttributes(new TextAttributes(Color.WHITE));
                        System.out.print(((Treasure)Game.mapArr[i][j]).getSign());
                    }
                    else if (((Treasure)Game.mapArr[i][j]).getSign() == '3') {
                        console.setTextAttributes(new TextAttributes(Color.WHITE));
                        System.out.print(((Treasure)Game.mapArr[i][j]).getSign());
                    }
                    else if (((Treasure)Game.mapArr[i][j]).getSign() == '4') {
                        console.setTextAttributes(new TextAttributes(Color.MAGENTA));
                        Game.indexNumbersOf4And5 = arrayFunctions.addItemToArray(Game.indexNumbersOf4And5,(i + "," + j));
                        System.out.print(((Treasure)Game.mapArr[i][j]).getSign());
                    }
                    else if (((Treasure)Game.mapArr[i][j]).getSign() == '5') {
                        console.setTextAttributes(new TextAttributes(Color.MAGENTA));
                        Game.indexNumbersOf4And5 = arrayFunctions.addItemToArray(Game.indexNumbersOf4And5,(i + "," + j));
                        System.out.print(((Treasure)Game.mapArr[i][j]).getSign());
                    }
                    else if (((Treasure)Game.mapArr[i][j]).getSign() == '*') {
                        console.setTextAttributes(new TextAttributes(Color.YELLOW));
                        warpDevicesIndex = arrayFunctions.addItemToArray(warpDevicesIndex,(i + "," + j));
                        System.out.print(((Treasure)Game.mapArr[i][j]).getSign());
                    }
                    else if (((Treasure)Game.mapArr[i][j]).getSign() == '=') {
                        console.setTextAttributes(new TextAttributes(Color.YELLOW));
                        trapDevicesIndex = arrayFunctions.addItemToArray(trapDevicesIndex,(i + "," + j));
                        System.out.print(((Treasure)Game.mapArr[i][j]).getSign());
                    }
                }
                else if(Game.mapArr[i][j] instanceof Computer)
                {
                    console.setTextAttributes(new TextAttributes(Color.RED));
                    System.out.print(((Computer)Game.mapArr[i][j]).getSign());
                    Game.computerIndexArray = arrayFunctions.addItemToArray(Game.computerIndexArray,i + "," + j);
                }
                else if(Game.mapArr[i][j] instanceof Player)
                {
                	console.setTextAttributes(new TextAttributes(Color.GREEN));
                    System.out.print(((Player)Game.mapArr[i][j]).getSign());
                }
                else if (Game.mapArr[i][j].equals('#')) {
                    console.setTextAttributes(new TextAttributes(Color.CYAN));
                    System.out.print(Game.mapArr[i][j]);
                }
                else
                    System.out.print(Game.mapArr[i][j]);
            }
        }
        console.setTextAttributes(new TextAttributes(Color.WHITE));
        printCircularQueue(Game.inputQueue);
        Game.gamePlay();
    }
	//printing exit   
	public void printExit() {

    	enigma.console.Console cn = Enigma.getConsole("Star Trek Warp Wars");
        cn.getTextWindow().setCursorPosition(0 , 0);
        System.out.println("             *                -0-          .    *o       -0-              *                            *     -0-                 *   -0-                  *                *                  -0-   o                 -0-      *         -0-      *      ");
        System.out.println("    o          -0-         *              *          o          *                    *           *                 o     *     -0-            *      o   -0-       *             *                            *              o                        *  ");
        System.out.println("                                                                               o                                                         o                                                              o                                                ");
        System.out.println("                 *       -0-     o          o                   o                                                                                         -0-                           o                     o        o                      -          ");
        System.out.println("*    -0-        -0-                              o                                               -0-                      o           o                                 o                                                               o                ");
        System.out.println("                                                    -0-      o         o                                                                          *         *                        *             *                           o                 *       ");
        System.out.println("*   o                                                                                  *                 -0-                                                               -0-                                -0-                                        ");
        System.out.println("*               *         -0-              *                                                                                                                        *                  o                   o        o         *            o             ");
        System.out.println("        *                        o                                                              o                        -0-             *         *                                                                                 o        -0-        ");
        System.out.println("   *                                               o                                  *                                                                       *                                                                                    *     ");
        System.out.println("                      *                    *                     *                                             *                                                                                                -0-               -0-                    ");
        System.out.println("   -0-       *                                                                                                                                                        -0-         *                     *                                   *     o      ");
        System.out.println("        -0-                   *                                                                                                                                                                                              *                           ");
        System.out.println("    *            o                                                                                                                                                                                                                                       ");
        System.out.println("                                                                                                                                                                                                                                      *                  ");
        System.out.println("             -0-                                                                                                                                                                                                                                   -0-   ");
        System.out.println("               *       __                                                                                                                                                                                                                   -0-          ");
        System.out.println("                       \\ \\_____                                                                                                                                                                                        ^                       *       ");
        System.out.println("    o               ###[==_____>                                                   _______ _     _ _______ __   _ _     _ _______      _______  _____   ______                                                              !               *            ");
        System.out.println("   *                   /_/                                                            |    |_____| |_____| | \\  | |____/  |______      |______ |     | |_____/                                                        !                                 ");
        System.out.println("                                                                                      |    |     | |     | |  \\_| |    \\_ ______|      |       |_____| |    \\_                                                     / \\              o      *         ");
        System.out.println("    o    *                                                                                                                                                                                                           /___\\                              ");
        System.out.println("      -0-                                                                                                                                                                                                            |=  =|                              ");
        System.out.println("                                                                                                                                                                                                                     |=  =|                              ");
        System.out.println("   *       *                                                                                       _____         _______ __   __ _____ __   _  ______                                                                |    |            -0-        *      ");
        System.out.println("o   o                                                                                             |_____] |      |_____|   \\_/     |   | \\  | |  ____                                                              |    |                              ");
        System.out.println("            *                                                                                     |       |_____ |     |    |    __|__ |  \\_| |_____|                                                               |    |                   0          ");
        System.out.println("                                        /\\                                                                                                                                                                           |    |                *            ");
        System.out.println("*      -0-                            .'  '.                                                                                                                                                                         |    |                   0     *    ");
        System.out.println("                                     /======\\                                                                                                                                                                        |    |                             ");
        System.out.println("   *                                ;:.  _   ;                                                                        CREATORS                                                                                      /|    |\\                            ");
        System.out.println("            *                       |:. (_)  |                                                                                                                                                                     / |#!##|\\\\          *               ");
        System.out.println("o                                   |:.  _   |                                                                       SEFA CELIK                                                                                   /  |#!##| \\\\                         ");
        System.out.println("                                    |:. (_)  |                                                                                                                                                                   /   |#!##|  \\\\                  *     ");
        System.out.println("                                    ;:.      ;                                                                       GUNEY SOGUT                                                                                 |  / ^ | ^ \\  |         -0-            ");
        System.out.println("     *                            .' \\:.    / `.                                                                                                                                                                 | /  ( | )  \\ |                   *   ");
        System.out.println("              o                  / .-'':._.'`-. \\                                                                    HASAN BALIKCI                                                                               |/   ( | )   \\|             o         ");
        System.out.println("*                                |/    /||\\    \\|                                                                                                                                                                    ((   ))                           ");
        System.out.println("     *   -0-                  _..--\"\"\"````\"\"\"--.._                                                                  DENIZ KATAYIFCI                                                                                 ((  :  ))                      ");
        System.out.println("o                          _.-'``                    ``'-._                                                                                                                                                         ((  :  ))                            ");
        System.out.println("                         -'                                '-                                                                                                                                                        ((   ))                      *      ");
        System.out.println("      o                                                                                                                                                                                                               (( ))           *      -0-         ");
        System.out.println("*  -0-          -0-                                                                                                                                                                                                    ( )    -0-                        ");
        System.out.println("                              0                -0-                                                                         -0-       *               -0-                   -0-          *                0              .                                ");
        System.out.println("   *       *                                                                      *                               *                                                *                             -0-           *        .                      *         ");
        System.out.println("                0       *      *                                 -0-    *               -0-      0                                                                              0                                       .                                ");
        System.out.println("      o                                                     0                                                                           -0-      0                                                                      .             *                  ");
        System.out.println("*        -0-                          -0-   *                                 *                                    *                                                                                       *            .                  o             ");
        System.out.println("                o               *                                 *                           *        0                   0          *                   *                   -0-                      0                  *    -0-                       ");
        System.out.println("    *                                               *                     -0-                                                                                0                             *                                                   *         ");
        System.out.println("o     *                                                                                 *                                                                                                                                                                ");
        System.out.println("                              *                                                                                                                *                       *                                         *                               -0-     ");
        System.out.println("  *                                                                                                                   *                                                                                                              *                   ");
        System.out.println("            -0-                                  *            *                                *                                                        *                                   *                            *                               ");
        try {
            Thread.sleep(3000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        System.exit(0);
    }
	//printing player's score
	public void printPlayerScore(){


        console.getTextWindow().setCursorPosition(158, 34);
        System.out.println(Game.player.getScore());
    }
	//printing player's energy
	public void printEnergy(){
        console.getTextWindow().setCursorPosition(156,38);
        System.out.println("Energy Time : " + Game.player.getEnergy());
    }
	//printing player's backpack
    public void printBackpack(Stack stack) {
        // if stack is empty
        if (stack.isEmpty())
            return;
        // extract top of the stack
        Object object = stack.peek();
        // pop the top element
        stack.pop();
        // print the current top element
        System.out.println(((Treasure)object).getSign() + " |");
        // print remaining stack using recursion
        printBackpack(stack);
        // push the element back
        stack.push(object);
    }
    //printing input queue
    public void printCircularQueue(CircularQueue circularQueue){
        console.getTextWindow().setCursorPosition(147,19);
        for (int i = 0; i < circularQueue.size(); i++) {
        	if(circularQueue.peek() instanceof Treasure)
        	{
        		System.out.print(((Treasure)circularQueue.peek()).getSign());
        	}
        	else
        	{
        		System.out.print(((Computer)circularQueue.peek()).getSign());
        	}
            circularQueue.enqueue(circularQueue.dequeue());
        }
    }
    //printing story of the game
    public void printStory() {
        System.out.println("             *                -0-          .    *o       -0-              *                            *     -0-                 *   -0-                  *                *                  -0-   o                 -0-      *         -0-      *      ");
        System.out.println("    o          -0-         *              *          o          *                    *           *                 o     *     -0-            *      o   -0-       *             *                            *              o                        *  ");
        System.out.println("                                                                               o                                                         o                                                              o                                                ");
        System.out.println("                 *       -0-     o          o                   o                                                                                         -0-                           o                     o        o                      -          ");
        System.out.println("*    -0-        -0-                              o                                               -0-                      o           o                                 o                                                               o                ");
        System.out.println("                                                    -0-      o         o                                                                          *         *                        *             *                           o                 *       ");
        System.out.println("*   o                                                                                  *                 -0-                                                               -0-                                -0-                                        ");
        System.out.println("*               *         -0-              *                                                                                                                        *                  o                   o        o         *            o             ");
        System.out.println("        *                        o                                                              o                        -0-             *         *                                                                                 o        -0-        ");
        System.out.println("   *                                               o                                  *                                                                       *                                                                                    *     ");
        System.out.println("                      *                    *                     *                                             *                                                                                                -0-               -0-                    ");
        System.out.println("   -0-       *                                                                                                                                                        -0-         *                     *                                   *     o      ");
        System.out.println("        -0-                   *                                                                                                                                                                                              *                           ");
        System.out.println("    *            o                                                                                                                                                                                                                                       ");
        System.out.println("                                                                                                                                                                                                                                      *                  ");
        System.out.println("             -0-                                                                                                                                                                                                                                   -0-   ");
        System.out.println("               *       __                                                                                                                                                                                                                   -0-          ");
        System.out.println("                       \\ \\_____                                                                                                                                                                                        ^                       *       ");
        System.out.println("    o               ###[==_____>                                                                                                                                                                                       !                    *            ");
        System.out.println("   *                   /_/                                                                                                                                                                                             !                                 ");
        System.out.println("                                                                                                                                                                                                                      / \\              o      *         ");
        System.out.println("    o    *                                                                                                                                                                                                           /___\\                              ");
        System.out.println("      -0-                                                                                                                                                                                                            |=  =|                              ");
        System.out.println("                                                                                                                                                                                                                     |=  =|                              ");
        System.out.println("   *       *                                                                                                                                                                                                         |    |            -0-        *      ");
        System.out.println("o   o                                                                                                                                                                                                                |    |                              ");
        System.out.println("            *                                                                                                                                                                                                        |    |                   0          ");
        System.out.println("                                        /\\                                                                                                                                                                           |    |                *            ");
        System.out.println("*      -0-                            .'  '.                                                                                                                                                                         |    |                   0     *    ");
        System.out.println("                                     /======\\                                                                                                                                                                        |    |                             ");
        System.out.println("   *                                ;:.  _   ;                                                                                                                                                                      /|    |\\                            ");
        System.out.println("            *                       |:. (_)  |                                                                                                                                                                     / |#!##|\\\\          *               ");
        System.out.println("o                                   |:.  _   |                                                                                                                                                                    /  |#!##| \\\\                         ");
        System.out.println("                                    |:. (_)  |                                                                                                                                                                   /   |#!##|  \\\\                  *     ");
        System.out.println("                                    ;:.      ;                                                                                                                                                                   |  / ^ | ^ \\  |         -0-            ");
        System.out.println("     *                            .' \\:.    / `.                                                                                                                                                                 | /  ( | )  \\ |                   *   ");
        System.out.println("              o                  / .-'':._.'`-. \\                                                                                                                                                                |/   ( | )   \\|             o         ");
        System.out.println("*                                |/    /||\\    \\|                                                                                                                                                                    ((   ))                           ");
        System.out.println("     *   -0-                  _..--\"\"\"````\"\"\"--.._                                                                                                                                                                  ((  :  ))                      ");
        System.out.println("o                          _.-'``                    ``'-._                                                                                                                                                         ((  :  ))                            ");
        System.out.println("                         -'                                '-                                                                                                                                                        ((   ))                      *      ");
        System.out.println("      o                                                                                                                                                                                                               (( ))           *      -0-         ");
        System.out.println("*  -0-          -0-                                                                                                                                                                                                    ( )    -0-                        ");
        System.out.println("                              0                -0-                                                                         -0-       *               -0-                   -0-          *                0              .                                ");
        System.out.println("   *       *                                                                      *                               *                                                *                             -0-           *        .                      *         ");
        System.out.println("                0       *      *                                 -0-    *               -0-      0                                                                              0                                       .                                ");
        System.out.println("      o                                                     0                                                                           -0-      0                                                                      .             *                  ");
        System.out.println("*        -0-                          -0-   *                                 *                                    *                                                                                       *            .                  o             ");
        System.out.println("                o               *                                 *                           *        0                   0          *                   *                   -0-                      0                  *    -0-                       ");
        System.out.println("    *                                               *                     -0-                                                                                0                             *                                                   *         ");
        System.out.println("o     *                                                                                 *                                                                                                                                                                ");
        System.out.println("                              *                                                                                                                *                       *                                         *                               -0-     ");
        System.out.println("  *                                                                                                                   *                                                                                                              *                   ");
        System.out.println("            -0-                                  *            *                                *                                                        *                                   *                            *                               ");
        console.getTextWindow().setCursorPosition(80 , 20);
        System.out.println("DAY 1:");
        console.getTextWindow().setCursorPosition(80 , 21);
        System.out.println("    You are now in an astronaut's space diary. We have been commissioned to establish a colony on Mars. A  ");
        console.getTextWindow().setCursorPosition(80 , 22);
        System.out.println("short time ago, our spaceship was attacked by creatures we can't understand what they are. We thought      ");
        console.getTextWindow().setCursorPosition(80 , 23);
        System.out.println("we had discovered an alien species. While my colleagues were repairing the spaceship, I was going to       ");
        console.getTextWindow().setCursorPosition(80 , 24);
        System.out.println("investigate these creatures. I didn't know how long I was going to spend away from the spaceship, and I    ");
        console.getTextWindow().setCursorPosition(80 , 25);
        System.out.println("took as much food as I could with me. I didn't know what to expect, but I had to catch them. I felt a great");
        console.getTextWindow().setCursorPosition(80 , 26);
        System.out.println("vibration while I followed the tracks they left.  When I woke up, I was at the bottom of a big rock and I  ");
        console.getTextWindow().setCursorPosition(80 , 27);
        System.out.println("was running out of oxygen. The spaceship was not in my line of sight.My food, my equipment,my oxygen supply");
        console.getTextWindow().setCursorPosition(80 , 28);
        System.out.println("were scattered around. I needed to collect them before I ran out of strength, but I was feeling the same   ");
        console.getTextWindow().setCursorPosition(80 , 29);
        System.out.println("vibration again. I hid and watched. I couldn't have caught them without my gun. I saw my gun gun at the foot");
        console.getTextWindow().setCursorPosition(80 , 30);
        System.out.println("of another rock. I grabbed the gun as fast as I could and hid. (You know, being fast in space isn't easy.) ");
        console.getTextWindow().setCursorPosition(80 , 31);
        System.out.println("I was horrified when they came into my sight. 2 strange creatures were tearing apart my equipment.It was the");
        console.getTextWindow().setCursorPosition(80 , 32);
        System.out.println("first time in my life that I had seen such a species. I can't explain what they look like because neither I ");
        console.getTextWindow().setCursorPosition(80 , 33);
        System.out.println("can describe them nor you can understand them! I had to get my oxygen supply before the aliens damaged it. ");
        console.getTextWindow().setCursorPosition(80 , 34);
        System.out.println("Otherwise, I would die of oxygen starvation. I took a deep breath and grabbed my gun. Here we go!!");
    }
    //printing info about game.
    public void printGameInfo() {
   	 System.out.println("             *                -0-          .    *o       -0-              *                            *     -0-                 *   -0-                  *                *                  -0-   o                 -0-      *         -0-      *      ");
        System.out.println("    o          -0-         *              *          o          *                    *           *                 o     *     -0-            *      o   -0-       *             *                            *              o                        *  ");
        System.out.println("                                                                               o                                                         o                                                              o                                                ");
        System.out.println("                 *       -0-     o          o                   o                                                                                         -0-                           o                     o        o                      -          ");
        System.out.println("*    -0-        -0-                              o                                               -0-                      o           o                                 o                                                               o                ");
        System.out.println("                                                    -0-      o         o                                                                          *         *                        *             *                           o                 *       ");
        System.out.println("*   o                                                                                  *                 -0-                                                               -0-                                -0-                                        ");
        System.out.println("*               *         -0-              *                                                                                                                        *                  o                   o        o         *            o             ");
        System.out.println("        *                        o                                                              o                        -0-             *         *                                                                                 o        -0-        ");
        System.out.println("   *                                               o                                  *                                                                       *                                                                                    *     ");
        System.out.println("                      *                    *                     *                                             *                                                                                                -0-               -0-                    ");
        System.out.println("   -0-       *                                                                                                                                                        -0-         *                     *                                   *     o      ");
        System.out.println("        -0-                   *                                                                                                                                                                                              *                           ");
        System.out.println("    *            o                                                                                                                                                                                                                                       ");
        System.out.println("                                                                                                                                                                                                                                      *                  ");
        System.out.println("             -0-                                                                                                                                                                                                                                   -0-   ");
        System.out.println("               *       __                                                                                                                                                                                                                   -0-          ");
        System.out.println("                       \\ \\_____                                                                                                                                                                                        ^                       *       ");
        System.out.println("    o               ###[==_____>                                                                                                                                                                                       !                    *            ");
        System.out.println("   *                   /_/                                                                                                                                                                                             !                                 ");
        System.out.println("                                                                                                                                                                                                                      / \\              o      *         ");
        System.out.println("    o    *                                                                                                                                                                                                           /___\\                              ");
        System.out.println("      -0-                                                                                                                                                                                                            |=  =|                              ");
        System.out.println("                                                                                                                                                                                                                     |=  =|                              ");
        System.out.println("   *       *                                                                                                                                                                                                         |    |            -0-        *      ");
        System.out.println("o   o                                                                                                                                                                                                                |    |                              ");
        System.out.println("            *                                                                                                                                                                                                        |    |                   0          ");
        System.out.println("                                        /\\                                                                                                                                                                           |    |                *            ");
        System.out.println("*      -0-                            .'  '.                                                                                                                                                                         |    |                   0     *    ");
        System.out.println("                                     /======\\                                                                                                                                                                        |    |                             ");
        System.out.println("   *                                ;:.  _   ;                                                                                                                                                                      /|    |\\                            ");
        System.out.println("            *                       |:. (_)  |                                                                                                                                                                     / |#!##|\\\\          *               ");
        System.out.println("o                                   |:.  _   |                                                                                                                                                                    /  |#!##| \\\\                         ");
        System.out.println("                                    |:. (_)  |                                                                                                                                                                   /   |#!##|  \\\\                  *     ");
        System.out.println("                                    ;:.      ;                                                                                                                                                                   |  / ^ | ^ \\  |         -0-            ");
        System.out.println("     *                            .' \\:.    / `.                                                                                                                                                                 | /  ( | )  \\ |                   *   ");
        System.out.println("              o                  / .-'':._.'`-. \\                                                                                                                                                                |/   ( | )   \\|             o         ");
        System.out.println("*                                |/    /||\\    \\|                                                                                                                                                                    ((   ))                           ");
        System.out.println("     *   -0-                  _..--\"\"\"````\"\"\"--.._                                                                                                                                                                  ((  :  ))                      ");
        System.out.println("o                          _.-'``                    ``'-._                                                                                                                                                         ((  :  ))                            ");
        System.out.println("                         -'                                '-                                                                                                                                                        ((   ))                      *      ");
        System.out.println("      o                                                                                                                                                                                                               (( ))           *      -0-         ");
        System.out.println("*  -0-          -0-                                                                                                                                                                                                    ( )    -0-                        ");
        System.out.println("                              0                -0-                                                                         -0-       *               -0-                   -0-          *                0              .                                ");
        System.out.println("   *       *                                                                      *                               *                                                *                             -0-           *        .                      *         ");
        System.out.println("                0       *      *                                 -0-    *               -0-      0                                                                              0                                       .                                ");
        System.out.println("      o                                                     0                                                                           -0-      0                                                                      .             *                  ");
        System.out.println("*        -0-                          -0-   *                                 *                                    *                                                                                       *            .                  o             ");
        System.out.println("                o               *                                 *                           *        0                   0          *                   *                   -0-                      0                  *    -0-                       ");
        System.out.println("    *                                               *                     -0-                                                                                0                             *                                                   *         ");
        System.out.println("o     *                                                                                 *                                                                                                                                                                ");
        System.out.println("                              *                                                                                                                *                       *                                         *                               -0-     ");
        System.out.println("  *                                                                                                                   *                                                                                                              *                   ");
        System.out.println("            -0-                                  *            *                                *                                                        *                                   *                            *                               ");
        console.getTextWindow().setCursorPosition(65 , 14);
        System.out.println("    The game is played in a 23*55 game field including walls. There are two competitors: Player (P) and Computer (C). There are some ");
        console.getTextWindow().setCursorPosition(65 , 15);
        System.out.println("some treasures/numbers in the game, which the players collect to increase their scores. The aim of the game is gaining the highest");
        console.getTextWindow().setCursorPosition(65 , 16);
        System.out.println("end-game score.");
        console.getTextWindow().setCursorPosition(65 , 17);
        System.out.println("Star Trek Warp Wars Elements:");
        console.getTextWindow().setCursorPosition(65 , 18);
        System.out.println("     P : Player:");
        console.getTextWindow().setCursorPosition(65 , 19);
        System.out.println("          •	Player uses cursor keys to control P.");
        console.getTextWindow().setCursorPosition(65 , 20);
        System.out.println("          •	Player has a backpack (size of 8 elements).");
        console.getTextWindow().setCursorPosition(65 , 21);
        System.out.println("          •	Player uses WASD keys to remove an element from the backpack.");
        console.getTextWindow().setCursorPosition(65 , 22);
        System.out.println("          •	Player has an energy for quick movement (2 times faster).");
        console.getTextWindow().setCursorPosition(65 , 23);
        System.out.println("     C : Computer robots:");
        console.getTextWindow().setCursorPosition(65 , 24);
        System.out.println("          •	Computer controls all C robots.");
        console.getTextWindow().setCursorPosition(65 , 25);
        System.out.println("          •	Treasures are 2 times valuable for computer.");
        console.getTextWindow().setCursorPosition(65 , 26);
        System.out.println("          •	C robot selects a target, then tries to go to that target directly.   ");
        console.getTextWindow().setCursorPosition(65 , 27);
        System.out.println("     Numbers (1-5): Treasure elements:");
        console.getTextWindow().setCursorPosition(65 , 28);
        System.out.println("          •	1-3 : Static numbers. They cannot move.");
        console.getTextWindow().setCursorPosition(65 , 29);
        System.out.println("          •	4-5 : Moving numbers. They move randomly.");
        console.getTextWindow().setCursorPosition(65 , 30);
        System.out.println("     Other treasures:");
        console.getTextWindow().setCursorPosition(65 , 31);
        System.out.println("          •	= : Trap device. It stops the numbers and C robots.");
        console.getTextWindow().setCursorPosition(65 , 32);
        System.out.println("          •	* : Warp device. It warps the numbers and C robots (So, they are out of game).");
        console.getTextWindow().setCursorPosition(65 , 33);
        System.out.println("		  o   Computer robots and numbers cannot detect/avoid trap/warp devices. ");
        console.getTextWindow().setCursorPosition(65 , 34);
        System.out.println("          o   Trap and warp devices do not affect human player.");
        console.getTextWindow().setCursorPosition(65 , 35);
        System.out.println("          o   Trap and warp devices have an effect (trap/warp) area: Square of the device and 8 neighbor squares (total 3*3 area) ");
        console.getTextWindow().setCursorPosition(65 , 36);
        System.out.println("          o   Trap and warp devices have a duration: They are active for 25 seconds after activation, then they disappear. ");
        console.getTextWindow().setCursorPosition(65 , 37);
        System.out.println("    The player leaves the items in his bag around with the wasd keys. If the number of items at the top of the bag is different, they");
        console.getTextWindow().setCursorPosition(65 , 38);
        System.out.println(" will disappear. If the same, two '2's combine to give energy for 30 seconds, two '3's combine to give a trap device, two '4's combine");
        console.getTextWindow().setCursorPosition(65 , 38);
        System.out.println("to give energy for 240 seconds, two '5's combine to give a warp device.");
        console.getTextWindow().setCursorPosition(65 , 39);
        System.out.println("    You have the right to die 5 times in the game. Every time computer robots approach you, a life is lost. At the end of the game, the");
        console.getTextWindow().setCursorPosition(65 , 40);
        System.out.println("difference between the points collected by the computer robots and the points collected by the player becomes your score.");  
   }
	
}

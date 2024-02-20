import java.awt.Color;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;

import enigma.console.TextAttributes;

public class Solitaire {	
	public KeyListener klis; 
	// ------ Standard variables for mouse and keyboard ------
	public int keypr;   // key pressed?
	public int rkey;    // key   (for press/release)
	// -------------------------------------------------------
	
	int px = 13 ,py = 7;
	
	ArrayFunction arrayFunc = new ArrayFunction();
	Utilities utility = new Utilities();
	PrintFunctions printer = new PrintFunctions();
	Columns columns = new Columns();
	public static DoubleLinkedList dll = new DoubleLinkedList();
	
	boolean boxOpened = false;
	boolean pressedZKey = false;
	int[] pressedZCards;
	int pressedZCardsColumn;
	
	
 	Solitaire () throws InterruptedException{
 		Columns.box = columns.boxCreator();
 		columns.firstRandomCards();
 		try {
			highScoreToList();
		} catch (NumberFormatException | IOException e) {
			e.printStackTrace();
		}
 		
 		printer.printMenu();
		inGame();
	}
	
	public void inGame() throws InterruptedException {	
		klis=new KeyListener() {
	         public void keyTyped(KeyEvent e) {}
	         public void keyPressed(KeyEvent e) {
	            if(keypr==0) {
	               keypr=1;
	               rkey=e.getKeyCode();
	            }
	         }
	         public void keyReleased(KeyEvent e) {}
	      };
	      PrintFunctions.console.getTextWindow().addKeyListener(klis);
	      
	      while(true) {
	          if(keypr==1) {    // if keyboard button pressed
	        	  
	        	 int temp_px = px;
	        	 int temp_py = py;
	        	 
	        	 String[] c1 = columns.column1.display().split(" ");
	             String[] c2 = columns.column2.display().split(" ");
	             String[] c3 = columns.column3.display().split(" ");
	             String[] c4 = columns.column4.display().split(" ");
	             String[] c5 = columns.column5.display().split(" ");
	             
	             if(rkey==KeyEvent.VK_LEFT) {
	            	 if (px != 13)
	            		 px = px - 9;
	             }
	             if(rkey==KeyEvent.VK_RIGHT) {
	            	 if (px != 49)
	            		 px = px + 9;
	             }
	             if(rkey==KeyEvent.VK_DOWN) {
	            	 if (px == 13) {
	            		 if(py < Columns.column1.size() + 6)
	            			 py = py + 1;
	            	 }
	            	 else if (px == 22) {
	            		 if(py < Columns.column2.size() + 6)
	            			 py = py + 1;
	            	 }
	            	 else if (px == 31) {
	            		 if(py < Columns.column3.size() + 6)
	            			 py = py + 1;
	            	 }
	            	 else if (px == 40) {
	            		 if(py < Columns.column4.size() + 6)
	            			 py = py + 1;
	            	 }
	            	 else if (px == 49) {
	            		 if(py < Columns.column5.size() + 6)
	            			 py = py + 1;
	            	 }		 
	             }
	             if(rkey==KeyEvent.VK_UP) {
	            	 if (py != 7)
	            		 py = py - 1;
	             }
	             if(rkey == KeyEvent.VK_ESCAPE) {
	            	 utility.cleanConsole();
	            	 printer.printMenu();
	             }
	             
	             
	             if(rkey==KeyEvent.VK_Z) {
	            	 PrintFunctions.console.getTextWindow().setCursorPosition(px , py);
	            	 PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.RED));
	            	 if (px == 13) {
	            		for (int i = 0; i < c1.length - (py - 7); i++) {
	            			PrintFunctions.console.getTextWindow().setCursorPosition(px , py + i);
	            			System.out.println(c1[py - 7 + i]);
	            			pressedZCards = arrayFunc.addItemToArray(pressedZCards, Integer.parseInt(c1[py - 7 + i]));
						}
	            		PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
	            		pressedZCardsColumn = 1;
	            	 }
	            	 else if (px == 22) {
	            		 for (int i = 0; i < c2.length - (py - 7); i++) {
		            			PrintFunctions.console.getTextWindow().setCursorPosition(px , py + i);
		            			System.out.println(c2[py - 7 + i]);
		            			pressedZCards = arrayFunc.addItemToArray(pressedZCards, Integer.parseInt(c2[py - 7 + i]));
							}
		            		PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		            		pressedZCardsColumn = 2;
	            	 }
	            	 else if (px == 31) {
	            		 for (int i = 0; i < c3.length - (py - 7); i++) {
		            			PrintFunctions.console.getTextWindow().setCursorPosition(px , py + i);
		            			System.out.println(c3[py - 7 + i]);
		            			pressedZCards = arrayFunc.addItemToArray(pressedZCards, Integer.parseInt(c3[py - 7 + i]));
							}
		            		PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		            		pressedZCardsColumn = 3;
	            	 }
	            	 else if (px == 40) {
	            		 for (int i = 0; i < c4.length - (py - 7); i++) {
		            			PrintFunctions.console.getTextWindow().setCursorPosition(px , py + i);
		            			System.out.println(c4[py - 7 + i]);
		            			pressedZCards = arrayFunc.addItemToArray(pressedZCards, Integer.parseInt(c4[py - 7 + i]));
							}
		            		PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		            		pressedZCardsColumn = 4;
	            	 }
	            	 else if (px == 49) {
	            		 for (int i = 0; i < c5.length - (py - 7); i++) {
		            			PrintFunctions.console.getTextWindow().setCursorPosition(px , py + i);
		            			System.out.println(c5[py - 7 + i]);
		            			pressedZCards = arrayFunc.addItemToArray(pressedZCards, Integer.parseInt(c5[py - 7 + i]));
							}
		            		PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		            		pressedZCardsColumn = 5;
	            	 }
	            	 pressedZKey = true;
	             }
	             
	             
	             if(rkey==KeyEvent.VK_X) {
	            	 PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
	            	 if ((px == 13) && (pressedZCards[pressedZCards.length - 1] == (int)Columns.column1.peekLastNode()
	            			 || pressedZCards[pressedZCards.length - 1] - 1 == (int)Columns.column1.peekLastNode()
	            			 || pressedZCards[pressedZCards.length - 1] + 1 == (int)Columns.column1.peekLastNode())) {
	            		for (int i = 0; i < pressedZCards.length; i++) {
	            			Columns.column1.add(pressedZCards[i]);
	            			PrintFunctions.console.getTextWindow().setCursorPosition(px , 7 + c1.length + i);
	            			System.out.println(pressedZCards[i]);
						}
	            	 }
	            	 else if (px == 22) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
		            		Columns.column2.add(pressedZCards[i]);
		            		PrintFunctions.console.getTextWindow().setCursorPosition(px , 7 + c2.length + i);
		            		System.out.println(pressedZCards[i]);	            		 }
	            	 }
	            	 else if (px == 31) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
			            	Columns.column3.add(pressedZCards[i]);
			            	PrintFunctions.console.getTextWindow().setCursorPosition(px , 7 + c3.length + i);
			            	System.out.println(pressedZCards[i]);
	            		 }
	            	 }
	            	 else if (px == 40) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
			            	Columns.column4.add(pressedZCards[i]);
			            	PrintFunctions.console.getTextWindow().setCursorPosition(px , 7 + c4.length + i);
			            	System.out.println(pressedZCards[i]);
	            		 }
	            	 }
	            	 else if (px == 49) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
			            	Columns.column5.add(pressedZCards[i]);
			            	PrintFunctions.console.getTextWindow().setCursorPosition(px , 7 + c5.length + i);
			            	System.out.println(pressedZCards[i]);
	            		 }
	            	 }
	            	 
	            	 
	            	 if(pressedZCardsColumn == 1) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
	            			 PrintFunctions.console.getTextWindow().setCursorPosition(13 , 7 + c1.length - pressedZCards.length + i);
				             System.out.println("  ");
				             Columns.column1 = Columns.column1.popLastNode();
						}
	            	 }
	            	 else if(pressedZCardsColumn == 2) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
	            			 PrintFunctions.console.getTextWindow().setCursorPosition(22 , 7 + c2.length - pressedZCards.length + i);
				             System.out.println("  ");
				             Columns.column2 = Columns.column2.popLastNode();
						}
	            	 }
	            	 else if(pressedZCardsColumn == 3) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
	            			 PrintFunctions.console.getTextWindow().setCursorPosition(31 , 7 + c3.length - pressedZCards.length + i);
				             System.out.println("  ");
				             Columns.column3 = Columns.column3.popLastNode();
						}
	            	 }
	            	 else if(pressedZCardsColumn == 4) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
	            			 PrintFunctions.console.getTextWindow().setCursorPosition(40 , 7 + c4.length - pressedZCards.length + i);
				             System.out.println("  ");
				             Columns.column4 = Columns.column4.popLastNode();
						}
	            	 }
	            	 else if(pressedZCardsColumn == 5) {
	            		 for (int i = 0; i < pressedZCards.length; i++) {
	            			 PrintFunctions.console.getTextWindow().setCursorPosition(49 , 7 + c5.length - pressedZCards.length + i);
				             System.out.println("  ");
				             Columns.column5 = Columns.column5.popLastNode();
						}
	            	 }
	            	 
	            	 
	            	 pressedZCards = null;
	             }
	             if(rkey==KeyEvent.VK_B) {
	            	 if(!boxOpened) {
	            		 PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
	            		 PrintFunctions.console.getTextWindow().setCursorPosition(62 , 16);
		            	 System.out.println(columns.box.printBoxElement());
		            	 boxOpened = true;
	            	 }
	             }
	            	 
	             char rckey=(char)rkey;
	             
	        
	             //        left          right          up            down
	             if(rckey=='%' || rckey=='\'' || rckey=='&' || rckey=='(') {
	            	 PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.BLUE));
	            	 PrintFunctions.console.getTextWindow().setCursorPosition(px , py);
	            	 if (px == 13) {
	            		 System.out.println(c1[py - 7]);
	            	 }
	            	 else if (px == 22) {
	            		 System.out.println(c2[py - 7]);
	            	 }
	            	 else if (px == 31) {
	            		 System.out.println(c3[py - 7]);
	            	 }
	            	 else if (px == 40) {
	            		 System.out.println(c4[py - 7]);
	            	 }
	            	 else if (px == 49) {
	            		 System.out.println(c5[py - 7]);
	            	 }	
	            	 if (!pressedZKey && (temp_px != px || temp_py != py)) {
	            		 PrintFunctions.console.setTextAttributes(new TextAttributes(Color.WHITE, Color.DARK_GRAY));
		            	 PrintFunctions.console.getTextWindow().setCursorPosition(temp_px , temp_py);
		            	 if (temp_px == 13) {
		            		 System.out.println(c1[temp_py - 7]);
		            	 }
		            	 else if (temp_px == 22) {
		            		 System.out.println(c2[temp_py - 7]);
		            	 }
		            	 else if (temp_px == 31) {
		            		 System.out.println(c3[temp_py - 7]);
		            	 }
		            	 else if (temp_px == 40) {
		            		 System.out.println(c4[temp_py - 7]);
		            	 }
		            	 else if (temp_px == 49) {
		            		 System.out.println(c5[temp_py - 7]);
		            	 }
	            	 }
	            	 pressedZKey = false;
	             }
	             
	             else PrintFunctions.console.getTextWindow().output(rckey);
	             keypr=0;    // last action  
	          }
	          Thread.sleep(15);
	       }
	}
	
	public  void highScoreToList() throws NumberFormatException, IOException {
		FileInputStream fStreamHighScore2=new FileInputStream("./src/HighScoreTable.txt");
		BufferedReader bReaderHighScore2=new BufferedReader(new InputStreamReader(fStreamHighScore2));
		String tmpString;
		
		while((tmpString=bReaderHighScore2.readLine())!=null) {
			String[] players =tmpString.split(":");
			String name = players[0];
			String scr = players[1];
			double score = Double.parseDouble(scr);
			Player pl = new Player(name,score);
			dll.orderedAdd(pl);
		}
	}
}

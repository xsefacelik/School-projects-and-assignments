import java.io.File;  
import java.io.FileNotFoundException;  
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		int[] demands = new int[51];
		int[] salarys = new int[311];
		
		
		
		try {
		      File myObj = new File("./src/yearly_player_demand.txt");
		      Scanner myReader = new Scanner(myObj);
		      int counter = 0;
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        
		        if (counter != 0) {
		        	String[] datas = data.split("\t");
		        	demands[counter] = Integer.parseInt(datas[1]);
		        }
		        counter++;
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
		
		try {
		      File myObj = new File("./src/players_salary.txt");
		      Scanner myReader = new Scanner(myObj);
		      int counter = 0;
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        
		        if (counter != 0) {
		        	String[] datas = data.split("\t");
		        	salarys[counter] = Integer.parseInt(datas[1]);
		        }
		        counter++;
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
		ga(demands, salarys);
		
	}
	
	public static void ga(int[] demands, int[] salarys) {
		final int p = 5, c = 5, n = 50;
		int[] extra = new int[demands.length];
		int cost = 0;
		
		for (int i = 1; i < n + 1; i++) {
			if(demands[i] > p) {
				int neededCoachs = demands[i] - p;
				extra[i] = neededCoachs;
				cost += c * neededCoachs;
			}
			else if(demands[i] < p) {
				int demandsPDifference = p - demands[i];
				if(demands[i + 1] > p) {
					int differenceOfNextYear = demands[i + 1] - p;
					int bestCost = 0;
					int free = 0;
					for (int j = 0; j <= Math.min(demandsPDifference, differenceOfNextYear); j++) {
						int tempCost = (c * (Math.min(demandsPDifference, differenceOfNextYear) - j)) + salarys[j];
						if(bestCost == 0 | tempCost < bestCost) {
							free = j;
							bestCost = tempCost;
						}
					}
					
					cost += salarys[free];
					demands[i + 1] -= free;
					extra[i] = 0;
				}
				else {
					extra[i] = 0;
				}
			}
			else if(demands[i] == p) {
				extra[i] = 0;
			}
		}
		
		for (int i = 1; i < n + 1; i++) {
			
			System.out.println(i + "- " + "Extra coach : " + extra[i]);
		}
		System.out.println("Cost: " + cost);
	}
}

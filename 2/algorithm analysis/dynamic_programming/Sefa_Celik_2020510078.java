import java.io.File;  
import java.io.FileNotFoundException;  
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		int[] demands = new int[51];
		int[] salarys = new int[311];
		
		int[][] dp = new int[51][311];
		
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
		
		for (int i = 0; i < dp.length; i++) {
			for (int j = 0; j < dp[i].length; j++) {
				if(i == 0) {
					dp[i][j] = salarys[j];
				}
			}
		}
		
		dp(demands, dp);
	}
	
	public static void dp(int[] demands, int[][] dp) {
		final int p = 5, c = 5, n = 3;
		
		String[][] line = new String[dp.length][dp[0].length];
		
		for (int i = 0; i < n + 2; i++) {
			
			if(i == n + 1) {
				System.out.println("Total cost : " + dp[n][0]);
				break;
			}
			for (int j = 0; j < dp[i].length; j++) {
				if(i == 0) {
					continue;
				}
				
				int temp = 0;
				String linetemp = null;
				
				if(demands[i] < p) {
					int diff = demands[i] - p + j;
					
					if(diff < 0) {
						temp = dp[i - 1][0] + dp[0][j];
						linetemp = "0 extra:" + (i - 1) + "," + j;
					}
					
					else if(diff == 0) {
						int tempDiff = p - demands[i];
						for (int k = 0; k < tempDiff; k++) {
							if(j + k > 310)
								break;
							int tempcost = (0 * (tempDiff - k)) + (dp[i - 1][k]) + dp[0][j];
							if(tempcost < temp | temp == 0) {
								temp = tempcost;
								linetemp = 0 + " extra:" + (i - 1) + "," + k;
							}
						}
					}
					
					else{
						int tempDiff = j;
						for (int k = 0; k < tempDiff; k++) {
							if(j + k > 310)
								break;
							int tempcost;
							if(tempDiff - k <= p - demands[i])
								tempcost = (0 * (tempDiff - k)) + (dp[i - 1][k]) + dp[0][j];
							else {
								tempcost = (c * (tempDiff - k - (p - demands[i]))) + (dp[i - 1][k]) + dp[0][j];
							}
							if(tempcost < temp | temp == 0) {
								temp = tempcost;
								linetemp = tempDiff - k - (p - demands[i]) + " extra:" + (i - 1) + "," + k;
							}
						}
					}
					dp[i][j] = temp;
					line[i][j] = linetemp;
					temp = 0;
					linetemp = null;
				}
				
				else if(demands[i] >= p){
					int diff = demands[i] - p + j;
					for (int k = 0; k < diff + 1; k++) {
						if(j + k > 310)
							break;
						int tempcost = (c * (diff - k)) + (dp[i - 1][k]) + dp[0][j];
						if(tempcost < temp | temp == 0) {
							temp = tempcost;
							linetemp = "Need " + (diff - k) + " extra coach(s) and:" + (i - 1) + "," + k;
						}
						
					}
					dp[i][j] = temp;
					line[i][j] = linetemp;
					temp = 0;
					linetemp = null;
				}
				
			}
		}
		
		
//		for (int k = 0; k < n + 1; k++) {
//			for (int k2 = 0; k2 < dp[1].length; k2++) {
//				System.out.print(dp[k][k2] + " ");
//			}
//			System.out.println();
//		}
		
		
		int k = n;
		int l = 0;
		while (k > 0) {
			String traceback = line[k][l];
			String[] splitted = traceback.split(":");
			System.out.println(k + ". year: " + splitted[0] + " " + splitted[1].split(",")[1] + " come from previous year.");
			k = Integer.parseInt(splitted[1].split(",")[0]);
			l = Integer.parseInt(splitted[1].split(",")[1]);
		}
	}
}

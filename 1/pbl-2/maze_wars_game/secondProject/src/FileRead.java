import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class FileRead {
	Object[][] mapArr = new Object[23][55];
	ArrayFunction arrayFunctions = new ArrayFunction();
	//this method reads map file
	public Object[][] getMapInFile() {


        try {
            File map = new File("map.txt");
            Scanner myReader = new Scanner(map);
            int i = 0;
            int k = 0;
            while (myReader.hasNextLine()) {
                String data = myReader.nextLine();
                for(k=0; k<data.length();k++)
                {
                    if(data.charAt(k) == ' ') {
                        String position = i + "," + k;
                        Game.spaceAreaIndex = arrayFunctions.addItemToArray(Game.spaceAreaIndex, position);
                    }
                    mapArr[i][k] = data.charAt(k);
                }
                i++;
            }
            myReader.close();

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return mapArr;
    }
    
}

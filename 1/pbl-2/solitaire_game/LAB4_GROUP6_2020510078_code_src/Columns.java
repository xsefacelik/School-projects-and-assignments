
public class Columns {
	ArrayFunction arrayFunc = new ArrayFunction();
	Utilities utility = new Utilities();
	
	public static SLL box;
	
	public static SLL column1 = new SLL();
	public static SLL column2 = new SLL();
	public static SLL column3 = new SLL();
	public static SLL column4 = new SLL();
	public static SLL column5 = new SLL();
	
	
	//create 5 set(0,1,...,9,10)
	public int[] cardsCreator() {
    	int[] resultCards=null;
        for (int i = 0; i < 5; i++) {
        	resultCards = arrayFunc.addItemToArray(resultCards, 1);
        	resultCards = arrayFunc.addItemToArray(resultCards, 2);
            resultCards = arrayFunc.addItemToArray(resultCards, 3);
            resultCards = arrayFunc.addItemToArray(resultCards, 4);
            resultCards = arrayFunc.addItemToArray(resultCards, 5);
            resultCards = arrayFunc.addItemToArray(resultCards, 6);
            resultCards = arrayFunc.addItemToArray(resultCards, 7);
            resultCards = arrayFunc.addItemToArray(resultCards, 8);
            resultCards = arrayFunc.addItemToArray(resultCards, 9);
            resultCards = arrayFunc.addItemToArray(resultCards, 10);
        }
        return resultCards;
    }
	//shuffles the cards and throws them into the box
	public SLL boxCreator() {
		int [] cards = cardsCreator();
		SLL resultBox = new SLL();
        while(cards !=null) {
            int randomIndex = utility.generateRandomNumber(cards.length);
            resultBox.add(cards[randomIndex]);
            cards = arrayFunc.dellIndexInArray(cards, randomIndex);
        }
        return resultBox;
    }
	//adds the first 6 numbers to the columns from the box.
	public void firstRandomCards() {
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 6; j++) {
				if(i == 0)
					column1.add(box.pop());
				else if(i == 1)
					column2.add(box.pop());
				else if(i == 2)
					column3.add(box.pop());
				else if(i == 3)
					column4.add(box.pop());
				else if(i == 4)
					column5.add(box.pop());
			}
		}
	}
}

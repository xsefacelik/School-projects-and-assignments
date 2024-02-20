
public class SLL {
	private Node head;
	
	public void addFromEnd(Object dataToAdd) {			
		if(head == null) {
			Node newnode = new Node(dataToAdd);
			head = newnode;
		}
		else {
			Node temp = head;
			while(temp.getLink() != null) 
				temp = temp.getLink();
			Node newnode = new Node(dataToAdd);
			temp.setLink(newnode);
		}
		
	}
	public void addFromStart(Object dataToAdd) {
		Node newnode = new Node(dataToAdd);
		newnode.setLink(head);
		head = newnode;
	}
	
	public String display(){
		
		String display = "";
		if(head == null) {
			
		}	
		else {
			Node temp = head;
			while(temp != null) {
				display += temp.getData() + " ";
				temp = temp.getLink();
			}
		}
		return display;
	}
	public boolean search(Object data) {
		if(head == null) {
			
		}
		else {
			Node temp = head;
			while(temp != null) {
				if((int)temp.getData() == (int)data)
					return true;
				temp = temp.getLink();
			}
		}
		return false;
	}
	
	//It deletes all the dataToDelete it finds.
	public SLL deleteAll(Object dataToDelete) {
		SLL tempSll = new SLL();
		if(head == null) {
			
		}
		else {
			Node temp = head;
			while(temp != null) {
				if((int)temp.getData() != (int) dataToDelete)
					tempSll.addFromEnd(temp.getData());
				temp = temp.getLink();
			}
		}
		return tempSll;
	}
	//It deletes the first dataToDelete it finds.
	public SLL deleteOnce(Object dataToDelete) {
	
		SLL tempSll = new SLL();
		int isDeleted = 0;
		if(head == null) {
			
		}	
		else {
			Node temp = head;
			while(temp != null) {
				if((int)temp.getData() == (int) dataToDelete)
					isDeleted++;
				if(isDeleted < 2) {
					if((int)temp.getData() != (int) dataToDelete)
						tempSll.addFromEnd(temp.getData());
					temp = temp.getLink();
					if(isDeleted == 1)
						isDeleted++;
				}
				else {
					tempSll.addFromEnd(temp.getData());
					temp = temp.getLink();
				}
			}
		}
		return tempSll;
	}
	
	public int size() {
		int count = 0;
		if(head==null) {
			
		}
		else{
			Node temp = head;
			while(temp != null) {
				count++;
				temp = temp.getLink();
			}
		}
		return count;
	}
	
	//Return the first object in the sll.
	public Object peekFirst() {
		return (Object) head.getData();
	}
	//Return the last object in the sll.
	public Object peekLastNode() {
		Object lastData = null;
		if(head == null) {
			
		}
		else {
			Node temp = head;
			while(temp.getLink() != null) {
				temp = temp.getLink();
			}
			lastData = temp.getData();
		}
		return lastData;
	}
	//Delete the first object in the sll.
	public Object pop() {
		Object retData = this.peekFirst();
		head = head.getLink();
		return retData;
	}
	
	//Sll reverser.
	public SLL reverse() {
	
	
		SLL reversedSll = new SLL();
	    while(this.size() != 0)              
	    {
	    	Object tempValue = this.pop();
	    	reversedSll.addFromStart(tempValue);
	    }
	    return reversedSll;
	}
}

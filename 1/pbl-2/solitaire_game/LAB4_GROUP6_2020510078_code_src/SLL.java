
public class SLL {
	private Node head;
	
	public void add(Object dataToAdd) {
		if(head == null) {
			Node newnode = new Node(dataToAdd);
			head = newnode;
		}
		else {
			Node temp = head;
			while(temp.getLink()!=null) 
				temp= temp.getLink();
			Node newnode = new Node(dataToAdd);
			temp.setLink(newnode);
		}
		
	}
	public String display(){
		
		String display = "";
		if(head == null) {
			
		}	
		else {
			Node temp = head;
			while(temp != null) {
				if(display.equals(""))
					display += temp.getData();
				else
					display += " " + temp.getData();
				temp = temp.getLink();
			}
		}
		return display;
	}
	public boolean search(Object data) {
		if(head==null) {
			System.out.println("List is empty");
		}
		else {
			Node temp = head;
			while(temp!=null) {
				if((int)temp.getData()==(int)data)
					return true;
				temp=temp.getLink();
			}
			
		}
		return false;
	}
	public void remove(Object dataToDelete) {
		if(head == null)
			System.out.println("List is empty");
		else {
			while((int)head.getData() == (int)dataToDelete) 
				head = head.getLink();
			Node temp = head;
			Node previous = null;
			while(temp!=null) {
				if((int)temp.getData()==(int)dataToDelete) {
					previous.setLink(temp.getLink());
					temp = previous;
				}
				
				previous = temp;
				temp = temp.getLink();
			}
			
		}
	}
	public int size() {
		int count = 0;
		if(head==null)
			System.out.println("List is empty");
		else{
			Node temp = head;
			while(temp != null) {
				count++;
				temp = temp.getLink();
			}
		}
		return count;
	}
	//Delete the first object in the sll.
	public Object pop() {
		Object retData = this.peekFirst();
		head = head.getLink();
		return retData;
	}
	//Delete the last element in the sll.
	public SLL popLastNode() {
		SLL tempSll = new SLL();
		if(head == null) {
			
		}	
		else {
			Node temp = head;
			while(temp.getLink() != null) {
				tempSll.add(temp.getData());
				temp = temp.getLink();
			}
		}
		return tempSll;
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
	public int printBoxElement() {
		if(head==null) {
			return -1;
		}
		else if(head.getLink()==null) {
			int tempData=(int)head.getData();
			head=null;
			return tempData;
		}
		else {
			int tempData=(int)head.getData();
			head=head.getLink();
			return tempData;
		}
	}
}

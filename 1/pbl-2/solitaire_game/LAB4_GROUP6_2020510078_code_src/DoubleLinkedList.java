
public class DoubleLinkedList {
	private  dllNode head;
	private dllNode tail;
	
	public DoubleLinkedList() {
		head =null;
		tail = null;
	}
	public void add(Object dataToAdd) {//Add new Node to the end
		if(head == null && tail == null) {
			dllNode newNode = new dllNode(dataToAdd);
			head = newNode;//pointing the first node
			tail = newNode;//pointing the last node
		}
		else {
			dllNode newnode = new dllNode(dataToAdd);
			newnode.setPrev(tail);
			tail.setNext(newnode);
			tail = newnode;
		}
	}

	public int size() {
		int count = 0;
		if(head == null)
			System.out.println("List is empty");
		else {
			dllNode temp = head;
			while(temp != null) {
				count ++;
				temp = temp.getNext();
			}
		}
		return count;
	}
	
	public boolean search(int number) {
		if(head == null)
			System.out.println("List is empty");
		else {
			dllNode temp = tail;
			while(temp != null) {
				if(number == (int)temp.getData()) {
					return true;
				}
				temp = temp.getPrev();
			}
		}
		return false;
	}
	public String display1() {
		String result = "";
		if(head == null) {
			
		}
		else {
			dllNode temp = head;
			while(temp!=null) {
				
				result += ((Player)temp.getData()).getName() + ((Player)temp.getData()).getScore() + ":";
				temp = temp.getNext();
			}
		}
		return result;
	}

	public void swap(int x) {
		if(head == null) {
			System.out.println("List is empty");
			
		}
		else if (x<0 || x> size()) {
			System.out.println("next is out of range");
			
		}
		else {
			dllNode temp = head;
			int element1 = -1;
			int count = 1;
			while(temp != null) {
				if(count ==x) {
					element1 = (int)temp.getData();
					break;
				}
				temp = temp.getNext();
				count ++;
			}
			
			int element2 =-1;
			dllNode temp2 = tail;
			count =1;
			while(temp2 != null) {
				if(count ==x) {
					element2 = (int) temp.getData();
					temp2.setData(element1);
					break;
				}
				temp2 = temp2.getPrev();
				count++;
			}
			temp.setData(element2);
		}
	}
	
	 public void orderedAdd(Player input) {
		 dllNode playerAndScore=new dllNode(input);
			if(head==null) {
				head=playerAndScore;
			}
			else if(((Player)head.getData()).getScore()<(double)input.getScore()) {
				playerAndScore.setNext(head);
				head=playerAndScore;            //if head is less than the incoming number, convert the head to the incoming number
			}
			else {
				dllNode tmp=head;
				while(tmp.getNext()!=null&&((Player)tmp.getNext().getData()).getScore()>(double)input.getScore()) {
					tmp=tmp.getNext();
				}                                     //if temp's link is less than the new score, add the new score between temp and its link
				playerAndScore.setNext(tmp.getNext());
				tmp.setNext(playerAndScore);
			}
	 }
}

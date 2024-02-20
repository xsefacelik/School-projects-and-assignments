package GraphPackage;
import java.security.DrbgParameters.NextBytes;
import java.util.Iterator;
import ADTPackage.*; // Classes that implement various ADTs
/**
 A class that implements the ADT directed graph.
 @author Frank M. Carrano
 @author Timothy M. Henry
 @version 5.1
 */
public class DirectedGraph<T> implements GraphInterface<T>
{	
   private DictionaryInterface<T, VertexInterface<T>> vertices;
   private int edgeCount;
   
   public DirectedGraph()
   {
      vertices = new UnsortedLinkedDictionary<>();
      edgeCount = 0;
   } // end default constructor

   public boolean addVertex(T vertexLabel)
   {
      VertexInterface<T> addOutcome = vertices.add(vertexLabel, new Vertex<>(vertexLabel));
      return addOutcome == null; // Was addition to dictionary successful?
   } // end addVertex
   
   public boolean addEdge(T begin, T end, double edgeWeight)
   {
      boolean result = false;
      VertexInterface<T> beginVertex = vertices.getValue(begin);
      VertexInterface<T> endVertex = vertices.getValue(end);
      if ( (beginVertex != null) && (endVertex != null) )
         result = beginVertex.connect(endVertex, edgeWeight);
      if (result)
         edgeCount++;
      return result;
   } // end addEdge
   
   public boolean addEdge(T begin, T end)
   {
      return addEdge(begin, end, 0);
   } // end addEdge

   public boolean hasEdge(T begin, T end)
   {
      boolean found = false;
      VertexInterface<T> beginVertex = vertices.getValue(begin);
      VertexInterface<T> endVertex = vertices.getValue(end);
      if ( (beginVertex != null) && (endVertex != null) )
      {
         Iterator<VertexInterface<T>> neighbors = beginVertex.getNeighborIterator();
         while (!found && neighbors.hasNext())
         {
            VertexInterface<T> nextNeighbor = neighbors.next();
            if (endVertex.equals(nextNeighbor))
               found = true;
         } // end while
      } // end if
      
      return found;
   } // end hasEdge

	public boolean isEmpty()
	{
	  return vertices.isEmpty();
	} // end isEmpty

	public void clear()
	{
	  vertices.clear();
	  edgeCount = 0;
	} // end clear

	public int getNumberOfVertices()
	{
	  return vertices.getSize();
	} // end getNumberOfVertices

	public int getNumberOfEdges()
	{
	  return edgeCount;
	} // end getNumberOfEdges

	protected void resetVertices()
	{
	   Iterator<VertexInterface<T>> vertexIterator = vertices.getValueIterator();
	   while (vertexIterator.hasNext())
	   {
	      VertexInterface<T> nextVertex = vertexIterator.next();
	      nextVertex.unvisit();
	      nextVertex.setCost(0);
	      nextVertex.setPredecessor(null);
	   } // end while
	} // end resetVertices
	
	public StackInterface<T> getTopologicalOrder() 
	{
		resetVertices();

		StackInterface<T> vertexStack = new LinkedStack<>();
		int numberOfVertices = getNumberOfVertices();
		for (int counter = 1; counter <= numberOfVertices; counter++)
		{
			VertexInterface<T> nextVertex = findTerminal();
			nextVertex.visit();
			vertexStack.push(nextVertex.getLabel());
		} // end for
		
		return vertexStack;	
	} // end getTopologicalOrder
	
	
   
   @SuppressWarnings("rawtypes")
   public LinkedQueue<Vertex> getBreadthFirstSearch(Vertex origin, Vertex end) {
	   int getVisitedVertices = 0;
	   LinkedQueue<Vertex> traversalOrder = new LinkedQueue<Vertex>();
	   LinkedQueue<Vertex> vertexQueue = new LinkedQueue<Vertex>();
	   boolean done = false;
	   origin.visit();
	   getVisitedVertices++;
	   traversalOrder.enqueue(origin);
	   vertexQueue.enqueue(origin);
	   while(!vertexQueue.isEmpty()) {
		   Vertex frontVertex = vertexQueue.dequeue();
		   @SuppressWarnings("unchecked")
		   Iterator<VertexInterface<Vertex>> vertexIterator = frontVertex.getNeighborIterator();
		   while(!done && vertexIterator.hasNext()) {
			   Vertex nextNeighbor = (Vertex) vertexIterator.next();
			   if(!nextNeighbor.isVisited()) {
				   nextNeighbor.visit();
				   getVisitedVertices++;
				   traversalOrder.enqueue(nextNeighbor);
				   vertexQueue.enqueue(nextNeighbor);
				   if(nextNeighbor == end) {
					   done = true;
				   }
			   }
		   }
	   }
	   System.out.println("Number of visited vertices: " + getVisitedVertices);
	   return traversalOrder;
	 //  return the traversal order between origin vertex and end vertex
   }
    

   @SuppressWarnings("rawtypes")
   public LinkedQueue<Vertex> getDepthFirstTraversal(Vertex origin, Vertex end) {
	   int getVisitedVertices = 0;
	   LinkedQueue<Vertex> traversalOrder = new LinkedQueue<Vertex>();
	   LinkedStack<Vertex> vertexStack = new LinkedStack<Vertex>();
	   boolean done = false;
	   origin.visit();
	   getVisitedVertices++;
	   traversalOrder.enqueue(origin);
	   vertexStack.push(origin);
	   while(!done && !vertexStack.isEmpty()) {
		   Vertex topVertex = vertexStack.peek();
		   Vertex unvisited = (Vertex) topVertex.getUnvisitedNeighbor();
		   if(unvisited != null) {
			   Vertex nextNeighbor = unvisited;
			   nextNeighbor.visit();
			   getVisitedVertices++;
			   traversalOrder.enqueue(nextNeighbor);
			   vertexStack.push(nextNeighbor);
			   if(nextNeighbor == end) {
				   done = true;
			   }
		   }
		   else {
			   vertexStack.pop();
		   }
	   }
	   System.out.println("Number of visited vertices: " + getVisitedVertices);
	   return traversalOrder;
	  // return depth first search traversal order between origin vertex and end vertex
   }
		
	
   @SuppressWarnings({ "rawtypes", "unchecked" })
   public int getShortestPath(Vertex begin, Vertex end, StackInterface<Vertex> path) {
	   int getVisitedVertices = 0;
	   boolean done = false;
	   LinkedQueue<Vertex> vertexQueue = new LinkedQueue<Vertex>();
	   begin.visit();
	   getVisitedVertices++;
	   vertexQueue.enqueue(begin);
	   while(!done && !vertexQueue.isEmpty()) {
		   
		   Vertex frontVertex = vertexQueue.dequeue();
		   
		   @SuppressWarnings("unchecked")
		   Iterator<VertexInterface<Vertex>> iterator = frontVertex.getNeighborIterator();
		   while(!done && iterator.hasNext()) {
			   Vertex nextNeighbor = (Vertex) iterator.next();
			   if(!nextNeighbor.isVisited()) {
				   nextNeighbor.visit();
				   getVisitedVertices++;
				   nextNeighbor.setCost(frontVertex.getCost() + 1);
				   nextNeighbor.setPredecessor(frontVertex);
				   vertexQueue.enqueue(nextNeighbor);
			   }
			   if(nextNeighbor == end) {
				   done = true;
			   }
		   }
	   }
	   int pathLenght = (int) end.getCost();
	   path.push(end);
	   
	   Vertex vertex = end;
	   
	   while(vertex.hasPredecessor()) {
		   vertex = (Vertex) vertex.getPredecessor();
		   path.push(vertex);
	   }
	   System.out.println("Number of visited vertices: " + getVisitedVertices);
	   return pathLenght;
	   // return the shortest path between begin vertex and end vertex
   }
  
   
   @SuppressWarnings({ "rawtypes", "unchecked" })
   public double getCheapestPath(Vertex begin, Vertex end, StackInterface<Vertex> path) {
	   int getVisitedVertices = 0;
	   boolean done = false;
	   @SuppressWarnings("rawtypes")
	   HeapPriorityQueue<EntryPQ> priorityQueue = new HeapPriorityQueue<EntryPQ>();
	   
	   priorityQueue.add(new EntryPQ(begin, 0.0, null));
	   
	   while(!done && !priorityQueue.isEmpty()) {
		   DirectedGraph<T>.EntryPQ frontEntry = priorityQueue.remove();
		   DirectedGraph<T>.EntryPQ frontVertex = frontEntry;
		   
		   if(!frontVertex.getVertex().isVisited()) {
			   frontVertex.getVertex().visit();
			   getVisitedVertices++;
			   frontVertex.getVertex().setCost(frontEntry.getCost());
			   frontVertex.getVertex().setPredecessor(frontEntry.getPredecessor());
			   
			   if(frontVertex.getVertex() == end){
				   done = true;
			   }
			   else {
				   Iterator<VertexInterface<T>> iterator = frontVertex.getVertex().getNeighborIterator();
				   while(iterator.hasNext()) {
					   Vertex nextNeighbor = (Vertex) iterator.next();
					   double weightOfEdgeToNeighbor =  weightOfEdgeToNeighbor(frontVertex, nextNeighbor);
					   
					   if(!nextNeighbor.isVisited()) {
						   double nextCost = weightOfEdgeToNeighbor + frontVertex.cost;
						   priorityQueue.add(new EntryPQ(nextNeighbor, nextCost, frontVertex.getVertex()));
					   }
				   }
			   }
		   }
	   }
	   double pathCost = end.getCost();
	   path.push(end);
	   
	   Vertex vertex = end;
	   while(vertex.hasPredecessor()) {
		   vertex = (Vertex) vertex.getPredecessor();
		   path.push(vertex);
	   }
	   System.out.println("Number of visited vertices: " + getVisitedVertices);
	   return pathCost;
   }
   //The function returns the weight between two given vertices.
   @SuppressWarnings("rawtypes")
   public double weightOfEdgeToNeighbor(DirectedGraph<T>.EntryPQ begin, Vertex to) {
		Iterator<VertexInterface<T>> i = begin.getVertex().getNeighborIterator();
        Iterator<Double> w = begin.getVertex().getWeightIterator();
        double cost = 0;
		while (i.hasNext()){
			Vertex<T> v = (Vertex<T>)i.next();
			double weight = w.next();
			if(v == to) {
				cost = weight;
			}
		}
		return cost;
	}
   
   
   
   
   
	protected VertexInterface<T> findTerminal()
	{
		boolean found = false;
		VertexInterface<T> result = null;

		Iterator<VertexInterface<T>> vertexIterator = vertices.getValueIterator();

		while (!found && vertexIterator.hasNext())
		{
			VertexInterface<T> nextVertex = vertexIterator.next();
			
			// If nextVertex is unvisited AND has only visited neighbors)
			if (!nextVertex.isVisited())
			{ 
				if (nextVertex.getUnvisitedNeighbor() == null )
				{ 
					found = true;
					result = nextVertex;
				} // end if
			} // end if
		} // end while

		return result;
	} // end findTerminal

	// Used for testing
	public void displayEdges()
	{
		System.out.println("\nEdges exist from the first vertex in each line to the other vertices in the line.");
		System.out.println("(Edge weights are given; weights are zero for unweighted graphs):\n");
		Iterator<VertexInterface<T>> vertexIterator = vertices.getValueIterator();
		while (vertexIterator.hasNext())
		{
			((Vertex<T>)(vertexIterator.next())).display();
		} // end while
	} // end displayEdges 
	
	private class EntryPQ implements Comparable<EntryPQ>
	{
		private VertexInterface<T> vertex; 	
		private VertexInterface<T> previousVertex; 
		private double cost; // cost to nextVertex
		
		private EntryPQ(VertexInterface<T> vertex, double cost, VertexInterface<T> previousVertex)
		{
			this.vertex = vertex;
			this.previousVertex = previousVertex;
			this.cost = cost;
		} // end constructor
		
		public VertexInterface<T> getVertex()
		{
			return vertex;
		} // end getVertex
		
		public VertexInterface<T> getPredecessor()
		{
			return previousVertex;
		} // end getPredecessor

		public double getCost()
		{
			return cost;
		} // end getCost
		
		public int compareTo(EntryPQ otherEntry)
		{
			// Using opposite of reality since our priority queue uses a maxHeap;
			// could revise using a minheap
			return (int)Math.signum(otherEntry.cost - cost);
		} // end compareTo
		
		public String toString()
		{
			return vertex.toString() + " " + cost;
		} // end toString 
	} // end EntryPQ
} // end DirectedGraph

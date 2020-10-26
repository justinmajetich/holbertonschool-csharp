using System;

/// <summary>
/// A generic queue class.
/// </summary>
/// <typeparam name="T">Type is user-defined at instantiation.</typeparam>
class Queue<T> {
    
    public Node head { get; set; } = null;
    public Node tail { get; set; } = null;
    int count { get; set; } = 0;

    /// <summary>
    /// Gets the type of the instance.
    /// </summary>
    /// <returns>Returns the instance type.</returns>
    public Type CheckType() {
        return typeof(T);
    }

    /// <summary>
    /// Defines a node of a queue.
    /// </summary>
    public class Node {

        public T value { get; set; }
        public Node next { get; set; } = null;

        /// <summary>
        /// Class contructor.
        /// </summary>
        /// <param name="_value">Value initialize node with.</param>
        public Node(T _value) {
            value = _value;
        }

    }

    /// <summary>
    /// Add a node to the queue.
    /// </summary>
    public void Enqueue(T _value) {
        
        Node newNode = new Node(_value);

        // If head does not exist, set new node as head and tail.
        if (head == null) {
            tail = head = newNode;
        } else {
            // Add new node.
            tail.next = newNode;
            tail = newNode;
        }
        // Increment count of nodes in queue.
        count++;
    }

    /// <summary>
    /// Remove first node in queue.
    /// </summary>
    public T Dequeue() {

        if (head != null) {

            T value = head.value;

            // If node being removed is only node...
            if (head == tail) {
                tail = null;
            }

            // Move head forward to reference next node.
            head = head.next;

            // Decrement count of nodes in queue.
            count--;

            return value;

        } else {

            // If queue is empty...
            Console.WriteLine("Queue is empty");
            return default(T);

        }
    }

    /// <summary>
    /// Get value of first node in queue.
    /// </summary>
    /// <returns>Returns value of first node in queue.</returns>
    public T Peek() {

        if (head != null) {
            return head.value;
        } else {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

    }

    /// <summary>
    /// Get the number of nodes in queue.
    /// </summary>
    public int Count() {
        return count;
    }
}

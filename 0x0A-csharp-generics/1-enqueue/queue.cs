using System;

/// <summary>
/// A generic queue class.
/// </summary>
/// <typeparam name="T">Type is user-defined at instantiation.</typeparam>
class Queue<T> {
    
    public Node head { get; set; } = null;
    public Node tail { get; set; } = null;
    int count = 0;

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

        T value;
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
        tail = newNode;

        // If head does not exist, set new node as head and tail.
        if (head == null) {
            head = newNode;
        } else {
            Node runner = head;

            // Find current end of queue.
            while (runner.next != null) {
                runner = runner.next;
            }

            // Add new node.
            runner.next = newNode;
        }
        // Increment count of nodes in queue.
        count++;
    }

    /// <summary>
    /// Get the number of nodes in queue.
    /// </summary>
    public int Count() {
        return count;
    }
}

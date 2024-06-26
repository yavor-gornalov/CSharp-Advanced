﻿namespace CustomDoublyLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        private class LinkedListNode
        {
            public LinkedListNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }

            public LinkedListNode Next { get; set; }

            public LinkedListNode Previous { get; set; }
        }


        private LinkedListNode Head { get; set; }

        private LinkedListNode Tail { get; set; }

        private bool IsEmpty => this.Count == 0;

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            if (this.IsEmpty)
            {
                this.Head = this.Tail = new LinkedListNode(value);
            }
            else
            {
                var previousHead = this.Head;
                var newNode = new LinkedListNode(value);
                previousHead.Previous = newNode;
                newNode.Next = previousHead;
                this.Head = newNode;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            if (this.IsEmpty)
            {
                this.Head = this.Tail = new LinkedListNode(value);
            }
            else
            {
                var previousTail = this.Tail;
                var newNode = new LinkedListNode(value);
                newNode.Previous = previousTail;
                previousTail.Next = newNode;
                this.Tail = newNode;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("Cannot remove head because the list is empty.");
            }

            var removedHead = this.Head;
            var removedHeadValue = removedHead.Value;

            var nextHead = removedHead.Next;

            if (nextHead == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextHead.Previous = null;
                removedHead.Next = null;

                this.Head = nextHead;
            }

            this.Count--;

            return removedHeadValue;
        }

        public T RemoveLast()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("Cannot remove tail because the list is empty.");
            }

            var removedTail = this.Tail;
            var removedTailValue = removedTail.Value;
            var nextTail = removedTail.Previous;

            if (nextTail == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                removedTail.Previous = null;
                nextTail.Next = null;

                this.Tail = nextTail;
            }

            this.Count--;

            return removedTailValue;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public List<T> ToList()
        {
            var list = new List<T>();
            this.ForEach(n => list.Add(n));
            return list;
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];
            int counter = 0;

            var currentNode = this.Head;
            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                counter++;
                currentNode = currentNode.Next;
            }

            return array;
        }
    }
}

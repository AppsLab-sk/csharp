using System.Globalization;

namespace AppsLab_017_List
{
    /// <summary>
    /// This class represents a queue.
    /// </summary>
    public class Queue
    {
        private List<string> elements;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue"/> class.
        /// </summary>
        public Queue()
        {
            elements = new List<string>();
            elements.Count();
        }

        /// <summary>
        /// Adds an item to the end of the queue.
        /// </summary>
        /// <param name="item">The item to add to the queue.</param>
        public void Enqueue(string item)
        {

            elements.Add(item);

        }

        /// <summary>
        /// Removes and returns the first item in the queue.
        /// </summary>
        /// <returns>The first item in the queue.</returns>
        public string Dequeue()
        {
            string item = elements[0];
            elements.RemoveAt(0);
            return item;
        }
    }
}
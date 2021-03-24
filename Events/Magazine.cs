using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    delegate void NewPostAdded(string post);
    class Magazine
    {
        public event NewPostAdded NewPostAddedEvent;// Оголосили делегат
        public string Title { get; set; }
        List<string> Posts = new List<string>();
        public void AddPost(string content)
        {
            Posts.Add($"{DateTime.Now}\t {content}");
            NewPostAddedEvent?.Invoke(content); // init event : викликаються методи групового делегату
        }
        public override string ToString()
        {
            return $"Magazine : {Title}\n" +
                $"{String.Join("\n",Posts)}";
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public void Handler(string message)
        {
            Console.WriteLine($"Customer {Name} was notified...\n" +
                $"About : {message}\n");
        }
    }
    class Worker
    {
        public static void Handler(string message)
        {
            Console.WriteLine($"All Workers was notified...\n" +
                $"About : {message}\n");
        }
    }
}

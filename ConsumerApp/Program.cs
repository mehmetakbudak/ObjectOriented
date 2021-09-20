using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace ConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "localhost";

            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare("mesajkuyrugu", false, false, true);
                EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
                channel.BasicConsume("mesajkuyrugu", false, consumer);
                consumer.Received += (sender, e) =>
                 {
                     var body = e.Body.ToArray();
                     Console.WriteLine(Encoding.UTF8.GetString(body));
                 };
            }
            Console.Read();
        }
    }
}

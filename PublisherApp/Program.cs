using RabbitMQ.Client;
using System;
using System.Text;

namespace PublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bağlantı tanımlanıyor
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "localhost";

            //Bağlantı sağlanmakta
            using (IConnection connection = factory.CreateConnection())
            //Kanal oluşturulmaktadır
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare("mesajkuyrugu", false, false, true);
                byte[] byteMessage = Encoding.UTF8.GetBytes("Merhaba RabbitMQ");
                channel.BasicPublish(exchange: "", routingKey: "mesajkuyrugu", body: byteMessage);
            }

            Console.WriteLine("Hello World!");
        }
    }
}

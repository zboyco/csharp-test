using Confluent.Kafka;
using Newtonsoft.Json;
using System;

namespace Kafka生产者
{
    public class Msg
    {
        public int id { get; set; }
        public string msg { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var conf = new ProducerConfig { BootstrapServers = "192.168.2.8:9092" };

            Action<DeliveryReportResult<Null, string>> handler = r =>
                Console.WriteLine(!r.Error.IsError
                    ? $"Delivered message to {r.TopicPartitionOffset}"
                    : $"Delivery Error: {r.Error.Reason}");

            using (var p = new Producer<Null, string>(conf))
            {
                while (true)
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        p.BeginProduce("logs", new Message<Null, string>
                        {
                            Value = JsonConvert.SerializeObject(new Msg
                            {
                                id = i,
                                msg = Guid.NewGuid().ToString()
                            })
                        }, handler);
                    }
                    // wait for up to 10 seconds for any inflight messages to be delivered.
                    p.Flush(TimeSpan.FromSeconds(10));
                }
            }
        }
    }
}

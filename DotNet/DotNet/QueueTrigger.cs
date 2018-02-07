using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.WindowsAzure.Storage.Table;

namespace DotNet
{
    public static class QueueTrigger
    {
        public class Message : TableEntity
        {
            public string Text { get; set; }
        }

        [FunctionName("Function1")]
        public async static Task RunAsync([QueueTrigger("myqueue-items", Connection = "connectionString")]string myQueueItem, [Table("MyTable", Connection = "connectionString")]IAsyncCollector<Message> messages, TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
            var message = new Message();
            message.PartitionKey = "1";
            message.RowKey = "2";
            message.Text = myQueueItem;
            await messages.AddAsync(message);
        }
    }
}

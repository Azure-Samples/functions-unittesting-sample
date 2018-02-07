using FunctionTestHelper;
using Microsoft.Azure.WebJobs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static DotNet.QueueTrigger;

namespace DotNet.Test
{
    [TestClass]
    public class QueueTriggerTest : FunctionTestHelper.FunctionTest
    {
        [TestMethod]
        public async Task Recieve_Queue_And_Emit_To_Table()
        {
            var col = new AsyncCollector<Message>();
            var json = "{\"name\": \"ushio\"}";
            await DotNet.QueueTrigger.RunAsync(json, col, log);
            Assert.AreEqual(json, col.Items[0].Text);

        }
    }
}



# Azure Functions / Durable Functions Unit Testing Sample

Azure Functions Unit Testing Samples for V2 Functions.

## Features

The sample provides the following samples:

* HttpTrigger
* QueueTrigger
* Table Output bindings
* Durable Functions

You can refer how to mock the apps. Also, you can re-use FunctionTestHelper package.

We try to increase the samples, EventGridTrigger, EventHubTrigger, ServiceBus... and so on.

## Getting Started

### 1. Clone this samples

Clone this repo with your Visual Studo. 

```
git clone https://github.com/Azure-Samples/functions-unittesting-sample.git
```

### Prerequisites

Visual Studio 2017 (15.6+)
.Net Core Runtime 


### Note

For enabling Durable Functions Unit Testing feature, you need to upgrade nuget packages. 

* Microsoft.NET.Sdk.Functions v1.0.7
* Microsoft.Azure.WebJobs.Extensions.DurableTask v1.1.1-beta2

You might need to add `https://www.myget.org/F/azure-appservice/api/v3/index.json` as a nuget package sources for fetching the DurableTask v1.1.1-beta2


## Resources

Coming soon


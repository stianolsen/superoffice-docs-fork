---
uid: blobagent-setproductthumbnail
title: BLOBAgent.SetProductThumbnail event method
description: Scripting events called on the SetProductThumbnail method on the BLOBAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# BLOBAgent.SetProductThumbnail

Scripting events called on the <see cref='M:IBLOBAgent.SetProductThumbnail'>SetProductThumbnail</see> method on the <see cref='IBLOBAgent'>IBLOBAgent</see>  service agent.

## BeforeSetProductThumbnail
```cs
    static void BeforeSetProductThumbnail(
       Int32  productId,
       Image  image,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetProductThumbnail
```cs
    static void AfterSetProductThumbnail(
       Int32  productId,
       Image  image,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetProductThumbnailAsync
```cs
    static void AfterSetProductThumbnailAsync(
       Int32  productId,
       Image  image,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.


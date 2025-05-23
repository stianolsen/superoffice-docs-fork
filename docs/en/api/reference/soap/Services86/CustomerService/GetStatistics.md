---
title: Services86.CustomerServiceAgent.GetStatistics SOAP
generated: 1
uid: Services86-CustomerService-GetStatistics
---

# Services86 CustomerService GetStatistics

SOAP request and response examples **Remote/Services86/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICustomerServiceAgent.GetStatistics">SuperOffice.Services86.ICustomerServiceAgent.GetStatistics</see> method.

## GetStatistics

[WSDL file for Services86/CustomerService](../Services86-CustomerService.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStatistics Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:GetStatistics>
    <CustomerService:Functions xsi:type="CustomerService:ArrayOfStatusScreenPanelType">
     <CustomerService:StatusScreenPanelType xsi:type="CustomerService:StatusScreenPanelType">None</CustomerService:StatusScreenPanelType>
    </CustomerService:Functions>
   </CustomerService:GetStatistics>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetStatistics Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <CustomerService:GetStatisticsResponse>
   <CustomerService:Response xsi:type="CustomerService:ArrayOfStatisticsDataSet">
    <CustomerService:StatisticsDataSet xsi:type="CustomerService:StatisticsDataSet">
     <CustomerService:Label xsi:type="xsd:string"></CustomerService:Label>
     <CustomerService:Values xsi:type="CustomerService:ArrayOfStatisticsDataValue">
      <CustomerService:StatisticsDataValue xsi:type="CustomerService:StatisticsDataValue">
       <CustomerService:Label xsi:type="xsd:string"></CustomerService:Label>
       <CustomerService:Value xsi:type="xsd:double">0.0</CustomerService:Value>
       <CustomerService:Description xsi:type="xsd:string"></CustomerService:Description>
      </CustomerService:StatisticsDataValue>
     </CustomerService:Values>
     <CustomerService:Description xsi:type="xsd:string"></CustomerService:Description>
    </CustomerService:StatisticsDataSet>
   </CustomerService:Response>
  </CustomerService:GetStatisticsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

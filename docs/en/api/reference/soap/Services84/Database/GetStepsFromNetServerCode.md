---
title: Services84.DatabaseAgent.GetStepsFromNetServerCode SOAP
generated: 1
uid: Services84-Database-GetStepsFromNetServerCode
---

# Services84 Database GetStepsFromNetServerCode

SOAP request and response examples **Remote/Services84/Database.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IDatabaseAgent.GetStepsFromNetServerCode">SuperOffice.Services84.IDatabaseAgent.GetStepsFromNetServerCode</see> method.

## GetStepsFromNetServerCode

[WSDL file for Services84/Database](../Services84-Database.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStepsFromNetServerCode Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Database="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Database:ApplicationToken>1234567-1234-9876</Database:ApplicationToken>
  <Database:Credentials>
    <Database:Ticket>7T:1234abcxyzExample==</Database:Ticket>
  </Database:Credentials>
 <SOAP-ENV:Body>
   <Database:GetStepsFromNetServerCode>
   </Database:GetStepsFromNetServerCode>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetStepsFromNetServerCode Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Database="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Database:GetStepsFromNetServerCodeResponse>
   <Database:Response xsi:type="Database:ArrayOfDictionaryStepInformation">
    <Database:DictionaryStepInformation xsi:type="Database:DictionaryStepInformation">
     <Database:Name xsi:type="xsd:string"></Database:Name>
     <Database:StepNumber xsi:type="xsd:int">0</Database:StepNumber>
    </Database:DictionaryStepInformation>
   </Database:Response>
  </Database:GetStepsFromNetServerCodeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

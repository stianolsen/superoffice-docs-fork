---
title: Services86.ForeignSystemAgent.DeleteForeignDevice SOAP
generated: 1
uid: Services86-ForeignSystem-DeleteForeignDevice
---

# Services86 ForeignSystem DeleteForeignDevice

SOAP request and response examples **Remote/Services86/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IForeignSystemAgent.DeleteForeignDevice">SuperOffice.Services86.IForeignSystemAgent.DeleteForeignDevice</see> method.

## DeleteForeignDevice

[WSDL file for Services86/ForeignSystem](../Services86-ForeignSystem.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteForeignDevice Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:DeleteForeignDevice>
    <ForeignSystem:ForeignDevice xsi:type="ForeignSystem:ForeignDevice">
     <ForeignSystem:ForeignDeviceId xsi:type="xsd:int">0</ForeignSystem:ForeignDeviceId>
     <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
     <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2023-03-31T13:23:37Z</ForeignSystem:CreatedDate>
     <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2023-03-31T13:23:37Z</ForeignSystem:UpdatedDate>
     <ForeignSystem:AssociateFullName xsi:type="xsd:string"></ForeignSystem:AssociateFullName>
     <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
     <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
     <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
     <ForeignSystem:ForeignAppId xsi:type="xsd:int">0</ForeignSystem:ForeignAppId>
    </ForeignSystem:ForeignDevice>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
   </ForeignSystem:DeleteForeignDevice>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## DeleteForeignDevice Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <ForeignSystem:DeleteForeignDeviceResponse>
  </ForeignSystem:DeleteForeignDeviceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

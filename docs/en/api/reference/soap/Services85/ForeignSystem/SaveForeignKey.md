---
title: Services85.ForeignSystemAgent.SaveForeignKey SOAP
generated: 1
uid: Services85-ForeignSystem-SaveForeignKey
---

# Services85 ForeignSystem SaveForeignKey

SOAP request and response examples **Remote/Services85/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IForeignSystemAgent.SaveForeignKey">SuperOffice.Services85.IForeignSystemAgent.SaveForeignKey</see> method.

## SaveForeignKey

[WSDL file for Services85/ForeignSystem](../Services85-ForeignSystem.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveForeignKey Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:SaveForeignKey>
    <ForeignSystem:ForeignKey xsi:type="ForeignSystem:ForeignKey">
     <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
     <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
     <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
     <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2023-03-31T13:21:40Z</ForeignSystem:CreatedDate>
     <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2023-03-31T13:21:40Z</ForeignSystem:UpdatedDate>
     <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
     <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
     <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
    </ForeignSystem:ForeignKey>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
   </ForeignSystem:SaveForeignKey>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## SaveForeignKey Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <ForeignSystem:SaveForeignKeyResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ForeignKey">
    <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
    <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
    <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
    <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2023-03-31T13:21:40Z</ForeignSystem:CreatedDate>
    <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2023-03-31T13:21:40Z</ForeignSystem:UpdatedDate>
    <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
    <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
   </ForeignSystem:Response>
  </ForeignSystem:SaveForeignKeyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

---
title: Services85.EMailAgent.SyncEmailAccounts SOAP
generated: 1
uid: Services85-EMail-SyncEmailAccounts
---

# Services85 EMail SyncEmailAccounts

SOAP request and response examples **Remote/Services85/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IEMailAgent.SyncEmailAccounts">SuperOffice.Services85.IEMailAgent.SyncEmailAccounts</see> method.

## SyncEmailAccounts

[WSDL file for Services85/EMail](../Services85-EMail.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SyncEmailAccounts Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:SyncEmailAccounts>
    <EMail:SyncUserAccounts xsi:type="EMail:ArrayOfSyncUserAccount">
     <EMail:SyncUserAccount xsi:type="EMail:SyncUserAccount">
      <EMail:AccountId xsi:type="xsd:int">0</EMail:AccountId>
      <EMail:AssociateName xsi:type="xsd:string"></EMail:AssociateName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
     </EMail:SyncUserAccount>
    </EMail:SyncUserAccounts>
   </EMail:SyncEmailAccounts>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## SyncEmailAccounts Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <EMail:SyncEmailAccountsResponse>
  </EMail:SyncEmailAccountsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

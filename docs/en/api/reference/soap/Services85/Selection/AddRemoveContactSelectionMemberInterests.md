---
title: Services85.SelectionAgent.AddRemoveContactSelectionMemberInterests SOAP
generated: 1
uid: Services85-Selection-AddRemoveContactSelectionMemberInterests
---

# Services85 Selection AddRemoveContactSelectionMemberInterests

SOAP request and response examples **Remote/Services85/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISelectionAgent.AddRemoveContactSelectionMemberInterests">SuperOffice.Services85.ISelectionAgent.AddRemoveContactSelectionMemberInterests</see> method.

## AddRemoveContactSelectionMemberInterests

[WSDL file for Services85/Selection](../Services85-Selection.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddRemoveContactSelectionMemberInterests Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:AddRemoveContactSelectionMemberInterests>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:AddCompanyInterests xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </Selection:AddCompanyInterests>
    <Selection:RemoveCompanyInterests xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </Selection:RemoveCompanyInterests>
    <Selection:AddContactInterests xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </Selection:AddContactInterests>
    <Selection:RemoveContactInterests xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </Selection:RemoveContactInterests>
   </Selection:AddRemoveContactSelectionMemberInterests>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## AddRemoveContactSelectionMemberInterests Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Selection:AddRemoveContactSelectionMemberInterestsResponse>
  </Selection:AddRemoveContactSelectionMemberInterestsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

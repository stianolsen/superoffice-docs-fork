---
title: Services85.ProjectAgent.AddProjectMembers SOAP
generated: 1
uid: Services85-Project-AddProjectMembers
---

# Services85 Project AddProjectMembers

SOAP request and response examples **Remote/Services85/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IProjectAgent.AddProjectMembers">SuperOffice.Services85.IProjectAgent.AddProjectMembers</see> method.

## AddProjectMembers

[WSDL file for Services85/Project](../Services85-Project.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddProjectMembers Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:AddProjectMembers>
    <Project:ProjectEntityId xsi:type="xsd:int">0</Project:ProjectEntityId>
    <Project:ProjectMembers xsi:type="Project:ArrayOfProjectMember">
     <Project:ProjectMember xsi:type="Project:ProjectMember">
      <Project:ContactId xsi:type="xsd:int">0</Project:ContactId>
      <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
      <Project:ContactName xsi:type="xsd:string"></Project:ContactName>
      <Project:EmailId xsi:type="xsd:int">0</Project:EmailId>
      <Project:EmailAddress xsi:type="xsd:string"></Project:EmailAddress>
      <Project:CountryId xsi:type="xsd:int">0</Project:CountryId>
      <Project:Firstname xsi:type="xsd:string"></Project:Firstname>
      <Project:MiddleName xsi:type="xsd:string"></Project:MiddleName>
      <Project:Lastname xsi:type="xsd:string"></Project:Lastname>
      <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
      <Project:Mrmrs xsi:type="xsd:string"></Project:Mrmrs>
      <Project:ProjectMemberTypeName xsi:type="xsd:string"></Project:ProjectMemberTypeName>
      <Project:Phone xsi:type="xsd:string"></Project:Phone>
      <Project:PhoneId xsi:type="xsd:int">0</Project:PhoneId>
      <Project:ProjectMemberTypeId xsi:type="xsd:int">0</Project:ProjectMemberTypeId>
      <Project:EmailAddressName xsi:type="xsd:string"></Project:EmailAddressName>
      <Project:Comment xsi:type="xsd:string"></Project:Comment>
      <Project:ProjectmemberId xsi:type="xsd:int">0</Project:ProjectmemberId>
      <Project:FullName xsi:type="xsd:string"></Project:FullName>
     </Project:ProjectMember>
    </Project:ProjectMembers>
   </Project:AddProjectMembers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## AddProjectMembers Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Project:AddProjectMembersResponse>
  </Project:AddProjectMembersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

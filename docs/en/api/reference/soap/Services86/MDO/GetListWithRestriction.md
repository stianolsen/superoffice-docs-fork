---
title: Services86.MDOAgent.GetListWithRestriction SOAP
generated: 1
uid: Services86-MDO-GetListWithRestriction
---

# Services86 MDO GetListWithRestriction

SOAP request and response examples **Remote/Services86/MDO.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IMDOAgent.GetListWithRestriction">SuperOffice.Services86.IMDOAgent.GetListWithRestriction</see> method.

## GetListWithRestriction

[WSDL file for Services86/MDO](../Services86-MDO.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetListWithRestriction Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <MDO:ApplicationToken>1234567-1234-9876</MDO:ApplicationToken>
  <MDO:Credentials>
    <MDO:Ticket>7T:1234abcxyzExample==</MDO:Ticket>
  </MDO:Credentials>
 <SOAP-ENV:Body>
   <MDO:GetListWithRestriction>
    <MDO:Name xsi:type="xsd:string"></MDO:Name>
    <MDO:AdditionalInfo xsi:type="xsd:string"></MDO:AdditionalInfo>
    <MDO:SearchValue xsi:type="xsd:string"></MDO:SearchValue>
   </MDO:GetListWithRestriction>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetListWithRestriction Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <MDO:GetListWithRestrictionResponse>
   <MDO:Response xsi:type="MDO:ArrayOfMDOListItem">
    <MDO:MDOListItem xsi:type="MDO:MDOListItem">
     <MDO:Id xsi:type="xsd:int">0</MDO:Id>
     <MDO:Name xsi:type="xsd:string"></MDO:Name>
     <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
     <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
     <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
     <MDO:Type xsi:type="xsd:string"></MDO:Type>
     <MDO:ChildItems xsi:type="MDO:ArrayOfMDOListItem">
      <MDO:MDOListItem xsi:type="MDO:MDOListItem">
       <MDO:Id xsi:type="xsd:int">0</MDO:Id>
       <MDO:Name xsi:type="xsd:string"></MDO:Name>
       <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
       <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
       <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
       <MDO:Type xsi:type="xsd:string"></MDO:Type>
       <MDO:ChildItems xsi:type="MDO:ArrayOfMDOListItem">
        <MDO:MDOListItem xsi:type="MDO:MDOListItem">
         <MDO:Id xsi:type="xsd:int">0</MDO:Id>
         <MDO:Name xsi:type="xsd:string"></MDO:Name>
         <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
         <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
         <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
         <MDO:Type xsi:type="xsd:string"></MDO:Type>
         <MDO:ChildItems xsi:type="MDO:ArrayOfMDOListItem">
          <MDO:MDOListItem xsi:nil="true"></MDO:MDOListItem>
         </MDO:ChildItems>
         <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
         <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
         <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
         <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
         <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
        </MDO:MDOListItem>
       </MDO:ChildItems>
       <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
       <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
       <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
       <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
       <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
      </MDO:MDOListItem>
     </MDO:ChildItems>
     <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
     <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
     <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
     <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
     <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
    </MDO:MDOListItem>
   </MDO:Response>
  </MDO:GetListWithRestrictionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

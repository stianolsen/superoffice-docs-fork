---
title: Services85.SelectionAgent.GetDynamicSelectionCriteria SOAP
generated: 1
uid: Services85-Selection-GetDynamicSelectionCriteria
---

# Services85 Selection GetDynamicSelectionCriteria

SOAP request and response examples **Remote/Services85/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISelectionAgent.GetDynamicSelectionCriteria">SuperOffice.Services85.ISelectionAgent.GetDynamicSelectionCriteria</see> method.

## GetDynamicSelectionCriteria

[WSDL file for Services85/Selection](../Services85-Selection.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDynamicSelectionCriteria Request

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
   <Selection:GetDynamicSelectionCriteria>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
   </Selection:GetDynamicSelectionCriteria>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetDynamicSelectionCriteria Response

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
  <Selection:GetDynamicSelectionCriteriaResponse>
   <Selection:Response xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
    <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
     <Selection:Name xsi:type="xsd:string"></Selection:Name>
     <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
     <Selection:Values xsi:type="NetServerServices852:ArrayOfstring">
      <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
     </Selection:Values>
     <Selection:DisplayValues xsi:type="NetServerServices852:ArrayOfstring">
      <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
     </Selection:DisplayValues>
     <Selection:ColumnInfo xsi:type="Selection:ArchiveColumnInfo">
      <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
      <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
      <Selection:DisplayType xsi:type="xsd:string"></Selection:DisplayType>
      <Selection:CanOrderBy xsi:type="xsd:boolean">false</Selection:CanOrderBy>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:CanRestrictBy xsi:type="xsd:boolean">false</Selection:CanRestrictBy>
      <Selection:RestrictionType xsi:type="xsd:string"></Selection:RestrictionType>
      <Selection:RestrictionListName xsi:type="xsd:string"></Selection:RestrictionListName>
      <Selection:IsVisible xsi:type="xsd:boolean">false</Selection:IsVisible>
      <Selection:Width xsi:type="xsd:string"></Selection:Width>
      <Selection:IconHint xsi:type="xsd:string"></Selection:IconHint>
      <Selection:HeadingIconHint xsi:type="xsd:string"></Selection:HeadingIconHint>
     </Selection:ColumnInfo>
     <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
     <Selection:SubRestrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
      <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
       <Selection:Name xsi:type="xsd:string"></Selection:Name>
       <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
       <Selection:Values xsi:type="NetServerServices852:ArrayOfstring">
        <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
       </Selection:Values>
       <Selection:DisplayValues xsi:type="NetServerServices852:ArrayOfstring">
        <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
       </Selection:DisplayValues>
       <Selection:ColumnInfo xsi:type="Selection:ArchiveColumnInfo">
        <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
        <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
        <Selection:DisplayType xsi:type="xsd:string"></Selection:DisplayType>
        <Selection:CanOrderBy xsi:type="xsd:boolean">false</Selection:CanOrderBy>
        <Selection:Name xsi:type="xsd:string"></Selection:Name>
        <Selection:CanRestrictBy xsi:type="xsd:boolean">false</Selection:CanRestrictBy>
        <Selection:RestrictionType xsi:type="xsd:string"></Selection:RestrictionType>
        <Selection:RestrictionListName xsi:type="xsd:string"></Selection:RestrictionListName>
        <Selection:IsVisible xsi:type="xsd:boolean">false</Selection:IsVisible>
        <Selection:Width xsi:type="xsd:string"></Selection:Width>
        <Selection:IconHint xsi:type="xsd:string"></Selection:IconHint>
        <Selection:HeadingIconHint xsi:type="xsd:string"></Selection:HeadingIconHint>
       </Selection:ColumnInfo>
       <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
       <Selection:SubRestrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
        <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
         <Selection:Name xsi:type="xsd:string"></Selection:Name>
         <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
         <Selection:Values xsi:type="NetServerServices852:ArrayOfstring">
          <NetServerServices852:string xsi:nil="true"></NetServerServices852:string>
         </Selection:Values>
         <Selection:DisplayValues xsi:type="NetServerServices852:ArrayOfstring">
          <NetServerServices852:string xsi:nil="true"></NetServerServices852:string>
         </Selection:DisplayValues>
         <Selection:ColumnInfo xsi:type="Selection:ArchiveColumnInfo">
          <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
          <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
          <Selection:DisplayType xsi:type="xsd:string"></Selection:DisplayType>
          <Selection:CanOrderBy xsi:nil="true"></Selection:CanOrderBy>
          <Selection:Name xsi:type="xsd:string"></Selection:Name>
          <Selection:CanRestrictBy xsi:nil="true"></Selection:CanRestrictBy>
          <Selection:RestrictionType xsi:type="xsd:string"></Selection:RestrictionType>
          <Selection:RestrictionListName xsi:type="xsd:string"></Selection:RestrictionListName>
          <Selection:IsVisible xsi:nil="true"></Selection:IsVisible>
          <Selection:Width xsi:type="xsd:string"></Selection:Width>
          <Selection:IconHint xsi:type="xsd:string"></Selection:IconHint>
          <Selection:HeadingIconHint xsi:type="xsd:string"></Selection:HeadingIconHint>
         </Selection:ColumnInfo>
         <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
         <Selection:SubRestrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
          <Selection:ArchiveRestrictionInfo xsi:nil="true"></Selection:ArchiveRestrictionInfo>
         </Selection:SubRestrictions>
         <Selection:InterParenthesis xsi:type="xsd:int">0</Selection:InterParenthesis>
         <Selection:InterOperator xsi:type="Selection:InterRestrictionOperator">None</Selection:InterOperator>
         <Selection:UniqueHash xsi:type="xsd:int">0</Selection:UniqueHash>
        </Selection:ArchiveRestrictionInfo>
       </Selection:SubRestrictions>
       <Selection:InterParenthesis xsi:type="xsd:int">0</Selection:InterParenthesis>
       <Selection:InterOperator xsi:type="Selection:InterRestrictionOperator">None</Selection:InterOperator>
       <Selection:UniqueHash xsi:type="xsd:int">0</Selection:UniqueHash>
      </Selection:ArchiveRestrictionInfo>
     </Selection:SubRestrictions>
     <Selection:InterParenthesis xsi:type="xsd:int">0</Selection:InterParenthesis>
     <Selection:InterOperator xsi:type="Selection:InterRestrictionOperator">None</Selection:InterOperator>
     <Selection:UniqueHash xsi:type="xsd:int">0</Selection:UniqueHash>
    </Selection:ArchiveRestrictionInfo>
   </Selection:Response>
  </Selection:GetDynamicSelectionCriteriaResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

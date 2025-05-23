---
title: Services88.ReplicationAgent.GetSatellite SOAP
generated: true
uid: Services88-Replication-GetSatellite
---

# Services88 Replication GetSatellite

SOAP request and response examples **Remote/Services88/Replication.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IReplicationAgent.GetSatellite">SuperOffice.Services88.IReplicationAgent.GetSatellite</see> method.

## GetSatellite





[WSDL file for Services88/Replication](../Services88-Replication.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSatellite Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Replication:ApplicationToken>1234567-1234-9876</Replication:ApplicationToken>
  <Replication:Credentials>
    <Replication:Ticket>7T:1234abcxyzExample==</Replication:Ticket>
  </Replication:Credentials>
 <SOAP-ENV:Body>
   <Replication:GetSatellite>
    <Replication:SatelliteId xsi:type="xsd:int">0</Replication:SatelliteId>
   </Replication:GetSatellite>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSatellite Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Replication:GetSatelliteResponse>
   <Replication:Response xsi:type="Replication:Satellite">
    <Replication:SatelliteId xsi:type="xsd:int">0</Replication:SatelliteId>
    <Replication:Created xsi:type="xsd:dateTime">2025-05-07T14:31:54Z</Replication:Created>
    <Replication:CreatedBy xsi:type="Replication:Associate">
     <Replication:AssociateId xsi:type="xsd:int">0</Replication:AssociateId>
     <Replication:Name xsi:type="xsd:string"></Replication:Name>
     <Replication:PersonId xsi:type="xsd:int">0</Replication:PersonId>
     <Replication:Rank xsi:type="xsd:short">0</Replication:Rank>
     <Replication:Tooltip xsi:type="xsd:string"></Replication:Tooltip>
     <Replication:Type xsi:type="Replication:UserType">Unknown</Replication:Type>
     <Replication:GroupIdx xsi:type="xsd:int">0</Replication:GroupIdx>
     <Replication:FullName xsi:type="xsd:string"></Replication:FullName>
     <Replication:FormalName xsi:type="xsd:string"></Replication:FormalName>
     <Replication:Deleted xsi:type="xsd:boolean">false</Replication:Deleted>
     <Replication:EjUserId xsi:type="xsd:int">0</Replication:EjUserId>
     <Replication:UserName xsi:type="xsd:string"></Replication:UserName>
    </Replication:CreatedBy>
    <Replication:Updated xsi:type="xsd:dateTime">2025-05-07T14:31:54Z</Replication:Updated>
    <Replication:UpdatedBy xsi:type="Replication:Associate">
     <Replication:AssociateId xsi:type="xsd:int">0</Replication:AssociateId>
     <Replication:Name xsi:type="xsd:string"></Replication:Name>
     <Replication:PersonId xsi:type="xsd:int">0</Replication:PersonId>
     <Replication:Rank xsi:type="xsd:short">0</Replication:Rank>
     <Replication:Tooltip xsi:type="xsd:string"></Replication:Tooltip>
     <Replication:Type xsi:type="Replication:UserType">Unknown</Replication:Type>
     <Replication:GroupIdx xsi:type="xsd:int">0</Replication:GroupIdx>
     <Replication:FullName xsi:type="xsd:string"></Replication:FullName>
     <Replication:FormalName xsi:type="xsd:string"></Replication:FormalName>
     <Replication:Deleted xsi:type="xsd:boolean">false</Replication:Deleted>
     <Replication:EjUserId xsi:type="xsd:int">0</Replication:EjUserId>
     <Replication:UserName xsi:type="xsd:string"></Replication:UserName>
    </Replication:UpdatedBy>
    <Replication:Contact xsi:type="Replication:Contact">
     <Replication:ContactId xsi:type="xsd:int">0</Replication:ContactId>
     <Replication:Name xsi:type="xsd:string"></Replication:Name>
     <Replication:OrgNr xsi:type="xsd:string"></Replication:OrgNr>
     <Replication:Department xsi:type="xsd:string"></Replication:Department>
     <Replication:URL xsi:type="xsd:string"></Replication:URL>
     <Replication:City xsi:type="xsd:string"></Replication:City>
     <Replication:DirectPhone xsi:type="xsd:string"></Replication:DirectPhone>
     <Replication:AssociateId xsi:type="xsd:int">0</Replication:AssociateId>
     <Replication:CountryId xsi:type="xsd:int">0</Replication:CountryId>
     <Replication:EmailAddress xsi:type="xsd:string"></Replication:EmailAddress>
     <Replication:Kananame xsi:type="xsd:string"></Replication:Kananame>
     <Replication:EmailAddressName xsi:type="xsd:string"></Replication:EmailAddressName>
     <Replication:URLName xsi:type="xsd:string"></Replication:URLName>
     <Replication:AssociateFullName xsi:type="xsd:string"></Replication:AssociateFullName>
     <Replication:BusinessName xsi:type="xsd:string"></Replication:BusinessName>
     <Replication:CategoryName xsi:type="xsd:string"></Replication:CategoryName>
     <Replication:CountryName xsi:type="xsd:string"></Replication:CountryName>
     <Replication:Address xsi:type="Replication:Address">
      <Replication:Wgs84Latitude xsi:type="xsd:double">0.0</Replication:Wgs84Latitude>
      <Replication:Wgs84Longitude xsi:type="xsd:double">0.0</Replication:Wgs84Longitude>
      <Replication:LocalizedAddress xsi:type="Replication:ArrayOfArrayOfLocalizedField">
       <Replication:ArrayOfLocalizedField xsi:type="Replication:ArrayOfLocalizedField">
        <Replication:LocalizedField xsi:type="Replication:LocalizedField">
         <Replication:Name xsi:type="xsd:string"></Replication:Name>
         <Replication:Value xsi:type="xsd:string"></Replication:Value>
         <Replication:Tooltip xsi:type="xsd:string"></Replication:Tooltip>
         <Replication:Label xsi:type="xsd:string"></Replication:Label>
         <Replication:ValueLength xsi:type="xsd:int">0</Replication:ValueLength>
         <Replication:AddressType xsi:type="xsd:string"></Replication:AddressType>
        </Replication:LocalizedField>
       </Replication:ArrayOfLocalizedField>
      </Replication:LocalizedAddress>
      <Replication:Street xsi:type="Replication:StructuredAddress">
       <Replication:AtypeIdx xsi:type="Replication:AddressType">Unknown</Replication:AtypeIdx>
       <Replication:Address1 xsi:type="xsd:string"></Replication:Address1>
       <Replication:Address2 xsi:type="xsd:string"></Replication:Address2>
       <Replication:Address3 xsi:type="xsd:string"></Replication:Address3>
       <Replication:City xsi:type="xsd:string"></Replication:City>
       <Replication:County xsi:type="xsd:string"></Replication:County>
       <Replication:State xsi:type="xsd:string"></Replication:State>
       <Replication:Zipcode xsi:type="xsd:string"></Replication:Zipcode>
       <Replication:Formatted xsi:type="xsd:string"></Replication:Formatted>
      </Replication:Street>
      <Replication:Postal xsi:type="Replication:StructuredAddress">
       <Replication:AtypeIdx xsi:type="Replication:AddressType">Unknown</Replication:AtypeIdx>
       <Replication:Address1 xsi:type="xsd:string"></Replication:Address1>
       <Replication:Address2 xsi:type="xsd:string"></Replication:Address2>
       <Replication:Address3 xsi:type="xsd:string"></Replication:Address3>
       <Replication:City xsi:type="xsd:string"></Replication:City>
       <Replication:County xsi:type="xsd:string"></Replication:County>
       <Replication:State xsi:type="xsd:string"></Replication:State>
       <Replication:Zipcode xsi:type="xsd:string"></Replication:Zipcode>
       <Replication:Formatted xsi:type="xsd:string"></Replication:Formatted>
      </Replication:Postal>
      <Replication:Formatted xsi:type="xsd:string"></Replication:Formatted>
     </Replication:Address>
     <Replication:FormattedAddress xsi:type="xsd:string"></Replication:FormattedAddress>
     <Replication:FullName xsi:type="xsd:string"></Replication:FullName>
     <Replication:IsOwnerContact xsi:type="xsd:boolean">false</Replication:IsOwnerContact>
     <Replication:ActiveErpLinks xsi:type="xsd:int">0</Replication:ActiveErpLinks>
     <Replication:Number1 xsi:type="xsd:string"></Replication:Number1>
     <Replication:Number2 xsi:type="xsd:string"></Replication:Number2>
    </Replication:Contact>
    <Replication:Area xsi:type="Replication:Area">
     <Replication:AreaId xsi:type="xsd:int">0</Replication:AreaId>
     <Replication:Name xsi:type="xsd:string"></Replication:Name>
     <Replication:MaxDataAge xsi:type="xsd:short">0</Replication:MaxDataAge>
     <Replication:NumberOfUsers xsi:type="xsd:int">0</Replication:NumberOfUsers>
     <Replication:NumberOfLogins xsi:type="xsd:int">0</Replication:NumberOfLogins>
     <Replication:FreetextEnabeled xsi:type="xsd:boolean">false</Replication:FreetextEnabeled>
    </Replication:Area>
    <Replication:LicenseOwners xsi:type="Replication:ArrayOfLicenseOwner">
     <Replication:LicenseOwner xsi:type="Replication:LicenseOwner">
      <Replication:Name xsi:type="xsd:string"></Replication:Name>
      <Replication:Description xsi:type="xsd:string"></Replication:Description>
      <Replication:RestrictedModuleLicenses xsi:type="Replication:ArrayOfModuleLicenseLink">
       <Replication:ModuleLicenseLink xsi:type="Replication:ModuleLicenseLink">
        <Replication:Unrestricted xsi:type="xsd:boolean">false</Replication:Unrestricted>
        <Replication:Total xsi:type="xsd:int">0</Replication:Total>
        <Replication:Tooltip xsi:type="xsd:string"></Replication:Tooltip>
        <Replication:CanAssign xsi:type="xsd:boolean">false</Replication:CanAssign>
        <Replication:Free xsi:type="xsd:int">0</Replication:Free>
        <Replication:InUse xsi:type="xsd:int">0</Replication:InUse>
        <Replication:IsHidden xsi:type="xsd:boolean">false</Replication:IsHidden>
        <Replication:Assigned xsi:type="xsd:boolean">false</Replication:Assigned>
        <Replication:ModuleLicenseId xsi:type="xsd:int">0</Replication:ModuleLicenseId>
        <Replication:Name xsi:type="xsd:string"></Replication:Name>
        <Replication:Description xsi:type="xsd:string"></Replication:Description>
        <Replication:PrerequisiteModuleName xsi:type="xsd:string"></Replication:PrerequisiteModuleName>
        <Replication:SortOrder xsi:type="xsd:int">0</Replication:SortOrder>
        <Replication:ExtraFlags xsi:type="xsd:int">0</Replication:ExtraFlags>
       </Replication:ModuleLicenseLink>
      </Replication:RestrictedModuleLicenses>
      <Replication:UnrestrictedModuleLicenses xsi:type="Replication:ArrayOfModuleLicenseLink">
       <Replication:ModuleLicenseLink xsi:type="Replication:ModuleLicenseLink">
        <Replication:Unrestricted xsi:type="xsd:boolean">false</Replication:Unrestricted>
        <Replication:Total xsi:type="xsd:int">0</Replication:Total>
        <Replication:Tooltip xsi:type="xsd:string"></Replication:Tooltip>
        <Replication:CanAssign xsi:type="xsd:boolean">false</Replication:CanAssign>
        <Replication:Free xsi:type="xsd:int">0</Replication:Free>
        <Replication:InUse xsi:type="xsd:int">0</Replication:InUse>
        <Replication:IsHidden xsi:type="xsd:boolean">false</Replication:IsHidden>
        <Replication:Assigned xsi:type="xsd:boolean">false</Replication:Assigned>
        <Replication:ModuleLicenseId xsi:type="xsd:int">0</Replication:ModuleLicenseId>
        <Replication:Name xsi:type="xsd:string"></Replication:Name>
        <Replication:Description xsi:type="xsd:string"></Replication:Description>
        <Replication:PrerequisiteModuleName xsi:type="xsd:string"></Replication:PrerequisiteModuleName>
        <Replication:SortOrder xsi:type="xsd:int">0</Replication:SortOrder>
        <Replication:ExtraFlags xsi:type="xsd:int">0</Replication:ExtraFlags>
       </Replication:ModuleLicenseLink>
      </Replication:UnrestrictedModuleLicenses>
     </Replication:LicenseOwner>
    </Replication:LicenseOwners>
   </Replication:Response>
  </Replication:GetSatelliteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


---
title: Services86.SaleAgent.GetSale SOAP
generated: 1
uid: Services86-Sale-GetSale
---

# Services86 Sale GetSale

SOAP request and response examples **Remote/Services86/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISaleAgent.GetSale">SuperOffice.Services86.ISaleAgent.GetSale</see> method.

## GetSale

[WSDL file for Services86/Sale](../Services86-Sale.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSale Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:GetSale>
    <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
   </Sale:GetSale>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetSale Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Sale:GetSaleResponse>
   <Sale:Response xsi:type="Sale:Sale">
    <Sale:ContactName xsi:type="xsd:string"></Sale:ContactName>
    <Sale:SaleDate xsi:type="xsd:dateTime">2023-03-31T13:24:11Z</Sale:SaleDate>
    <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
    <Sale:Probability xsi:type="xsd:short">0</Sale:Probability>
    <Sale:Title xsi:type="xsd:string"></Sale:Title>
    <Sale:Amount xsi:type="xsd:double">0.0</Sale:Amount>
    <Sale:Currency xsi:type="xsd:string"></Sale:Currency>
    <Sale:ProjectName xsi:type="xsd:string"></Sale:ProjectName>
    <Sale:AssociateFullName xsi:type="xsd:string"></Sale:AssociateFullName>
    <Sale:Description xsi:type="xsd:string"></Sale:Description>
    <Sale:Status xsi:type="Sale:SaleStatus">Unknown</Sale:Status>
    <Sale:WeightedAmount xsi:type="xsd:double">0.0</Sale:WeightedAmount>
    <Sale:ProjectId xsi:type="xsd:int">0</Sale:ProjectId>
    <Sale:EarningPercent xsi:type="xsd:double">0.0</Sale:EarningPercent>
    <Sale:Earning xsi:type="xsd:double">0.0</Sale:Earning>
    <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
    <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
    <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
    <Sale:SaleTypeId xsi:type="xsd:int">0</Sale:SaleTypeId>
    <Sale:SaleTypeName xsi:type="xsd:string"></Sale:SaleTypeName>
    <Sale:PersonFullName xsi:type="xsd:string"></Sale:PersonFullName>
    <Sale:Completed xsi:type="Sale:ActivityStatus">Unknown</Sale:Completed>
    <Sale:ActiveErpLinks xsi:type="xsd:int">0</Sale:ActiveErpLinks>
    <Sale:NextDueDate xsi:type="xsd:dateTime">2023-03-31T13:24:11Z</Sale:NextDueDate>
   </Sale:Response>
  </Sale:GetSaleResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

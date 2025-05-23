---
generated: true
uid: wsdl-Services88-EMail
title: Services88.EMailAgent WSDL
---

# Services88.EMailAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfEMailService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetPreviewAttachmentFromId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailItemId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AttachmentType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AttachmentFilename" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ApplicationToken" nillable="true" type="xs:string" />
      <xs:complexType name="SoCredentials">
        <xs:sequence>
          <xs:element minOccurs="0" name="Ticket" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoCredentials" nillable="true" type="q1:SoCredentials" xmlns:q1="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Credentials" nillable="true" type="q2:SoCredentials" xmlns:q2="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="q3:SoTimeZone" xmlns:q3="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="TimeZone" nillable="true" type="q4:SoTimeZone" xmlns:q4="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetPreviewAttachmentFromIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:EMailAttachment" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailAttachment">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Size" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Encoding" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Id" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Disposition" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsSafeFileExtension" type="xs:boolean" />
              <xs:element minOccurs="0" name="Stream" nillable="true" type="xs:base64Binary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailAttachment" nillable="true" type="q7:EMailAttachment" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="q8:TableRight" xmlns:q8="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="q9:FieldPropertyDictionary" xmlns:q9="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="q10:Carrier" xmlns:q10="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q11:ETableRight" xmlns:q11="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="q12:TableRight" xmlns:q12="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ETableRight">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Select" />
              <xs:enumeration value="Update" />
              <xs:enumeration value="Insert" />
              <xs:enumeration value="Delete" />
              <xs:enumeration value="Filtering" />
              <xs:enumeration value="RestrictedUpdate" />
              <xs:enumeration value="Unused1" />
              <xs:enumeration value="Uninitialized" />
              <xs:enumeration value="R">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
              <xs:enumeration value="F">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ETableRight" nillable="true" type="q13:ETableRight" xmlns:q13="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldPropertyDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="FieldPropertyDictionaryKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="q14:FieldProperty" xmlns:q14="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="q15:FieldPropertyDictionary" xmlns:q15="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="q16:FieldRight" xmlns:q16="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="q17:FieldProperty" xmlns:q17="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="q18:EFieldRight" xmlns:q18="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="q19:FieldRight" xmlns:q19="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="EFieldRight">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Read" />
              <xs:enumeration value="Write" />
              <xs:enumeration value="Unused1" />
              <xs:enumeration value="Unused2" />
              <xs:enumeration value="Unused3" />
              <xs:enumeration value="Unused4" />
              <xs:enumeration value="UIHintMandatory" />
              <xs:enumeration value="UIHintReadOnly" />
              <xs:enumeration value="UndefinedValue256" />
              <xs:enumeration value="Nullable">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">32</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="q20:EFieldRight" xmlns:q20="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q21:SoExceptionInfo" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q22:SoExceptionInfoParameters" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q23:SoExceptionInfo" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoExceptionInfoParameters">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SoExceptionInfoParametersKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q24:SoExceptionInfoParameters" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExceptionInfo" nillable="true" type="q25:SoExceptionInfo" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoExtraInfo">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ExtraInfoNameValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExtraInfo" nillable="true" type="q26:SoExtraInfo" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExtraInfo" nillable="true" type="q27:SoExtraInfo" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="GetUnsanitizedPreviewAttachmentFromId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailItemId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentId" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AttachmentType" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AttachmentFilename" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedPreviewAttachmentFromIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q28:EMailAttachment" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewAttachmentFromDocId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPreviewAttachmentFromDocIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q29:EMailAttachment" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedPreviewAttachmentFromDocId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedPreviewAttachmentFromDocIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q30:EMailAttachment" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TestAuthenticate">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="TestAuthenticateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleSubscription">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FolderId" type="xs:int" />
            <xs:element minOccurs="0" name="SubscriptionStatus" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleSubscriptionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasNewMail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailItemId" type="xs:int" />
            <xs:element minOccurs="0" name="FolderId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasNewMailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="LatestItemIdByFolder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FolderId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="LatestItemIdByFolderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateInlineHtmlHeader">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Email" nillable="true" type="q31:EMailEntity" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q32:Carrier" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="To" nillable="true" type="q32:ArrayOfEMailAddress" />
              <xs:element minOccurs="0" name="Cc" nillable="true" type="q32:ArrayOfEMailAddress" />
              <xs:element minOccurs="0" name="Bcc" nillable="true" type="q32:ArrayOfEMailAddress" />
              <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HTMLBody" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="From" nillable="true" type="q32:EMailAddress" />
              <xs:element minOccurs="0" name="Sent" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Size" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" type="q32:EMailPriority" />
              <xs:element minOccurs="0" name="Flags" type="q32:EMailFlags" />
              <xs:element minOccurs="0" name="MessageID" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PlainBody" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsSent" type="xs:boolean" />
              <xs:element minOccurs="0" name="EMailSOInfo" nillable="true" type="q32:EMailSOInfo" />
              <xs:element minOccurs="0" name="ServerId" type="xs:int" />
              <xs:element minOccurs="0" name="Attachments" nillable="true" type="q32:ArrayOfEMailAttachment" />
              <xs:element minOccurs="0" name="CustomHeaderList" nillable="true" type="q32:ArrayOfEMailCustomHeader" />
              <xs:element minOccurs="0" name="FolderName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailItemId" type="xs:int" />
              <xs:element minOccurs="0" name="AccountId" type="xs:int" />
              <xs:element minOccurs="0" name="ReceivedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="InReplyTo" nillable="true" type="q32:EMailEnvelope" />
              <xs:element minOccurs="0" name="RepliedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasCalendarData" type="xs:boolean" />
              <xs:element minOccurs="0" name="CalMethod" type="q32:CalMethod" />
              <xs:element minOccurs="0" name="CalReplyStatus" type="q32:CalReplyStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailEntity" nillable="true" type="q33:EMailEntity" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfEMailAddress">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailAddress" nillable="true" type="q34:EMailAddress" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailAddress" nillable="true" type="q35:ArrayOfEMailAddress" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailAddress">
        <xs:complexContent mixed="false">
          <xs:extension base="q36:Carrier" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailId" type="xs:int" />
              <xs:element minOccurs="0" name="DuplicatePersonIds" nillable="true" type="q37:ArrayOfint" xmlns:q37="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailAddress" nillable="true" type="q38:EMailAddress" xmlns:q38="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="EMailPriority">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="NoPriority" />
          <xs:enumeration value="Highest" />
          <xs:enumeration value="High" />
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Low" />
          <xs:enumeration value="Lowest" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="EMailPriority" nillable="true" type="q39:EMailPriority" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="EMailFlags">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Seen" />
              <xs:enumeration value="Deleted" />
              <xs:enumeration value="Recent" />
              <xs:enumeration value="Flagged" />
              <xs:enumeration value="Draft" />
              <xs:enumeration value="Answered" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EMailFlags" nillable="true" type="q40:EMailFlags" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailSOInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q41:Carrier" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="Archived" type="xs:boolean" />
              <xs:element minOccurs="0" name="ArchivedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ArchivedBy" type="xs:int" />
              <xs:element minOccurs="0" name="ArchivedDisplayName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailSOInfo" nillable="true" type="q42:EMailSOInfo" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfEMailAttachment">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailAttachment" nillable="true" type="q43:EMailAttachment" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailAttachment" nillable="true" type="q44:ArrayOfEMailAttachment" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfEMailCustomHeader">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailCustomHeader" nillable="true" type="q45:EMailCustomHeader" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailCustomHeader" nillable="true" type="q46:ArrayOfEMailCustomHeader" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailCustomHeader">
        <xs:complexContent mixed="false">
          <xs:extension base="q47:Carrier" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Values" nillable="true" type="q48:ArrayOfstring" xmlns:q48="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailCustomHeader" nillable="true" type="q49:EMailCustomHeader" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailEnvelope">
        <xs:complexContent mixed="false">
          <xs:extension base="q50:Carrier" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ServerId" type="xs:int" />
              <xs:element minOccurs="0" name="MessageId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="From" nillable="true" type="q50:EMailAddress" />
              <xs:element minOccurs="0" name="To" nillable="true" type="q50:ArrayOfEMailAddress" />
              <xs:element minOccurs="0" name="Sent" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Priority" type="q50:EMailPriority" />
              <xs:element minOccurs="0" name="Flags" type="q50:EMailFlags" />
              <xs:element minOccurs="0" name="Size" type="xs:int" />
              <xs:element minOccurs="0" name="EMailSOInfo" nillable="true" type="q50:EMailSOInfo" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailEnvelope" nillable="true" type="q51:EMailEnvelope" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="CalMethod">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Add" />
          <xs:enumeration value="Cancel" />
          <xs:enumeration value="Counter" />
          <xs:enumeration value="DeclineCounter" />
          <xs:enumeration value="Publish" />
          <xs:enumeration value="Refresh" />
          <xs:enumeration value="Reply" />
          <xs:enumeration value="Request" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CalMethod" nillable="true" type="q52:CalMethod" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="CalReplyStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Accepted" />
          <xs:enumeration value="Declined" />
          <xs:enumeration value="Tentative" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CalReplyStatus" nillable="true" type="q53:CalReplyStatus" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateInlineHtmlHeaderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q54:EMailAppointment" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailAppointment">
        <xs:complexContent mixed="false">
          <xs:extension base="q55:Carrier" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Appointment" nillable="true" type="q55:Appointment" />
              <xs:element minOccurs="0" name="CalMethod" type="q55:CalMethod" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q56:ArrayOfstring" xmlns:q56="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Sequence" type="xs:int" />
              <xs:element minOccurs="0" name="DtStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="DtEnd" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Superseded" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailAppointment" nillable="true" type="q57:EMailAppointment" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Appointment">
        <xs:complexContent mixed="false">
          <xs:extension base="q58:Carrier" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Type" type="q58:AppointmentType" />
              <xs:element minOccurs="0" name="Task" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="ColorIndex" type="xs:short" />
              <xs:element minOccurs="0" name="IsFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="HasAlarm" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="Private" type="q58:AppointmentPrivate" />
              <xs:element minOccurs="0" name="PriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskType" type="q58:TaskType" />
              <xs:element minOccurs="0" name="IsBookingMain" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBooking" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q58:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q58:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q58:BookingType" />
              <xs:element minOccurs="0" name="Completed" type="q58:ActivityStatus" />
              <xs:element minOccurs="0" name="RecurringPattern" type="q58:RecurrencePattern" />
              <xs:element minOccurs="0" name="RecurringStartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RecurringEndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="AssignedBy" type="xs:int" />
              <xs:element minOccurs="0" name="AssignedByFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Location" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AlarmLeadTime" type="ser:duration" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedByFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedByAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="CautionWarning" type="q58:AppointmentCautionWarning" />
              <xs:element minOccurs="0" name="OwnedExternally" type="q58:AppointmentExternalOwner" />
              <xs:element minOccurs="0" name="JoinVideomeetUrl" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PreferredTZLocation" type="xs:int" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Agenda" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InternalNotes" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Appointment" nillable="true" type="q59:Appointment" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="AppointmentType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="inDiary" />
          <xs:enumeration value="inChecklist" />
          <xs:enumeration value="Note" />
          <xs:enumeration value="Document" />
          <xs:enumeration value="SavedReport" />
          <xs:enumeration value="BookingForDiary" />
          <xs:enumeration value="BookingForChecklist" />
          <xs:enumeration value="MergeDraft" />
          <xs:enumeration value="MergeFinal" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentType" nillable="true" type="q60:AppointmentType" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="AppointmentPrivate">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Public" />
          <xs:enumeration value="PrivateUser" />
          <xs:enumeration value="PrivateGroup" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentPrivate" nillable="true" type="q61:AppointmentPrivate" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="TaskType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Appointment" />
          <xs:enumeration value="Document" />
          <xs:enumeration value="Email" />
          <xs:enumeration value="Fax" />
          <xs:enumeration value="Phone" />
          <xs:enumeration value="ToDo" />
          <xs:enumeration value="MailMergeDraft" />
          <xs:enumeration value="MailMergeFinal" />
          <xs:enumeration value="Report" />
          <xs:enumeration value="SaintAll" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="TaskType" nillable="true" type="q62:TaskType" xmlns:q62="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="AssignmentStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Assigning">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Seen">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Declined">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">13</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AssignmentStatus" nillable="true" type="q63:AssignmentStatus" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="InvitationStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Accepted" />
          <xs:enumeration value="Hidden">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Invitation">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Moved">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">6</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Seen">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="MovedSeen">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Declined">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">9</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="Cancelled">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">10</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="InvitationStatus" nillable="true" type="q64:InvitationStatus" xmlns:q64="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q65:BookingType" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q66:ActivityStatus" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrencePattern">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Daily" />
          <xs:enumeration value="Weekly" />
          <xs:enumeration value="Monthly" />
          <xs:enumeration value="Yearly" />
          <xs:enumeration value="Custom" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrencePattern" nillable="true" type="q67:RecurrencePattern" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="AppointmentCautionWarning">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="OK" />
          <xs:enumeration value="NotInSync" />
          <xs:enumeration value="NotNotifiedByEmail" />
          <xs:enumeration value="RecurrencePatternNotSupported" />
          <xs:enumeration value="IncomingRecurrenceChangeNotSupported" />
          <xs:enumeration value="ExternalParticipantsDateTimeMismatch" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentCautionWarning" nillable="true" type="q68:AppointmentCautionWarning" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="AppointmentExternalOwner">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Other" />
          <xs:enumeration value="Outlook" />
          <xs:enumeration value="Google" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentExternalOwner" nillable="true" type="q69:AppointmentExternalOwner" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetEmailAppointmentRecurrence">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailAppointmentRecurrenceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q70:RecurrenceInfo" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="RecurrenceInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="RecurrenceId" type="xs:int" />
          <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
          <xs:element minOccurs="0" name="RecurrenceEndType" type="q71:RecurrenceEndType" xmlns:q71="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q72:RecurrencePattern" xmlns:q72="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="DayPattern" nillable="true" type="q73:RecurrenceDayPattern" xmlns:q73="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekPattern" nillable="true" type="q74:RecurrenceWeekPattern" xmlns:q74="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="MonthPattern" nillable="true" type="q75:RecurrenceMonthPattern" xmlns:q75="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="YearPattern" nillable="true" type="q76:RecurrenceYearPattern" xmlns:q76="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Dates" nillable="true" type="q77:ArrayOfRecurrenceDate" xmlns:q77="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="RecurrenceCounter" type="xs:int" />
          <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceInfo" nillable="true" type="q78:RecurrenceInfo" xmlns:q78="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceEndType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EndDate" />
          <xs:enumeration value="Counter" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceEndType" nillable="true" type="q79:RecurrenceEndType" xmlns:q79="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceDayPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Pattern" type="q80:RecurrenceDailyPattern" xmlns:q80="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDayPattern" nillable="true" type="q81:RecurrenceDayPattern" xmlns:q81="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceDailyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="EveryWorkday" />
          <xs:enumeration value="EveryWeekday" />
          <xs:enumeration value="EveryCyclicDay" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceDailyPattern" nillable="true" type="q82:RecurrenceDailyPattern" xmlns:q82="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceWeekPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Weekdays" type="q83:Weekday" xmlns:q83="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceWeekPattern" nillable="true" type="q84:RecurrenceWeekPattern" xmlns:q84="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="Weekday">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Monday" />
              <xs:enumeration value="Tuesday" />
              <xs:enumeration value="Wednesday" />
              <xs:enumeration value="Thursday" />
              <xs:enumeration value="Friday" />
              <xs:enumeration value="Saturday" />
              <xs:enumeration value="Sunday" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="Weekday" nillable="true" type="q85:Weekday" xmlns:q85="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceMonthPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q86:Weekday" xmlns:q86="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q87:WeekOfMonth" xmlns:q87="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q88:RecurrenceMonthlyPattern" xmlns:q88="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceMonthPattern" nillable="true" type="q89:RecurrenceMonthPattern" xmlns:q89="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="WeekOfMonth">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="First" />
          <xs:enumeration value="Second" />
          <xs:enumeration value="Third" />
          <xs:enumeration value="Fourth" />
          <xs:enumeration value="Last" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="WeekOfMonth" nillable="true" type="q90:WeekOfMonth" xmlns:q90="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceMonthlyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="DayOfMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="WeekdayOfMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">5</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceMonthlyPattern" nillable="true" type="q91:RecurrenceMonthlyPattern" xmlns:q91="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceYearPattern">
        <xs:sequence>
          <xs:element minOccurs="0" name="Cycle" type="xs:int" />
          <xs:element minOccurs="0" name="Day" type="xs:int" />
          <xs:element minOccurs="0" name="Weekday" type="q92:Weekday" xmlns:q92="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="WeekOfMonth" type="q93:WeekOfMonth" xmlns:q93="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Pattern" type="q94:RecurrenceYearlyPattern" xmlns:q94="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceYearPattern" nillable="true" type="q95:RecurrenceYearPattern" xmlns:q95="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceYearlyPattern">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="DayOfMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">6</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="WeekdayOfMonth">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceYearlyPattern" nillable="true" type="q96:RecurrenceYearlyPattern" xmlns:q96="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfRecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RecurrenceDate" nillable="true" type="q97:RecurrenceDate" xmlns:q97="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRecurrenceDate" nillable="true" type="q98:ArrayOfRecurrenceDate" xmlns:q98="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RecurrenceDate">
        <xs:sequence>
          <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
          <xs:element minOccurs="0" name="IsConflict" type="xs:boolean" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="DescriptionStyleHint" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="RecurrenceDate" nillable="true" type="q99:RecurrenceDate" xmlns:q99="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetParticipantInfoFromEmailAddress">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetParticipantInfoFromEmailAddressResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q100:Person" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q101:Carrier" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Position" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Mrmrs" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Firstname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Lastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Email" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DirectPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CountryId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Retired" type="xs:short" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="ActiveInterests" type="xs:short" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactCountryId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactOrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FaxPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MobilePhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="UsePersonAddress" type="xs:boolean" />
              <xs:element minOccurs="0" name="ContactFax" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanafname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanalname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="TicketPriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="SupportLanguageId" type="xs:int" />
              <xs:element minOccurs="0" name="SupportAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="CategoryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonNumber" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Person" nillable="true" type="q102:Person" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetEmailDocumentAsMimeStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailDocumentAsMimeStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailSOInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EMailSOInfoId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailSOInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q103:EMailSOInfo" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReadySyncEmailAccounts">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetReadySyncEmailAccountsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q104:ArrayOfSyncUserAccount" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfSyncUserAccount">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SyncUserAccount" nillable="true" type="q105:SyncUserAccount" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSyncUserAccount" nillable="true" type="q106:ArrayOfSyncUserAccount" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SyncUserAccount">
        <xs:complexContent mixed="false">
          <xs:extension base="q107:Carrier" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AccountId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SyncUserAccount" nillable="true" type="q108:SyncUserAccount" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SyncEmailAccount">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SyncUserAccount" nillable="true" type="q109:SyncUserAccount" xmlns:q109="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SyncEmailAccountResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SyncEmailAccounts">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SyncUserAccounts" nillable="true" type="q110:ArrayOfSyncUserAccount" xmlns:q110="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SyncEmailAccountsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailAccount">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailAccountResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q111:EMailAccount" xmlns:q111="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailAccount">
        <xs:complexContent mixed="false">
          <xs:extension base="q112:Carrier" xmlns:q112="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="EMailAccountId" type="xs:int" />
              <xs:element minOccurs="0" name="EMailAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="IncomingCredentials" nillable="true" type="q112:ServiceAuth" />
              <xs:element minOccurs="0" name="OutgoingCredentials" nillable="true" type="q112:ServiceAuth" />
              <xs:element minOccurs="0" name="AccountStatus" type="xs:short" />
              <xs:element minOccurs="0" name="ErrorCount" type="xs:int" />
              <xs:element minOccurs="0" name="ErrorReason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InboxFolder" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SentFolder" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SimpleMode" type="xs:short" />
              <xs:element minOccurs="0" name="LastFetch" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailAccount" nillable="true" type="q113:EMailAccount" xmlns:q113="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ServiceAuth">
        <xs:complexContent mixed="false">
          <xs:extension base="q114:Carrier" xmlns:q114="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ServiceAuthId" type="xs:int" />
              <xs:element minOccurs="0" name="Server" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Port" type="xs:int" />
              <xs:element minOccurs="0" name="AuthType" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Username" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ServiceAuth" nillable="true" type="q115:ServiceAuth" xmlns:q115="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveEMailAccount">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EMailAccount" nillable="true" type="q116:EMailAccount" xmlns:q116="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveEMailAccountResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q117:EMailAccount" xmlns:q117="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEMailAccount">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EMailAccountId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEMailAccountResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailAddress">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailAddressResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q118:EMailAddress" xmlns:q118="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailAppointment">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q119:EMailAppointment" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailAttachment">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailAttachmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q120:EMailAttachment" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailConnectionInfo">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailConnectionInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q121:EMailConnectionInfo" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailConnectionInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q122:Carrier" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ServerName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Folder" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UseSSL" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailConnectionInfo" nillable="true" type="q123:EMailConnectionInfo" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateDefaultEMailConnectionInfoExtended">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailConnectionInfoExtendedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q124:EMailConnectionInfoExtended" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailConnectionInfoExtended">
        <xs:complexContent mixed="false">
          <xs:extension base="q125:Carrier" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Port" type="xs:int" />
              <xs:element minOccurs="0" name="ServerName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Protocol" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Password" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UseSSL" type="xs:boolean" />
              <xs:element minOccurs="0" name="Folder" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailConnectionInfoExtended" nillable="true" type="q126:EMailConnectionInfoExtended" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateDefaultEMailCustomHeader">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailCustomHeaderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q127:EMailCustomHeader" xmlns:q127="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q128:EMailEntity" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailEnvelope">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailEnvelopeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q129:EMailEnvelope" xmlns:q129="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailFolder">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailFolderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q130:EMailFolder" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailFolder">
        <xs:complexContent mixed="false">
          <xs:extension base="q131:Carrier" xmlns:q131="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Delimiter" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Flags" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TotalItems" type="xs:int" />
              <xs:element minOccurs="0" name="UnreadItems" type="xs:int" />
              <xs:element minOccurs="0" name="Subscribed" type="xs:boolean" />
              <xs:element minOccurs="0" name="EmailFolderId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailFolder" nillable="true" type="q132:EMailFolder" xmlns:q132="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateDefaultEMailSOInfo">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultEMailSOInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q133:EMailSOInfo" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailAccount">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EMailAccountId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailAccountResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q134:EMailAccount" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailAccountFromEMailAddress">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FromAddress" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailAccountFromEMailAddressResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q135:EMailAccount" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrentAccountId">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrentAccountIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrentAccount">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCurrentAccountResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q136:EMailAccount" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonEntitiesFromEmailAddress">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonEntitiesFromEmailAddressResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q137:ArrayOfPersonEntity" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPersonEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="PersonEntity" nillable="true" type="q138:PersonEntity" xmlns:q138="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPersonEntity" nillable="true" type="q139:ArrayOfPersonEntity" xmlns:q139="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="PersonEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q140:Carrier" xmlns:q140="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Firstname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Lastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Mrmrs" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="BirthDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q140:Associate" />
              <xs:element minOccurs="0" name="Emails" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsAssociate" type="xs:boolean" />
              <xs:element minOccurs="0" name="PrivatePhones" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Faxes" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="MobilePhones" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="OfficePhones" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="OtherPhones" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Position" nillable="true" type="q140:Position" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q140:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q140:Contact" />
              <xs:element minOccurs="0" name="Country" nillable="true" type="q140:Country" />
              <xs:element minOccurs="0" name="Interests" nillable="true" type="q140:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="PersonNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="NoMailing" type="xs:boolean" />
              <xs:element minOccurs="0" name="UsePersonAddress" type="xs:boolean" />
              <xs:element minOccurs="0" name="Retired" type="xs:boolean" />
              <xs:element minOccurs="0" name="Urls" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="q140:Address" />
              <xs:element minOccurs="0" name="Post3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Post1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanalname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kanafname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CorrespondingAssociate" nillable="true" type="q140:Associate" />
              <xs:element minOccurs="0" name="Category" nillable="true" type="q140:Category" />
              <xs:element minOccurs="0" name="Business" nillable="true" type="q140:Business" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q140:Associate" />
              <xs:element minOccurs="0" name="Salutation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveInterests" type="xs:int" />
              <xs:element minOccurs="0" name="SupportAssociate" nillable="true" type="q140:Associate" />
              <xs:element minOccurs="0" name="TicketPriority" nillable="true" type="q140:TicketPriority" />
              <xs:element minOccurs="0" name="CustomerLanguage" nillable="true" type="q140:CustomerLanguage" />
              <xs:element minOccurs="0" name="DbiAgentId" type="xs:int" />
              <xs:element minOccurs="0" name="DbiKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DbiLastModified" type="xs:dateTime" />
              <xs:element minOccurs="0" name="DbiLastSyncronized" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SentInfo" type="xs:short" />
              <xs:element minOccurs="0" name="ShowContactTickets" type="xs:short" />
              <xs:element minOccurs="0" name="UserInfo" nillable="true" type="q140:UserInfo" />
              <xs:element minOccurs="0" name="ChatEmails" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="InternetPhones" nillable="true" type="q140:ArrayOfEntityElement" />
              <xs:element minOccurs="0" name="Source" type="xs:short" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="ShipmentTypes" nillable="true" type="q140:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="Consents" nillable="true" type="q140:ArrayOfConsentInfo" />
              <xs:element minOccurs="0" name="BounceEmails" nillable="true" type="q141:ArrayOfstring" xmlns:q141="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="ActiveStatusMonitorId" type="xs:int" />
              <xs:element minOccurs="0" name="CreatedByFormId" type="xs:int" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q140:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q140:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q140:StringDictionary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PersonEntity" nillable="true" type="q142:PersonEntity" xmlns:q142="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q143:Carrier" xmlns:q143="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q143:UserType" />
              <xs:element minOccurs="0" name="GroupIdx" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Associate" nillable="true" type="q144:Associate" xmlns:q144="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="UserType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="InternalAssociate" />
          <xs:enumeration value="ResourceAssociate" />
          <xs:enumeration value="ExternalAssociate" />
          <xs:enumeration value="AnonymousAssociate" />
          <xs:enumeration value="SystemAssociate" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="UserType" nillable="true" type="q145:UserType" xmlns:q145="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfEntityElement">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EntityElement" nillable="true" type="q146:EntityElement" xmlns:q146="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEntityElement" nillable="true" type="q147:ArrayOfEntityElement" xmlns:q147="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EntityElement">
        <xs:complexContent mixed="false">
          <xs:extension base="q148:Carrier" xmlns:q148="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StrippedValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EntityElement" nillable="true" type="q149:EntityElement" xmlns:q149="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Position">
        <xs:complexContent mixed="false">
          <xs:extension base="q150:Carrier" xmlns:q150="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Position" nillable="true" type="q151:Position" xmlns:q151="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q152:Carrier" xmlns:q152="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrgNr" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Department" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="URL" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="City" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DirectPhone" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="CountryId" type="xs:int" />
              <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Kananame" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailAddressName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="URLName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="BusinessName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CategoryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CountryName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="q152:Address" />
              <xs:element minOccurs="0" name="FormattedAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsOwnerContact" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Number1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Number2" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Contact" nillable="true" type="q153:Contact" xmlns:q153="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q154:Carrier" xmlns:q154="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q154:ArrayOfArrayOfLocalizedField" />
              <xs:element minOccurs="0" name="Street" nillable="true" type="q154:StructuredAddress" />
              <xs:element minOccurs="0" name="Postal" nillable="true" type="q154:StructuredAddress" />
              <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q155:Address" xmlns:q155="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q156:ArrayOfLocalizedField" xmlns:q156="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q157:ArrayOfArrayOfLocalizedField" xmlns:q157="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q158:LocalizedField" xmlns:q158="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q159:ArrayOfLocalizedField" xmlns:q159="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q160:Carrier" xmlns:q160="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Label" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ValueLength" type="xs:int" />
              <xs:element minOccurs="0" name="AddressType" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="LocalizedField" nillable="true" type="q161:LocalizedField" xmlns:q161="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="StructuredAddress">
        <xs:sequence>
          <xs:element minOccurs="0" name="AtypeIdx" type="q162:AddressType" xmlns:q162="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Address1" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Address2" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Address3" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="City" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="County" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="State" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Zipcode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StructuredAddress" nillable="true" type="q163:StructuredAddress" xmlns:q163="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="AddressType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="ContactPostalAddress" />
          <xs:enumeration value="ContactStreetAddress" />
          <xs:enumeration value="PersonPrivateAddress">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16387</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="QuoteBillingAddress">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8196</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="QuoteShippingAddress">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8197</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AddressType" nillable="true" type="q164:AddressType" xmlns:q164="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Country">
        <xs:complexContent mixed="false">
          <xs:extension base="q165:Carrier" xmlns:q165="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="CountryId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CurrencyId" type="xs:int" />
              <xs:element minOccurs="0" name="EnglishName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TwoLetterISOCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ThreeLetterISOCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ImageDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrgNrText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InterAreaPrefix" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DialInPrefix" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ZipPrefix" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DomainName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AddressLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="DomesticAddressLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="ForeignAddressLayoutId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Country" nillable="true" type="q166:Country" xmlns:q166="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfSelectableMDOListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SelectableMDOListItem" nillable="true" type="q167:SelectableMDOListItem" xmlns:q167="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfSelectableMDOListItem" nillable="true" type="q168:ArrayOfSelectableMDOListItem" xmlns:q168="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SelectableMDOListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q169:Carrier" xmlns:q169="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToolTip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ColorBlock" type="xs:int" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Selected" type="xs:boolean" />
              <xs:element minOccurs="0" name="LastChanged" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ChildItems" nillable="true" type="q169:ArrayOfSelectableMDOListItem" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StyleHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Hidden" type="xs:boolean" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SelectableMDOListItem" nillable="true" type="q170:SelectableMDOListItem" xmlns:q170="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Category">
        <xs:complexContent mixed="false">
          <xs:extension base="q171:Carrier" xmlns:q171="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Category" nillable="true" type="q172:Category" xmlns:q172="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Business">
        <xs:complexContent mixed="false">
          <xs:extension base="q173:Carrier" xmlns:q173="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Business" nillable="true" type="q174:Business" xmlns:q174="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TicketPriority">
        <xs:complexContent mixed="false">
          <xs:extension base="q175:Carrier" xmlns:q175="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TicketPriority" nillable="true" type="q176:TicketPriority" xmlns:q176="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="CustomerLanguage">
        <xs:complexContent mixed="false">
          <xs:extension base="q177:Carrier" xmlns:q177="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CustomerLanguage" nillable="true" type="q178:CustomerLanguage" xmlns:q178="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="UserInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q179:Carrier" xmlns:q179="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserInfoId" type="xs:int" />
              <xs:element minOccurs="0" name="UserName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupId" type="xs:int" />
              <xs:element minOccurs="0" name="EjUserId" type="xs:int" />
              <xs:element minOccurs="0" name="UserType" type="q179:UserType" />
              <xs:element minOccurs="0" name="GrantedLicenses" nillable="true" type="q180:ArrayOfstring" xmlns:q180="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="CanLogon" type="xs:boolean" />
              <xs:element minOccurs="0" name="RoleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RoleTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserGroupTooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="UserInfo" nillable="true" type="q181:UserInfo" xmlns:q181="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfConsentInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ConsentInfo" nillable="true" type="q182:ConsentInfo" xmlns:q182="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfConsentInfo" nillable="true" type="q183:ArrayOfConsentInfo" xmlns:q183="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ConsentInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q184:Carrier" xmlns:q184="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ConsentPersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Comment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="LegalBaseId" type="xs:int" />
              <xs:element minOccurs="0" name="LegalBaseKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LegalBaseName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentPurposeId" type="xs:int" />
              <xs:element minOccurs="0" name="ConsentPurposeKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentPurposeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentSourceId" type="xs:int" />
              <xs:element minOccurs="0" name="ConsentSourceKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ConsentSourceName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ConsentInfo" nillable="true" type="q185:ConsentInfo" xmlns:q185="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="StringDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StringKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StringDictionary" nillable="true" type="q186:StringDictionary" xmlns:q186="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetPersonsFromEmailAddress">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonsFromEmailAddressResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q187:ArrayOfPerson" xmlns:q187="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPerson">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Person" nillable="true" type="q188:Person" xmlns:q188="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPerson" nillable="true" type="q189:ArrayOfPerson" xmlns:q189="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="HasMXRecord">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailDomain" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasMXRecordResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasSPFRecord">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SourceSpf" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TargetDomain" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="HasSPFRecordResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ResolveEMailRecipients">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ResolveEMailRecipientsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q190:ArrayOfEMailAddress" xmlns:q190="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q191:EMailConnectionInfo" xmlns:q191="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageServerId" type="xs:int" />
            <xs:element minOccurs="0" name="LookupAddresses" type="xs:boolean" />
            <xs:element minOccurs="0" name="Flags" type="q192:EMailFlags" xmlns:q192="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="IncludeAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q193:EMailEntity" xmlns:q193="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendEMails">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OutgoingConnectionInfo" nillable="true" type="q194:EMailConnectionInfo" xmlns:q194="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Emails" nillable="true" type="q195:ArrayOfEMailEntity" xmlns:q195="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="SentItemsConnectionInfo" nillable="true" type="q196:EMailConnectionInfo" xmlns:q196="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfEMailEntity">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailEntity" nillable="true" type="q197:EMailEntity" xmlns:q197="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailEntity" nillable="true" type="q198:ArrayOfEMailEntity" xmlns:q198="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SendEMailsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q199:ArrayOfEMailEntity" xmlns:q199="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveEMail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q200:EMailConnectionInfo" xmlns:q200="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Email" nillable="true" type="q201:EMailEntity" xmlns:q201="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveEMailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q202:EMailEntity" xmlns:q202="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AuthenticateIncoming">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q203:EMailConnectionInfo" xmlns:q203="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AuthenticateIncomingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AuthenticateOutgoing">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q204:EMailConnectionInfo" xmlns:q204="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AuthenticateOutgoingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFolderList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q205:EMailConnectionInfo" xmlns:q205="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="IncludeItemCount" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFolderListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q206:ArrayOfstring" xmlns:q206="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q207:EMailConnectionInfo" xmlns:q207="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageServerId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q208:EMailAttachment" xmlns:q208="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MarkAsRead">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q209:EMailConnectionInfo" xmlns:q209="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageServerIds" nillable="true" type="q210:ArrayOfint" xmlns:q210="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Read" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MarkAsReadResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFolderEMailCount">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q211:EMailConnectionInfo" xmlns:q211="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="OnlyUnread" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFolderEMailCountResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Delete">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q212:EMailConnectionInfo" xmlns:q212="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageServerIds" nillable="true" type="q213:ArrayOfint" xmlns:q213="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="MoveToFolder" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveToFolder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q214:EMailConnectionInfo" xmlns:q214="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageServerIds" nillable="true" type="q215:ArrayOfint" xmlns:q215="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="TargetFolder" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveToFolderResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="EmptyFolder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q216:EMailConnectionInfo" xmlns:q216="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MoveToFolder" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="EmptyFolderResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailAsStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q217:EMailConnectionInfo" xmlns:q217="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageServerId" type="xs:int" />
            <xs:element minOccurs="0" name="StripAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailAsStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindAddress">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Address" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindAddressResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q218:ArrayOfEMailAddress" xmlns:q218="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromDocumentId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromDocumentIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q219:EMailEntity" xmlns:q219="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailFromDocumentId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailFromDocumentIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q220:EMailEntity" xmlns:q220="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromAttachmentId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q221:ArrayOfstring" xmlns:q221="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="IncludeAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromAttachmentIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q222:EMailEntity" xmlns:q222="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailFromAttachmentId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q223:ArrayOfstring" xmlns:q223="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="IncludeAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailFromAttachmentIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q224:EMailEntity" xmlns:q224="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromDocumentAttachmentId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q225:ArrayOfstring" xmlns:q225="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="IncludeAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromDocumentAttachmentIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q226:EMailEntity" xmlns:q226="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailFromDocumentAttachmentId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentIds" nillable="true" type="q227:ArrayOfstring" xmlns:q227="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="IncludeAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailFromDocumentAttachmentIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q228:EMailEntity" xmlns:q228="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailEnvelopes">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q229:EMailConnectionInfo" xmlns:q229="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageServerIds" nillable="true" type="q230:ArrayOfint" xmlns:q230="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailEnvelopesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q231:ArrayOfEMailEnvelope" xmlns:q231="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfEMailEnvelope">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailEnvelope" nillable="true" type="q232:EMailEnvelope" xmlns:q232="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailEnvelope" nillable="true" type="q233:ArrayOfEMailEnvelope" xmlns:q233="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SetSubscription">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q234:EMailConnectionInfo" xmlns:q234="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Folders" nillable="true" type="q235:ArrayOfEMailFolder" xmlns:q235="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfEMailFolder">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailFolder" nillable="true" type="q236:EMailFolder" xmlns:q236="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailFolder" nillable="true" type="q237:ArrayOfEMailFolder" xmlns:q237="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SetSubscriptionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateFolder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q238:EMailConnectionInfo" xmlns:q238="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateFolderResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFolder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q239:EMailConnectionInfo" xmlns:q239="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteFolderResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateEMailFromDocumentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentEntity" nillable="true" type="q240:DocumentEntity" xmlns:q240="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="DocumentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q241:Carrier" xmlns:q241="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q241:Associate" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q241:Associate" />
              <xs:element minOccurs="0" name="Attention" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Header" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OurRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="YourRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DocumentTemplate" nillable="true" type="q241:DocumentTemplate" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q241:Person" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q241:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q241:Contact" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q241:Project" />
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ExternalRef" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Completed" type="q241:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Type" type="q241:AppointmentType" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q241:ArrayOfLink" />
              <xs:element minOccurs="0" name="LockSemantics" type="q241:DocumentLockSemantics" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="q241:Sale" />
              <xs:element minOccurs="0" name="SuggestedDocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="Snum" type="xs:int" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q241:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q241:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q241:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q241:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DocumentEntity" nillable="true" type="q242:DocumentEntity" xmlns:q242="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="DocumentTemplate">
        <xs:complexContent mixed="false">
          <xs:extension base="q243:Carrier" xmlns:q243="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="DocumentTemplateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaveInDb" type="xs:short" />
              <xs:element minOccurs="0" name="Filename" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultOref" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RecordType" type="q243:DocTmplType" />
              <xs:element minOccurs="0" name="Deleted" type="xs:short" />
              <xs:element minOccurs="0" name="Direction" type="q243:DocTmplDirection" />
              <xs:element minOccurs="0" name="AutoeventId" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteDocType" type="q243:DocTmplQuoteType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DocumentTemplate" nillable="true" type="q244:DocumentTemplate" xmlns:q244="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="DocTmplType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Appointment" />
          <xs:enumeration value="Document" />
          <xs:enumeration value="Email" />
          <xs:enumeration value="Fax" />
          <xs:enumeration value="Phone" />
          <xs:enumeration value="Todo" />
          <xs:enumeration value="MergeDraft" />
          <xs:enumeration value="MergeFinal" />
          <xs:enumeration value="SavedReport" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocTmplType" nillable="true" type="q245:DocTmplType" xmlns:q245="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="DocTmplDirection">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Incoming" />
          <xs:enumeration value="Outgoing" />
          <xs:enumeration value="SaintAll" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocTmplDirection" nillable="true" type="q246:DocTmplDirection" xmlns:q246="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="DocTmplQuoteType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="MailBody" />
          <xs:enumeration value="MainDocument" />
          <xs:enumeration value="QuoteLines" />
          <xs:enumeration value="ConfirmationMailBody" />
          <xs:enumeration value="ConfirmationLines" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocTmplQuoteType" nillable="true" type="q247:DocTmplQuoteType" xmlns:q247="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q248:Carrier" xmlns:q248="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="URL" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TypeId" type="xs:int" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="StatusId" type="xs:int" />
              <xs:element minOccurs="0" name="Status" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TextId" type="xs:int" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="URLName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Project" nillable="true" type="q249:Project" xmlns:q249="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q250:Link" xmlns:q250="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q251:ArrayOfLink" xmlns:q251="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q252:Carrier" xmlns:q252="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LinkId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Link" nillable="true" type="q253:Link" xmlns:q253="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="DocumentLockSemantics">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Locking" />
          <xs:enumeration value="Versioning" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="DocumentLockSemantics" nillable="true" type="q254:DocumentLockSemantics" xmlns:q254="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q255:Carrier" xmlns:q255="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="Probability" type="xs:short" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Amount" type="xs:double" />
              <xs:element minOccurs="0" name="Currency" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="q255:SaleStatus" />
              <xs:element minOccurs="0" name="WeightedAmount" type="xs:double" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="EarningPercent" type="xs:double" />
              <xs:element minOccurs="0" name="Earning" type="xs:double" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Completed" type="q255:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q256:Sale" xmlns:q256="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="SaleStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Open" />
          <xs:enumeration value="Sold" />
          <xs:enumeration value="Lost" />
          <xs:enumeration value="Stalled" />
          <xs:enumeration value="SaintAll">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1000</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="SaleStatus" nillable="true" type="q257:SaleStatus" xmlns:q257="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="q258:VisibleFor" xmlns:q258="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="q259:ArrayOfVisibleFor" xmlns:q259="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="q260:Carrier" xmlns:q260="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="q260:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="q261:VisibleFor" xmlns:q261="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="q262:Visibility" xmlns:q262="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateEMailFromDocumentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q263:EMailEntity" xmlns:q263="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateEMailFromMimeMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MimeMessage" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateEMailFromMimeMessageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q264:EMailEntity" xmlns:q264="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFolderInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q265:EMailConnectionInfo" xmlns:q265="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Folders" nillable="true" type="q266:ArrayOfstring" xmlns:q266="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFolderInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q267:ArrayOfEMailFolder" xmlns:q267="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFolderHasNewEMail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q268:EMailConnectionInfo" xmlns:q268="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetFolderHasNewEMailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailAddresses">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailIds" nillable="true" type="q269:ArrayOfint" xmlns:q269="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailAddressesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q270:ArrayOfEMailAddress" xmlns:q270="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RefreshFolder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfo" nillable="true" type="q271:EMailConnectionInfo" xmlns:q271="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Folders" nillable="true" type="q272:ArrayOfstring" xmlns:q272="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RefreshFolderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromTemp">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FileName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromTempResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q273:EMailEntity" xmlns:q273="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Authenticate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfoExtended" nillable="true" type="q274:EMailConnectionInfoExtended" xmlns:q274="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AuthenticateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailMessageIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfoExtended" nillable="true" type="q275:EMailConnectionInfoExtended" xmlns:q275="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailMessageIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q276:ArrayOfstring" xmlns:q276="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetExtendedEmailMessageIds">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfoExtended" nillable="true" type="q277:EMailConnectionInfoExtended" xmlns:q277="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetExtendedEmailMessageIdsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q278:ArrayOfstring" xmlns:q278="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailsAsString">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfoExtended" nillable="true" type="q279:EMailConnectionInfoExtended" xmlns:q279="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageIds" nillable="true" type="q280:ArrayOfstring" xmlns:q280="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEmailsAsStringResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q281:ArrayOfstring" xmlns:q281="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteExtended">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfoExtended" nillable="true" type="q282:EMailConnectionInfoExtended" xmlns:q282="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="MessageIds" nillable="true" type="q283:ArrayOfstring" xmlns:q283="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteExtendedResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RelayMessage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionInfoExtended" nillable="true" type="q284:EMailConnectionInfoExtended" xmlns:q284="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Rfc822" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="From" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Recipients" nillable="true" type="q285:ArrayOfstring" xmlns:q285="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RelayMessageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q286:EMailEntity" xmlns:q286="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q287:EMailEntity" xmlns:q287="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MarkEmailsAsRead">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q288:ArrayOfint" xmlns:q288="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="Read" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MarkEmailsAsReadResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEmails">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q289:ArrayOfint" xmlns:q289="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="MoveToFolder" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteEmailsResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveEmailsToTrash">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Ids" nillable="true" type="q290:ArrayOfint" xmlns:q290="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveEmailsToTrashResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Save">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Email" nillable="true" type="q291:EMailEntity" xmlns:q291="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q292:EMailEntity" xmlns:q292="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveToMailServer">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Email" nillable="true" type="q293:EMailEntity" xmlns:q293="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveToMailServerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q294:EMailEntity" xmlns:q294="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Send">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Emails" nillable="true" type="q295:ArrayOfEMailEntity" xmlns:q295="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q296:ArrayOfEMailEntity" xmlns:q296="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateForwardEmail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Email" nillable="true" type="q297:EMailEntity" xmlns:q297="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateForwardEmailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q298:EMailEntity" xmlns:q298="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindContactOrPersonByEmailName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindContactOrPersonByEmailNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q299:ArrayOfContactOrPersonFromEmail" xmlns:q299="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfContactOrPersonFromEmail">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ContactOrPersonFromEmail" nillable="true" type="q300:ContactOrPersonFromEmail" xmlns:q300="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfContactOrPersonFromEmail" nillable="true" type="q301:ArrayOfContactOrPersonFromEmail" xmlns:q301="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ContactOrPersonFromEmail">
        <xs:complexContent mixed="false">
          <xs:extension base="q302:Carrier" xmlns:q302="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="FullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactCategory" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SortName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ContactOrPersonFromEmail" nillable="true" type="q303:ContactOrPersonFromEmail" xmlns:q303="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="FindContactOrPersonByEmailNameWithLimit">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="NumberOfContacts" type="xs:int" />
            <xs:element minOccurs="0" name="NumberOfPersons" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindContactOrPersonByEmailNameWithLimitResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q304:ArrayOfContactOrPersonFromEmail" xmlns:q304="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RefreshFolderForAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Folders" nillable="true" type="q305:ArrayOfstring" xmlns:q305="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RefreshFolderForAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNewMail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Folders" nillable="true" type="q306:ArrayOfint" xmlns:q306="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNewMailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q307:ArrayOfEMailEnvelope" xmlns:q307="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CacheFolderList">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CacheFolderListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q308:ArrayOfEMailFolder" xmlns:q308="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveEmailsToFolder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FolderId" type="xs:int" />
            <xs:element minOccurs="0" name="EmailItemIds" nillable="true" type="q309:ArrayOfint" xmlns:q309="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveEmailsToFolderResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMailFromMessageId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MessageId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMailFromMessageIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q310:EMailEntity" xmlns:q310="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMailFromInReplyTo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MessageId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMailFromInReplyToResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q311:EMailEntity" xmlns:q311="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendAndSaveEmailToTmpDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Email" nillable="true" type="q312:EMailEntity" xmlns:q312="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="StripAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendAndSaveEmailToTmpDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveEmailToTmpDocument">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Email" nillable="true" type="q313:EMailEntity" xmlns:q313="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="FolderId" type="xs:int" />
            <xs:element minOccurs="0" name="StripAttachments" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveEmailToTmpDocumentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromEmailAttachment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="EmailItemId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromEmailAttachmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q314:DocumentEntity" xmlns:q314="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromEmail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="EmailItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateNewPhysicalDocumentFromEmailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q315:DocumentEntity" xmlns:q315="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDraft">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Entity" nillable="true" type="q316:EMailEntity" xmlns:q316="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveDraftResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q317:EMailEntity" xmlns:q317="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRepliedAt">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MessageId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetRepliedAtResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromDocumentIdWithoutAttachmentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetEMailFromDocumentIdWithoutAttachmentStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q318:EMailEntity" xmlns:q318="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q319:EMailEntity" xmlns:q319="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentFromId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MailItemId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachmentId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAttachmentFromIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q320:EMailAttachment" xmlns:q320="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:schema>
    <xs:schema attributeFormDefault="qualified" elementFormDefault="qualified" targetNamespace="http://schemas.microsoft.com/2003/10/Serialization/" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:element name="anyType" nillable="true" type="xs:anyType" />
      <xs:element name="anyURI" nillable="true" type="xs:anyURI" />
      <xs:element name="base64Binary" nillable="true" type="xs:base64Binary" />
      <xs:element name="boolean" nillable="true" type="xs:boolean" />
      <xs:element name="byte" nillable="true" type="xs:byte" />
      <xs:element name="dateTime" nillable="true" type="xs:dateTime" />
      <xs:element name="decimal" nillable="true" type="xs:decimal" />
      <xs:element name="double" nillable="true" type="xs:double" />
      <xs:element name="float" nillable="true" type="xs:float" />
      <xs:element name="int" nillable="true" type="xs:int" />
      <xs:element name="long" nillable="true" type="xs:long" />
      <xs:element name="QName" nillable="true" type="xs:QName" />
      <xs:element name="short" nillable="true" type="xs:short" />
      <xs:element name="string" nillable="true" type="xs:string" />
      <xs:element name="unsignedByte" nillable="true" type="xs:unsignedByte" />
      <xs:element name="unsignedInt" nillable="true" type="xs:unsignedInt" />
      <xs:element name="unsignedLong" nillable="true" type="xs:unsignedLong" />
      <xs:element name="unsignedShort" nillable="true" type="xs:unsignedShort" />
      <xs:element name="char" nillable="true" type="tns:char" />
      <xs:simpleType name="char">
        <xs:restriction base="xs:int" />
      </xs:simpleType>
      <xs:element name="duration" nillable="true" type="tns:duration" />
      <xs:simpleType name="duration">
        <xs:restriction base="xs:duration">
          <xs:pattern value="\-?P(\d*D)?(T(\d*H)?(\d*M)?(\d*(\.\d*)?S)?)?" />
          <xs:minInclusive value="-P10675199DT2H48M5.4775808S" />
          <xs:maxInclusive value="P10675199DT2H48M5.4775807S" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="guid" nillable="true" type="tns:guid" />
      <xs:simpleType name="guid">
        <xs:restriction base="xs:string">
          <xs:pattern value="[\da-fA-F]{8}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{12}" />
        </xs:restriction>
      </xs:simpleType>
      <xs:attribute name="FactoryType" type="xs:QName" />
      <xs:attribute name="Id" type="xs:ID" />
      <xs:attribute name="Ref" type="xs:IDREF" />
    </xs:schema>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="GetPreviewAttachmentFromIdRequest">
    <wsdl:part name="parameters" element="tns:GetPreviewAttachmentFromId" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentFromIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentFromIdResponse">
    <wsdl:part name="parameters" element="tns:GetPreviewAttachmentFromIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentFromIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedPreviewAttachmentFromIdRequest">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedPreviewAttachmentFromId" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedPreviewAttachmentFromIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedPreviewAttachmentFromIdResponse">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedPreviewAttachmentFromIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedPreviewAttachmentFromIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentFromDocIdRequest">
    <wsdl:part name="parameters" element="tns:GetPreviewAttachmentFromDocId" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentFromDocIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentFromDocIdResponse">
    <wsdl:part name="parameters" element="tns:GetPreviewAttachmentFromDocIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetPreviewAttachmentFromDocIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedPreviewAttachmentFromDocIdRequest">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedPreviewAttachmentFromDocId" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedPreviewAttachmentFromDocIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedPreviewAttachmentFromDocIdResponse">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedPreviewAttachmentFromDocIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedPreviewAttachmentFromDocIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestAuthenticateRequest">
    <wsdl:part name="parameters" element="tns:TestAuthenticate" />
  </wsdl:message>
  <wsdl:message name="TestAuthenticateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestAuthenticateResponse">
    <wsdl:part name="parameters" element="tns:TestAuthenticateResponse" />
  </wsdl:message>
  <wsdl:message name="TestAuthenticateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleSubscriptionRequest">
    <wsdl:part name="parameters" element="tns:ToggleSubscription" />
  </wsdl:message>
  <wsdl:message name="ToggleSubscriptionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleSubscriptionResponse">
    <wsdl:part name="parameters" element="tns:ToggleSubscriptionResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleSubscriptionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasNewMailRequest">
    <wsdl:part name="parameters" element="tns:HasNewMail" />
  </wsdl:message>
  <wsdl:message name="HasNewMailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasNewMailResponse">
    <wsdl:part name="parameters" element="tns:HasNewMailResponse" />
  </wsdl:message>
  <wsdl:message name="HasNewMailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="LatestItemIdByFolderRequest">
    <wsdl:part name="parameters" element="tns:LatestItemIdByFolder" />
  </wsdl:message>
  <wsdl:message name="LatestItemIdByFolderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="LatestItemIdByFolderResponse">
    <wsdl:part name="parameters" element="tns:LatestItemIdByFolderResponse" />
  </wsdl:message>
  <wsdl:message name="LatestItemIdByFolderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateInlineHtmlHeaderRequest">
    <wsdl:part name="parameters" element="tns:CreateInlineHtmlHeader" />
  </wsdl:message>
  <wsdl:message name="CreateInlineHtmlHeaderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateInlineHtmlHeaderResponse">
    <wsdl:part name="parameters" element="tns:CreateInlineHtmlHeaderResponse" />
  </wsdl:message>
  <wsdl:message name="CreateInlineHtmlHeaderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailAppointmentRequest">
    <wsdl:part name="parameters" element="tns:GetEmailAppointment" />
  </wsdl:message>
  <wsdl:message name="GetEmailAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailAppointmentResponse">
    <wsdl:part name="parameters" element="tns:GetEmailAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetEmailAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailAppointmentRecurrenceRequest">
    <wsdl:part name="parameters" element="tns:GetEmailAppointmentRecurrence" />
  </wsdl:message>
  <wsdl:message name="GetEmailAppointmentRecurrenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailAppointmentRecurrenceResponse">
    <wsdl:part name="parameters" element="tns:GetEmailAppointmentRecurrenceResponse" />
  </wsdl:message>
  <wsdl:message name="GetEmailAppointmentRecurrenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetParticipantInfoFromEmailAddressRequest">
    <wsdl:part name="parameters" element="tns:GetParticipantInfoFromEmailAddress" />
  </wsdl:message>
  <wsdl:message name="GetParticipantInfoFromEmailAddressRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetParticipantInfoFromEmailAddressResponse">
    <wsdl:part name="parameters" element="tns:GetParticipantInfoFromEmailAddressResponse" />
  </wsdl:message>
  <wsdl:message name="GetParticipantInfoFromEmailAddressResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailDocumentAsMimeStreamRequest">
    <wsdl:part name="parameters" element="tns:GetEmailDocumentAsMimeStream" />
  </wsdl:message>
  <wsdl:message name="GetEmailDocumentAsMimeStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailDocumentAsMimeStreamResponse">
    <wsdl:part name="parameters" element="tns:GetEmailDocumentAsMimeStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetEmailDocumentAsMimeStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailSOInfoRequest">
    <wsdl:part name="parameters" element="tns:GetEMailSOInfo" />
  </wsdl:message>
  <wsdl:message name="GetEMailSOInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailSOInfoResponse">
    <wsdl:part name="parameters" element="tns:GetEMailSOInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailSOInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReadySyncEmailAccountsRequest">
    <wsdl:part name="parameters" element="tns:GetReadySyncEmailAccounts" />
  </wsdl:message>
  <wsdl:message name="GetReadySyncEmailAccountsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetReadySyncEmailAccountsResponse">
    <wsdl:part name="parameters" element="tns:GetReadySyncEmailAccountsResponse" />
  </wsdl:message>
  <wsdl:message name="GetReadySyncEmailAccountsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SyncEmailAccountRequest">
    <wsdl:part name="parameters" element="tns:SyncEmailAccount" />
  </wsdl:message>
  <wsdl:message name="SyncEmailAccountRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SyncEmailAccountResponse">
    <wsdl:part name="parameters" element="tns:SyncEmailAccountResponse" />
  </wsdl:message>
  <wsdl:message name="SyncEmailAccountResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SyncEmailAccountsRequest">
    <wsdl:part name="parameters" element="tns:SyncEmailAccounts" />
  </wsdl:message>
  <wsdl:message name="SyncEmailAccountsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SyncEmailAccountsResponse">
    <wsdl:part name="parameters" element="tns:SyncEmailAccountsResponse" />
  </wsdl:message>
  <wsdl:message name="SyncEmailAccountsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAccountRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailAccount" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAccountRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAccountResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailAccountResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAccountResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveEMailAccountRequest">
    <wsdl:part name="parameters" element="tns:SaveEMailAccount" />
  </wsdl:message>
  <wsdl:message name="SaveEMailAccountRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveEMailAccountResponse">
    <wsdl:part name="parameters" element="tns:SaveEMailAccountResponse" />
  </wsdl:message>
  <wsdl:message name="SaveEMailAccountResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEMailAccountRequest">
    <wsdl:part name="parameters" element="tns:DeleteEMailAccount" />
  </wsdl:message>
  <wsdl:message name="DeleteEMailAccountRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEMailAccountResponse">
    <wsdl:part name="parameters" element="tns:DeleteEMailAccountResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteEMailAccountResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAddressRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailAddress" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAddressRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAddressResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailAddressResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAddressResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAppointmentRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailAppointment" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAppointmentResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAttachmentRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailAttachment" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAttachmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAttachmentResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailAttachmentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailAttachmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailConnectionInfoRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailConnectionInfo" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailConnectionInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailConnectionInfoResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailConnectionInfoResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailConnectionInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailConnectionInfoExtendedRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailConnectionInfoExtended" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailConnectionInfoExtendedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailConnectionInfoExtendedResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailConnectionInfoExtendedResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailConnectionInfoExtendedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailCustomHeaderRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailCustomHeader" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailCustomHeaderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailCustomHeaderResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailCustomHeaderResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailCustomHeaderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailEnvelopeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailEnvelope" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailEnvelopeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailEnvelopeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailEnvelopeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailEnvelopeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailFolderRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailFolder" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailFolderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailFolderResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailFolderResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailFolderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailSOInfoRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailSOInfo" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailSOInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailSOInfoResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultEMailSOInfoResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultEMailSOInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailAccountRequest">
    <wsdl:part name="parameters" element="tns:GetEMailAccount" />
  </wsdl:message>
  <wsdl:message name="GetEMailAccountRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailAccountResponse">
    <wsdl:part name="parameters" element="tns:GetEMailAccountResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailAccountResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailAccountFromEMailAddressRequest">
    <wsdl:part name="parameters" element="tns:GetEMailAccountFromEMailAddress" />
  </wsdl:message>
  <wsdl:message name="GetEMailAccountFromEMailAddressRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailAccountFromEMailAddressResponse">
    <wsdl:part name="parameters" element="tns:GetEMailAccountFromEMailAddressResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailAccountFromEMailAddressResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrentAccountIdRequest">
    <wsdl:part name="parameters" element="tns:GetCurrentAccountId" />
  </wsdl:message>
  <wsdl:message name="GetCurrentAccountIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrentAccountIdResponse">
    <wsdl:part name="parameters" element="tns:GetCurrentAccountIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetCurrentAccountIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrentAccountRequest">
    <wsdl:part name="parameters" element="tns:GetCurrentAccount" />
  </wsdl:message>
  <wsdl:message name="GetCurrentAccountRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCurrentAccountResponse">
    <wsdl:part name="parameters" element="tns:GetCurrentAccountResponse" />
  </wsdl:message>
  <wsdl:message name="GetCurrentAccountResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonEntitiesFromEmailAddressRequest">
    <wsdl:part name="parameters" element="tns:GetPersonEntitiesFromEmailAddress" />
  </wsdl:message>
  <wsdl:message name="GetPersonEntitiesFromEmailAddressRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonEntitiesFromEmailAddressResponse">
    <wsdl:part name="parameters" element="tns:GetPersonEntitiesFromEmailAddressResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonEntitiesFromEmailAddressResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromEmailAddressRequest">
    <wsdl:part name="parameters" element="tns:GetPersonsFromEmailAddress" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromEmailAddressRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromEmailAddressResponse">
    <wsdl:part name="parameters" element="tns:GetPersonsFromEmailAddressResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonsFromEmailAddressResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasMXRecordRequest">
    <wsdl:part name="parameters" element="tns:HasMXRecord" />
  </wsdl:message>
  <wsdl:message name="HasMXRecordRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasMXRecordResponse">
    <wsdl:part name="parameters" element="tns:HasMXRecordResponse" />
  </wsdl:message>
  <wsdl:message name="HasMXRecordResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasSPFRecordRequest">
    <wsdl:part name="parameters" element="tns:HasSPFRecord" />
  </wsdl:message>
  <wsdl:message name="HasSPFRecordRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasSPFRecordResponse">
    <wsdl:part name="parameters" element="tns:HasSPFRecordResponse" />
  </wsdl:message>
  <wsdl:message name="HasSPFRecordResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResolveEMailRecipientsRequest">
    <wsdl:part name="parameters" element="tns:ResolveEMailRecipients" />
  </wsdl:message>
  <wsdl:message name="ResolveEMailRecipientsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ResolveEMailRecipientsResponse">
    <wsdl:part name="parameters" element="tns:ResolveEMailRecipientsResponse" />
  </wsdl:message>
  <wsdl:message name="ResolveEMailRecipientsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromIdRequest">
    <wsdl:part name="parameters" element="tns:GetEMailFromId" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromIdResponse">
    <wsdl:part name="parameters" element="tns:GetEMailFromIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendEMailsRequest">
    <wsdl:part name="parameters" element="tns:SendEMails" />
  </wsdl:message>
  <wsdl:message name="SendEMailsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendEMailsResponse">
    <wsdl:part name="parameters" element="tns:SendEMailsResponse" />
  </wsdl:message>
  <wsdl:message name="SendEMailsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveEMailRequest">
    <wsdl:part name="parameters" element="tns:SaveEMail" />
  </wsdl:message>
  <wsdl:message name="SaveEMailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveEMailResponse">
    <wsdl:part name="parameters" element="tns:SaveEMailResponse" />
  </wsdl:message>
  <wsdl:message name="SaveEMailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AuthenticateIncomingRequest">
    <wsdl:part name="parameters" element="tns:AuthenticateIncoming" />
  </wsdl:message>
  <wsdl:message name="AuthenticateIncomingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AuthenticateIncomingResponse">
    <wsdl:part name="parameters" element="tns:AuthenticateIncomingResponse" />
  </wsdl:message>
  <wsdl:message name="AuthenticateIncomingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AuthenticateOutgoingRequest">
    <wsdl:part name="parameters" element="tns:AuthenticateOutgoing" />
  </wsdl:message>
  <wsdl:message name="AuthenticateOutgoingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AuthenticateOutgoingResponse">
    <wsdl:part name="parameters" element="tns:AuthenticateOutgoingResponse" />
  </wsdl:message>
  <wsdl:message name="AuthenticateOutgoingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFolderListRequest">
    <wsdl:part name="parameters" element="tns:GetFolderList" />
  </wsdl:message>
  <wsdl:message name="GetFolderListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFolderListResponse">
    <wsdl:part name="parameters" element="tns:GetFolderListResponse" />
  </wsdl:message>
  <wsdl:message name="GetFolderListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentRequest">
    <wsdl:part name="parameters" element="tns:GetAttachment" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentResponse">
    <wsdl:part name="parameters" element="tns:GetAttachmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MarkAsReadRequest">
    <wsdl:part name="parameters" element="tns:MarkAsRead" />
  </wsdl:message>
  <wsdl:message name="MarkAsReadRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MarkAsReadResponse">
    <wsdl:part name="parameters" element="tns:MarkAsReadResponse" />
  </wsdl:message>
  <wsdl:message name="MarkAsReadResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFolderEMailCountRequest">
    <wsdl:part name="parameters" element="tns:GetFolderEMailCount" />
  </wsdl:message>
  <wsdl:message name="GetFolderEMailCountRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFolderEMailCountResponse">
    <wsdl:part name="parameters" element="tns:GetFolderEMailCountResponse" />
  </wsdl:message>
  <wsdl:message name="GetFolderEMailCountResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteRequest">
    <wsdl:part name="parameters" element="tns:Delete" />
  </wsdl:message>
  <wsdl:message name="DeleteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteResponse">
    <wsdl:part name="parameters" element="tns:DeleteResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveToFolderRequest">
    <wsdl:part name="parameters" element="tns:MoveToFolder" />
  </wsdl:message>
  <wsdl:message name="MoveToFolderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveToFolderResponse">
    <wsdl:part name="parameters" element="tns:MoveToFolderResponse" />
  </wsdl:message>
  <wsdl:message name="MoveToFolderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EmptyFolderRequest">
    <wsdl:part name="parameters" element="tns:EmptyFolder" />
  </wsdl:message>
  <wsdl:message name="EmptyFolderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="EmptyFolderResponse">
    <wsdl:part name="parameters" element="tns:EmptyFolderResponse" />
  </wsdl:message>
  <wsdl:message name="EmptyFolderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailAsStreamRequest">
    <wsdl:part name="parameters" element="tns:GetEMailAsStream" />
  </wsdl:message>
  <wsdl:message name="GetEMailAsStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailAsStreamResponse">
    <wsdl:part name="parameters" element="tns:GetEMailAsStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailAsStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindAddressRequest">
    <wsdl:part name="parameters" element="tns:FindAddress" />
  </wsdl:message>
  <wsdl:message name="FindAddressRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindAddressResponse">
    <wsdl:part name="parameters" element="tns:FindAddressResponse" />
  </wsdl:message>
  <wsdl:message name="FindAddressResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentIdRequest">
    <wsdl:part name="parameters" element="tns:GetEMailFromDocumentId" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentIdResponse">
    <wsdl:part name="parameters" element="tns:GetEMailFromDocumentIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentIdRequest">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailFromDocumentId" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentIdResponse">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailFromDocumentIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromAttachmentIdRequest">
    <wsdl:part name="parameters" element="tns:GetEMailFromAttachmentId" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromAttachmentIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromAttachmentIdResponse">
    <wsdl:part name="parameters" element="tns:GetEMailFromAttachmentIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromAttachmentIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromAttachmentIdRequest">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailFromAttachmentId" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromAttachmentIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromAttachmentIdResponse">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailFromAttachmentIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromAttachmentIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentAttachmentIdRequest">
    <wsdl:part name="parameters" element="tns:GetEMailFromDocumentAttachmentId" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentAttachmentIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentAttachmentIdResponse">
    <wsdl:part name="parameters" element="tns:GetEMailFromDocumentAttachmentIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentAttachmentIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentAttachmentIdRequest">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailFromDocumentAttachmentId" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentAttachmentIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentAttachmentIdResponse">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailFromDocumentAttachmentIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentAttachmentIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailEnvelopesRequest">
    <wsdl:part name="parameters" element="tns:GetEMailEnvelopes" />
  </wsdl:message>
  <wsdl:message name="GetEMailEnvelopesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailEnvelopesResponse">
    <wsdl:part name="parameters" element="tns:GetEMailEnvelopesResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailEnvelopesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSubscriptionRequest">
    <wsdl:part name="parameters" element="tns:SetSubscription" />
  </wsdl:message>
  <wsdl:message name="SetSubscriptionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSubscriptionResponse">
    <wsdl:part name="parameters" element="tns:SetSubscriptionResponse" />
  </wsdl:message>
  <wsdl:message name="SetSubscriptionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateFolderRequest">
    <wsdl:part name="parameters" element="tns:CreateFolder" />
  </wsdl:message>
  <wsdl:message name="CreateFolderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateFolderResponse">
    <wsdl:part name="parameters" element="tns:CreateFolderResponse" />
  </wsdl:message>
  <wsdl:message name="CreateFolderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFolderRequest">
    <wsdl:part name="parameters" element="tns:DeleteFolder" />
  </wsdl:message>
  <wsdl:message name="DeleteFolderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteFolderResponse">
    <wsdl:part name="parameters" element="tns:DeleteFolderResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteFolderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateEMailFromDocumentEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateEMailFromDocumentEntity" />
  </wsdl:message>
  <wsdl:message name="CreateEMailFromDocumentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateEMailFromDocumentEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateEMailFromDocumentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateEMailFromDocumentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateEMailFromMimeMessageRequest">
    <wsdl:part name="parameters" element="tns:CreateEMailFromMimeMessage" />
  </wsdl:message>
  <wsdl:message name="CreateEMailFromMimeMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateEMailFromMimeMessageResponse">
    <wsdl:part name="parameters" element="tns:CreateEMailFromMimeMessageResponse" />
  </wsdl:message>
  <wsdl:message name="CreateEMailFromMimeMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFolderInfoRequest">
    <wsdl:part name="parameters" element="tns:GetFolderInfo" />
  </wsdl:message>
  <wsdl:message name="GetFolderInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFolderInfoResponse">
    <wsdl:part name="parameters" element="tns:GetFolderInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetFolderInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFolderHasNewEMailRequest">
    <wsdl:part name="parameters" element="tns:GetFolderHasNewEMail" />
  </wsdl:message>
  <wsdl:message name="GetFolderHasNewEMailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetFolderHasNewEMailResponse">
    <wsdl:part name="parameters" element="tns:GetFolderHasNewEMailResponse" />
  </wsdl:message>
  <wsdl:message name="GetFolderHasNewEMailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailAddressesRequest">
    <wsdl:part name="parameters" element="tns:GetEMailAddresses" />
  </wsdl:message>
  <wsdl:message name="GetEMailAddressesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailAddressesResponse">
    <wsdl:part name="parameters" element="tns:GetEMailAddressesResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailAddressesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RefreshFolderRequest">
    <wsdl:part name="parameters" element="tns:RefreshFolder" />
  </wsdl:message>
  <wsdl:message name="RefreshFolderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RefreshFolderResponse">
    <wsdl:part name="parameters" element="tns:RefreshFolderResponse" />
  </wsdl:message>
  <wsdl:message name="RefreshFolderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromTempRequest">
    <wsdl:part name="parameters" element="tns:GetEMailFromTemp" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromTempRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromTempResponse">
    <wsdl:part name="parameters" element="tns:GetEMailFromTempResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromTempResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AuthenticateRequest">
    <wsdl:part name="parameters" element="tns:Authenticate" />
  </wsdl:message>
  <wsdl:message name="AuthenticateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AuthenticateResponse">
    <wsdl:part name="parameters" element="tns:AuthenticateResponse" />
  </wsdl:message>
  <wsdl:message name="AuthenticateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailMessageIdsRequest">
    <wsdl:part name="parameters" element="tns:GetEmailMessageIds" />
  </wsdl:message>
  <wsdl:message name="GetEmailMessageIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailMessageIdsResponse">
    <wsdl:part name="parameters" element="tns:GetEmailMessageIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetEmailMessageIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetExtendedEmailMessageIdsRequest">
    <wsdl:part name="parameters" element="tns:GetExtendedEmailMessageIds" />
  </wsdl:message>
  <wsdl:message name="GetExtendedEmailMessageIdsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetExtendedEmailMessageIdsResponse">
    <wsdl:part name="parameters" element="tns:GetExtendedEmailMessageIdsResponse" />
  </wsdl:message>
  <wsdl:message name="GetExtendedEmailMessageIdsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailsAsStringRequest">
    <wsdl:part name="parameters" element="tns:GetEmailsAsString" />
  </wsdl:message>
  <wsdl:message name="GetEmailsAsStringRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEmailsAsStringResponse">
    <wsdl:part name="parameters" element="tns:GetEmailsAsStringResponse" />
  </wsdl:message>
  <wsdl:message name="GetEmailsAsStringResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteExtendedRequest">
    <wsdl:part name="parameters" element="tns:DeleteExtended" />
  </wsdl:message>
  <wsdl:message name="DeleteExtendedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteExtendedResponse">
    <wsdl:part name="parameters" element="tns:DeleteExtendedResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteExtendedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RelayMessageRequest">
    <wsdl:part name="parameters" element="tns:RelayMessage" />
  </wsdl:message>
  <wsdl:message name="RelayMessageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RelayMessageResponse">
    <wsdl:part name="parameters" element="tns:RelayMessageResponse" />
  </wsdl:message>
  <wsdl:message name="RelayMessageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailRequest">
    <wsdl:part name="parameters" element="tns:GetEMail" />
  </wsdl:message>
  <wsdl:message name="GetEMailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailResponse">
    <wsdl:part name="parameters" element="tns:GetEMailResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailRequest">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMail" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailResponse">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailResponse" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MarkEmailsAsReadRequest">
    <wsdl:part name="parameters" element="tns:MarkEmailsAsRead" />
  </wsdl:message>
  <wsdl:message name="MarkEmailsAsReadRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MarkEmailsAsReadResponse">
    <wsdl:part name="parameters" element="tns:MarkEmailsAsReadResponse" />
  </wsdl:message>
  <wsdl:message name="MarkEmailsAsReadResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEmailsRequest">
    <wsdl:part name="parameters" element="tns:DeleteEmails" />
  </wsdl:message>
  <wsdl:message name="DeleteEmailsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteEmailsResponse">
    <wsdl:part name="parameters" element="tns:DeleteEmailsResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteEmailsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveEmailsToTrashRequest">
    <wsdl:part name="parameters" element="tns:MoveEmailsToTrash" />
  </wsdl:message>
  <wsdl:message name="MoveEmailsToTrashRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveEmailsToTrashResponse">
    <wsdl:part name="parameters" element="tns:MoveEmailsToTrashResponse" />
  </wsdl:message>
  <wsdl:message name="MoveEmailsToTrashResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveRequest">
    <wsdl:part name="parameters" element="tns:Save" />
  </wsdl:message>
  <wsdl:message name="SaveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveResponse">
    <wsdl:part name="parameters" element="tns:SaveResponse" />
  </wsdl:message>
  <wsdl:message name="SaveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveToMailServerRequest">
    <wsdl:part name="parameters" element="tns:SaveToMailServer" />
  </wsdl:message>
  <wsdl:message name="SaveToMailServerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveToMailServerResponse">
    <wsdl:part name="parameters" element="tns:SaveToMailServerResponse" />
  </wsdl:message>
  <wsdl:message name="SaveToMailServerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendRequest">
    <wsdl:part name="parameters" element="tns:Send" />
  </wsdl:message>
  <wsdl:message name="SendRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendResponse">
    <wsdl:part name="parameters" element="tns:SendResponse" />
  </wsdl:message>
  <wsdl:message name="SendResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateForwardEmailRequest">
    <wsdl:part name="parameters" element="tns:CreateForwardEmail" />
  </wsdl:message>
  <wsdl:message name="CreateForwardEmailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateForwardEmailResponse">
    <wsdl:part name="parameters" element="tns:CreateForwardEmailResponse" />
  </wsdl:message>
  <wsdl:message name="CreateForwardEmailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindContactOrPersonByEmailNameRequest">
    <wsdl:part name="parameters" element="tns:FindContactOrPersonByEmailName" />
  </wsdl:message>
  <wsdl:message name="FindContactOrPersonByEmailNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindContactOrPersonByEmailNameResponse">
    <wsdl:part name="parameters" element="tns:FindContactOrPersonByEmailNameResponse" />
  </wsdl:message>
  <wsdl:message name="FindContactOrPersonByEmailNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindContactOrPersonByEmailNameWithLimitRequest">
    <wsdl:part name="parameters" element="tns:FindContactOrPersonByEmailNameWithLimit" />
  </wsdl:message>
  <wsdl:message name="FindContactOrPersonByEmailNameWithLimitRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindContactOrPersonByEmailNameWithLimitResponse">
    <wsdl:part name="parameters" element="tns:FindContactOrPersonByEmailNameWithLimitResponse" />
  </wsdl:message>
  <wsdl:message name="FindContactOrPersonByEmailNameWithLimitResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RefreshFolderForAssociateRequest">
    <wsdl:part name="parameters" element="tns:RefreshFolderForAssociate" />
  </wsdl:message>
  <wsdl:message name="RefreshFolderForAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RefreshFolderForAssociateResponse">
    <wsdl:part name="parameters" element="tns:RefreshFolderForAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="RefreshFolderForAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewMailRequest">
    <wsdl:part name="parameters" element="tns:GetNewMail" />
  </wsdl:message>
  <wsdl:message name="GetNewMailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNewMailResponse">
    <wsdl:part name="parameters" element="tns:GetNewMailResponse" />
  </wsdl:message>
  <wsdl:message name="GetNewMailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CacheFolderListRequest">
    <wsdl:part name="parameters" element="tns:CacheFolderList" />
  </wsdl:message>
  <wsdl:message name="CacheFolderListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CacheFolderListResponse">
    <wsdl:part name="parameters" element="tns:CacheFolderListResponse" />
  </wsdl:message>
  <wsdl:message name="CacheFolderListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveEmailsToFolderRequest">
    <wsdl:part name="parameters" element="tns:MoveEmailsToFolder" />
  </wsdl:message>
  <wsdl:message name="MoveEmailsToFolderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveEmailsToFolderResponse">
    <wsdl:part name="parameters" element="tns:MoveEmailsToFolderResponse" />
  </wsdl:message>
  <wsdl:message name="MoveEmailsToFolderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMailFromMessageIdRequest">
    <wsdl:part name="parameters" element="tns:GetMailFromMessageId" />
  </wsdl:message>
  <wsdl:message name="GetMailFromMessageIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMailFromMessageIdResponse">
    <wsdl:part name="parameters" element="tns:GetMailFromMessageIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetMailFromMessageIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMailFromInReplyToRequest">
    <wsdl:part name="parameters" element="tns:GetMailFromInReplyTo" />
  </wsdl:message>
  <wsdl:message name="GetMailFromInReplyToRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMailFromInReplyToResponse">
    <wsdl:part name="parameters" element="tns:GetMailFromInReplyToResponse" />
  </wsdl:message>
  <wsdl:message name="GetMailFromInReplyToResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendAndSaveEmailToTmpDocumentRequest">
    <wsdl:part name="parameters" element="tns:SendAndSaveEmailToTmpDocument" />
  </wsdl:message>
  <wsdl:message name="SendAndSaveEmailToTmpDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendAndSaveEmailToTmpDocumentResponse">
    <wsdl:part name="parameters" element="tns:SendAndSaveEmailToTmpDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="SendAndSaveEmailToTmpDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveEmailToTmpDocumentRequest">
    <wsdl:part name="parameters" element="tns:SaveEmailToTmpDocument" />
  </wsdl:message>
  <wsdl:message name="SaveEmailToTmpDocumentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveEmailToTmpDocumentResponse">
    <wsdl:part name="parameters" element="tns:SaveEmailToTmpDocumentResponse" />
  </wsdl:message>
  <wsdl:message name="SaveEmailToTmpDocumentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromEmailAttachmentRequest">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromEmailAttachment" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromEmailAttachmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromEmailAttachmentResponse">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromEmailAttachmentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromEmailAttachmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromEmailRequest">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromEmail" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromEmailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromEmailResponse">
    <wsdl:part name="parameters" element="tns:CreateNewPhysicalDocumentFromEmailResponse" />
  </wsdl:message>
  <wsdl:message name="CreateNewPhysicalDocumentFromEmailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDraftRequest">
    <wsdl:part name="parameters" element="tns:SaveDraft" />
  </wsdl:message>
  <wsdl:message name="SaveDraftRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveDraftResponse">
    <wsdl:part name="parameters" element="tns:SaveDraftResponse" />
  </wsdl:message>
  <wsdl:message name="SaveDraftResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRepliedAtRequest">
    <wsdl:part name="parameters" element="tns:SetRepliedAt" />
  </wsdl:message>
  <wsdl:message name="SetRepliedAtRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetRepliedAtResponse">
    <wsdl:part name="parameters" element="tns:SetRepliedAtResponse" />
  </wsdl:message>
  <wsdl:message name="SetRepliedAtResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentIdWithoutAttachmentStreamRequest">
    <wsdl:part name="parameters" element="tns:GetEMailFromDocumentIdWithoutAttachmentStream" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentIdWithoutAttachmentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentIdWithoutAttachmentStreamResponse">
    <wsdl:part name="parameters" element="tns:GetEMailFromDocumentIdWithoutAttachmentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamRequest">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse">
    <wsdl:part name="parameters" element="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse" />
  </wsdl:message>
  <wsdl:message name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentFromIdRequest">
    <wsdl:part name="parameters" element="tns:GetAttachmentFromId" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentFromIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentFromIdResponse">
    <wsdl:part name="parameters" element="tns:GetAttachmentFromIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetAttachmentFromIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="EMail">
    <wsdl:operation name="GetPreviewAttachmentFromId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPreviewAttachmentFromId" name="GetPreviewAttachmentFromIdRequest" message="tns:GetPreviewAttachmentFromIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPreviewAttachmentFromIdResponse" name="GetPreviewAttachmentFromIdResponse" message="tns:GetPreviewAttachmentFromIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedPreviewAttachmentFromId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedPreviewAttachmentFromId" name="GetUnsanitizedPreviewAttachmentFromIdRequest" message="tns:GetUnsanitizedPreviewAttachmentFromIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedPreviewAttachmentFromIdResponse" name="GetUnsanitizedPreviewAttachmentFromIdResponse" message="tns:GetUnsanitizedPreviewAttachmentFromIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPreviewAttachmentFromDocId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPreviewAttachmentFromDocId" name="GetPreviewAttachmentFromDocIdRequest" message="tns:GetPreviewAttachmentFromDocIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPreviewAttachmentFromDocIdResponse" name="GetPreviewAttachmentFromDocIdResponse" message="tns:GetPreviewAttachmentFromDocIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedPreviewAttachmentFromDocId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedPreviewAttachmentFromDocId" name="GetUnsanitizedPreviewAttachmentFromDocIdRequest" message="tns:GetUnsanitizedPreviewAttachmentFromDocIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedPreviewAttachmentFromDocIdResponse" name="GetUnsanitizedPreviewAttachmentFromDocIdResponse" message="tns:GetUnsanitizedPreviewAttachmentFromDocIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="TestAuthenticate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/TestAuthenticate" name="TestAuthenticateRequest" message="tns:TestAuthenticateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/TestAuthenticateResponse" name="TestAuthenticateResponse" message="tns:TestAuthenticateResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleSubscription">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/ToggleSubscription" name="ToggleSubscriptionRequest" message="tns:ToggleSubscriptionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/ToggleSubscriptionResponse" name="ToggleSubscriptionResponse" message="tns:ToggleSubscriptionResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasNewMail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasNewMail" name="HasNewMailRequest" message="tns:HasNewMailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasNewMailResponse" name="HasNewMailResponse" message="tns:HasNewMailResponse" />
    </wsdl:operation>
    <wsdl:operation name="LatestItemIdByFolder">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/LatestItemIdByFolder" name="LatestItemIdByFolderRequest" message="tns:LatestItemIdByFolderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/LatestItemIdByFolderResponse" name="LatestItemIdByFolderResponse" message="tns:LatestItemIdByFolderResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateInlineHtmlHeader">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateInlineHtmlHeader" name="CreateInlineHtmlHeaderRequest" message="tns:CreateInlineHtmlHeaderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateInlineHtmlHeaderResponse" name="CreateInlineHtmlHeaderResponse" message="tns:CreateInlineHtmlHeaderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEmailAppointment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailAppointment" name="GetEmailAppointmentRequest" message="tns:GetEmailAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailAppointmentResponse" name="GetEmailAppointmentResponse" message="tns:GetEmailAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEmailAppointmentRecurrence">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailAppointmentRecurrence" name="GetEmailAppointmentRecurrenceRequest" message="tns:GetEmailAppointmentRecurrenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailAppointmentRecurrenceResponse" name="GetEmailAppointmentRecurrenceResponse" message="tns:GetEmailAppointmentRecurrenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetParticipantInfoFromEmailAddress">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetParticipantInfoFromEmailAddress" name="GetParticipantInfoFromEmailAddressRequest" message="tns:GetParticipantInfoFromEmailAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetParticipantInfoFromEmailAddressResponse" name="GetParticipantInfoFromEmailAddressResponse" message="tns:GetParticipantInfoFromEmailAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEmailDocumentAsMimeStream">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailDocumentAsMimeStream" name="GetEmailDocumentAsMimeStreamRequest" message="tns:GetEmailDocumentAsMimeStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailDocumentAsMimeStreamResponse" name="GetEmailDocumentAsMimeStreamResponse" message="tns:GetEmailDocumentAsMimeStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailSOInfo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailSOInfo" name="GetEMailSOInfoRequest" message="tns:GetEMailSOInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailSOInfoResponse" name="GetEMailSOInfoResponse" message="tns:GetEMailSOInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetReadySyncEmailAccounts">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetReadySyncEmailAccounts" name="GetReadySyncEmailAccountsRequest" message="tns:GetReadySyncEmailAccountsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetReadySyncEmailAccountsResponse" name="GetReadySyncEmailAccountsResponse" message="tns:GetReadySyncEmailAccountsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SyncEmailAccount">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SyncEmailAccount" name="SyncEmailAccountRequest" message="tns:SyncEmailAccountRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SyncEmailAccountResponse" name="SyncEmailAccountResponse" message="tns:SyncEmailAccountResponse" />
    </wsdl:operation>
    <wsdl:operation name="SyncEmailAccounts">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SyncEmailAccounts" name="SyncEmailAccountsRequest" message="tns:SyncEmailAccountsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SyncEmailAccountsResponse" name="SyncEmailAccountsResponse" message="tns:SyncEmailAccountsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailAccount">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAccount" name="CreateDefaultEMailAccountRequest" message="tns:CreateDefaultEMailAccountRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAccountResponse" name="CreateDefaultEMailAccountResponse" message="tns:CreateDefaultEMailAccountResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveEMailAccount">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEMailAccount" name="SaveEMailAccountRequest" message="tns:SaveEMailAccountRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEMailAccountResponse" name="SaveEMailAccountResponse" message="tns:SaveEMailAccountResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteEMailAccount">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteEMailAccount" name="DeleteEMailAccountRequest" message="tns:DeleteEMailAccountRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteEMailAccountResponse" name="DeleteEMailAccountResponse" message="tns:DeleteEMailAccountResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailAddress">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAddress" name="CreateDefaultEMailAddressRequest" message="tns:CreateDefaultEMailAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAddressResponse" name="CreateDefaultEMailAddressResponse" message="tns:CreateDefaultEMailAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailAppointment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAppointment" name="CreateDefaultEMailAppointmentRequest" message="tns:CreateDefaultEMailAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAppointmentResponse" name="CreateDefaultEMailAppointmentResponse" message="tns:CreateDefaultEMailAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailAttachment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAttachment" name="CreateDefaultEMailAttachmentRequest" message="tns:CreateDefaultEMailAttachmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAttachmentResponse" name="CreateDefaultEMailAttachmentResponse" message="tns:CreateDefaultEMailAttachmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailConnectionInfo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailConnectionInfo" name="CreateDefaultEMailConnectionInfoRequest" message="tns:CreateDefaultEMailConnectionInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailConnectionInfoResponse" name="CreateDefaultEMailConnectionInfoResponse" message="tns:CreateDefaultEMailConnectionInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailConnectionInfoExtended">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailConnectionInfoExtended" name="CreateDefaultEMailConnectionInfoExtendedRequest" message="tns:CreateDefaultEMailConnectionInfoExtendedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailConnectionInfoExtendedResponse" name="CreateDefaultEMailConnectionInfoExtendedResponse" message="tns:CreateDefaultEMailConnectionInfoExtendedResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailCustomHeader">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailCustomHeader" name="CreateDefaultEMailCustomHeaderRequest" message="tns:CreateDefaultEMailCustomHeaderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailCustomHeaderResponse" name="CreateDefaultEMailCustomHeaderResponse" message="tns:CreateDefaultEMailCustomHeaderResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailEntity" name="CreateDefaultEMailEntityRequest" message="tns:CreateDefaultEMailEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailEntityResponse" name="CreateDefaultEMailEntityResponse" message="tns:CreateDefaultEMailEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailEnvelope">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailEnvelope" name="CreateDefaultEMailEnvelopeRequest" message="tns:CreateDefaultEMailEnvelopeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailEnvelopeResponse" name="CreateDefaultEMailEnvelopeResponse" message="tns:CreateDefaultEMailEnvelopeResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailFolder">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailFolder" name="CreateDefaultEMailFolderRequest" message="tns:CreateDefaultEMailFolderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailFolderResponse" name="CreateDefaultEMailFolderResponse" message="tns:CreateDefaultEMailFolderResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailSOInfo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailSOInfo" name="CreateDefaultEMailSOInfoRequest" message="tns:CreateDefaultEMailSOInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailSOInfoResponse" name="CreateDefaultEMailSOInfoResponse" message="tns:CreateDefaultEMailSOInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailAccount">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAccount" name="GetEMailAccountRequest" message="tns:GetEMailAccountRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAccountResponse" name="GetEMailAccountResponse" message="tns:GetEMailAccountResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailAccountFromEMailAddress">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAccountFromEMailAddress" name="GetEMailAccountFromEMailAddressRequest" message="tns:GetEMailAccountFromEMailAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAccountFromEMailAddressResponse" name="GetEMailAccountFromEMailAddressResponse" message="tns:GetEMailAccountFromEMailAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCurrentAccountId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetCurrentAccountId" name="GetCurrentAccountIdRequest" message="tns:GetCurrentAccountIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetCurrentAccountIdResponse" name="GetCurrentAccountIdResponse" message="tns:GetCurrentAccountIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCurrentAccount">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetCurrentAccount" name="GetCurrentAccountRequest" message="tns:GetCurrentAccountRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetCurrentAccountResponse" name="GetCurrentAccountResponse" message="tns:GetCurrentAccountResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonEntitiesFromEmailAddress">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPersonEntitiesFromEmailAddress" name="GetPersonEntitiesFromEmailAddressRequest" message="tns:GetPersonEntitiesFromEmailAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPersonEntitiesFromEmailAddressResponse" name="GetPersonEntitiesFromEmailAddressResponse" message="tns:GetPersonEntitiesFromEmailAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonsFromEmailAddress">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPersonsFromEmailAddress" name="GetPersonsFromEmailAddressRequest" message="tns:GetPersonsFromEmailAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPersonsFromEmailAddressResponse" name="GetPersonsFromEmailAddressResponse" message="tns:GetPersonsFromEmailAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasMXRecord">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasMXRecord" name="HasMXRecordRequest" message="tns:HasMXRecordRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasMXRecordResponse" name="HasMXRecordResponse" message="tns:HasMXRecordResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasSPFRecord">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasSPFRecord" name="HasSPFRecordRequest" message="tns:HasSPFRecordRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasSPFRecordResponse" name="HasSPFRecordResponse" message="tns:HasSPFRecordResponse" />
    </wsdl:operation>
    <wsdl:operation name="ResolveEMailRecipients">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/ResolveEMailRecipients" name="ResolveEMailRecipientsRequest" message="tns:ResolveEMailRecipientsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/ResolveEMailRecipientsResponse" name="ResolveEMailRecipientsResponse" message="tns:ResolveEMailRecipientsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromId" name="GetEMailFromIdRequest" message="tns:GetEMailFromIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromIdResponse" name="GetEMailFromIdResponse" message="tns:GetEMailFromIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendEMails">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SendEMails" name="SendEMailsRequest" message="tns:SendEMailsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SendEMailsResponse" name="SendEMailsResponse" message="tns:SendEMailsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveEMail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEMail" name="SaveEMailRequest" message="tns:SaveEMailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEMailResponse" name="SaveEMailResponse" message="tns:SaveEMailResponse" />
    </wsdl:operation>
    <wsdl:operation name="AuthenticateIncoming">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/AuthenticateIncoming" name="AuthenticateIncomingRequest" message="tns:AuthenticateIncomingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/AuthenticateIncomingResponse" name="AuthenticateIncomingResponse" message="tns:AuthenticateIncomingResponse" />
    </wsdl:operation>
    <wsdl:operation name="AuthenticateOutgoing">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/AuthenticateOutgoing" name="AuthenticateOutgoingRequest" message="tns:AuthenticateOutgoingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/AuthenticateOutgoingResponse" name="AuthenticateOutgoingResponse" message="tns:AuthenticateOutgoingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFolderList">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderList" name="GetFolderListRequest" message="tns:GetFolderListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderListResponse" name="GetFolderListResponse" message="tns:GetFolderListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAttachment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetAttachment" name="GetAttachmentRequest" message="tns:GetAttachmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetAttachmentResponse" name="GetAttachmentResponse" message="tns:GetAttachmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="MarkAsRead">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MarkAsRead" name="MarkAsReadRequest" message="tns:MarkAsReadRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MarkAsReadResponse" name="MarkAsReadResponse" message="tns:MarkAsReadResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFolderEMailCount">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderEMailCount" name="GetFolderEMailCountRequest" message="tns:GetFolderEMailCountRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderEMailCountResponse" name="GetFolderEMailCountResponse" message="tns:GetFolderEMailCountResponse" />
    </wsdl:operation>
    <wsdl:operation name="Delete">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/Delete" name="DeleteRequest" message="tns:DeleteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteResponse" name="DeleteResponse" message="tns:DeleteResponse" />
    </wsdl:operation>
    <wsdl:operation name="MoveToFolder">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveToFolder" name="MoveToFolderRequest" message="tns:MoveToFolderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveToFolderResponse" name="MoveToFolderResponse" message="tns:MoveToFolderResponse" />
    </wsdl:operation>
    <wsdl:operation name="EmptyFolder">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/EmptyFolder" name="EmptyFolderRequest" message="tns:EmptyFolderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/EmptyFolderResponse" name="EmptyFolderResponse" message="tns:EmptyFolderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailAsStream">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAsStream" name="GetEMailAsStreamRequest" message="tns:GetEMailAsStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAsStreamResponse" name="GetEMailAsStreamResponse" message="tns:GetEMailAsStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindAddress">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindAddress" name="FindAddressRequest" message="tns:FindAddressRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindAddressResponse" name="FindAddressResponse" message="tns:FindAddressResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromDocumentId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentId" name="GetEMailFromDocumentIdRequest" message="tns:GetEMailFromDocumentIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentIdResponse" name="GetEMailFromDocumentIdResponse" message="tns:GetEMailFromDocumentIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMailFromDocumentId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentId" name="GetUnsanitizedEMailFromDocumentIdRequest" message="tns:GetUnsanitizedEMailFromDocumentIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentIdResponse" name="GetUnsanitizedEMailFromDocumentIdResponse" message="tns:GetUnsanitizedEMailFromDocumentIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromAttachmentId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromAttachmentId" name="GetEMailFromAttachmentIdRequest" message="tns:GetEMailFromAttachmentIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromAttachmentIdResponse" name="GetEMailFromAttachmentIdResponse" message="tns:GetEMailFromAttachmentIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMailFromAttachmentId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromAttachmentId" name="GetUnsanitizedEMailFromAttachmentIdRequest" message="tns:GetUnsanitizedEMailFromAttachmentIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromAttachmentIdResponse" name="GetUnsanitizedEMailFromAttachmentIdResponse" message="tns:GetUnsanitizedEMailFromAttachmentIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromDocumentAttachmentId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentAttachmentId" name="GetEMailFromDocumentAttachmentIdRequest" message="tns:GetEMailFromDocumentAttachmentIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentAttachmentIdResponse" name="GetEMailFromDocumentAttachmentIdResponse" message="tns:GetEMailFromDocumentAttachmentIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMailFromDocumentAttachmentId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentAttachmentId" name="GetUnsanitizedEMailFromDocumentAttachmentIdRequest" message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentAttachmentIdResponse" name="GetUnsanitizedEMailFromDocumentAttachmentIdResponse" message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailEnvelopes">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailEnvelopes" name="GetEMailEnvelopesRequest" message="tns:GetEMailEnvelopesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailEnvelopesResponse" name="GetEMailEnvelopesResponse" message="tns:GetEMailEnvelopesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetSubscription">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SetSubscription" name="SetSubscriptionRequest" message="tns:SetSubscriptionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SetSubscriptionResponse" name="SetSubscriptionResponse" message="tns:SetSubscriptionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateFolder">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateFolder" name="CreateFolderRequest" message="tns:CreateFolderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateFolderResponse" name="CreateFolderResponse" message="tns:CreateFolderResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteFolder">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteFolder" name="DeleteFolderRequest" message="tns:DeleteFolderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteFolderResponse" name="DeleteFolderResponse" message="tns:DeleteFolderResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateEMailFromDocumentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateEMailFromDocumentEntity" name="CreateEMailFromDocumentEntityRequest" message="tns:CreateEMailFromDocumentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateEMailFromDocumentEntityResponse" name="CreateEMailFromDocumentEntityResponse" message="tns:CreateEMailFromDocumentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateEMailFromMimeMessage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateEMailFromMimeMessage" name="CreateEMailFromMimeMessageRequest" message="tns:CreateEMailFromMimeMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateEMailFromMimeMessageResponse" name="CreateEMailFromMimeMessageResponse" message="tns:CreateEMailFromMimeMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFolderInfo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderInfo" name="GetFolderInfoRequest" message="tns:GetFolderInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderInfoResponse" name="GetFolderInfoResponse" message="tns:GetFolderInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetFolderHasNewEMail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderHasNewEMail" name="GetFolderHasNewEMailRequest" message="tns:GetFolderHasNewEMailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderHasNewEMailResponse" name="GetFolderHasNewEMailResponse" message="tns:GetFolderHasNewEMailResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailAddresses">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAddresses" name="GetEMailAddressesRequest" message="tns:GetEMailAddressesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAddressesResponse" name="GetEMailAddressesResponse" message="tns:GetEMailAddressesResponse" />
    </wsdl:operation>
    <wsdl:operation name="RefreshFolder">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RefreshFolder" name="RefreshFolderRequest" message="tns:RefreshFolderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RefreshFolderResponse" name="RefreshFolderResponse" message="tns:RefreshFolderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromTemp">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromTemp" name="GetEMailFromTempRequest" message="tns:GetEMailFromTempRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromTempResponse" name="GetEMailFromTempResponse" message="tns:GetEMailFromTempResponse" />
    </wsdl:operation>
    <wsdl:operation name="Authenticate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/Authenticate" name="AuthenticateRequest" message="tns:AuthenticateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/AuthenticateResponse" name="AuthenticateResponse" message="tns:AuthenticateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEmailMessageIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailMessageIds" name="GetEmailMessageIdsRequest" message="tns:GetEmailMessageIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailMessageIdsResponse" name="GetEmailMessageIdsResponse" message="tns:GetEmailMessageIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetExtendedEmailMessageIds">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetExtendedEmailMessageIds" name="GetExtendedEmailMessageIdsRequest" message="tns:GetExtendedEmailMessageIdsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetExtendedEmailMessageIdsResponse" name="GetExtendedEmailMessageIdsResponse" message="tns:GetExtendedEmailMessageIdsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEmailsAsString">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailsAsString" name="GetEmailsAsStringRequest" message="tns:GetEmailsAsStringRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailsAsStringResponse" name="GetEmailsAsStringResponse" message="tns:GetEmailsAsStringResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteExtended">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteExtended" name="DeleteExtendedRequest" message="tns:DeleteExtendedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteExtendedResponse" name="DeleteExtendedResponse" message="tns:DeleteExtendedResponse" />
    </wsdl:operation>
    <wsdl:operation name="RelayMessage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RelayMessage" name="RelayMessageRequest" message="tns:RelayMessageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RelayMessageResponse" name="RelayMessageResponse" message="tns:RelayMessageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMail" name="GetEMailRequest" message="tns:GetEMailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailResponse" name="GetEMailResponse" message="tns:GetEMailResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMail" name="GetUnsanitizedEMailRequest" message="tns:GetUnsanitizedEMailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailResponse" name="GetUnsanitizedEMailResponse" message="tns:GetUnsanitizedEMailResponse" />
    </wsdl:operation>
    <wsdl:operation name="MarkEmailsAsRead">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MarkEmailsAsRead" name="MarkEmailsAsReadRequest" message="tns:MarkEmailsAsReadRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MarkEmailsAsReadResponse" name="MarkEmailsAsReadResponse" message="tns:MarkEmailsAsReadResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteEmails">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteEmails" name="DeleteEmailsRequest" message="tns:DeleteEmailsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteEmailsResponse" name="DeleteEmailsResponse" message="tns:DeleteEmailsResponse" />
    </wsdl:operation>
    <wsdl:operation name="MoveEmailsToTrash">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveEmailsToTrash" name="MoveEmailsToTrashRequest" message="tns:MoveEmailsToTrashRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveEmailsToTrashResponse" name="MoveEmailsToTrashResponse" message="tns:MoveEmailsToTrashResponse" />
    </wsdl:operation>
    <wsdl:operation name="Save">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/Save" name="SaveRequest" message="tns:SaveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveResponse" name="SaveResponse" message="tns:SaveResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveToMailServer">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveToMailServer" name="SaveToMailServerRequest" message="tns:SaveToMailServerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveToMailServerResponse" name="SaveToMailServerResponse" message="tns:SaveToMailServerResponse" />
    </wsdl:operation>
    <wsdl:operation name="Send">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/Send" name="SendRequest" message="tns:SendRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SendResponse" name="SendResponse" message="tns:SendResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateForwardEmail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateForwardEmail" name="CreateForwardEmailRequest" message="tns:CreateForwardEmailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateForwardEmailResponse" name="CreateForwardEmailResponse" message="tns:CreateForwardEmailResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindContactOrPersonByEmailName">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindContactOrPersonByEmailName" name="FindContactOrPersonByEmailNameRequest" message="tns:FindContactOrPersonByEmailNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindContactOrPersonByEmailNameResponse" name="FindContactOrPersonByEmailNameResponse" message="tns:FindContactOrPersonByEmailNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindContactOrPersonByEmailNameWithLimit">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindContactOrPersonByEmailNameWithLimit" name="FindContactOrPersonByEmailNameWithLimitRequest" message="tns:FindContactOrPersonByEmailNameWithLimitRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindContactOrPersonByEmailNameWithLimitResponse" name="FindContactOrPersonByEmailNameWithLimitResponse" message="tns:FindContactOrPersonByEmailNameWithLimitResponse" />
    </wsdl:operation>
    <wsdl:operation name="RefreshFolderForAssociate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RefreshFolderForAssociate" name="RefreshFolderForAssociateRequest" message="tns:RefreshFolderForAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RefreshFolderForAssociateResponse" name="RefreshFolderForAssociateResponse" message="tns:RefreshFolderForAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNewMail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetNewMail" name="GetNewMailRequest" message="tns:GetNewMailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetNewMailResponse" name="GetNewMailResponse" message="tns:GetNewMailResponse" />
    </wsdl:operation>
    <wsdl:operation name="CacheFolderList">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CacheFolderList" name="CacheFolderListRequest" message="tns:CacheFolderListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CacheFolderListResponse" name="CacheFolderListResponse" message="tns:CacheFolderListResponse" />
    </wsdl:operation>
    <wsdl:operation name="MoveEmailsToFolder">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveEmailsToFolder" name="MoveEmailsToFolderRequest" message="tns:MoveEmailsToFolderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveEmailsToFolderResponse" name="MoveEmailsToFolderResponse" message="tns:MoveEmailsToFolderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMailFromMessageId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetMailFromMessageId" name="GetMailFromMessageIdRequest" message="tns:GetMailFromMessageIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetMailFromMessageIdResponse" name="GetMailFromMessageIdResponse" message="tns:GetMailFromMessageIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMailFromInReplyTo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetMailFromInReplyTo" name="GetMailFromInReplyToRequest" message="tns:GetMailFromInReplyToRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetMailFromInReplyToResponse" name="GetMailFromInReplyToResponse" message="tns:GetMailFromInReplyToResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendAndSaveEmailToTmpDocument">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SendAndSaveEmailToTmpDocument" name="SendAndSaveEmailToTmpDocumentRequest" message="tns:SendAndSaveEmailToTmpDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SendAndSaveEmailToTmpDocumentResponse" name="SendAndSaveEmailToTmpDocumentResponse" message="tns:SendAndSaveEmailToTmpDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveEmailToTmpDocument">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEmailToTmpDocument" name="SaveEmailToTmpDocumentRequest" message="tns:SaveEmailToTmpDocumentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEmailToTmpDocumentResponse" name="SaveEmailToTmpDocumentResponse" message="tns:SaveEmailToTmpDocumentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromEmailAttachment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateNewPhysicalDocumentFromEmailAttachment" name="CreateNewPhysicalDocumentFromEmailAttachmentRequest" message="tns:CreateNewPhysicalDocumentFromEmailAttachmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateNewPhysicalDocumentFromEmailAttachmentResponse" name="CreateNewPhysicalDocumentFromEmailAttachmentResponse" message="tns:CreateNewPhysicalDocumentFromEmailAttachmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromEmail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateNewPhysicalDocumentFromEmail" name="CreateNewPhysicalDocumentFromEmailRequest" message="tns:CreateNewPhysicalDocumentFromEmailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateNewPhysicalDocumentFromEmailResponse" name="CreateNewPhysicalDocumentFromEmailResponse" message="tns:CreateNewPhysicalDocumentFromEmailResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveDraft">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveDraft" name="SaveDraftRequest" message="tns:SaveDraftRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveDraftResponse" name="SaveDraftResponse" message="tns:SaveDraftResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetRepliedAt">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SetRepliedAt" name="SetRepliedAtRequest" message="tns:SetRepliedAtRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SetRepliedAtResponse" name="SetRepliedAtResponse" message="tns:SetRepliedAtResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromDocumentIdWithoutAttachmentStream">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentIdWithoutAttachmentStream" name="GetEMailFromDocumentIdWithoutAttachmentStreamRequest" message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentIdWithoutAttachmentStreamResponse" name="GetEMailFromDocumentIdWithoutAttachmentStreamResponse" message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream" name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamRequest" message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse" name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse" message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentFromId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetAttachmentFromId" name="GetAttachmentFromIdRequest" message="tns:GetAttachmentFromIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetAttachmentFromIdResponse" name="GetAttachmentFromIdResponse" message="tns:GetAttachmentFromIdResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_EMail" type="tns:EMail">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetPreviewAttachmentFromId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPreviewAttachmentFromId" style="document" />
      <wsdl:input name="GetPreviewAttachmentFromIdRequest">
        <soap:header message="tns:GetPreviewAttachmentFromIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreviewAttachmentFromIdResponse">
        <soap:header message="tns:GetPreviewAttachmentFromIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedPreviewAttachmentFromId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedPreviewAttachmentFromId" style="document" />
      <wsdl:input name="GetUnsanitizedPreviewAttachmentFromIdRequest">
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUnsanitizedPreviewAttachmentFromIdResponse">
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPreviewAttachmentFromDocId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPreviewAttachmentFromDocId" style="document" />
      <wsdl:input name="GetPreviewAttachmentFromDocIdRequest">
        <soap:header message="tns:GetPreviewAttachmentFromDocIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromDocIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromDocIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPreviewAttachmentFromDocIdResponse">
        <soap:header message="tns:GetPreviewAttachmentFromDocIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromDocIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromDocIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPreviewAttachmentFromDocIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedPreviewAttachmentFromDocId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedPreviewAttachmentFromDocId" style="document" />
      <wsdl:input name="GetUnsanitizedPreviewAttachmentFromDocIdRequest">
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromDocIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromDocIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromDocIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUnsanitizedPreviewAttachmentFromDocIdResponse">
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromDocIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromDocIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromDocIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUnsanitizedPreviewAttachmentFromDocIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TestAuthenticate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/TestAuthenticate" style="document" />
      <wsdl:input name="TestAuthenticateRequest">
        <soap:header message="tns:TestAuthenticateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TestAuthenticateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TestAuthenticateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TestAuthenticateResponse">
        <soap:header message="tns:TestAuthenticateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TestAuthenticateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TestAuthenticateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TestAuthenticateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleSubscription">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/ToggleSubscription" style="document" />
      <wsdl:input name="ToggleSubscriptionRequest">
        <soap:header message="tns:ToggleSubscriptionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleSubscriptionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleSubscriptionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleSubscriptionResponse">
        <soap:header message="tns:ToggleSubscriptionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleSubscriptionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleSubscriptionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleSubscriptionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasNewMail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasNewMail" style="document" />
      <wsdl:input name="HasNewMailRequest">
        <soap:header message="tns:HasNewMailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasNewMailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasNewMailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasNewMailResponse">
        <soap:header message="tns:HasNewMailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasNewMailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasNewMailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasNewMailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="LatestItemIdByFolder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/LatestItemIdByFolder" style="document" />
      <wsdl:input name="LatestItemIdByFolderRequest">
        <soap:header message="tns:LatestItemIdByFolderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:LatestItemIdByFolderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:LatestItemIdByFolderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="LatestItemIdByFolderResponse">
        <soap:header message="tns:LatestItemIdByFolderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:LatestItemIdByFolderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:LatestItemIdByFolderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:LatestItemIdByFolderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateInlineHtmlHeader">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateInlineHtmlHeader" style="document" />
      <wsdl:input name="CreateInlineHtmlHeaderRequest">
        <soap:header message="tns:CreateInlineHtmlHeaderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateInlineHtmlHeaderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateInlineHtmlHeaderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateInlineHtmlHeaderResponse">
        <soap:header message="tns:CreateInlineHtmlHeaderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateInlineHtmlHeaderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateInlineHtmlHeaderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateInlineHtmlHeaderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEmailAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailAppointment" style="document" />
      <wsdl:input name="GetEmailAppointmentRequest">
        <soap:header message="tns:GetEmailAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEmailAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEmailAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEmailAppointmentResponse">
        <soap:header message="tns:GetEmailAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEmailAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEmailAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEmailAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEmailAppointmentRecurrence">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailAppointmentRecurrence" style="document" />
      <wsdl:input name="GetEmailAppointmentRecurrenceRequest">
        <soap:header message="tns:GetEmailAppointmentRecurrenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEmailAppointmentRecurrenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEmailAppointmentRecurrenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEmailAppointmentRecurrenceResponse">
        <soap:header message="tns:GetEmailAppointmentRecurrenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEmailAppointmentRecurrenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEmailAppointmentRecurrenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEmailAppointmentRecurrenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetParticipantInfoFromEmailAddress">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetParticipantInfoFromEmailAddress" style="document" />
      <wsdl:input name="GetParticipantInfoFromEmailAddressRequest">
        <soap:header message="tns:GetParticipantInfoFromEmailAddressRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetParticipantInfoFromEmailAddressRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetParticipantInfoFromEmailAddressRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetParticipantInfoFromEmailAddressResponse">
        <soap:header message="tns:GetParticipantInfoFromEmailAddressResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetParticipantInfoFromEmailAddressResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetParticipantInfoFromEmailAddressResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetParticipantInfoFromEmailAddressResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEmailDocumentAsMimeStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailDocumentAsMimeStream" style="document" />
      <wsdl:input name="GetEmailDocumentAsMimeStreamRequest">
        <soap:header message="tns:GetEmailDocumentAsMimeStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEmailDocumentAsMimeStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEmailDocumentAsMimeStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEmailDocumentAsMimeStreamResponse">
        <soap:header message="tns:GetEmailDocumentAsMimeStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEmailDocumentAsMimeStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEmailDocumentAsMimeStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEmailDocumentAsMimeStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailSOInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailSOInfo" style="document" />
      <wsdl:input name="GetEMailSOInfoRequest">
        <soap:header message="tns:GetEMailSOInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailSOInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailSOInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailSOInfoResponse">
        <soap:header message="tns:GetEMailSOInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailSOInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailSOInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailSOInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetReadySyncEmailAccounts">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetReadySyncEmailAccounts" style="document" />
      <wsdl:input name="GetReadySyncEmailAccountsRequest">
        <soap:header message="tns:GetReadySyncEmailAccountsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetReadySyncEmailAccountsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetReadySyncEmailAccountsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetReadySyncEmailAccountsResponse">
        <soap:header message="tns:GetReadySyncEmailAccountsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetReadySyncEmailAccountsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetReadySyncEmailAccountsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetReadySyncEmailAccountsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SyncEmailAccount">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SyncEmailAccount" style="document" />
      <wsdl:input name="SyncEmailAccountRequest">
        <soap:header message="tns:SyncEmailAccountRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SyncEmailAccountRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SyncEmailAccountRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SyncEmailAccountResponse">
        <soap:header message="tns:SyncEmailAccountResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SyncEmailAccountResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SyncEmailAccountResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SyncEmailAccountResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SyncEmailAccounts">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SyncEmailAccounts" style="document" />
      <wsdl:input name="SyncEmailAccountsRequest">
        <soap:header message="tns:SyncEmailAccountsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SyncEmailAccountsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SyncEmailAccountsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SyncEmailAccountsResponse">
        <soap:header message="tns:SyncEmailAccountsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SyncEmailAccountsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SyncEmailAccountsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SyncEmailAccountsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailAccount">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAccount" style="document" />
      <wsdl:input name="CreateDefaultEMailAccountRequest">
        <soap:header message="tns:CreateDefaultEMailAccountRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAccountRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAccountRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailAccountResponse">
        <soap:header message="tns:CreateDefaultEMailAccountResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAccountResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAccountResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAccountResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveEMailAccount">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEMailAccount" style="document" />
      <wsdl:input name="SaveEMailAccountRequest">
        <soap:header message="tns:SaveEMailAccountRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveEMailAccountRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveEMailAccountRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveEMailAccountResponse">
        <soap:header message="tns:SaveEMailAccountResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveEMailAccountResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveEMailAccountResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveEMailAccountResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteEMailAccount">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteEMailAccount" style="document" />
      <wsdl:input name="DeleteEMailAccountRequest">
        <soap:header message="tns:DeleteEMailAccountRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteEMailAccountRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteEMailAccountRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteEMailAccountResponse">
        <soap:header message="tns:DeleteEMailAccountResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteEMailAccountResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteEMailAccountResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteEMailAccountResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailAddress">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAddress" style="document" />
      <wsdl:input name="CreateDefaultEMailAddressRequest">
        <soap:header message="tns:CreateDefaultEMailAddressRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAddressRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAddressRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailAddressResponse">
        <soap:header message="tns:CreateDefaultEMailAddressResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAddressResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAddressResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAddressResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAppointment" style="document" />
      <wsdl:input name="CreateDefaultEMailAppointmentRequest">
        <soap:header message="tns:CreateDefaultEMailAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailAppointmentResponse">
        <soap:header message="tns:CreateDefaultEMailAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailAttachment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailAttachment" style="document" />
      <wsdl:input name="CreateDefaultEMailAttachmentRequest">
        <soap:header message="tns:CreateDefaultEMailAttachmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAttachmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAttachmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailAttachmentResponse">
        <soap:header message="tns:CreateDefaultEMailAttachmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAttachmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAttachmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailAttachmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailConnectionInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailConnectionInfo" style="document" />
      <wsdl:input name="CreateDefaultEMailConnectionInfoRequest">
        <soap:header message="tns:CreateDefaultEMailConnectionInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailConnectionInfoResponse">
        <soap:header message="tns:CreateDefaultEMailConnectionInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailConnectionInfoExtended">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailConnectionInfoExtended" style="document" />
      <wsdl:input name="CreateDefaultEMailConnectionInfoExtendedRequest">
        <soap:header message="tns:CreateDefaultEMailConnectionInfoExtendedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoExtendedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoExtendedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailConnectionInfoExtendedResponse">
        <soap:header message="tns:CreateDefaultEMailConnectionInfoExtendedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoExtendedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoExtendedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailConnectionInfoExtendedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailCustomHeader">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailCustomHeader" style="document" />
      <wsdl:input name="CreateDefaultEMailCustomHeaderRequest">
        <soap:header message="tns:CreateDefaultEMailCustomHeaderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailCustomHeaderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailCustomHeaderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailCustomHeaderResponse">
        <soap:header message="tns:CreateDefaultEMailCustomHeaderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailCustomHeaderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailCustomHeaderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailCustomHeaderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailEntity" style="document" />
      <wsdl:input name="CreateDefaultEMailEntityRequest">
        <soap:header message="tns:CreateDefaultEMailEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailEntityResponse">
        <soap:header message="tns:CreateDefaultEMailEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailEnvelope">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailEnvelope" style="document" />
      <wsdl:input name="CreateDefaultEMailEnvelopeRequest">
        <soap:header message="tns:CreateDefaultEMailEnvelopeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEnvelopeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEnvelopeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailEnvelopeResponse">
        <soap:header message="tns:CreateDefaultEMailEnvelopeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEnvelopeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEnvelopeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailEnvelopeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailFolder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailFolder" style="document" />
      <wsdl:input name="CreateDefaultEMailFolderRequest">
        <soap:header message="tns:CreateDefaultEMailFolderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailFolderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailFolderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailFolderResponse">
        <soap:header message="tns:CreateDefaultEMailFolderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailFolderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailFolderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailFolderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultEMailSOInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateDefaultEMailSOInfo" style="document" />
      <wsdl:input name="CreateDefaultEMailSOInfoRequest">
        <soap:header message="tns:CreateDefaultEMailSOInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultEMailSOInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultEMailSOInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultEMailSOInfoResponse">
        <soap:header message="tns:CreateDefaultEMailSOInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailSOInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultEMailSOInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultEMailSOInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailAccount">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAccount" style="document" />
      <wsdl:input name="GetEMailAccountRequest">
        <soap:header message="tns:GetEMailAccountRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailAccountRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailAccountRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailAccountResponse">
        <soap:header message="tns:GetEMailAccountResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailAccountResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailAccountResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailAccountResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailAccountFromEMailAddress">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAccountFromEMailAddress" style="document" />
      <wsdl:input name="GetEMailAccountFromEMailAddressRequest">
        <soap:header message="tns:GetEMailAccountFromEMailAddressRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailAccountFromEMailAddressRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailAccountFromEMailAddressRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailAccountFromEMailAddressResponse">
        <soap:header message="tns:GetEMailAccountFromEMailAddressResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailAccountFromEMailAddressResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailAccountFromEMailAddressResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailAccountFromEMailAddressResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCurrentAccountId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetCurrentAccountId" style="document" />
      <wsdl:input name="GetCurrentAccountIdRequest">
        <soap:header message="tns:GetCurrentAccountIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCurrentAccountIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCurrentAccountIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCurrentAccountIdResponse">
        <soap:header message="tns:GetCurrentAccountIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCurrentAccountIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCurrentAccountIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCurrentAccountIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCurrentAccount">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetCurrentAccount" style="document" />
      <wsdl:input name="GetCurrentAccountRequest">
        <soap:header message="tns:GetCurrentAccountRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCurrentAccountRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCurrentAccountRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCurrentAccountResponse">
        <soap:header message="tns:GetCurrentAccountResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCurrentAccountResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCurrentAccountResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCurrentAccountResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonEntitiesFromEmailAddress">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPersonEntitiesFromEmailAddress" style="document" />
      <wsdl:input name="GetPersonEntitiesFromEmailAddressRequest">
        <soap:header message="tns:GetPersonEntitiesFromEmailAddressRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonEntitiesFromEmailAddressRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonEntitiesFromEmailAddressRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonEntitiesFromEmailAddressResponse">
        <soap:header message="tns:GetPersonEntitiesFromEmailAddressResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonEntitiesFromEmailAddressResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonEntitiesFromEmailAddressResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonEntitiesFromEmailAddressResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonsFromEmailAddress">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetPersonsFromEmailAddress" style="document" />
      <wsdl:input name="GetPersonsFromEmailAddressRequest">
        <soap:header message="tns:GetPersonsFromEmailAddressRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonsFromEmailAddressRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonsFromEmailAddressRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonsFromEmailAddressResponse">
        <soap:header message="tns:GetPersonsFromEmailAddressResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonsFromEmailAddressResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonsFromEmailAddressResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonsFromEmailAddressResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasMXRecord">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasMXRecord" style="document" />
      <wsdl:input name="HasMXRecordRequest">
        <soap:header message="tns:HasMXRecordRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasMXRecordRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasMXRecordRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasMXRecordResponse">
        <soap:header message="tns:HasMXRecordResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasMXRecordResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasMXRecordResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasMXRecordResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasSPFRecord">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/HasSPFRecord" style="document" />
      <wsdl:input name="HasSPFRecordRequest">
        <soap:header message="tns:HasSPFRecordRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasSPFRecordRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasSPFRecordRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasSPFRecordResponse">
        <soap:header message="tns:HasSPFRecordResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasSPFRecordResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasSPFRecordResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasSPFRecordResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ResolveEMailRecipients">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/ResolveEMailRecipients" style="document" />
      <wsdl:input name="ResolveEMailRecipientsRequest">
        <soap:header message="tns:ResolveEMailRecipientsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ResolveEMailRecipientsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ResolveEMailRecipientsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ResolveEMailRecipientsResponse">
        <soap:header message="tns:ResolveEMailRecipientsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ResolveEMailRecipientsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ResolveEMailRecipientsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ResolveEMailRecipientsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromId" style="document" />
      <wsdl:input name="GetEMailFromIdRequest">
        <soap:header message="tns:GetEMailFromIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailFromIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailFromIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailFromIdResponse">
        <soap:header message="tns:GetEMailFromIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailFromIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailFromIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailFromIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendEMails">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SendEMails" style="document" />
      <wsdl:input name="SendEMailsRequest">
        <soap:header message="tns:SendEMailsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendEMailsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendEMailsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendEMailsResponse">
        <soap:header message="tns:SendEMailsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendEMailsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendEMailsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendEMailsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveEMail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEMail" style="document" />
      <wsdl:input name="SaveEMailRequest">
        <soap:header message="tns:SaveEMailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveEMailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveEMailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveEMailResponse">
        <soap:header message="tns:SaveEMailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveEMailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveEMailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveEMailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AuthenticateIncoming">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/AuthenticateIncoming" style="document" />
      <wsdl:input name="AuthenticateIncomingRequest">
        <soap:header message="tns:AuthenticateIncomingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AuthenticateIncomingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AuthenticateIncomingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AuthenticateIncomingResponse">
        <soap:header message="tns:AuthenticateIncomingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AuthenticateIncomingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AuthenticateIncomingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AuthenticateIncomingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AuthenticateOutgoing">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/AuthenticateOutgoing" style="document" />
      <wsdl:input name="AuthenticateOutgoingRequest">
        <soap:header message="tns:AuthenticateOutgoingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AuthenticateOutgoingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AuthenticateOutgoingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AuthenticateOutgoingResponse">
        <soap:header message="tns:AuthenticateOutgoingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AuthenticateOutgoingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AuthenticateOutgoingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AuthenticateOutgoingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFolderList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderList" style="document" />
      <wsdl:input name="GetFolderListRequest">
        <soap:header message="tns:GetFolderListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFolderListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFolderListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFolderListResponse">
        <soap:header message="tns:GetFolderListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFolderListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFolderListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFolderListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAttachment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetAttachment" style="document" />
      <wsdl:input name="GetAttachmentRequest">
        <soap:header message="tns:GetAttachmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAttachmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAttachmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAttachmentResponse">
        <soap:header message="tns:GetAttachmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAttachmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAttachmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAttachmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MarkAsRead">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MarkAsRead" style="document" />
      <wsdl:input name="MarkAsReadRequest">
        <soap:header message="tns:MarkAsReadRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MarkAsReadRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MarkAsReadRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MarkAsReadResponse">
        <soap:header message="tns:MarkAsReadResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MarkAsReadResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MarkAsReadResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MarkAsReadResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFolderEMailCount">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderEMailCount" style="document" />
      <wsdl:input name="GetFolderEMailCountRequest">
        <soap:header message="tns:GetFolderEMailCountRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFolderEMailCountRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFolderEMailCountRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFolderEMailCountResponse">
        <soap:header message="tns:GetFolderEMailCountResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFolderEMailCountResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFolderEMailCountResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFolderEMailCountResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Delete">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/Delete" style="document" />
      <wsdl:input name="DeleteRequest">
        <soap:header message="tns:DeleteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteResponse">
        <soap:header message="tns:DeleteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MoveToFolder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveToFolder" style="document" />
      <wsdl:input name="MoveToFolderRequest">
        <soap:header message="tns:MoveToFolderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveToFolderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveToFolderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveToFolderResponse">
        <soap:header message="tns:MoveToFolderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveToFolderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveToFolderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveToFolderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="EmptyFolder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/EmptyFolder" style="document" />
      <wsdl:input name="EmptyFolderRequest">
        <soap:header message="tns:EmptyFolderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:EmptyFolderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:EmptyFolderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="EmptyFolderResponse">
        <soap:header message="tns:EmptyFolderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:EmptyFolderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:EmptyFolderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:EmptyFolderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailAsStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAsStream" style="document" />
      <wsdl:input name="GetEMailAsStreamRequest">
        <soap:header message="tns:GetEMailAsStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailAsStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailAsStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailAsStreamResponse">
        <soap:header message="tns:GetEMailAsStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailAsStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailAsStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailAsStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindAddress">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindAddress" style="document" />
      <wsdl:input name="FindAddressRequest">
        <soap:header message="tns:FindAddressRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindAddressRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindAddressRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindAddressResponse">
        <soap:header message="tns:FindAddressResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindAddressResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindAddressResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindAddressResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromDocumentId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentId" style="document" />
      <wsdl:input name="GetEMailFromDocumentIdRequest">
        <soap:header message="tns:GetEMailFromDocumentIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailFromDocumentIdResponse">
        <soap:header message="tns:GetEMailFromDocumentIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMailFromDocumentId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentId" style="document" />
      <wsdl:input name="GetUnsanitizedEMailFromDocumentIdRequest">
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUnsanitizedEMailFromDocumentIdResponse">
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromAttachmentId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromAttachmentId" style="document" />
      <wsdl:input name="GetEMailFromAttachmentIdRequest">
        <soap:header message="tns:GetEMailFromAttachmentIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailFromAttachmentIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailFromAttachmentIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailFromAttachmentIdResponse">
        <soap:header message="tns:GetEMailFromAttachmentIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailFromAttachmentIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailFromAttachmentIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailFromAttachmentIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMailFromAttachmentId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromAttachmentId" style="document" />
      <wsdl:input name="GetUnsanitizedEMailFromAttachmentIdRequest">
        <soap:header message="tns:GetUnsanitizedEMailFromAttachmentIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromAttachmentIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromAttachmentIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUnsanitizedEMailFromAttachmentIdResponse">
        <soap:header message="tns:GetUnsanitizedEMailFromAttachmentIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromAttachmentIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromAttachmentIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromAttachmentIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromDocumentAttachmentId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentAttachmentId" style="document" />
      <wsdl:input name="GetEMailFromDocumentAttachmentIdRequest">
        <soap:header message="tns:GetEMailFromDocumentAttachmentIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentAttachmentIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentAttachmentIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailFromDocumentAttachmentIdResponse">
        <soap:header message="tns:GetEMailFromDocumentAttachmentIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentAttachmentIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentAttachmentIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentAttachmentIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMailFromDocumentAttachmentId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentAttachmentId" style="document" />
      <wsdl:input name="GetUnsanitizedEMailFromDocumentAttachmentIdRequest">
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUnsanitizedEMailFromDocumentAttachmentIdResponse">
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentAttachmentIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailEnvelopes">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailEnvelopes" style="document" />
      <wsdl:input name="GetEMailEnvelopesRequest">
        <soap:header message="tns:GetEMailEnvelopesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailEnvelopesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailEnvelopesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailEnvelopesResponse">
        <soap:header message="tns:GetEMailEnvelopesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailEnvelopesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailEnvelopesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailEnvelopesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetSubscription">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SetSubscription" style="document" />
      <wsdl:input name="SetSubscriptionRequest">
        <soap:header message="tns:SetSubscriptionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetSubscriptionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetSubscriptionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetSubscriptionResponse">
        <soap:header message="tns:SetSubscriptionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetSubscriptionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetSubscriptionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetSubscriptionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateFolder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateFolder" style="document" />
      <wsdl:input name="CreateFolderRequest">
        <soap:header message="tns:CreateFolderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateFolderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateFolderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateFolderResponse">
        <soap:header message="tns:CreateFolderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateFolderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateFolderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateFolderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteFolder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteFolder" style="document" />
      <wsdl:input name="DeleteFolderRequest">
        <soap:header message="tns:DeleteFolderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteFolderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteFolderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteFolderResponse">
        <soap:header message="tns:DeleteFolderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteFolderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteFolderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteFolderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateEMailFromDocumentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateEMailFromDocumentEntity" style="document" />
      <wsdl:input name="CreateEMailFromDocumentEntityRequest">
        <soap:header message="tns:CreateEMailFromDocumentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateEMailFromDocumentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateEMailFromDocumentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateEMailFromDocumentEntityResponse">
        <soap:header message="tns:CreateEMailFromDocumentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateEMailFromDocumentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateEMailFromDocumentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateEMailFromDocumentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateEMailFromMimeMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateEMailFromMimeMessage" style="document" />
      <wsdl:input name="CreateEMailFromMimeMessageRequest">
        <soap:header message="tns:CreateEMailFromMimeMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateEMailFromMimeMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateEMailFromMimeMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateEMailFromMimeMessageResponse">
        <soap:header message="tns:CreateEMailFromMimeMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateEMailFromMimeMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateEMailFromMimeMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateEMailFromMimeMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFolderInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderInfo" style="document" />
      <wsdl:input name="GetFolderInfoRequest">
        <soap:header message="tns:GetFolderInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFolderInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFolderInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFolderInfoResponse">
        <soap:header message="tns:GetFolderInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFolderInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFolderInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFolderInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetFolderHasNewEMail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetFolderHasNewEMail" style="document" />
      <wsdl:input name="GetFolderHasNewEMailRequest">
        <soap:header message="tns:GetFolderHasNewEMailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetFolderHasNewEMailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetFolderHasNewEMailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetFolderHasNewEMailResponse">
        <soap:header message="tns:GetFolderHasNewEMailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetFolderHasNewEMailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetFolderHasNewEMailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetFolderHasNewEMailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailAddresses">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailAddresses" style="document" />
      <wsdl:input name="GetEMailAddressesRequest">
        <soap:header message="tns:GetEMailAddressesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailAddressesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailAddressesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailAddressesResponse">
        <soap:header message="tns:GetEMailAddressesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailAddressesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailAddressesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailAddressesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RefreshFolder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RefreshFolder" style="document" />
      <wsdl:input name="RefreshFolderRequest">
        <soap:header message="tns:RefreshFolderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RefreshFolderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RefreshFolderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RefreshFolderResponse">
        <soap:header message="tns:RefreshFolderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RefreshFolderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RefreshFolderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RefreshFolderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromTemp">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromTemp" style="document" />
      <wsdl:input name="GetEMailFromTempRequest">
        <soap:header message="tns:GetEMailFromTempRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailFromTempRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailFromTempRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailFromTempResponse">
        <soap:header message="tns:GetEMailFromTempResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailFromTempResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailFromTempResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailFromTempResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Authenticate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/Authenticate" style="document" />
      <wsdl:input name="AuthenticateRequest">
        <soap:header message="tns:AuthenticateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AuthenticateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AuthenticateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AuthenticateResponse">
        <soap:header message="tns:AuthenticateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AuthenticateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEmailMessageIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailMessageIds" style="document" />
      <wsdl:input name="GetEmailMessageIdsRequest">
        <soap:header message="tns:GetEmailMessageIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEmailMessageIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEmailMessageIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEmailMessageIdsResponse">
        <soap:header message="tns:GetEmailMessageIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEmailMessageIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEmailMessageIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEmailMessageIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetExtendedEmailMessageIds">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetExtendedEmailMessageIds" style="document" />
      <wsdl:input name="GetExtendedEmailMessageIdsRequest">
        <soap:header message="tns:GetExtendedEmailMessageIdsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetExtendedEmailMessageIdsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetExtendedEmailMessageIdsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetExtendedEmailMessageIdsResponse">
        <soap:header message="tns:GetExtendedEmailMessageIdsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetExtendedEmailMessageIdsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetExtendedEmailMessageIdsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetExtendedEmailMessageIdsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEmailsAsString">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEmailsAsString" style="document" />
      <wsdl:input name="GetEmailsAsStringRequest">
        <soap:header message="tns:GetEmailsAsStringRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEmailsAsStringRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEmailsAsStringRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEmailsAsStringResponse">
        <soap:header message="tns:GetEmailsAsStringResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEmailsAsStringResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEmailsAsStringResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEmailsAsStringResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteExtended">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteExtended" style="document" />
      <wsdl:input name="DeleteExtendedRequest">
        <soap:header message="tns:DeleteExtendedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteExtendedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteExtendedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteExtendedResponse">
        <soap:header message="tns:DeleteExtendedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteExtendedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteExtendedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteExtendedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RelayMessage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RelayMessage" style="document" />
      <wsdl:input name="RelayMessageRequest">
        <soap:header message="tns:RelayMessageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RelayMessageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RelayMessageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RelayMessageResponse">
        <soap:header message="tns:RelayMessageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RelayMessageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RelayMessageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RelayMessageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMail" style="document" />
      <wsdl:input name="GetEMailRequest">
        <soap:header message="tns:GetEMailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailResponse">
        <soap:header message="tns:GetEMailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMail" style="document" />
      <wsdl:input name="GetUnsanitizedEMailRequest">
        <soap:header message="tns:GetUnsanitizedEMailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUnsanitizedEMailResponse">
        <soap:header message="tns:GetUnsanitizedEMailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MarkEmailsAsRead">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MarkEmailsAsRead" style="document" />
      <wsdl:input name="MarkEmailsAsReadRequest">
        <soap:header message="tns:MarkEmailsAsReadRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MarkEmailsAsReadRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MarkEmailsAsReadRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MarkEmailsAsReadResponse">
        <soap:header message="tns:MarkEmailsAsReadResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MarkEmailsAsReadResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MarkEmailsAsReadResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MarkEmailsAsReadResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteEmails">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/DeleteEmails" style="document" />
      <wsdl:input name="DeleteEmailsRequest">
        <soap:header message="tns:DeleteEmailsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteEmailsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteEmailsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteEmailsResponse">
        <soap:header message="tns:DeleteEmailsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteEmailsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteEmailsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteEmailsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MoveEmailsToTrash">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveEmailsToTrash" style="document" />
      <wsdl:input name="MoveEmailsToTrashRequest">
        <soap:header message="tns:MoveEmailsToTrashRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveEmailsToTrashRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveEmailsToTrashRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveEmailsToTrashResponse">
        <soap:header message="tns:MoveEmailsToTrashResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveEmailsToTrashResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveEmailsToTrashResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveEmailsToTrashResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Save">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/Save" style="document" />
      <wsdl:input name="SaveRequest">
        <soap:header message="tns:SaveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveResponse">
        <soap:header message="tns:SaveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveToMailServer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveToMailServer" style="document" />
      <wsdl:input name="SaveToMailServerRequest">
        <soap:header message="tns:SaveToMailServerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveToMailServerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveToMailServerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveToMailServerResponse">
        <soap:header message="tns:SaveToMailServerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveToMailServerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveToMailServerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveToMailServerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Send">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/Send" style="document" />
      <wsdl:input name="SendRequest">
        <soap:header message="tns:SendRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendResponse">
        <soap:header message="tns:SendResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateForwardEmail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateForwardEmail" style="document" />
      <wsdl:input name="CreateForwardEmailRequest">
        <soap:header message="tns:CreateForwardEmailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateForwardEmailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateForwardEmailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateForwardEmailResponse">
        <soap:header message="tns:CreateForwardEmailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateForwardEmailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateForwardEmailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateForwardEmailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindContactOrPersonByEmailName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindContactOrPersonByEmailName" style="document" />
      <wsdl:input name="FindContactOrPersonByEmailNameRequest">
        <soap:header message="tns:FindContactOrPersonByEmailNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindContactOrPersonByEmailNameResponse">
        <soap:header message="tns:FindContactOrPersonByEmailNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindContactOrPersonByEmailNameWithLimit">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/FindContactOrPersonByEmailNameWithLimit" style="document" />
      <wsdl:input name="FindContactOrPersonByEmailNameWithLimitRequest">
        <soap:header message="tns:FindContactOrPersonByEmailNameWithLimitRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameWithLimitRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameWithLimitRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindContactOrPersonByEmailNameWithLimitResponse">
        <soap:header message="tns:FindContactOrPersonByEmailNameWithLimitResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameWithLimitResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameWithLimitResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindContactOrPersonByEmailNameWithLimitResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RefreshFolderForAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/RefreshFolderForAssociate" style="document" />
      <wsdl:input name="RefreshFolderForAssociateRequest">
        <soap:header message="tns:RefreshFolderForAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RefreshFolderForAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RefreshFolderForAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RefreshFolderForAssociateResponse">
        <soap:header message="tns:RefreshFolderForAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RefreshFolderForAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RefreshFolderForAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RefreshFolderForAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNewMail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetNewMail" style="document" />
      <wsdl:input name="GetNewMailRequest">
        <soap:header message="tns:GetNewMailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNewMailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNewMailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNewMailResponse">
        <soap:header message="tns:GetNewMailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNewMailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNewMailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNewMailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CacheFolderList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CacheFolderList" style="document" />
      <wsdl:input name="CacheFolderListRequest">
        <soap:header message="tns:CacheFolderListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CacheFolderListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CacheFolderListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CacheFolderListResponse">
        <soap:header message="tns:CacheFolderListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CacheFolderListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CacheFolderListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CacheFolderListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MoveEmailsToFolder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/MoveEmailsToFolder" style="document" />
      <wsdl:input name="MoveEmailsToFolderRequest">
        <soap:header message="tns:MoveEmailsToFolderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveEmailsToFolderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveEmailsToFolderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveEmailsToFolderResponse">
        <soap:header message="tns:MoveEmailsToFolderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveEmailsToFolderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveEmailsToFolderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveEmailsToFolderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMailFromMessageId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetMailFromMessageId" style="document" />
      <wsdl:input name="GetMailFromMessageIdRequest">
        <soap:header message="tns:GetMailFromMessageIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMailFromMessageIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMailFromMessageIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMailFromMessageIdResponse">
        <soap:header message="tns:GetMailFromMessageIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMailFromMessageIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMailFromMessageIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMailFromMessageIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMailFromInReplyTo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetMailFromInReplyTo" style="document" />
      <wsdl:input name="GetMailFromInReplyToRequest">
        <soap:header message="tns:GetMailFromInReplyToRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMailFromInReplyToRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMailFromInReplyToRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMailFromInReplyToResponse">
        <soap:header message="tns:GetMailFromInReplyToResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMailFromInReplyToResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMailFromInReplyToResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMailFromInReplyToResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendAndSaveEmailToTmpDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SendAndSaveEmailToTmpDocument" style="document" />
      <wsdl:input name="SendAndSaveEmailToTmpDocumentRequest">
        <soap:header message="tns:SendAndSaveEmailToTmpDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendAndSaveEmailToTmpDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendAndSaveEmailToTmpDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendAndSaveEmailToTmpDocumentResponse">
        <soap:header message="tns:SendAndSaveEmailToTmpDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendAndSaveEmailToTmpDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendAndSaveEmailToTmpDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendAndSaveEmailToTmpDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveEmailToTmpDocument">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveEmailToTmpDocument" style="document" />
      <wsdl:input name="SaveEmailToTmpDocumentRequest">
        <soap:header message="tns:SaveEmailToTmpDocumentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveEmailToTmpDocumentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveEmailToTmpDocumentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveEmailToTmpDocumentResponse">
        <soap:header message="tns:SaveEmailToTmpDocumentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveEmailToTmpDocumentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveEmailToTmpDocumentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveEmailToTmpDocumentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromEmailAttachment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateNewPhysicalDocumentFromEmailAttachment" style="document" />
      <wsdl:input name="CreateNewPhysicalDocumentFromEmailAttachmentRequest">
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailAttachmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailAttachmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailAttachmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateNewPhysicalDocumentFromEmailAttachmentResponse">
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailAttachmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailAttachmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailAttachmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailAttachmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateNewPhysicalDocumentFromEmail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/CreateNewPhysicalDocumentFromEmail" style="document" />
      <wsdl:input name="CreateNewPhysicalDocumentFromEmailRequest">
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateNewPhysicalDocumentFromEmailResponse">
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateNewPhysicalDocumentFromEmailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveDraft">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SaveDraft" style="document" />
      <wsdl:input name="SaveDraftRequest">
        <soap:header message="tns:SaveDraftRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveDraftRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveDraftRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveDraftResponse">
        <soap:header message="tns:SaveDraftResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveDraftResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveDraftResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveDraftResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetRepliedAt">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/SetRepliedAt" style="document" />
      <wsdl:input name="SetRepliedAtRequest">
        <soap:header message="tns:SetRepliedAtRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetRepliedAtRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetRepliedAtRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetRepliedAtResponse">
        <soap:header message="tns:SetRepliedAtResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetRepliedAtResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetRepliedAtResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetRepliedAtResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetEMailFromDocumentIdWithoutAttachmentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetEMailFromDocumentIdWithoutAttachmentStream" style="document" />
      <wsdl:input name="GetEMailFromDocumentIdWithoutAttachmentStreamRequest">
        <soap:header message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetEMailFromDocumentIdWithoutAttachmentStreamResponse">
        <soap:header message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream" style="document" />
      <wsdl:input name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamRequest">
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse">
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStreamResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAttachmentFromId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/EMail/GetAttachmentFromId" style="document" />
      <wsdl:input name="GetAttachmentFromIdRequest">
        <soap:header message="tns:GetAttachmentFromIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAttachmentFromIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAttachmentFromIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAttachmentFromIdResponse">
        <soap:header message="tns:GetAttachmentFromIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAttachmentFromIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAttachmentFromIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAttachmentFromIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfEMailService">
    <wsdl:port name="BasicHttpBinding_EMail" binding="tns:BasicHttpBinding_EMail">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/EMail.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```


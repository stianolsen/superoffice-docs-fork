---
generated: true
uid: wsdl-Services88-Appointment
title: Services88.AppointmentAgent WSDL
---

# Services88.AppointmentAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfAppointmentService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:ser="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="GetPublishedAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
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
      <xs:element name="GetPublishedAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q5:Appointment" xmlns:q5="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Appointment">
        <xs:complexContent mixed="false">
          <xs:extension base="q6:Carrier" xmlns:q6="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Type" type="q6:AppointmentType" />
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
              <xs:element minOccurs="0" name="Private" type="q6:AppointmentPrivate" />
              <xs:element minOccurs="0" name="PriorityId" type="xs:int" />
              <xs:element minOccurs="0" name="PriorityName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskType" type="q6:TaskType" />
              <xs:element minOccurs="0" name="IsBookingMain" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsRecurrence" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBooking" type="xs:boolean" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q6:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q6:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q6:BookingType" />
              <xs:element minOccurs="0" name="Completed" type="q6:ActivityStatus" />
              <xs:element minOccurs="0" name="RecurringPattern" type="q6:RecurrencePattern" />
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
              <xs:element minOccurs="0" name="CautionWarning" type="q6:AppointmentCautionWarning" />
              <xs:element minOccurs="0" name="OwnedExternally" type="q6:AppointmentExternalOwner" />
              <xs:element minOccurs="0" name="JoinVideomeetUrl" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PreferredTZLocation" type="xs:int" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Agenda" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InternalNotes" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Appointment" nillable="true" type="q7:Appointment" xmlns:q7="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentType" nillable="true" type="q21:AppointmentType" xmlns:q21="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentPrivate" nillable="true" type="q22:AppointmentPrivate" xmlns:q22="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="TaskType" nillable="true" type="q23:TaskType" xmlns:q23="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AssignmentStatus" nillable="true" type="q24:AssignmentStatus" xmlns:q24="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="InvitationStatus" nillable="true" type="q25:InvitationStatus" xmlns:q25="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="BookingType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="None" />
          <xs:enumeration value="Owner" />
          <xs:enumeration value="Participant" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="BookingType" nillable="true" type="q26:BookingType" xmlns:q26="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="q27:ActivityStatus" xmlns:q27="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="RecurrencePattern" nillable="true" type="q28:RecurrencePattern" xmlns:q28="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentCautionWarning" nillable="true" type="q29:AppointmentCautionWarning" xmlns:q29="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AppointmentExternalOwner" nillable="true" type="q30:AppointmentExternalOwner" xmlns:q30="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="q31:SoExceptionInfo" xmlns:q31="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="q32:SoExceptionInfoParameters" xmlns:q32="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="q33:SoExceptionInfo" xmlns:q33="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="q34:SoExceptionInfoParameters" xmlns:q34="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExceptionInfo" nillable="true" type="q35:SoExceptionInfo" xmlns:q35="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SoExtraInfo" nillable="true" type="q36:SoExtraInfo" xmlns:q36="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ExtraInfo" nillable="true" type="q37:SoExtraInfo" xmlns:q37="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="GetPublishedAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentIds" nillable="true" type="q38:ArrayOfint" xmlns:q38="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q39:ArrayOfAppointment" xmlns:q39="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAppointment">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Appointment" nillable="true" type="q40:Appointment" xmlns:q40="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAppointment" nillable="true" type="q41:ArrayOfAppointment" xmlns:q41="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetMyPublishedAppointments">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyPublishedAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q42:ArrayOfAppointment" xmlns:q42="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPublishedProjectAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q43:ArrayOfAppointment" xmlns:q43="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q44:ArrayOfAppointment" xmlns:q44="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociateDiary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociateDiaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q45:ArrayOfAppointment" xmlns:q45="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDiaryByGroup">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="GroupId" type="xs:int" />
            <xs:element minOccurs="0" name="GroupType" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDiaryByGroupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q46:ArrayOfAppointment" xmlns:q46="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Status" type="xs:int" />
            <xs:element minOccurs="0" name="Type" type="xs:int" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q47:Appointment" xmlns:q47="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateAppointmentWithMode">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Status" type="q48:AppointmentStatus" xmlns:q48="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Type" type="q49:AppointmentType" xmlns:q49="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q50:RecurrenceUpdateMode" xmlns:q50="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="AppointmentStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="UnknownOrPostIt" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
          <xs:enumeration value="Hidden" />
          <xs:enumeration value="Booking" />
          <xs:enumeration value="BookingMoved" />
          <xs:enumeration value="BookingSeen" />
          <xs:enumeration value="BookingMovedSeen" />
          <xs:enumeration value="BookingDeclined" />
          <xs:enumeration value="BookingDeleted" />
          <xs:enumeration value="Assignment" />
          <xs:enumeration value="AssignmentSeen" />
          <xs:enumeration value="AssignmentDeclined" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AppointmentStatus" nillable="true" type="q51:AppointmentStatus" xmlns:q51="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="RecurrenceUpdateMode">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="OnlyThis" />
          <xs:enumeration value="ThisAndForward" />
          <xs:enumeration value="StopRecurrence">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">9</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="RecurrenceUpdateMode" nillable="true" type="q52:RecurrenceUpdateMode" xmlns:q52="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="UpdateAppointmentWithModeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q53:Appointment" xmlns:q53="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateAppointmentWithModeAndEmail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Id" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Status" type="q54:AppointmentStatus" xmlns:q54="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Type" type="q55:AppointmentType" xmlns:q55="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q56:RecurrenceUpdateMode" xmlns:q56="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="SendEmailToParticipants" type="xs:boolean" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q57:EMailConnectionInfo" xmlns:q57="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ImapEMailConnectionInfo" nillable="true" type="q58:EMailConnectionInfo" xmlns:q58="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailConnectionInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q59:Carrier" xmlns:q59="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="EMailConnectionInfo" nillable="true" type="q60:EMailConnectionInfo" xmlns:q60="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="UpdateAppointmentWithModeAndEmailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q61:Appointment" xmlns:q61="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociatesDiary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q62:ArrayOfint" xmlns:q62="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociatesDiaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q63:ArrayOfAppointment" xmlns:q63="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociatesDiaryInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q64:ArrayOfint" xmlns:q64="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAssociatesDiaryInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q65:ArrayOfAppointmentInfo" xmlns:q65="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAppointmentInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AppointmentInfo" nillable="true" type="q66:AppointmentInfo" xmlns:q66="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAppointmentInfo" nillable="true" type="q67:ArrayOfAppointmentInfo" xmlns:q67="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="AppointmentInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q68:Carrier" xmlns:q68="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ColorIndex" type="q68:ColorIndex" />
              <xs:element minOccurs="0" name="TaskName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Agenda" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsAllDay" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBusy" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsRecurring" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsVideoMeeting" type="xs:boolean" />
              <xs:element minOccurs="0" name="HasAlarm" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsCompleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsTentative" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBookingMain" type="xs:boolean" />
              <xs:element minOccurs="0" name="SendEmail" type="xs:boolean" />
              <xs:element minOccurs="0" name="AnySendEmail" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsPrivate" type="xs:boolean" />
              <xs:element minOccurs="0" name="RecurrenceInfo" nillable="true" type="q68:RecurrenceInfo" />
              <xs:element minOccurs="0" name="PersonName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsBooking" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentInfo" nillable="true" type="q69:AppointmentInfo" xmlns:q69="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="ColorIndex">
        <xs:restriction base="xs:string">
          <xs:enumeration value="LightBlue" />
          <xs:enumeration value="DarkBlue" />
          <xs:enumeration value="LightGray" />
          <xs:enumeration value="DarkGray" />
          <xs:enumeration value="LightGreen" />
          <xs:enumeration value="DarkGreen" />
          <xs:enumeration value="LightYellow" />
          <xs:enumeration value="DarkYellow" />
          <xs:enumeration value="LightRed" />
          <xs:enumeration value="DarkRed" />
          <xs:enumeration value="BlueAlt1" />
          <xs:enumeration value="BlueAlt2" />
          <xs:enumeration value="BlueAlt3" />
          <xs:enumeration value="GrayAlt1" />
          <xs:enumeration value="GrayAlt2" />
          <xs:enumeration value="GrayAlt3" />
          <xs:enumeration value="GreenAlt1" />
          <xs:enumeration value="GreenAlt2" />
          <xs:enumeration value="GreenAlt3" />
          <xs:enumeration value="YellowAlt1" />
          <xs:enumeration value="YellowAlt2" />
          <xs:enumeration value="YellowAlt3" />
          <xs:enumeration value="RedAlt1" />
          <xs:enumeration value="RedAlt2" />
          <xs:enumeration value="RedAlt3" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ColorIndex" nillable="true" type="q70:ColorIndex" xmlns:q70="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="GetAppointmentRecords">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MotherId" type="xs:int" />
            <xs:element minOccurs="0" name="RecurrenceRuleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentRecordsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q100:ArrayOfAppointment" xmlns:q100="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMySyncAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMySyncAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q101:ArrayOfAppointmentSyncData" xmlns:q101="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfAppointmentSyncData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AppointmentSyncData" nillable="true" type="q102:AppointmentSyncData" xmlns:q102="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAppointmentSyncData" nillable="true" type="q103:ArrayOfAppointmentSyncData" xmlns:q103="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="AppointmentSyncData">
        <xs:complexContent mixed="false">
          <xs:extension base="q104:Carrier" xmlns:q104="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AlarmTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="AppointmentText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasAlarm" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAllDay" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAssignment" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsBusy" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsCompleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsInvitation" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsTentative" type="xs:boolean" />
              <xs:element minOccurs="0" name="Location" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q104:ArrayOfParticipantSyncData" />
              <xs:element minOccurs="0" name="PersonFormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="TaskName" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentSyncData" nillable="true" type="q105:AppointmentSyncData" xmlns:q105="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfParticipantSyncData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ParticipantSyncData" nillable="true" type="q106:ParticipantSyncData" xmlns:q106="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfParticipantSyncData" nillable="true" type="q107:ArrayOfParticipantSyncData" xmlns:q107="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ParticipantSyncData">
        <xs:complexContent mixed="false">
          <xs:extension base="q108:Carrier" xmlns:q108="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFirstName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonMiddleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonLastname" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonMrmrs" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonTitle" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonPosition" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonAcademicTitle" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactBusiness" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactCategory" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EMail" nillable="true" type="q109:ArrayOfstring" xmlns:q109="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhonePrivate" nillable="true" type="q110:ArrayOfstring" xmlns:q110="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhoneFax" nillable="true" type="q111:ArrayOfstring" xmlns:q111="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhoneMobile" nillable="true" type="q112:ArrayOfstring" xmlns:q112="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhoneDirect" nillable="true" type="q113:ArrayOfstring" xmlns:q113="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="PhoneContact" nillable="true" type="q114:ArrayOfstring" xmlns:q114="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Messenger" nillable="true" type="q115:ArrayOfstring" xmlns:q115="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Voip" nillable="true" type="q116:ArrayOfstring" xmlns:q116="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="ContactUrl" nillable="true" type="q117:ArrayOfstring" xmlns:q117="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Url" nillable="true" type="q118:ArrayOfstring" xmlns:q118="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="StreetAddress" nillable="true" type="q108:AddressSyncData" />
              <xs:element minOccurs="0" name="PostalAddress" nillable="true" type="q108:AddressSyncData" />
              <xs:element minOccurs="0" name="Country" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonAddress" nillable="true" type="q108:AddressSyncData" />
              <xs:element minOccurs="0" name="PersonCountry" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ParticipantStatus" type="q108:AppointmentStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ParticipantSyncData" nillable="true" type="q119:ParticipantSyncData" xmlns:q119="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="AddressSyncData">
        <xs:complexContent mixed="false">
          <xs:extension base="q120:Carrier" xmlns:q120="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AddressId" type="xs:int" />
              <xs:element minOccurs="0" name="AddressType" type="q120:AddressType" />
              <xs:element minOccurs="0" name="Address1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Address3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="City" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="County" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ZipCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="State" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="FormattedAddress" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AddressSyncData" nillable="true" type="q121:AddressSyncData" xmlns:q121="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="AddressType" nillable="true" type="q122:AddressType" xmlns:q122="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetDayInformationListByDatesAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetDayInformationListByDatesAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q123:ArrayOfDayInformationListItem" xmlns:q123="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfDayInformationListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="DayInformationListItem" nillable="true" type="q124:DayInformationListItem" xmlns:q124="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfDayInformationListItem" nillable="true" type="q125:ArrayOfDayInformationListItem" xmlns:q125="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="DayInformationListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q126:Carrier" xmlns:q126="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ActivityInformation" nillable="true" type="q126:ActivitySummary" />
              <xs:element minOccurs="0" name="RedLetterInformation" nillable="true" type="q126:RedLetterSummary" />
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="DayInformationListItem" nillable="true" type="q127:DayInformationListItem" xmlns:q127="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ActivitySummary">
        <xs:complexContent mixed="false">
          <xs:extension base="q128:Carrier" xmlns:q128="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="NumBusyActivities" type="xs:int" />
              <xs:element minOccurs="0" name="NumFreeActivities" type="xs:int" />
              <xs:element minOccurs="0" name="PercentageBusy" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ActivitySummary" nillable="true" type="q129:ActivitySummary" xmlns:q129="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RedLetterSummary">
        <xs:complexContent mixed="false">
          <xs:extension base="q130:Carrier" xmlns:q130="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="IsOwnCountryHoliday" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsOtherCountryHoliday" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RedLetterSummary" nillable="true" type="q131:RedLetterSummary" xmlns:q131="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetActivityInformationListByDatesAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActivityInformationListByDatesAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q132:ArrayOfActivityInformationListItem" xmlns:q132="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfActivityInformationListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ActivityInformationListItem" nillable="true" type="q133:ActivityInformationListItem" xmlns:q133="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfActivityInformationListItem" nillable="true" type="q134:ArrayOfActivityInformationListItem" xmlns:q134="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ActivityInformationListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q135:Carrier" xmlns:q135="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ActivityInformation" nillable="true" type="q135:ActivitySummary" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ActivityInformationListItem" nillable="true" type="q136:ActivityInformationListItem" xmlns:q136="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetRedLetterInformationListByDatesAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetRedLetterInformationListByDatesAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q137:ArrayOfRedLetterInformationListItem" xmlns:q137="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfRedLetterInformationListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="RedLetterInformationListItem" nillable="true" type="q138:RedLetterInformationListItem" xmlns:q138="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfRedLetterInformationListItem" nillable="true" type="q139:ArrayOfRedLetterInformationListItem" xmlns:q139="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RedLetterInformationListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q140:Carrier" xmlns:q140="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Date" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RedLetterInformation" nillable="true" type="q140:RedLetterSummary" />
              <xs:element minOccurs="0" name="RedLetterDetails" nillable="true" type="q140:RedLetterDetails" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RedLetterInformationListItem" nillable="true" type="q141:RedLetterInformationListItem" xmlns:q141="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="RedLetterDetails">
        <xs:complexContent mixed="false">
          <xs:extension base="q142:Carrier" xmlns:q142="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="OwnCountryDayTexts" nillable="true" type="q143:ArrayOfstring" xmlns:q143="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="OtherCountryDayTexts" nillable="true" type="q144:ArrayOfstring" xmlns:q144="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="RedLetterDetails" nillable="true" type="q145:RedLetterDetails" xmlns:q145="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetAlarms">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeInvitations" type="xs:boolean" />
            <xs:element minOccurs="0" name="IncludeAllAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="DefaultAlarmLeadTimeInMinutes" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAlarmsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q146:MultiAlarmData" xmlns:q146="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="MultiAlarmData">
        <xs:complexContent mixed="false">
          <xs:extension base="q147:Carrier" xmlns:q147="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Alarms" nillable="true" type="q147:ArrayOfAlarmData" />
              <xs:element minOccurs="0" name="PollingInterval" type="xs:int" />
              <xs:element minOccurs="0" name="SilentAfter" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="MultiAlarmData" nillable="true" type="q148:MultiAlarmData" xmlns:q148="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfAlarmData">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="AlarmData" nillable="true" type="q149:AlarmData" xmlns:q149="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfAlarmData" nillable="true" type="q150:ArrayOfAlarmData" xmlns:q150="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="AlarmData">
        <xs:complexContent mixed="false">
          <xs:extension base="q151:Carrier" xmlns:q151="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AlarmTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AppointmentText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Location" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AppointmentType" type="q151:AppointmentType" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q151:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q151:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q151:BookingType" />
              <xs:element minOccurs="0" name="FormalName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactDepartment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ContactFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="JoinVideomeetUrl" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AlarmData" nillable="true" type="q152:AlarmData" xmlns:q152="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetNextAvailableTime">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Associates" nillable="true" type="q153:ArrayOfint" xmlns:q153="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="IsAllDay" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextAvailableTimeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q154:ArrayOfNextAvailableTime" xmlns:q154="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfNextAvailableTime">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="NextAvailableTime" nillable="true" type="q155:NextAvailableTime" xmlns:q155="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfNextAvailableTime" nillable="true" type="q156:ArrayOfNextAvailableTime" xmlns:q156="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="NextAvailableTime">
        <xs:complexContent mixed="false">
          <xs:extension base="q157:Carrier" xmlns:q157="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AvailableTimeStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AvailableTimeEnd" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RecommendedTimeStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RecommendedTimeEnd" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="NextAvailableTime" nillable="true" type="q158:NextAvailableTime" xmlns:q158="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GenerateLead">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIdForNewContact" type="xs:int" />
            <xs:element minOccurs="0" name="LeadDescription" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Relation" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RelationId" type="xs:int" />
            <xs:element minOccurs="0" name="LeadContact" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LeadPersonFirstname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LeadPersonLastname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LeadPersonEmail" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="LeadPhoneNumber" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CreatorsContact" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CreatorsFirstname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CreatorsLastname" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateLeadResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q159:SalesActivity" xmlns:q159="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SalesActivity">
        <xs:complexContent mixed="false">
          <xs:extension base="q160:Carrier" xmlns:q160="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="RequestedContacts" nillable="true" type="q160:ArrayOfContact" />
              <xs:element minOccurs="0" name="RequestedPerson" nillable="true" type="q160:Person" />
              <xs:element minOccurs="0" name="SalesRep" nillable="true" type="q160:Person" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SalesActivity" nillable="true" type="q161:SalesActivity" xmlns:q161="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfContact">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Contact" nillable="true" type="q162:Contact" xmlns:q162="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfContact" nillable="true" type="q163:ArrayOfContact" xmlns:q163="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Contact">
        <xs:complexContent mixed="false">
          <xs:extension base="q164:Carrier" xmlns:q164="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Address" nillable="true" type="q164:Address" />
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
      <xs:element name="Contact" nillable="true" type="q165:Contact" xmlns:q165="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Address">
        <xs:complexContent mixed="false">
          <xs:extension base="q166:Carrier" xmlns:q166="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Wgs84Latitude" type="xs:double" />
              <xs:element minOccurs="0" name="Wgs84Longitude" type="xs:double" />
              <xs:element minOccurs="0" name="LocalizedAddress" nillable="true" type="q166:ArrayOfArrayOfLocalizedField" />
              <xs:element minOccurs="0" name="Street" nillable="true" type="q166:StructuredAddress" />
              <xs:element minOccurs="0" name="Postal" nillable="true" type="q166:StructuredAddress" />
              <xs:element minOccurs="0" name="Formatted" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Address" nillable="true" type="q167:Address" xmlns:q167="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ArrayOfLocalizedField" nillable="true" type="q168:ArrayOfLocalizedField" xmlns:q168="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfArrayOfLocalizedField" nillable="true" type="q169:ArrayOfArrayOfLocalizedField" xmlns:q169="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLocalizedField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="LocalizedField" nillable="true" type="q170:LocalizedField" xmlns:q170="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLocalizedField" nillable="true" type="q171:ArrayOfLocalizedField" xmlns:q171="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="LocalizedField">
        <xs:complexContent mixed="false">
          <xs:extension base="q172:Carrier" xmlns:q172="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="LocalizedField" nillable="true" type="q173:LocalizedField" xmlns:q173="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="StructuredAddress">
        <xs:sequence>
          <xs:element minOccurs="0" name="AtypeIdx" type="q174:AddressType" xmlns:q174="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StructuredAddress" nillable="true" type="q175:StructuredAddress" xmlns:q175="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Person">
        <xs:complexContent mixed="false">
          <xs:extension base="q176:Carrier" xmlns:q176="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Person" nillable="true" type="q177:Person" xmlns:q177="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="RequestForInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIdForNewContact" type="xs:int" />
            <xs:element minOccurs="0" name="Channel" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Regarding" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonFirstname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PersonLastname" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PhoneNumber" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RequestForInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q178:SalesActivity" xmlns:q178="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q179:SuggestedAppointment" xmlns:q179="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SuggestedAppointment">
        <xs:complexContent mixed="false">
          <xs:extension base="q180:Carrier" xmlns:q180="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AutoSuggest" type="xs:short" />
              <xs:element minOccurs="0" name="Deleted" type="xs:short" />
              <xs:element minOccurs="0" name="DaysFuture" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TaskId" type="xs:int" />
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeStageLinkId" type="xs:int" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="ProjectTypeStatusLinkId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Duration" type="xs:short" />
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q180:Associate" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SuggestedAppointment" nillable="true" type="q181:SuggestedAppointment" xmlns:q181="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Associate">
        <xs:complexContent mixed="false">
          <xs:extension base="q182:Carrier" xmlns:q182="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="q182:UserType" />
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
      <xs:element name="Associate" nillable="true" type="q183:Associate" xmlns:q183="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="UserType" nillable="true" type="q184:UserType" xmlns:q184="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetSuggestedAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSuggestedAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q185:SuggestedAppointmentEntity" xmlns:q185="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="SuggestedAppointmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q186:Carrier" xmlns:q186="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="DaysFuture" type="xs:short" />
              <xs:element minOccurs="0" name="Duration" type="ser:duration" />
              <xs:element minOccurs="0" name="AutoSuggest" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsMilestone" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssignToMember" type="xs:boolean" />
              <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectTypeStatusLink" nillable="true" type="q186:ProjectTypeStatusLink" />
              <xs:element minOccurs="0" name="SaleTypeStageLink" nillable="true" type="q186:SaleTypeStageLink" />
              <xs:element minOccurs="0" name="Type" nillable="true" type="q186:Task" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SuggestedAppointmentEntity" nillable="true" type="q187:SuggestedAppointmentEntity" xmlns:q187="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ProjectTypeStatusLink">
        <xs:complexContent mixed="false">
          <xs:extension base="q188:Carrier" xmlns:q188="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProjectTypeStatusLinkId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjTypeTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjStatusId" type="xs:int" />
              <xs:element minOccurs="0" name="ProjStatusName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjStatusTooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProjectTypeStatusLink" nillable="true" type="q189:ProjectTypeStatusLink" xmlns:q189="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="SaleTypeStageLink">
        <xs:complexContent mixed="false">
          <xs:extension base="q190:Carrier" xmlns:q190="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="SaleTypeStageLinkId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleTypeTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProbId" type="xs:int" />
              <xs:element minOccurs="0" name="ProbName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProbTooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Probability" type="xs:short" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="SaleTypeStageLink" nillable="true" type="q191:SaleTypeStageLink" xmlns:q191="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Task">
        <xs:complexContent mixed="false">
          <xs:extension base="q192:Carrier" xmlns:q192="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Task" nillable="true" type="q193:Task" xmlns:q193="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetTaskListItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskListItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q194:TaskListItem" xmlns:q194="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="TaskListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="q195:Carrier" xmlns:q195="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="TaskListItemId" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Direction" type="q195:TaskDirection" />
              <xs:element minOccurs="0" name="Type" type="q195:TaskType" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="IntentId" type="xs:int" />
              <xs:element minOccurs="0" name="Rank" type="xs:short" />
              <xs:element minOccurs="0" name="IsDefaultAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsDefaultPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="q195:ColorIndex" />
              <xs:element minOccurs="0" name="DefaultVideomeetingStatus" type="q195:VideoMeetingStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="TaskListItem" nillable="true" type="q196:TaskListItem" xmlns:q196="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="TaskDirection">
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
      <xs:element name="TaskDirection" nillable="true" type="q197:TaskDirection" xmlns:q197="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="VideoMeetingStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="NoChange" />
          <xs:enumeration value="VideoMeetingOn" />
          <xs:enumeration value="VideoMeetingOff" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="VideoMeetingStatus" nillable="true" type="q198:VideoMeetingStatus" xmlns:q198="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="GetTaskListItems">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IncludeDeleted" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTaskListItemsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q199:ArrayOfTaskListItem" xmlns:q199="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfTaskListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TaskListItem" nillable="true" type="q200:TaskListItem" xmlns:q200="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfTaskListItem" nillable="true" type="q201:ArrayOfTaskListItem" xmlns:q201="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="CreateVideoMeetingReservation">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateVideoMeetingReservationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q202:VideoMeetingReservation" xmlns:q202="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="VideoMeetingReservation">
        <xs:complexContent mixed="false">
          <xs:extension base="q203:Carrier" xmlns:q203="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="VideoMeetingId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="VideoMeetingUrl" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VideoMeetingReservation" nillable="true" type="q204:VideoMeetingReservation" xmlns:q204="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="DeleteVideoMeetingReservation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="VideoMeetingId" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteVideoMeetingReservationResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q205:AppointmentEntity" xmlns:q205="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AppointmentEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q206:Carrier" xmlns:q206="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Associate" nillable="true" type="q206:Associate" />
              <xs:element minOccurs="0" name="Contact" nillable="true" type="q206:Contact" />
              <xs:element minOccurs="0" name="CreatedBy" nillable="true" type="q206:Associate" />
              <xs:element minOccurs="0" name="UpdatedBy" nillable="true" type="q206:Associate" />
              <xs:element minOccurs="0" name="CreatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Agenda" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InternalNotes" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="EndDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="InvitedPerson" nillable="true" type="q206:Person" />
              <xs:element minOccurs="0" name="Person" nillable="true" type="q206:Person" />
              <xs:element minOccurs="0" name="MotherId" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" nillable="true" type="q206:Priority" />
              <xs:element minOccurs="0" name="Private" type="q206:AppointmentPrivate" />
              <xs:element minOccurs="0" name="Project" nillable="true" type="q206:Project" />
              <xs:element minOccurs="0" name="Type" type="q206:AppointmentType" />
              <xs:element minOccurs="0" name="UpdatedDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Completed" type="q206:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveLinks" type="xs:int" />
              <xs:element minOccurs="0" name="Links" nillable="true" type="q206:ArrayOfLink" />
              <xs:element minOccurs="0" name="AlarmLeadTime" type="ser:duration" />
              <xs:element minOccurs="0" name="HasAlarm" type="xs:boolean" />
              <xs:element minOccurs="0" name="ColorIndex" type="xs:short" />
              <xs:element minOccurs="0" name="IsFree" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="LagTime" type="ser:duration" />
              <xs:element minOccurs="0" name="LeadTime" type="ser:duration" />
              <xs:element minOccurs="0" name="Location" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RejectCounter" type="xs:short" />
              <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Recurrence" nillable="true" type="q206:RecurrenceInfo" />
              <xs:element minOccurs="0" name="Participants" nillable="true" type="q206:ArrayOfParticipantInfo" />
              <xs:element minOccurs="0" name="AssignmentStatus" type="q206:AssignmentStatus" />
              <xs:element minOccurs="0" name="InvitationStatus" type="q206:InvitationStatus" />
              <xs:element minOccurs="0" name="BookingType" type="q206:BookingType" />
              <xs:element minOccurs="0" name="ActiveDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasConflict" type="xs:boolean" />
              <xs:element minOccurs="0" name="AssignedBy" nillable="true" type="q206:Associate" />
              <xs:element minOccurs="0" name="MotherAssociate" nillable="true" type="q206:Associate" />
              <xs:element minOccurs="0" name="Task" nillable="true" type="q206:TaskListItem" />
              <xs:element minOccurs="0" name="PreferredTZLocation" type="xs:int" />
              <xs:element minOccurs="0" name="PreferredTZLocationData" nillable="true" type="q206:TimeZoneData" />
              <xs:element minOccurs="0" name="Sale" nillable="true" type="q206:Sale" />
              <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="IsMileStone" type="xs:boolean" />
              <xs:element minOccurs="0" name="CautionWarning" type="q206:AppointmentCautionWarning" />
              <xs:element minOccurs="0" name="OwnedExternally" type="q206:AppointmentExternalOwner" />
              <xs:element minOccurs="0" name="JoinVideomeetUrl" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CentralserviceVideomeetId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UserDefinedFields" nillable="true" type="q206:StringDictionary" />
              <xs:element minOccurs="0" name="ExtraFields" nillable="true" type="q206:StringDictionary" />
              <xs:element minOccurs="0" name="CustomFields" nillable="true" type="q206:StringDictionary" />
              <xs:element minOccurs="0" name="PublishEventDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="PublishFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsPublished" type="xs:boolean" />
              <xs:element minOccurs="0" name="VisibleFor" nillable="true" type="q206:ArrayOfVisibleFor" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentEntity" nillable="true" type="q207:AppointmentEntity" xmlns:q207="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Priority">
        <xs:complexContent mixed="false">
          <xs:extension base="q208:Carrier" xmlns:q208="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Id" type="xs:int" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Priority" nillable="true" type="q209:Priority" xmlns:q209="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Project">
        <xs:complexContent mixed="false">
          <xs:extension base="q210:Carrier" xmlns:q210="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Project" nillable="true" type="q211:Project" xmlns:q211="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfLink">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Link" nillable="true" type="q212:Link" xmlns:q212="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfLink" nillable="true" type="q213:ArrayOfLink" xmlns:q213="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Link">
        <xs:complexContent mixed="false">
          <xs:extension base="q214:Carrier" xmlns:q214="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="Link" nillable="true" type="q215:Link" xmlns:q215="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ParticipantInfo" nillable="true" type="q216:ParticipantInfo" xmlns:q216="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfParticipantInfo" nillable="true" type="q217:ArrayOfParticipantInfo" xmlns:q217="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ParticipantInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          <xs:element minOccurs="0" name="PersonId" type="xs:int" />
          <xs:element minOccurs="0" name="ContactId" type="xs:int" />
          <xs:element minOccurs="0" name="EmailId" type="xs:int" />
          <xs:element minOccurs="0" name="SendEmail" type="xs:boolean" />
          <xs:element minOccurs="0" name="InvitationStatus" type="q218:InvitationStatus" xmlns:q218="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ParticipantInfo" nillable="true" type="q219:ParticipantInfo" xmlns:q219="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneData">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZLocationID" type="xs:int" />
          <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCode" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="TZLocationCities" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="IsoNumber" type="xs:int" />
          <xs:element minOccurs="0" name="TimeZoneSTDRules" nillable="true" type="q220:TimeZoneRuleDictionary" xmlns:q220="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          <xs:element minOccurs="0" name="TimeZoneDSTRules" nillable="true" type="q221:TimeZoneRuleDictionary" xmlns:q221="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneData" nillable="true" type="q222:TimeZoneData" xmlns:q222="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneRuleDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="TimeZoneRuleKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" type="xs:dateTime" />
                <xs:element name="Value" nillable="true" type="q223:TimeZoneRule" xmlns:q223="http://www.superoffice.net/ws/crm/NetServer/Services88" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRuleDictionary" nillable="true" type="q224:TimeZoneRuleDictionary" xmlns:q224="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="TimeZoneRule">
        <xs:sequence>
          <xs:element minOccurs="0" name="TZOffset" type="xs:int" />
          <xs:element minOccurs="0" name="StartRulePattern" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="EndRulePattern" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StartDay" type="xs:int" />
          <xs:element minOccurs="0" name="StartMonth" type="xs:int" />
          <xs:element minOccurs="0" name="EndDay" type="xs:int" />
          <xs:element minOccurs="0" name="EndMonth" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TimeZoneRule" nillable="true" type="q225:TimeZoneRule" xmlns:q225="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="q226:Carrier" xmlns:q226="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
              <xs:element minOccurs="0" name="Status" type="q226:SaleStatus" />
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
              <xs:element minOccurs="0" name="Completed" type="q226:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="q227:Sale" xmlns:q227="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="SaleStatus" nillable="true" type="q228:SaleStatus" xmlns:q228="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="StringDictionary" nillable="true" type="q229:StringDictionary" xmlns:q229="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfVisibleFor">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="VisibleFor" nillable="true" type="q230:VisibleFor" xmlns:q230="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfVisibleFor" nillable="true" type="q231:ArrayOfVisibleFor" xmlns:q231="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="VisibleFor">
        <xs:complexContent mixed="false">
          <xs:extension base="q232:Carrier" xmlns:q232="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="VisibleId" type="xs:int" />
              <xs:element minOccurs="0" name="Visibility" type="q232:Visibility" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="VisibleFor" nillable="true" type="q233:VisibleFor" xmlns:q233="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="Visibility">
        <xs:restriction base="xs:string">
          <xs:enumeration value="All" />
          <xs:enumeration value="Associate" />
          <xs:enumeration value="Group" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="Visibility" nillable="true" type="q234:Visibility" xmlns:q234="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q235:AppointmentEntity" xmlns:q235="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q236:AppointmentEntity" xmlns:q236="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSuggestedAppointmentEntity">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultSuggestedAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q237:SuggestedAppointmentEntity" xmlns:q237="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSuggestedAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentEntity" nillable="true" type="q238:SuggestedAppointmentEntity" xmlns:q238="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveSuggestedAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q239:SuggestedAppointmentEntity" xmlns:q239="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTaskListItem">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultTaskListItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q240:TaskListItem" xmlns:q240="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTaskListItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TaskListItem" nillable="true" type="q241:TaskListItem" xmlns:q241="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveTaskListItemResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q242:TaskListItem" xmlns:q242="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q243:Appointment" xmlns:q243="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleAppointmentStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleAppointmentStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q244:AppointmentStatus" xmlns:q244="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActivity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityIdentifier" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActivityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q245:ActivityStatus" xmlns:q245="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActivities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityIdentifier" nillable="true" type="q246:ArrayOfstring" xmlns:q246="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleActivitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="q247:ActivityStatus" xmlns:q247="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActivityStatus">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityIdentifier" nillable="true" type="q248:ArrayOfstring" xmlns:q248="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="ActivityStatus" type="q249:ActivityStatus" xmlns:q249="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetActivityStatusResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleAndSetActivities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ActivityIdentifiers" nillable="true" type="q250:ArrayOfstring" xmlns:q250="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleAndSetActivitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q251:ArrayOfstring" xmlns:q251="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntityId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q252:AppointmentEntity" xmlns:q252="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" type="q253:TaskType" xmlns:q253="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q254:AppointmentEntity" xmlns:q254="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAppointmentEntityFromExisting">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAppointmentEntityFromExistingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q255:AppointmentEntity" xmlns:q255="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Accept">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q256:RecurrenceUpdateMode" xmlns:q256="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndAccept">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailItemId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q257:RecurrenceUpdateMode" xmlns:q257="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndAcceptResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptWithEmailConfirmation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q258:RecurrenceUpdateMode" xmlns:q258="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptWithEmailConfirmationResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndAcceptWithEmailConfirmation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailItemId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q259:RecurrenceUpdateMode" xmlns:q259="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndAcceptWithEmailConfirmationResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Reject">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UpdateMode" type="q260:RecurrenceUpdateMode" xmlns:q260="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectWithEmailConfirmation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UpdateMode" type="q261:RecurrenceUpdateMode" xmlns:q261="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectWithEmailConfirmationResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="DeclineInvitationFromEmailItem">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailItemId" type="xs:int" />
            <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeclineInvitationFromEmailItemResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOrganizerName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="MotherAppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOrganizerNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Save">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q262:AppointmentEntity" xmlns:q262="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="UpdateMode" type="q263:RecurrenceUpdateMode" xmlns:q263="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="SendEmailToParticipants" type="xs:boolean" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q264:EMailConnectionInfo" xmlns:q264="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ImapEMailConnectionInfo" nillable="true" type="q265:EMailConnectionInfo" xmlns:q265="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q266:AppointmentEntity" xmlns:q266="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="Delete">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q267:RecurrenceUpdateMode" xmlns:q267="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="SendEmailToParticipants" type="xs:boolean" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q268:EMailConnectionInfo" xmlns:q268="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ImapEMailConnectionInfo" nillable="true" type="q269:EMailConnectionInfo" xmlns:q269="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CalculateDays">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q270:AppointmentEntity" xmlns:q270="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CalculateDaysResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q271:RecurrenceInfo" xmlns:q271="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateDays">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q272:AppointmentEntity" xmlns:q272="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="Dates" nillable="true" type="q273:ArrayOfdateTime" xmlns:q273="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateDaysResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q274:ArrayOfRecurrenceDate" xmlns:q274="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRecurrence">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRecurrenceResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q275:RecurrenceInfo" xmlns:q275="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AssignTo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="Participant" nillable="true" type="q276:ParticipantInfo" xmlns:q276="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="UpdateMode" type="q277:RecurrenceUpdateMode" xmlns:q277="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AssignToResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q278:AppointmentEntity" xmlns:q278="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSeen">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q279:RecurrenceUpdateMode" xmlns:q279="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSeenResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSeenMany">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentIds" nillable="true" type="q280:ArrayOfint" xmlns:q280="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="UpdateMode" type="q281:RecurrenceUpdateMode" xmlns:q281="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SetSeenManyResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="Move">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="NewStartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="UpdateMode" type="q282:RecurrenceUpdateMode" xmlns:q282="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q283:AppointmentEntity" xmlns:q283="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveWithEmail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="NewStartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="UpdateMode" type="q284:RecurrenceUpdateMode" xmlns:q284="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="SendEmailToParticipants" type="xs:boolean" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q285:EMailConnectionInfo" xmlns:q285="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ImapEMailConnectionInfo" nillable="true" type="q286:EMailConnectionInfo" xmlns:q286="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveWithEmailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q287:AppointmentEntity" xmlns:q287="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveExtended">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentMoveData" nillable="true" type="q288:AppointmentMoveData" xmlns:q288="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AppointmentMoveData">
        <xs:complexContent mixed="false">
          <xs:extension base="q289:Carrier" xmlns:q289="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
              <xs:element minOccurs="0" name="NewStartTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdateMode" type="q289:RecurrenceUpdateMode" />
              <xs:element minOccurs="0" name="SendEmailToParticipants" type="xs:boolean" />
              <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q289:EMailConnectionInfo" />
              <xs:element minOccurs="0" name="ImapEMailConnectionInfo" nillable="true" type="q289:EMailConnectionInfo" />
              <xs:element minOccurs="0" name="IsAlldayEvent" type="xs:boolean" />
              <xs:element minOccurs="0" name="IsFree" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentMoveData" nillable="true" type="q290:AppointmentMoveData" xmlns:q290="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="MoveExtendedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q291:AppointmentEntity" xmlns:q291="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptRejected">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q292:RecurrenceUpdateMode" xmlns:q292="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptRejectedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q293:AppointmentEntity" xmlns:q293="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRecurrenceByDate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartDate" type="xs:dateTime" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultRecurrenceByDateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q294:RecurrenceInfo" xmlns:q294="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanUpBookingDeleted">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentIds" nillable="true" type="q295:ArrayOfint" xmlns:q295="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanUpBookingDeletedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanUpBookingDeletedWithUpdateMode">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentIds" nillable="true" type="q296:ArrayOfint" xmlns:q296="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            <xs:element minOccurs="0" name="UpdateMode" type="q297:RecurrenceUpdateMode" xmlns:q297="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanUpBookingDeletedWithUpdateModeResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanUpRecurringBookingDeleted">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CleanUpRecurringBookingDeletedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityByTypeAndAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Type" type="q298:TaskType" xmlns:q298="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q299:AppointmentEntity" xmlns:q299="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCanInsertForAssociates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateIds" nillable="true" type="q300:ArrayOfint" xmlns:q300="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetCanInsertForAssociatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q301:ArrayOfboolean" xmlns:q301="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentHaveParticipantsWithEmail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentHaveParticipantsWithEmailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityFromSaleSuggestion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="CreateNow" type="xs:boolean" />
            <xs:element minOccurs="0" name="OwnerId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q302:AppointmentEntity" xmlns:q302="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextSuggestedAppointmentBySale">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="CurrentAppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="SkipCompleteCheck" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetNextSuggestedAppointmentBySaleResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q303:SuggestedAppointment" xmlns:q303="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultReOpenAppointment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultReOpenAppointmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q304:AppointmentEntity" xmlns:q304="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityFromProjectSuggestion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="CreateNow" type="xs:boolean" />
            <xs:element minOccurs="0" name="OwnerId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q305:AppointmentEntity" xmlns:q305="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAppointmentForUID">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q306:AppointmentEntity" xmlns:q306="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="UID" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAppointmentForUIDResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q307:AppointmentEntity" xmlns:q307="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentFromUID">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="UID" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentFromUIDResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q308:AppointmentEntity" xmlns:q308="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanAssignToProjectMember">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="SuggestedAppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanAssignToProjectMemberResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUIDFromAppointmentId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UseMotherId" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetUIDFromAppointmentIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateAppointmentFromIcsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EmailAddress" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IcsData" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="UpdateAppointmentFromIcsResponseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateAppointmentEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q309:AppointmentEntity" xmlns:q309="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateAppointmentEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q310:StringDictionary" xmlns:q310="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="WillSendEmail">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Appointment" nillable="true" type="q311:AppointmentEntity" xmlns:q311="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="WillSendEmailResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptWithSmtpEmailConfirmation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="UpdateMode" type="q312:RecurrenceUpdateMode" xmlns:q312="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q313:EMailConnectionInfo" xmlns:q313="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AcceptWithSmtpEmailConfirmationResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectWithSmtpEmailConfirmation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
            <xs:element minOccurs="0" name="RejectReason" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UpdateMode" type="q314:RecurrenceUpdateMode" xmlns:q314="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q315:EMailConnectionInfo" xmlns:q315="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectWithSmtpEmailConfirmationResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentEmailInvitation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Appointment" nillable="true" type="q316:AppointmentEntity" xmlns:q316="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="TemplateName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Language" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentEmailInvitationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q317:EMailEntity" xmlns:q317="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="EMailEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="q318:Carrier" xmlns:q318="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="To" nillable="true" type="q318:ArrayOfEMailAddress" />
              <xs:element minOccurs="0" name="Cc" nillable="true" type="q318:ArrayOfEMailAddress" />
              <xs:element minOccurs="0" name="Bcc" nillable="true" type="q318:ArrayOfEMailAddress" />
              <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="HTMLBody" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="From" nillable="true" type="q318:EMailAddress" />
              <xs:element minOccurs="0" name="Sent" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Size" type="xs:int" />
              <xs:element minOccurs="0" name="Priority" type="q318:EMailPriority" />
              <xs:element minOccurs="0" name="Flags" type="q318:EMailFlags" />
              <xs:element minOccurs="0" name="MessageID" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PlainBody" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsSent" type="xs:boolean" />
              <xs:element minOccurs="0" name="EMailSOInfo" nillable="true" type="q318:EMailSOInfo" />
              <xs:element minOccurs="0" name="ServerId" type="xs:int" />
              <xs:element minOccurs="0" name="Attachments" nillable="true" type="q318:ArrayOfEMailAttachment" />
              <xs:element minOccurs="0" name="CustomHeaderList" nillable="true" type="q318:ArrayOfEMailCustomHeader" />
              <xs:element minOccurs="0" name="FolderName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailItemId" type="xs:int" />
              <xs:element minOccurs="0" name="AccountId" type="xs:int" />
              <xs:element minOccurs="0" name="ReceivedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="InReplyTo" nillable="true" type="q318:EMailEnvelope" />
              <xs:element minOccurs="0" name="RepliedAt" type="xs:dateTime" />
              <xs:element minOccurs="0" name="HasCalendarData" type="xs:boolean" />
              <xs:element minOccurs="0" name="CalMethod" type="q318:CalMethod" />
              <xs:element minOccurs="0" name="CalReplyStatus" type="q318:CalReplyStatus" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailEntity" nillable="true" type="q319:EMailEntity" xmlns:q319="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfEMailAddress">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailAddress" nillable="true" type="q320:EMailAddress" xmlns:q320="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailAddress" nillable="true" type="q321:ArrayOfEMailAddress" xmlns:q321="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailAddress">
        <xs:complexContent mixed="false">
          <xs:extension base="q322:Carrier" xmlns:q322="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Address" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="EmailId" type="xs:int" />
              <xs:element minOccurs="0" name="DuplicatePersonIds" nillable="true" type="q323:ArrayOfint" xmlns:q323="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailAddress" nillable="true" type="q324:EMailAddress" xmlns:q324="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="EMailPriority" nillable="true" type="q325:EMailPriority" xmlns:q325="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="EMailFlags" nillable="true" type="q326:EMailFlags" xmlns:q326="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailSOInfo">
        <xs:complexContent mixed="false">
          <xs:extension base="q327:Carrier" xmlns:q327="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="EMailSOInfo" nillable="true" type="q328:EMailSOInfo" xmlns:q328="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfEMailAttachment">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailAttachment" nillable="true" type="q329:EMailAttachment" xmlns:q329="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailAttachment" nillable="true" type="q330:ArrayOfEMailAttachment" xmlns:q330="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailAttachment">
        <xs:complexContent mixed="false">
          <xs:extension base="q331:Carrier" xmlns:q331="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
      <xs:element name="EMailAttachment" nillable="true" type="q332:EMailAttachment" xmlns:q332="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="ArrayOfEMailCustomHeader">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="EMailCustomHeader" nillable="true" type="q333:EMailCustomHeader" xmlns:q333="http://www.superoffice.net/ws/crm/NetServer/Services88" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfEMailCustomHeader" nillable="true" type="q334:ArrayOfEMailCustomHeader" xmlns:q334="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailCustomHeader">
        <xs:complexContent mixed="false">
          <xs:extension base="q335:Carrier" xmlns:q335="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Values" nillable="true" type="q336:ArrayOfstring" xmlns:q336="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailCustomHeader" nillable="true" type="q337:EMailCustomHeader" xmlns:q337="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:complexType name="EMailEnvelope">
        <xs:complexContent mixed="false">
          <xs:extension base="q338:Carrier" xmlns:q338="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="ServerId" type="xs:int" />
              <xs:element minOccurs="0" name="MessageId" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="From" nillable="true" type="q338:EMailAddress" />
              <xs:element minOccurs="0" name="To" nillable="true" type="q338:ArrayOfEMailAddress" />
              <xs:element minOccurs="0" name="Sent" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Priority" type="q338:EMailPriority" />
              <xs:element minOccurs="0" name="Flags" type="q338:EMailFlags" />
              <xs:element minOccurs="0" name="Size" type="xs:int" />
              <xs:element minOccurs="0" name="EMailSOInfo" nillable="true" type="q338:EMailSOInfo" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="EMailEnvelope" nillable="true" type="q339:EMailEnvelope" xmlns:q339="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:element name="CalMethod" nillable="true" type="q340:CalMethod" xmlns:q340="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:simpleType name="CalReplyStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Accepted" />
          <xs:enumeration value="Declined" />
          <xs:enumeration value="Tentative" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="CalReplyStatus" nillable="true" type="q341:CalReplyStatus" xmlns:q341="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="SaveWithCustomInvitation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q342:AppointmentEntity" xmlns:q342="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="UpdateMode" type="q343:RecurrenceUpdateMode" xmlns:q343="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="SendEmailToParticipants" type="xs:boolean" />
            <xs:element minOccurs="0" name="SmtpEMailConnectionInfo" nillable="true" type="q344:EMailConnectionInfo" xmlns:q344="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="ImapEMailConnectionInfo" nillable="true" type="q345:EMailConnectionInfo" xmlns:q345="http://www.superoffice.net/ws/crm/NetServer/Services88" />
            <xs:element minOccurs="0" name="EmailBody" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TemplateLanguage" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveWithCustomInvitationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q346:AppointmentSaveData" xmlns:q346="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="AppointmentSaveData">
        <xs:complexContent mixed="false">
          <xs:extension base="q347:Carrier" xmlns:q347="http://www.superoffice.net/ws/crm/NetServer/Services88">
            <xs:sequence>
              <xs:element minOccurs="0" name="AppointmentEntity" nillable="true" type="q347:AppointmentEntity" />
              <xs:element minOccurs="0" name="EmailCreated" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="AppointmentSaveData" nillable="true" type="q348:AppointmentSaveData" xmlns:q348="http://www.superoffice.net/ws/crm/NetServer/Services88" />
      <xs:element name="ConvertAppointmentToTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ConvertAppointmentToTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q349:AppointmentEntity" xmlns:q349="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AppointmentIds" nillable="true" type="q350:ArrayOfint" xmlns:q350="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAppointmentListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q351:ArrayOfAppointment" xmlns:q351="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q352:ArrayOfAppointment" xmlns:q352="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q353:ArrayOfAppointment" xmlns:q353="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyDiary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyDiaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q354:ArrayOfAppointment" xmlns:q354="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetMyTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q355:ArrayOfAppointment" xmlns:q355="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDiary">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonDiaryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q356:ArrayOfAppointment" xmlns:q356="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q357:ArrayOfAppointment" xmlns:q357="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentType" type="q358:AppointmentType" xmlns:q358="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q359:ArrayOfAppointment" xmlns:q359="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q360:ArrayOfAppointment" xmlns:q360="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentType" type="q361:AppointmentType" xmlns:q361="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q362:ArrayOfAppointment" xmlns:q362="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q363:ArrayOfAppointment" xmlns:q363="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentType" type="q364:AppointmentType" xmlns:q364="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q365:ArrayOfAppointment" xmlns:q365="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q366:ArrayOfAppointment" xmlns:q366="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByType">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="AppointmentType" type="q367:AppointmentType" xmlns:q367="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTypeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q368:ArrayOfAppointment" xmlns:q368="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q369:ArrayOfAppointment" xmlns:q369="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q370:ArrayOfint" xmlns:q370="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q371:ArrayOfAppointment" xmlns:q371="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeProjectAppointments" type="xs:boolean" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPersonAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q372:ArrayOfAppointment" xmlns:q372="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q373:ArrayOfAppointment" xmlns:q373="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q374:ArrayOfint" xmlns:q374="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q375:ArrayOfAppointment" xmlns:q375="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q376:ArrayOfAppointment" xmlns:q376="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q377:ArrayOfAppointment" xmlns:q377="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q378:ArrayOfint" xmlns:q378="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q379:ArrayOfAppointment" xmlns:q379="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PersonId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProjectMemberAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q380:ArrayOfAppointment" xmlns:q380="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTask">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTaskResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q381:ArrayOfAppointment" xmlns:q381="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTasks">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskIds" nillable="true" type="q382:ArrayOfint" xmlns:q382="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTasksResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q383:ArrayOfAppointment" xmlns:q383="http://www.superoffice.net/ws/crm/NetServer/Services88" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTaskHeading">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="StartTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="EndTime" type="xs:dateTime" />
            <xs:element minOccurs="0" name="Count" type="xs:int" />
            <xs:element minOccurs="0" name="TaskHeadingId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetContactAppointmentsByTaskHeadingResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q384:ArrayOfAppointment" xmlns:q384="http://www.superoffice.net/ws/crm/NetServer/Services88" />
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
      <xs:complexType name="ArrayOfdateTime">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="dateTime" type="xs:dateTime" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfdateTime" nillable="true" type="tns:ArrayOfdateTime" />
      <xs:complexType name="ArrayOfboolean">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="boolean" type="xs:boolean" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfboolean" nillable="true" type="tns:ArrayOfboolean" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="GetPublishedAppointmentRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedAppointment" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedAppointments" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetMyPublishedAppointments" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetMyPublishedAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyPublishedAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectAppointments" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetPublishedProjectAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPublishedProjectAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateDiaryRequest">
    <wsdl:part name="parameters" element="tns:GetAssociateDiary" />
  </wsdl:message>
  <wsdl:message name="GetAssociateDiaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociateDiaryResponse">
    <wsdl:part name="parameters" element="tns:GetAssociateDiaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociateDiaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDiaryByGroupRequest">
    <wsdl:part name="parameters" element="tns:GetDiaryByGroup" />
  </wsdl:message>
  <wsdl:message name="GetDiaryByGroupRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDiaryByGroupResponse">
    <wsdl:part name="parameters" element="tns:GetDiaryByGroupResponse" />
  </wsdl:message>
  <wsdl:message name="GetDiaryByGroupResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentRequest">
    <wsdl:part name="parameters" element="tns:UpdateAppointment" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentResponse">
    <wsdl:part name="parameters" element="tns:UpdateAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentWithModeRequest">
    <wsdl:part name="parameters" element="tns:UpdateAppointmentWithMode" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentWithModeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentWithModeResponse">
    <wsdl:part name="parameters" element="tns:UpdateAppointmentWithModeResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentWithModeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentWithModeAndEmailRequest">
    <wsdl:part name="parameters" element="tns:UpdateAppointmentWithModeAndEmail" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentWithModeAndEmailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentWithModeAndEmailResponse">
    <wsdl:part name="parameters" element="tns:UpdateAppointmentWithModeAndEmailResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentWithModeAndEmailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryRequest">
    <wsdl:part name="parameters" element="tns:GetAssociatesDiary" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryResponse">
    <wsdl:part name="parameters" element="tns:GetAssociatesDiaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryInfoRequest">
    <wsdl:part name="parameters" element="tns:GetAssociatesDiaryInfo" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryInfoResponse">
    <wsdl:part name="parameters" element="tns:GetAssociatesDiaryInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetAssociatesDiaryInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRecordsRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentRecords" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRecordsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRecordsResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentRecordsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRecordsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMySyncAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetMySyncAppointments" />
  </wsdl:message>
  <wsdl:message name="GetMySyncAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMySyncAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetMySyncAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMySyncAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDayInformationListByDatesAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetDayInformationListByDatesAndAssociate" />
  </wsdl:message>
  <wsdl:message name="GetDayInformationListByDatesAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetDayInformationListByDatesAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetDayInformationListByDatesAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetDayInformationListByDatesAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivityInformationListByDatesAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetActivityInformationListByDatesAndAssociate" />
  </wsdl:message>
  <wsdl:message name="GetActivityInformationListByDatesAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivityInformationListByDatesAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetActivityInformationListByDatesAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetActivityInformationListByDatesAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRedLetterInformationListByDatesAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetRedLetterInformationListByDatesAndAssociate" />
  </wsdl:message>
  <wsdl:message name="GetRedLetterInformationListByDatesAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetRedLetterInformationListByDatesAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetRedLetterInformationListByDatesAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetRedLetterInformationListByDatesAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAlarmsRequest">
    <wsdl:part name="parameters" element="tns:GetAlarms" />
  </wsdl:message>
  <wsdl:message name="GetAlarmsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAlarmsResponse">
    <wsdl:part name="parameters" element="tns:GetAlarmsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAlarmsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextAvailableTimeRequest">
    <wsdl:part name="parameters" element="tns:GetNextAvailableTime" />
  </wsdl:message>
  <wsdl:message name="GetNextAvailableTimeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextAvailableTimeResponse">
    <wsdl:part name="parameters" element="tns:GetNextAvailableTimeResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextAvailableTimeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateLeadRequest">
    <wsdl:part name="parameters" element="tns:GenerateLead" />
  </wsdl:message>
  <wsdl:message name="GenerateLeadRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateLeadResponse">
    <wsdl:part name="parameters" element="tns:GenerateLeadResponse" />
  </wsdl:message>
  <wsdl:message name="GenerateLeadResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RequestForInfoRequest">
    <wsdl:part name="parameters" element="tns:RequestForInfo" />
  </wsdl:message>
  <wsdl:message name="RequestForInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RequestForInfoResponse">
    <wsdl:part name="parameters" element="tns:RequestForInfoResponse" />
  </wsdl:message>
  <wsdl:message name="RequestForInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentRequest">
    <wsdl:part name="parameters" element="tns:GetSuggestedAppointment" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentResponse">
    <wsdl:part name="parameters" element="tns:GetSuggestedAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:GetSuggestedAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:GetSuggestedAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetSuggestedAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemRequest">
    <wsdl:part name="parameters" element="tns:GetTaskListItem" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemResponse">
    <wsdl:part name="parameters" element="tns:GetTaskListItemResponse" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemsRequest">
    <wsdl:part name="parameters" element="tns:GetTaskListItems" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemsResponse">
    <wsdl:part name="parameters" element="tns:GetTaskListItemsResponse" />
  </wsdl:message>
  <wsdl:message name="GetTaskListItemsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateVideoMeetingReservationRequest">
    <wsdl:part name="parameters" element="tns:CreateVideoMeetingReservation" />
  </wsdl:message>
  <wsdl:message name="CreateVideoMeetingReservationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateVideoMeetingReservationResponse">
    <wsdl:part name="parameters" element="tns:CreateVideoMeetingReservationResponse" />
  </wsdl:message>
  <wsdl:message name="CreateVideoMeetingReservationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteVideoMeetingReservationRequest">
    <wsdl:part name="parameters" element="tns:DeleteVideoMeetingReservation" />
  </wsdl:message>
  <wsdl:message name="DeleteVideoMeetingReservationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteVideoMeetingReservationResponse">
    <wsdl:part name="parameters" element="tns:DeleteVideoMeetingReservationResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteVideoMeetingReservationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="SaveAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:DeleteAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="DeleteAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:DeleteAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultSuggestedAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultSuggestedAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultSuggestedAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveSuggestedAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveSuggestedAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveSuggestedAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTaskListItemRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultTaskListItem" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTaskListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTaskListItemResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultTaskListItemResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultTaskListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTaskListItemRequest">
    <wsdl:part name="parameters" element="tns:SaveTaskListItem" />
  </wsdl:message>
  <wsdl:message name="SaveTaskListItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveTaskListItemResponse">
    <wsdl:part name="parameters" element="tns:SaveTaskListItemResponse" />
  </wsdl:message>
  <wsdl:message name="SaveTaskListItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRequest">
    <wsdl:part name="parameters" element="tns:GetAppointment" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleAppointmentStatusRequest">
    <wsdl:part name="parameters" element="tns:ToggleAppointmentStatus" />
  </wsdl:message>
  <wsdl:message name="ToggleAppointmentStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleAppointmentStatusResponse">
    <wsdl:part name="parameters" element="tns:ToggleAppointmentStatusResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleAppointmentStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActivityRequest">
    <wsdl:part name="parameters" element="tns:ToggleActivity" />
  </wsdl:message>
  <wsdl:message name="ToggleActivityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActivityResponse">
    <wsdl:part name="parameters" element="tns:ToggleActivityResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleActivityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActivitiesRequest">
    <wsdl:part name="parameters" element="tns:ToggleActivities" />
  </wsdl:message>
  <wsdl:message name="ToggleActivitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleActivitiesResponse">
    <wsdl:part name="parameters" element="tns:ToggleActivitiesResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleActivitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActivityStatusRequest">
    <wsdl:part name="parameters" element="tns:SetActivityStatus" />
  </wsdl:message>
  <wsdl:message name="SetActivityStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetActivityStatusResponse">
    <wsdl:part name="parameters" element="tns:SetActivityStatusResponse" />
  </wsdl:message>
  <wsdl:message name="SetActivityStatusResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleAndSetActivitiesRequest">
    <wsdl:part name="parameters" element="tns:ToggleAndSetActivities" />
  </wsdl:message>
  <wsdl:message name="ToggleAndSetActivitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleAndSetActivitiesResponse">
    <wsdl:part name="parameters" element="tns:ToggleAndSetActivitiesResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleAndSetActivitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityByType" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAppointmentEntityFromExistingRequest">
    <wsdl:part name="parameters" element="tns:CreateAppointmentEntityFromExisting" />
  </wsdl:message>
  <wsdl:message name="CreateAppointmentEntityFromExistingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAppointmentEntityFromExistingResponse">
    <wsdl:part name="parameters" element="tns:CreateAppointmentEntityFromExistingResponse" />
  </wsdl:message>
  <wsdl:message name="CreateAppointmentEntityFromExistingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptRequest">
    <wsdl:part name="parameters" element="tns:Accept" />
  </wsdl:message>
  <wsdl:message name="AcceptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptResponse">
    <wsdl:part name="parameters" element="tns:AcceptResponse" />
  </wsdl:message>
  <wsdl:message name="AcceptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndAcceptRequest">
    <wsdl:part name="parameters" element="tns:CreateAndAccept" />
  </wsdl:message>
  <wsdl:message name="CreateAndAcceptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndAcceptResponse">
    <wsdl:part name="parameters" element="tns:CreateAndAcceptResponse" />
  </wsdl:message>
  <wsdl:message name="CreateAndAcceptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptWithEmailConfirmationRequest">
    <wsdl:part name="parameters" element="tns:AcceptWithEmailConfirmation" />
  </wsdl:message>
  <wsdl:message name="AcceptWithEmailConfirmationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptWithEmailConfirmationResponse">
    <wsdl:part name="parameters" element="tns:AcceptWithEmailConfirmationResponse" />
  </wsdl:message>
  <wsdl:message name="AcceptWithEmailConfirmationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndAcceptWithEmailConfirmationRequest">
    <wsdl:part name="parameters" element="tns:CreateAndAcceptWithEmailConfirmation" />
  </wsdl:message>
  <wsdl:message name="CreateAndAcceptWithEmailConfirmationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndAcceptWithEmailConfirmationResponse">
    <wsdl:part name="parameters" element="tns:CreateAndAcceptWithEmailConfirmationResponse" />
  </wsdl:message>
  <wsdl:message name="CreateAndAcceptWithEmailConfirmationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectRequest">
    <wsdl:part name="parameters" element="tns:Reject" />
  </wsdl:message>
  <wsdl:message name="RejectRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectResponse">
    <wsdl:part name="parameters" element="tns:RejectResponse" />
  </wsdl:message>
  <wsdl:message name="RejectResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectWithEmailConfirmationRequest">
    <wsdl:part name="parameters" element="tns:RejectWithEmailConfirmation" />
  </wsdl:message>
  <wsdl:message name="RejectWithEmailConfirmationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectWithEmailConfirmationResponse">
    <wsdl:part name="parameters" element="tns:RejectWithEmailConfirmationResponse" />
  </wsdl:message>
  <wsdl:message name="RejectWithEmailConfirmationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeclineInvitationFromEmailItemRequest">
    <wsdl:part name="parameters" element="tns:DeclineInvitationFromEmailItem" />
  </wsdl:message>
  <wsdl:message name="DeclineInvitationFromEmailItemRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeclineInvitationFromEmailItemResponse">
    <wsdl:part name="parameters" element="tns:DeclineInvitationFromEmailItemResponse" />
  </wsdl:message>
  <wsdl:message name="DeclineInvitationFromEmailItemResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOrganizerNameRequest">
    <wsdl:part name="parameters" element="tns:GetOrganizerName" />
  </wsdl:message>
  <wsdl:message name="GetOrganizerNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOrganizerNameResponse">
    <wsdl:part name="parameters" element="tns:GetOrganizerNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetOrganizerNameResponse_Headers">
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
  <wsdl:message name="CalculateDaysRequest">
    <wsdl:part name="parameters" element="tns:CalculateDays" />
  </wsdl:message>
  <wsdl:message name="CalculateDaysRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CalculateDaysResponse">
    <wsdl:part name="parameters" element="tns:CalculateDaysResponse" />
  </wsdl:message>
  <wsdl:message name="CalculateDaysResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateDaysRequest">
    <wsdl:part name="parameters" element="tns:ValidateDays" />
  </wsdl:message>
  <wsdl:message name="ValidateDaysRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateDaysResponse">
    <wsdl:part name="parameters" element="tns:ValidateDaysResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateDaysResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultRecurrence" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultRecurrenceResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AssignToRequest">
    <wsdl:part name="parameters" element="tns:AssignTo" />
  </wsdl:message>
  <wsdl:message name="AssignToRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AssignToResponse">
    <wsdl:part name="parameters" element="tns:AssignToResponse" />
  </wsdl:message>
  <wsdl:message name="AssignToResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSeenRequest">
    <wsdl:part name="parameters" element="tns:SetSeen" />
  </wsdl:message>
  <wsdl:message name="SetSeenRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSeenResponse">
    <wsdl:part name="parameters" element="tns:SetSeenResponse" />
  </wsdl:message>
  <wsdl:message name="SetSeenResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSeenManyRequest">
    <wsdl:part name="parameters" element="tns:SetSeenMany" />
  </wsdl:message>
  <wsdl:message name="SetSeenManyRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SetSeenManyResponse">
    <wsdl:part name="parameters" element="tns:SetSeenManyResponse" />
  </wsdl:message>
  <wsdl:message name="SetSeenManyResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveRequest">
    <wsdl:part name="parameters" element="tns:Move" />
  </wsdl:message>
  <wsdl:message name="MoveRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveResponse">
    <wsdl:part name="parameters" element="tns:MoveResponse" />
  </wsdl:message>
  <wsdl:message name="MoveResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveWithEmailRequest">
    <wsdl:part name="parameters" element="tns:MoveWithEmail" />
  </wsdl:message>
  <wsdl:message name="MoveWithEmailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveWithEmailResponse">
    <wsdl:part name="parameters" element="tns:MoveWithEmailResponse" />
  </wsdl:message>
  <wsdl:message name="MoveWithEmailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveExtendedRequest">
    <wsdl:part name="parameters" element="tns:MoveExtended" />
  </wsdl:message>
  <wsdl:message name="MoveExtendedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveExtendedResponse">
    <wsdl:part name="parameters" element="tns:MoveExtendedResponse" />
  </wsdl:message>
  <wsdl:message name="MoveExtendedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptRejectedRequest">
    <wsdl:part name="parameters" element="tns:AcceptRejected" />
  </wsdl:message>
  <wsdl:message name="AcceptRejectedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptRejectedResponse">
    <wsdl:part name="parameters" element="tns:AcceptRejectedResponse" />
  </wsdl:message>
  <wsdl:message name="AcceptRejectedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceByDateRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultRecurrenceByDate" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceByDateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceByDateResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultRecurrenceByDateResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultRecurrenceByDateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedRequest">
    <wsdl:part name="parameters" element="tns:CleanUpBookingDeleted" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedResponse">
    <wsdl:part name="parameters" element="tns:CleanUpBookingDeletedResponse" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedWithUpdateModeRequest">
    <wsdl:part name="parameters" element="tns:CleanUpBookingDeletedWithUpdateMode" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedWithUpdateModeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedWithUpdateModeResponse">
    <wsdl:part name="parameters" element="tns:CleanUpBookingDeletedWithUpdateModeResponse" />
  </wsdl:message>
  <wsdl:message name="CleanUpBookingDeletedWithUpdateModeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanUpRecurringBookingDeletedRequest">
    <wsdl:part name="parameters" element="tns:CleanUpRecurringBookingDeleted" />
  </wsdl:message>
  <wsdl:message name="CleanUpRecurringBookingDeletedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CleanUpRecurringBookingDeletedResponse">
    <wsdl:part name="parameters" element="tns:CleanUpRecurringBookingDeletedResponse" />
  </wsdl:message>
  <wsdl:message name="CleanUpRecurringBookingDeletedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeAndAssociateRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityByTypeAndAssociate" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeAndAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCanInsertForAssociatesRequest">
    <wsdl:part name="parameters" element="tns:GetCanInsertForAssociates" />
  </wsdl:message>
  <wsdl:message name="GetCanInsertForAssociatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetCanInsertForAssociatesResponse">
    <wsdl:part name="parameters" element="tns:GetCanInsertForAssociatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetCanInsertForAssociatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentHaveParticipantsWithEmailRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentHaveParticipantsWithEmail" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentHaveParticipantsWithEmailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentHaveParticipantsWithEmailResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentHaveParticipantsWithEmailResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentHaveParticipantsWithEmailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromSaleSuggestionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityFromSaleSuggestion" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromSaleSuggestionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextSuggestedAppointmentBySaleRequest">
    <wsdl:part name="parameters" element="tns:GetNextSuggestedAppointmentBySale" />
  </wsdl:message>
  <wsdl:message name="GetNextSuggestedAppointmentBySaleRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetNextSuggestedAppointmentBySaleResponse">
    <wsdl:part name="parameters" element="tns:GetNextSuggestedAppointmentBySaleResponse" />
  </wsdl:message>
  <wsdl:message name="GetNextSuggestedAppointmentBySaleResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReOpenAppointmentRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultReOpenAppointment" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReOpenAppointmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReOpenAppointmentResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultReOpenAppointmentResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultReOpenAppointmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromProjectSuggestionRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityFromProjectSuggestion" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromProjectSuggestionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAppointmentForUIDRequest">
    <wsdl:part name="parameters" element="tns:CreateAppointmentForUID" />
  </wsdl:message>
  <wsdl:message name="CreateAppointmentForUIDRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAppointmentForUIDResponse">
    <wsdl:part name="parameters" element="tns:CreateAppointmentForUIDResponse" />
  </wsdl:message>
  <wsdl:message name="CreateAppointmentForUIDResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentFromUIDRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentFromUID" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentFromUIDRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentFromUIDResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentFromUIDResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentFromUIDResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanAssignToProjectMemberRequest">
    <wsdl:part name="parameters" element="tns:CanAssignToProjectMember" />
  </wsdl:message>
  <wsdl:message name="CanAssignToProjectMemberRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanAssignToProjectMemberResponse">
    <wsdl:part name="parameters" element="tns:CanAssignToProjectMemberResponse" />
  </wsdl:message>
  <wsdl:message name="CanAssignToProjectMemberResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUIDFromAppointmentIdRequest">
    <wsdl:part name="parameters" element="tns:GetUIDFromAppointmentId" />
  </wsdl:message>
  <wsdl:message name="GetUIDFromAppointmentIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetUIDFromAppointmentIdResponse">
    <wsdl:part name="parameters" element="tns:GetUIDFromAppointmentIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetUIDFromAppointmentIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentFromIcsResponseRequest">
    <wsdl:part name="parameters" element="tns:UpdateAppointmentFromIcsResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentFromIcsResponseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentFromIcsResponseResponse">
    <wsdl:part name="parameters" element="tns:UpdateAppointmentFromIcsResponseResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateAppointmentFromIcsResponseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateAppointmentEntityRequest">
    <wsdl:part name="parameters" element="tns:ValidateAppointmentEntity" />
  </wsdl:message>
  <wsdl:message name="ValidateAppointmentEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateAppointmentEntityResponse">
    <wsdl:part name="parameters" element="tns:ValidateAppointmentEntityResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateAppointmentEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WillSendEmailRequest">
    <wsdl:part name="parameters" element="tns:WillSendEmail" />
  </wsdl:message>
  <wsdl:message name="WillSendEmailRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="WillSendEmailResponse">
    <wsdl:part name="parameters" element="tns:WillSendEmailResponse" />
  </wsdl:message>
  <wsdl:message name="WillSendEmailResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptWithSmtpEmailConfirmationRequest">
    <wsdl:part name="parameters" element="tns:AcceptWithSmtpEmailConfirmation" />
  </wsdl:message>
  <wsdl:message name="AcceptWithSmtpEmailConfirmationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AcceptWithSmtpEmailConfirmationResponse">
    <wsdl:part name="parameters" element="tns:AcceptWithSmtpEmailConfirmationResponse" />
  </wsdl:message>
  <wsdl:message name="AcceptWithSmtpEmailConfirmationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectWithSmtpEmailConfirmationRequest">
    <wsdl:part name="parameters" element="tns:RejectWithSmtpEmailConfirmation" />
  </wsdl:message>
  <wsdl:message name="RejectWithSmtpEmailConfirmationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectWithSmtpEmailConfirmationResponse">
    <wsdl:part name="parameters" element="tns:RejectWithSmtpEmailConfirmationResponse" />
  </wsdl:message>
  <wsdl:message name="RejectWithSmtpEmailConfirmationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEmailInvitationRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentEmailInvitation" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEmailInvitationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEmailInvitationResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentEmailInvitationResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentEmailInvitationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWithCustomInvitationRequest">
    <wsdl:part name="parameters" element="tns:SaveWithCustomInvitation" />
  </wsdl:message>
  <wsdl:message name="SaveWithCustomInvitationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveWithCustomInvitationResponse">
    <wsdl:part name="parameters" element="tns:SaveWithCustomInvitationResponse" />
  </wsdl:message>
  <wsdl:message name="SaveWithCustomInvitationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ConvertAppointmentToTaskRequest">
    <wsdl:part name="parameters" element="tns:ConvertAppointmentToTask" />
  </wsdl:message>
  <wsdl:message name="ConvertAppointmentToTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ConvertAppointmentToTaskResponse">
    <wsdl:part name="parameters" element="tns:ConvertAppointmentToTaskResponse" />
  </wsdl:message>
  <wsdl:message name="ConvertAppointmentToTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentListRequest">
    <wsdl:part name="parameters" element="tns:GetAppointmentList" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentListResponse">
    <wsdl:part name="parameters" element="tns:GetAppointmentListResponse" />
  </wsdl:message>
  <wsdl:message name="GetAppointmentListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetMyAppointments" />
  </wsdl:message>
  <wsdl:message name="GetMyAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetMyAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointments" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyDiaryRequest">
    <wsdl:part name="parameters" element="tns:GetMyDiary" />
  </wsdl:message>
  <wsdl:message name="GetMyDiaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyDiaryResponse">
    <wsdl:part name="parameters" element="tns:GetMyDiaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyDiaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyTasksRequest">
    <wsdl:part name="parameters" element="tns:GetMyTasks" />
  </wsdl:message>
  <wsdl:message name="GetMyTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetMyTasksResponse">
    <wsdl:part name="parameters" element="tns:GetMyTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetMyTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDiaryRequest">
    <wsdl:part name="parameters" element="tns:GetPersonDiary" />
  </wsdl:message>
  <wsdl:message name="GetPersonDiaryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonDiaryResponse">
    <wsdl:part name="parameters" element="tns:GetPersonDiaryResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonDiaryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonTasksRequest">
    <wsdl:part name="parameters" element="tns:GetPersonTasks" />
  </wsdl:message>
  <wsdl:message name="GetPersonTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonTasksResponse">
    <wsdl:part name="parameters" element="tns:GetPersonTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByType" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointments" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByType" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointments" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByType" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointments" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTypeRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByType" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTypeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTypeResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTypeResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTypeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTask" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTasksRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTasks" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTasksResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetPersonAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetPersonAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTask" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTasksRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTasks" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTasksResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetProjectAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTask" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTasksRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTasks" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTasksResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetProjectMemberAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetProjectMemberAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTask" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTaskResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTasksRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTasks" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTasksRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTasksResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTasksResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTasksResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskHeadingRequest">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTaskHeading" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskHeadingRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskHeadingResponse">
    <wsdl:part name="parameters" element="tns:GetContactAppointmentsByTaskHeadingResponse" />
  </wsdl:message>
  <wsdl:message name="GetContactAppointmentsByTaskHeadingResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Appointment">
    <wsdl:operation name="GetPublishedAppointment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedAppointment" name="GetPublishedAppointmentRequest" message="tns:GetPublishedAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedAppointmentResponse" name="GetPublishedAppointmentResponse" message="tns:GetPublishedAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedAppointments" name="GetPublishedAppointmentsRequest" message="tns:GetPublishedAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedAppointmentsResponse" name="GetPublishedAppointmentsResponse" message="tns:GetPublishedAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyPublishedAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyPublishedAppointments" name="GetMyPublishedAppointmentsRequest" message="tns:GetMyPublishedAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyPublishedAppointmentsResponse" name="GetMyPublishedAppointmentsResponse" message="tns:GetMyPublishedAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjectAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedProjectAppointments" name="GetPublishedProjectAppointmentsRequest" message="tns:GetPublishedProjectAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedProjectAppointmentsResponse" name="GetPublishedProjectAppointmentsResponse" message="tns:GetPublishedProjectAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentsByTaskHeading">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentsByTaskHeading" name="GetAppointmentsByTaskHeadingRequest" message="tns:GetAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentsByTaskHeadingResponse" name="GetAppointmentsByTaskHeadingResponse" message="tns:GetAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAssociateDiary">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociateDiary" name="GetAssociateDiaryRequest" message="tns:GetAssociateDiaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociateDiaryResponse" name="GetAssociateDiaryResponse" message="tns:GetAssociateDiaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDiaryByGroup">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetDiaryByGroup" name="GetDiaryByGroupRequest" message="tns:GetDiaryByGroupRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetDiaryByGroupResponse" name="GetDiaryByGroupResponse" message="tns:GetDiaryByGroupResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointment" name="UpdateAppointmentRequest" message="tns:UpdateAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentResponse" name="UpdateAppointmentResponse" message="tns:UpdateAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointmentWithMode">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentWithMode" name="UpdateAppointmentWithModeRequest" message="tns:UpdateAppointmentWithModeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentWithModeResponse" name="UpdateAppointmentWithModeResponse" message="tns:UpdateAppointmentWithModeResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointmentWithModeAndEmail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentWithModeAndEmail" name="UpdateAppointmentWithModeAndEmailRequest" message="tns:UpdateAppointmentWithModeAndEmailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentWithModeAndEmailResponse" name="UpdateAppointmentWithModeAndEmailResponse" message="tns:UpdateAppointmentWithModeAndEmailResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAssociatesDiary">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociatesDiary" name="GetAssociatesDiaryRequest" message="tns:GetAssociatesDiaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociatesDiaryResponse" name="GetAssociatesDiaryResponse" message="tns:GetAssociatesDiaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAssociatesDiaryInfo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociatesDiaryInfo" name="GetAssociatesDiaryInfoRequest" message="tns:GetAssociatesDiaryInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociatesDiaryInfoResponse" name="GetAssociatesDiaryInfoResponse" message="tns:GetAssociatesDiaryInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentRecords">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentRecords" name="GetAppointmentRecordsRequest" message="tns:GetAppointmentRecordsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentRecordsResponse" name="GetAppointmentRecordsResponse" message="tns:GetAppointmentRecordsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMySyncAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMySyncAppointments" name="GetMySyncAppointmentsRequest" message="tns:GetMySyncAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMySyncAppointmentsResponse" name="GetMySyncAppointmentsResponse" message="tns:GetMySyncAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetDayInformationListByDatesAndAssociate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetDayInformationListByDatesAndAssociate" name="GetDayInformationListByDatesAndAssociateRequest" message="tns:GetDayInformationListByDatesAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetDayInformationListByDatesAndAssociateResponse" name="GetDayInformationListByDatesAndAssociateResponse" message="tns:GetDayInformationListByDatesAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetActivityInformationListByDatesAndAssociate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetActivityInformationListByDatesAndAssociate" name="GetActivityInformationListByDatesAndAssociateRequest" message="tns:GetActivityInformationListByDatesAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetActivityInformationListByDatesAndAssociateResponse" name="GetActivityInformationListByDatesAndAssociateResponse" message="tns:GetActivityInformationListByDatesAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetRedLetterInformationListByDatesAndAssociate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetRedLetterInformationListByDatesAndAssociate" name="GetRedLetterInformationListByDatesAndAssociateRequest" message="tns:GetRedLetterInformationListByDatesAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetRedLetterInformationListByDatesAndAssociateResponse" name="GetRedLetterInformationListByDatesAndAssociateResponse" message="tns:GetRedLetterInformationListByDatesAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAlarms">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAlarms" name="GetAlarmsRequest" message="tns:GetAlarmsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAlarmsResponse" name="GetAlarmsResponse" message="tns:GetAlarmsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextAvailableTime">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetNextAvailableTime" name="GetNextAvailableTimeRequest" message="tns:GetNextAvailableTimeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetNextAvailableTimeResponse" name="GetNextAvailableTimeResponse" message="tns:GetNextAvailableTimeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GenerateLead">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GenerateLead" name="GenerateLeadRequest" message="tns:GenerateLeadRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GenerateLeadResponse" name="GenerateLeadResponse" message="tns:GenerateLeadResponse" />
    </wsdl:operation>
    <wsdl:operation name="RequestForInfo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RequestForInfo" name="RequestForInfoRequest" message="tns:RequestForInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RequestForInfoResponse" name="RequestForInfoResponse" message="tns:RequestForInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedAppointment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetSuggestedAppointment" name="GetSuggestedAppointmentRequest" message="tns:GetSuggestedAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetSuggestedAppointmentResponse" name="GetSuggestedAppointmentResponse" message="tns:GetSuggestedAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedAppointmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetSuggestedAppointmentEntity" name="GetSuggestedAppointmentEntityRequest" message="tns:GetSuggestedAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetSuggestedAppointmentEntityResponse" name="GetSuggestedAppointmentEntityResponse" message="tns:GetSuggestedAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTaskListItem">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetTaskListItem" name="GetTaskListItemRequest" message="tns:GetTaskListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetTaskListItemResponse" name="GetTaskListItemResponse" message="tns:GetTaskListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTaskListItems">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetTaskListItems" name="GetTaskListItemsRequest" message="tns:GetTaskListItemsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetTaskListItemsResponse" name="GetTaskListItemsResponse" message="tns:GetTaskListItemsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateVideoMeetingReservation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateVideoMeetingReservation" name="CreateVideoMeetingReservationRequest" message="tns:CreateVideoMeetingReservationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateVideoMeetingReservationResponse" name="CreateVideoMeetingReservationResponse" message="tns:CreateVideoMeetingReservationResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteVideoMeetingReservation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeleteVideoMeetingReservation" name="DeleteVideoMeetingReservationRequest" message="tns:DeleteVideoMeetingReservationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeleteVideoMeetingReservationResponse" name="DeleteVideoMeetingReservationResponse" message="tns:DeleteVideoMeetingReservationResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntity" name="CreateDefaultAppointmentEntityRequest" message="tns:CreateDefaultAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityResponse" name="CreateDefaultAppointmentEntityResponse" message="tns:CreateDefaultAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveAppointmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveAppointmentEntity" name="SaveAppointmentEntityRequest" message="tns:SaveAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveAppointmentEntityResponse" name="SaveAppointmentEntityResponse" message="tns:SaveAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteAppointmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeleteAppointmentEntity" name="DeleteAppointmentEntityRequest" message="tns:DeleteAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeleteAppointmentEntityResponse" name="DeleteAppointmentEntityResponse" message="tns:DeleteAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSuggestedAppointmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultSuggestedAppointmentEntity" name="CreateDefaultSuggestedAppointmentEntityRequest" message="tns:CreateDefaultSuggestedAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultSuggestedAppointmentEntityResponse" name="CreateDefaultSuggestedAppointmentEntityResponse" message="tns:CreateDefaultSuggestedAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveSuggestedAppointmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveSuggestedAppointmentEntity" name="SaveSuggestedAppointmentEntityRequest" message="tns:SaveSuggestedAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveSuggestedAppointmentEntityResponse" name="SaveSuggestedAppointmentEntityResponse" message="tns:SaveSuggestedAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTaskListItem">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultTaskListItem" name="CreateDefaultTaskListItemRequest" message="tns:CreateDefaultTaskListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultTaskListItemResponse" name="CreateDefaultTaskListItemResponse" message="tns:CreateDefaultTaskListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveTaskListItem">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveTaskListItem" name="SaveTaskListItemRequest" message="tns:SaveTaskListItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveTaskListItemResponse" name="SaveTaskListItemResponse" message="tns:SaveTaskListItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointment" name="GetAppointmentRequest" message="tns:GetAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentResponse" name="GetAppointmentResponse" message="tns:GetAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleAppointmentStatus">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleAppointmentStatus" name="ToggleAppointmentStatusRequest" message="tns:ToggleAppointmentStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleAppointmentStatusResponse" name="ToggleAppointmentStatusResponse" message="tns:ToggleAppointmentStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleActivity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleActivity" name="ToggleActivityRequest" message="tns:ToggleActivityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleActivityResponse" name="ToggleActivityResponse" message="tns:ToggleActivityResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleActivities">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleActivities" name="ToggleActivitiesRequest" message="tns:ToggleActivitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleActivitiesResponse" name="ToggleActivitiesResponse" message="tns:ToggleActivitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetActivityStatus">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetActivityStatus" name="SetActivityStatusRequest" message="tns:SetActivityStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetActivityStatusResponse" name="SetActivityStatusResponse" message="tns:SetActivityStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleAndSetActivities">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleAndSetActivities" name="ToggleAndSetActivitiesRequest" message="tns:ToggleAndSetActivitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleAndSetActivitiesResponse" name="ToggleAndSetActivitiesResponse" message="tns:ToggleAndSetActivitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentEntity" name="GetAppointmentEntityRequest" message="tns:GetAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentEntityResponse" name="GetAppointmentEntityResponse" message="tns:GetAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityByType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityByType" name="CreateDefaultAppointmentEntityByTypeRequest" message="tns:CreateDefaultAppointmentEntityByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityByTypeResponse" name="CreateDefaultAppointmentEntityByTypeResponse" message="tns:CreateDefaultAppointmentEntityByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateAppointmentEntityFromExisting">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAppointmentEntityFromExisting" name="CreateAppointmentEntityFromExistingRequest" message="tns:CreateAppointmentEntityFromExistingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAppointmentEntityFromExistingResponse" name="CreateAppointmentEntityFromExistingResponse" message="tns:CreateAppointmentEntityFromExistingResponse" />
    </wsdl:operation>
    <wsdl:operation name="Accept">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Accept" name="AcceptRequest" message="tns:AcceptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptResponse" name="AcceptResponse" message="tns:AcceptResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateAndAccept">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAndAccept" name="CreateAndAcceptRequest" message="tns:CreateAndAcceptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAndAcceptResponse" name="CreateAndAcceptResponse" message="tns:CreateAndAcceptResponse" />
    </wsdl:operation>
    <wsdl:operation name="AcceptWithEmailConfirmation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptWithEmailConfirmation" name="AcceptWithEmailConfirmationRequest" message="tns:AcceptWithEmailConfirmationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptWithEmailConfirmationResponse" name="AcceptWithEmailConfirmationResponse" message="tns:AcceptWithEmailConfirmationResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateAndAcceptWithEmailConfirmation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAndAcceptWithEmailConfirmation" name="CreateAndAcceptWithEmailConfirmationRequest" message="tns:CreateAndAcceptWithEmailConfirmationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAndAcceptWithEmailConfirmationResponse" name="CreateAndAcceptWithEmailConfirmationResponse" message="tns:CreateAndAcceptWithEmailConfirmationResponse" />
    </wsdl:operation>
    <wsdl:operation name="Reject">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Reject" name="RejectRequest" message="tns:RejectRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RejectResponse" name="RejectResponse" message="tns:RejectResponse" />
    </wsdl:operation>
    <wsdl:operation name="RejectWithEmailConfirmation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RejectWithEmailConfirmation" name="RejectWithEmailConfirmationRequest" message="tns:RejectWithEmailConfirmationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RejectWithEmailConfirmationResponse" name="RejectWithEmailConfirmationResponse" message="tns:RejectWithEmailConfirmationResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeclineInvitationFromEmailItem">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeclineInvitationFromEmailItem" name="DeclineInvitationFromEmailItemRequest" message="tns:DeclineInvitationFromEmailItemRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeclineInvitationFromEmailItemResponse" name="DeclineInvitationFromEmailItemResponse" message="tns:DeclineInvitationFromEmailItemResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetOrganizerName">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetOrganizerName" name="GetOrganizerNameRequest" message="tns:GetOrganizerNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetOrganizerNameResponse" name="GetOrganizerNameResponse" message="tns:GetOrganizerNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="Save">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Save" name="SaveRequest" message="tns:SaveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveResponse" name="SaveResponse" message="tns:SaveResponse" />
    </wsdl:operation>
    <wsdl:operation name="Delete">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Delete" name="DeleteRequest" message="tns:DeleteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeleteResponse" name="DeleteResponse" message="tns:DeleteResponse" />
    </wsdl:operation>
    <wsdl:operation name="CalculateDays">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CalculateDays" name="CalculateDaysRequest" message="tns:CalculateDaysRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CalculateDaysResponse" name="CalculateDaysResponse" message="tns:CalculateDaysResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateDays">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ValidateDays" name="ValidateDaysRequest" message="tns:ValidateDaysRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ValidateDaysResponse" name="ValidateDaysResponse" message="tns:ValidateDaysResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRecurrence">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultRecurrence" name="CreateDefaultRecurrenceRequest" message="tns:CreateDefaultRecurrenceRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultRecurrenceResponse" name="CreateDefaultRecurrenceResponse" message="tns:CreateDefaultRecurrenceResponse" />
    </wsdl:operation>
    <wsdl:operation name="AssignTo">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AssignTo" name="AssignToRequest" message="tns:AssignToRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AssignToResponse" name="AssignToResponse" message="tns:AssignToResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetSeen">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetSeen" name="SetSeenRequest" message="tns:SetSeenRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetSeenResponse" name="SetSeenResponse" message="tns:SetSeenResponse" />
    </wsdl:operation>
    <wsdl:operation name="SetSeenMany">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetSeenMany" name="SetSeenManyRequest" message="tns:SetSeenManyRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetSeenManyResponse" name="SetSeenManyResponse" message="tns:SetSeenManyResponse" />
    </wsdl:operation>
    <wsdl:operation name="Move">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Move" name="MoveRequest" message="tns:MoveRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/MoveResponse" name="MoveResponse" message="tns:MoveResponse" />
    </wsdl:operation>
    <wsdl:operation name="MoveWithEmail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/MoveWithEmail" name="MoveWithEmailRequest" message="tns:MoveWithEmailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/MoveWithEmailResponse" name="MoveWithEmailResponse" message="tns:MoveWithEmailResponse" />
    </wsdl:operation>
    <wsdl:operation name="MoveExtended">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/MoveExtended" name="MoveExtendedRequest" message="tns:MoveExtendedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/MoveExtendedResponse" name="MoveExtendedResponse" message="tns:MoveExtendedResponse" />
    </wsdl:operation>
    <wsdl:operation name="AcceptRejected">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptRejected" name="AcceptRejectedRequest" message="tns:AcceptRejectedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptRejectedResponse" name="AcceptRejectedResponse" message="tns:AcceptRejectedResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRecurrenceByDate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultRecurrenceByDate" name="CreateDefaultRecurrenceByDateRequest" message="tns:CreateDefaultRecurrenceByDateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultRecurrenceByDateResponse" name="CreateDefaultRecurrenceByDateResponse" message="tns:CreateDefaultRecurrenceByDateResponse" />
    </wsdl:operation>
    <wsdl:operation name="CleanUpBookingDeleted">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpBookingDeleted" name="CleanUpBookingDeletedRequest" message="tns:CleanUpBookingDeletedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpBookingDeletedResponse" name="CleanUpBookingDeletedResponse" message="tns:CleanUpBookingDeletedResponse" />
    </wsdl:operation>
    <wsdl:operation name="CleanUpBookingDeletedWithUpdateMode">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpBookingDeletedWithUpdateMode" name="CleanUpBookingDeletedWithUpdateModeRequest" message="tns:CleanUpBookingDeletedWithUpdateModeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpBookingDeletedWithUpdateModeResponse" name="CleanUpBookingDeletedWithUpdateModeResponse" message="tns:CleanUpBookingDeletedWithUpdateModeResponse" />
    </wsdl:operation>
    <wsdl:operation name="CleanUpRecurringBookingDeleted">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpRecurringBookingDeleted" name="CleanUpRecurringBookingDeletedRequest" message="tns:CleanUpRecurringBookingDeletedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpRecurringBookingDeletedResponse" name="CleanUpRecurringBookingDeletedResponse" message="tns:CleanUpRecurringBookingDeletedResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityByTypeAndAssociate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate" name="CreateDefaultAppointmentEntityByTypeAndAssociateRequest" message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociateResponse" name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse" message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetCanInsertForAssociates">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetCanInsertForAssociates" name="GetCanInsertForAssociatesRequest" message="tns:GetCanInsertForAssociatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetCanInsertForAssociatesResponse" name="GetCanInsertForAssociatesResponse" message="tns:GetCanInsertForAssociatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentHaveParticipantsWithEmail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentHaveParticipantsWithEmail" name="GetAppointmentHaveParticipantsWithEmailRequest" message="tns:GetAppointmentHaveParticipantsWithEmailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentHaveParticipantsWithEmailResponse" name="GetAppointmentHaveParticipantsWithEmailResponse" message="tns:GetAppointmentHaveParticipantsWithEmailResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityFromSaleSuggestion">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion" name="CreateDefaultAppointmentEntityFromSaleSuggestionRequest" message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestionResponse" name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse" message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetNextSuggestedAppointmentBySale">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetNextSuggestedAppointmentBySale" name="GetNextSuggestedAppointmentBySaleRequest" message="tns:GetNextSuggestedAppointmentBySaleRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetNextSuggestedAppointmentBySaleResponse" name="GetNextSuggestedAppointmentBySaleResponse" message="tns:GetNextSuggestedAppointmentBySaleResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultReOpenAppointment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultReOpenAppointment" name="CreateDefaultReOpenAppointmentRequest" message="tns:CreateDefaultReOpenAppointmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultReOpenAppointmentResponse" name="CreateDefaultReOpenAppointmentResponse" message="tns:CreateDefaultReOpenAppointmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityFromProjectSuggestion">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion" name="CreateDefaultAppointmentEntityFromProjectSuggestionRequest" message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestionResponse" name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse" message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateAppointmentForUID">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAppointmentForUID" name="CreateAppointmentForUIDRequest" message="tns:CreateAppointmentForUIDRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAppointmentForUIDResponse" name="CreateAppointmentForUIDResponse" message="tns:CreateAppointmentForUIDResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentFromUID">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentFromUID" name="GetAppointmentFromUIDRequest" message="tns:GetAppointmentFromUIDRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentFromUIDResponse" name="GetAppointmentFromUIDResponse" message="tns:GetAppointmentFromUIDResponse" />
    </wsdl:operation>
    <wsdl:operation name="CanAssignToProjectMember">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CanAssignToProjectMember" name="CanAssignToProjectMemberRequest" message="tns:CanAssignToProjectMemberRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CanAssignToProjectMemberResponse" name="CanAssignToProjectMemberResponse" message="tns:CanAssignToProjectMemberResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetUIDFromAppointmentId">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetUIDFromAppointmentId" name="GetUIDFromAppointmentIdRequest" message="tns:GetUIDFromAppointmentIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetUIDFromAppointmentIdResponse" name="GetUIDFromAppointmentIdResponse" message="tns:GetUIDFromAppointmentIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointmentFromIcsResponse">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentFromIcsResponse" name="UpdateAppointmentFromIcsResponseRequest" message="tns:UpdateAppointmentFromIcsResponseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentFromIcsResponseResponse" name="UpdateAppointmentFromIcsResponseResponse" message="tns:UpdateAppointmentFromIcsResponseResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateAppointmentEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ValidateAppointmentEntity" name="ValidateAppointmentEntityRequest" message="tns:ValidateAppointmentEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ValidateAppointmentEntityResponse" name="ValidateAppointmentEntityResponse" message="tns:ValidateAppointmentEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="WillSendEmail">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/WillSendEmail" name="WillSendEmailRequest" message="tns:WillSendEmailRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/WillSendEmailResponse" name="WillSendEmailResponse" message="tns:WillSendEmailResponse" />
    </wsdl:operation>
    <wsdl:operation name="AcceptWithSmtpEmailConfirmation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptWithSmtpEmailConfirmation" name="AcceptWithSmtpEmailConfirmationRequest" message="tns:AcceptWithSmtpEmailConfirmationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptWithSmtpEmailConfirmationResponse" name="AcceptWithSmtpEmailConfirmationResponse" message="tns:AcceptWithSmtpEmailConfirmationResponse" />
    </wsdl:operation>
    <wsdl:operation name="RejectWithSmtpEmailConfirmation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RejectWithSmtpEmailConfirmation" name="RejectWithSmtpEmailConfirmationRequest" message="tns:RejectWithSmtpEmailConfirmationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RejectWithSmtpEmailConfirmationResponse" name="RejectWithSmtpEmailConfirmationResponse" message="tns:RejectWithSmtpEmailConfirmationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentEmailInvitation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentEmailInvitation" name="GetAppointmentEmailInvitationRequest" message="tns:GetAppointmentEmailInvitationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentEmailInvitationResponse" name="GetAppointmentEmailInvitationResponse" message="tns:GetAppointmentEmailInvitationResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveWithCustomInvitation">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveWithCustomInvitation" name="SaveWithCustomInvitationRequest" message="tns:SaveWithCustomInvitationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveWithCustomInvitationResponse" name="SaveWithCustomInvitationResponse" message="tns:SaveWithCustomInvitationResponse" />
    </wsdl:operation>
    <wsdl:operation name="ConvertAppointmentToTask">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ConvertAppointmentToTask" name="ConvertAppointmentToTaskRequest" message="tns:ConvertAppointmentToTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ConvertAppointmentToTaskResponse" name="ConvertAppointmentToTaskResponse" message="tns:ConvertAppointmentToTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentList">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentList" name="GetAppointmentListRequest" message="tns:GetAppointmentListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentListResponse" name="GetAppointmentListResponse" message="tns:GetAppointmentListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyAppointments" name="GetMyAppointmentsRequest" message="tns:GetMyAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyAppointmentsResponse" name="GetMyAppointmentsResponse" message="tns:GetMyAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointments" name="GetPersonAppointmentsRequest" message="tns:GetPersonAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsResponse" name="GetPersonAppointmentsResponse" message="tns:GetPersonAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyDiary">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyDiary" name="GetMyDiaryRequest" message="tns:GetMyDiaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyDiaryResponse" name="GetMyDiaryResponse" message="tns:GetMyDiaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetMyTasks">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyTasks" name="GetMyTasksRequest" message="tns:GetMyTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyTasksResponse" name="GetMyTasksResponse" message="tns:GetMyTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonDiary">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonDiary" name="GetPersonDiaryRequest" message="tns:GetPersonDiaryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonDiaryResponse" name="GetPersonDiaryResponse" message="tns:GetPersonDiaryResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonTasks">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonTasks" name="GetPersonTasksRequest" message="tns:GetPersonTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonTasksResponse" name="GetPersonTasksResponse" message="tns:GetPersonTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByType" name="GetPersonAppointmentsByTypeRequest" message="tns:GetPersonAppointmentsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTypeResponse" name="GetPersonAppointmentsByTypeResponse" message="tns:GetPersonAppointmentsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointments" name="GetProjectAppointmentsRequest" message="tns:GetProjectAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsResponse" name="GetProjectAppointmentsResponse" message="tns:GetProjectAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByType" name="GetProjectAppointmentsByTypeRequest" message="tns:GetProjectAppointmentsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTypeResponse" name="GetProjectAppointmentsByTypeResponse" message="tns:GetProjectAppointmentsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointments" name="GetContactAppointmentsRequest" message="tns:GetContactAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsResponse" name="GetContactAppointmentsResponse" message="tns:GetContactAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByType" name="GetContactAppointmentsByTypeRequest" message="tns:GetContactAppointmentsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTypeResponse" name="GetContactAppointmentsByTypeResponse" message="tns:GetContactAppointmentsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointments">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointments" name="GetProjectMemberAppointmentsRequest" message="tns:GetProjectMemberAppointmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsResponse" name="GetProjectMemberAppointmentsResponse" message="tns:GetProjectMemberAppointmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByType">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByType" name="GetProjectMemberAppointmentsByTypeRequest" message="tns:GetProjectMemberAppointmentsByTypeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTypeResponse" name="GetProjectMemberAppointmentsByTypeResponse" message="tns:GetProjectMemberAppointmentsByTypeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTask">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTask" name="GetPersonAppointmentsByTaskRequest" message="tns:GetPersonAppointmentsByTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTaskResponse" name="GetPersonAppointmentsByTaskResponse" message="tns:GetPersonAppointmentsByTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTasks">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTasks" name="GetPersonAppointmentsByTasksRequest" message="tns:GetPersonAppointmentsByTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTasksResponse" name="GetPersonAppointmentsByTasksResponse" message="tns:GetPersonAppointmentsByTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTaskHeading">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTaskHeading" name="GetPersonAppointmentsByTaskHeadingRequest" message="tns:GetPersonAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTaskHeadingResponse" name="GetPersonAppointmentsByTaskHeadingResponse" message="tns:GetPersonAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTask">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTask" name="GetProjectAppointmentsByTaskRequest" message="tns:GetProjectAppointmentsByTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTaskResponse" name="GetProjectAppointmentsByTaskResponse" message="tns:GetProjectAppointmentsByTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTasks">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTasks" name="GetProjectAppointmentsByTasksRequest" message="tns:GetProjectAppointmentsByTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTasksResponse" name="GetProjectAppointmentsByTasksResponse" message="tns:GetProjectAppointmentsByTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTaskHeading">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTaskHeading" name="GetProjectAppointmentsByTaskHeadingRequest" message="tns:GetProjectAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTaskHeadingResponse" name="GetProjectAppointmentsByTaskHeadingResponse" message="tns:GetProjectAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTask">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTask" name="GetProjectMemberAppointmentsByTaskRequest" message="tns:GetProjectMemberAppointmentsByTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTaskResponse" name="GetProjectMemberAppointmentsByTaskResponse" message="tns:GetProjectMemberAppointmentsByTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTasks">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTasks" name="GetProjectMemberAppointmentsByTasksRequest" message="tns:GetProjectMemberAppointmentsByTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTasksResponse" name="GetProjectMemberAppointmentsByTasksResponse" message="tns:GetProjectMemberAppointmentsByTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTaskHeading">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTaskHeading" name="GetProjectMemberAppointmentsByTaskHeadingRequest" message="tns:GetProjectMemberAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTaskHeadingResponse" name="GetProjectMemberAppointmentsByTaskHeadingResponse" message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTask">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTask" name="GetContactAppointmentsByTaskRequest" message="tns:GetContactAppointmentsByTaskRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTaskResponse" name="GetContactAppointmentsByTaskResponse" message="tns:GetContactAppointmentsByTaskResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTasks">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTasks" name="GetContactAppointmentsByTasksRequest" message="tns:GetContactAppointmentsByTasksRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTasksResponse" name="GetContactAppointmentsByTasksResponse" message="tns:GetContactAppointmentsByTasksResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTaskHeading">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTaskHeading" name="GetContactAppointmentsByTaskHeadingRequest" message="tns:GetContactAppointmentsByTaskHeadingRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTaskHeadingResponse" name="GetContactAppointmentsByTaskHeadingResponse" message="tns:GetContactAppointmentsByTaskHeadingResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Appointment" type="tns:Appointment">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="GetPublishedAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedAppointment" style="document" />
      <wsdl:input name="GetPublishedAppointmentRequest">
        <soap:header message="tns:GetPublishedAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedAppointmentResponse">
        <soap:header message="tns:GetPublishedAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedAppointments" style="document" />
      <wsdl:input name="GetPublishedAppointmentsRequest">
        <soap:header message="tns:GetPublishedAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedAppointmentsResponse">
        <soap:header message="tns:GetPublishedAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyPublishedAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyPublishedAppointments" style="document" />
      <wsdl:input name="GetMyPublishedAppointmentsRequest">
        <soap:header message="tns:GetMyPublishedAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyPublishedAppointmentsResponse">
        <soap:header message="tns:GetMyPublishedAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyPublishedAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPublishedProjectAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPublishedProjectAppointments" style="document" />
      <wsdl:input name="GetPublishedProjectAppointmentsRequest">
        <soap:header message="tns:GetPublishedProjectAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPublishedProjectAppointmentsResponse">
        <soap:header message="tns:GetPublishedProjectAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPublishedProjectAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAssociateDiary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociateDiary" style="document" />
      <wsdl:input name="GetAssociateDiaryRequest">
        <soap:header message="tns:GetAssociateDiaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociateDiaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociateDiaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociateDiaryResponse">
        <soap:header message="tns:GetAssociateDiaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociateDiaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociateDiaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociateDiaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDiaryByGroup">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetDiaryByGroup" style="document" />
      <wsdl:input name="GetDiaryByGroupRequest">
        <soap:header message="tns:GetDiaryByGroupRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDiaryByGroupRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDiaryByGroupRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDiaryByGroupResponse">
        <soap:header message="tns:GetDiaryByGroupResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDiaryByGroupResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDiaryByGroupResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDiaryByGroupResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointment" style="document" />
      <wsdl:input name="UpdateAppointmentRequest">
        <soap:header message="tns:UpdateAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateAppointmentResponse">
        <soap:header message="tns:UpdateAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointmentWithMode">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentWithMode" style="document" />
      <wsdl:input name="UpdateAppointmentWithModeRequest">
        <soap:header message="tns:UpdateAppointmentWithModeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateAppointmentWithModeResponse">
        <soap:header message="tns:UpdateAppointmentWithModeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointmentWithModeAndEmail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentWithModeAndEmail" style="document" />
      <wsdl:input name="UpdateAppointmentWithModeAndEmailRequest">
        <soap:header message="tns:UpdateAppointmentWithModeAndEmailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeAndEmailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeAndEmailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateAppointmentWithModeAndEmailResponse">
        <soap:header message="tns:UpdateAppointmentWithModeAndEmailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeAndEmailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeAndEmailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateAppointmentWithModeAndEmailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAssociatesDiary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociatesDiary" style="document" />
      <wsdl:input name="GetAssociatesDiaryRequest">
        <soap:header message="tns:GetAssociatesDiaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociatesDiaryResponse">
        <soap:header message="tns:GetAssociatesDiaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAssociatesDiaryInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAssociatesDiaryInfo" style="document" />
      <wsdl:input name="GetAssociatesDiaryInfoRequest">
        <soap:header message="tns:GetAssociatesDiaryInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAssociatesDiaryInfoResponse">
        <soap:header message="tns:GetAssociatesDiaryInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAssociatesDiaryInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentRecords">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentRecords" style="document" />
      <wsdl:input name="GetAppointmentRecordsRequest">
        <soap:header message="tns:GetAppointmentRecordsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentRecordsResponse">
        <soap:header message="tns:GetAppointmentRecordsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentRecordsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMySyncAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMySyncAppointments" style="document" />
      <wsdl:input name="GetMySyncAppointmentsRequest">
        <soap:header message="tns:GetMySyncAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMySyncAppointmentsResponse">
        <soap:header message="tns:GetMySyncAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMySyncAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetDayInformationListByDatesAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetDayInformationListByDatesAndAssociate" style="document" />
      <wsdl:input name="GetDayInformationListByDatesAndAssociateRequest">
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetDayInformationListByDatesAndAssociateResponse">
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetDayInformationListByDatesAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetActivityInformationListByDatesAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetActivityInformationListByDatesAndAssociate" style="document" />
      <wsdl:input name="GetActivityInformationListByDatesAndAssociateRequest">
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetActivityInformationListByDatesAndAssociateResponse">
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetActivityInformationListByDatesAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetRedLetterInformationListByDatesAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetRedLetterInformationListByDatesAndAssociate" style="document" />
      <wsdl:input name="GetRedLetterInformationListByDatesAndAssociateRequest">
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetRedLetterInformationListByDatesAndAssociateResponse">
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetRedLetterInformationListByDatesAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAlarms">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAlarms" style="document" />
      <wsdl:input name="GetAlarmsRequest">
        <soap:header message="tns:GetAlarmsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAlarmsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAlarmsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAlarmsResponse">
        <soap:header message="tns:GetAlarmsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAlarmsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAlarmsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAlarmsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextAvailableTime">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetNextAvailableTime" style="document" />
      <wsdl:input name="GetNextAvailableTimeRequest">
        <soap:header message="tns:GetNextAvailableTimeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextAvailableTimeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextAvailableTimeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextAvailableTimeResponse">
        <soap:header message="tns:GetNextAvailableTimeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextAvailableTimeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextAvailableTimeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextAvailableTimeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GenerateLead">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GenerateLead" style="document" />
      <wsdl:input name="GenerateLeadRequest">
        <soap:header message="tns:GenerateLeadRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GenerateLeadRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GenerateLeadRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GenerateLeadResponse">
        <soap:header message="tns:GenerateLeadResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GenerateLeadResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GenerateLeadResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GenerateLeadResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RequestForInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RequestForInfo" style="document" />
      <wsdl:input name="RequestForInfoRequest">
        <soap:header message="tns:RequestForInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RequestForInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RequestForInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RequestForInfoResponse">
        <soap:header message="tns:RequestForInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RequestForInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RequestForInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RequestForInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetSuggestedAppointment" style="document" />
      <wsdl:input name="GetSuggestedAppointmentRequest">
        <soap:header message="tns:GetSuggestedAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSuggestedAppointmentResponse">
        <soap:header message="tns:GetSuggestedAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSuggestedAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetSuggestedAppointmentEntity" style="document" />
      <wsdl:input name="GetSuggestedAppointmentEntityRequest">
        <soap:header message="tns:GetSuggestedAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSuggestedAppointmentEntityResponse">
        <soap:header message="tns:GetSuggestedAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSuggestedAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTaskListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetTaskListItem" style="document" />
      <wsdl:input name="GetTaskListItemRequest">
        <soap:header message="tns:GetTaskListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTaskListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTaskListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTaskListItemResponse">
        <soap:header message="tns:GetTaskListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTaskListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTaskListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTaskListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTaskListItems">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetTaskListItems" style="document" />
      <wsdl:input name="GetTaskListItemsRequest">
        <soap:header message="tns:GetTaskListItemsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTaskListItemsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTaskListItemsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTaskListItemsResponse">
        <soap:header message="tns:GetTaskListItemsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTaskListItemsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTaskListItemsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTaskListItemsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateVideoMeetingReservation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateVideoMeetingReservation" style="document" />
      <wsdl:input name="CreateVideoMeetingReservationRequest">
        <soap:header message="tns:CreateVideoMeetingReservationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateVideoMeetingReservationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateVideoMeetingReservationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateVideoMeetingReservationResponse">
        <soap:header message="tns:CreateVideoMeetingReservationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateVideoMeetingReservationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateVideoMeetingReservationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateVideoMeetingReservationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteVideoMeetingReservation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeleteVideoMeetingReservation" style="document" />
      <wsdl:input name="DeleteVideoMeetingReservationRequest">
        <soap:header message="tns:DeleteVideoMeetingReservationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteVideoMeetingReservationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteVideoMeetingReservationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteVideoMeetingReservationResponse">
        <soap:header message="tns:DeleteVideoMeetingReservationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteVideoMeetingReservationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteVideoMeetingReservationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteVideoMeetingReservationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntity" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveAppointmentEntity" style="document" />
      <wsdl:input name="SaveAppointmentEntityRequest">
        <soap:header message="tns:SaveAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveAppointmentEntityResponse">
        <soap:header message="tns:SaveAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeleteAppointmentEntity" style="document" />
      <wsdl:input name="DeleteAppointmentEntityRequest">
        <soap:header message="tns:DeleteAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteAppointmentEntityResponse">
        <soap:header message="tns:DeleteAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultSuggestedAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultSuggestedAppointmentEntity" style="document" />
      <wsdl:input name="CreateDefaultSuggestedAppointmentEntityRequest">
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultSuggestedAppointmentEntityResponse">
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultSuggestedAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveSuggestedAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveSuggestedAppointmentEntity" style="document" />
      <wsdl:input name="SaveSuggestedAppointmentEntityRequest">
        <soap:header message="tns:SaveSuggestedAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveSuggestedAppointmentEntityResponse">
        <soap:header message="tns:SaveSuggestedAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveSuggestedAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultTaskListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultTaskListItem" style="document" />
      <wsdl:input name="CreateDefaultTaskListItemRequest">
        <soap:header message="tns:CreateDefaultTaskListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultTaskListItemResponse">
        <soap:header message="tns:CreateDefaultTaskListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultTaskListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveTaskListItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveTaskListItem" style="document" />
      <wsdl:input name="SaveTaskListItemRequest">
        <soap:header message="tns:SaveTaskListItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveTaskListItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveTaskListItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveTaskListItemResponse">
        <soap:header message="tns:SaveTaskListItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveTaskListItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveTaskListItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveTaskListItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointment" style="document" />
      <wsdl:input name="GetAppointmentRequest">
        <soap:header message="tns:GetAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentResponse">
        <soap:header message="tns:GetAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleAppointmentStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleAppointmentStatus" style="document" />
      <wsdl:input name="ToggleAppointmentStatusRequest">
        <soap:header message="tns:ToggleAppointmentStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleAppointmentStatusResponse">
        <soap:header message="tns:ToggleAppointmentStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleAppointmentStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleActivity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleActivity" style="document" />
      <wsdl:input name="ToggleActivityRequest">
        <soap:header message="tns:ToggleActivityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleActivityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleActivityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleActivityResponse">
        <soap:header message="tns:ToggleActivityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleActivityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleActivityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleActivityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleActivities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleActivities" style="document" />
      <wsdl:input name="ToggleActivitiesRequest">
        <soap:header message="tns:ToggleActivitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleActivitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleActivitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleActivitiesResponse">
        <soap:header message="tns:ToggleActivitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleActivitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleActivitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleActivitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetActivityStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetActivityStatus" style="document" />
      <wsdl:input name="SetActivityStatusRequest">
        <soap:header message="tns:SetActivityStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetActivityStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetActivityStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetActivityStatusResponse">
        <soap:header message="tns:SetActivityStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetActivityStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetActivityStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetActivityStatusResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleAndSetActivities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ToggleAndSetActivities" style="document" />
      <wsdl:input name="ToggleAndSetActivitiesRequest">
        <soap:header message="tns:ToggleAndSetActivitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleAndSetActivitiesResponse">
        <soap:header message="tns:ToggleAndSetActivitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleAndSetActivitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentEntity" style="document" />
      <wsdl:input name="GetAppointmentEntityRequest">
        <soap:header message="tns:GetAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentEntityResponse">
        <soap:header message="tns:GetAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityByType" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityByTypeRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityByTypeResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateAppointmentEntityFromExisting">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAppointmentEntityFromExisting" style="document" />
      <wsdl:input name="CreateAppointmentEntityFromExistingRequest">
        <soap:header message="tns:CreateAppointmentEntityFromExistingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateAppointmentEntityFromExistingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateAppointmentEntityFromExistingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateAppointmentEntityFromExistingResponse">
        <soap:header message="tns:CreateAppointmentEntityFromExistingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateAppointmentEntityFromExistingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateAppointmentEntityFromExistingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateAppointmentEntityFromExistingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Accept">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Accept" style="document" />
      <wsdl:input name="AcceptRequest">
        <soap:header message="tns:AcceptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AcceptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AcceptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AcceptResponse">
        <soap:header message="tns:AcceptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AcceptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AcceptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AcceptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateAndAccept">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAndAccept" style="document" />
      <wsdl:input name="CreateAndAcceptRequest">
        <soap:header message="tns:CreateAndAcceptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateAndAcceptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateAndAcceptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateAndAcceptResponse">
        <soap:header message="tns:CreateAndAcceptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateAndAcceptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateAndAcceptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateAndAcceptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AcceptWithEmailConfirmation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptWithEmailConfirmation" style="document" />
      <wsdl:input name="AcceptWithEmailConfirmationRequest">
        <soap:header message="tns:AcceptWithEmailConfirmationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AcceptWithEmailConfirmationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AcceptWithEmailConfirmationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AcceptWithEmailConfirmationResponse">
        <soap:header message="tns:AcceptWithEmailConfirmationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AcceptWithEmailConfirmationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AcceptWithEmailConfirmationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AcceptWithEmailConfirmationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateAndAcceptWithEmailConfirmation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAndAcceptWithEmailConfirmation" style="document" />
      <wsdl:input name="CreateAndAcceptWithEmailConfirmationRequest">
        <soap:header message="tns:CreateAndAcceptWithEmailConfirmationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateAndAcceptWithEmailConfirmationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateAndAcceptWithEmailConfirmationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateAndAcceptWithEmailConfirmationResponse">
        <soap:header message="tns:CreateAndAcceptWithEmailConfirmationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateAndAcceptWithEmailConfirmationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateAndAcceptWithEmailConfirmationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateAndAcceptWithEmailConfirmationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Reject">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Reject" style="document" />
      <wsdl:input name="RejectRequest">
        <soap:header message="tns:RejectRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RejectRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RejectRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RejectResponse">
        <soap:header message="tns:RejectResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RejectResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RejectResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RejectResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RejectWithEmailConfirmation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RejectWithEmailConfirmation" style="document" />
      <wsdl:input name="RejectWithEmailConfirmationRequest">
        <soap:header message="tns:RejectWithEmailConfirmationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RejectWithEmailConfirmationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RejectWithEmailConfirmationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RejectWithEmailConfirmationResponse">
        <soap:header message="tns:RejectWithEmailConfirmationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RejectWithEmailConfirmationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RejectWithEmailConfirmationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RejectWithEmailConfirmationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeclineInvitationFromEmailItem">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/DeclineInvitationFromEmailItem" style="document" />
      <wsdl:input name="DeclineInvitationFromEmailItemRequest">
        <soap:header message="tns:DeclineInvitationFromEmailItemRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeclineInvitationFromEmailItemRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeclineInvitationFromEmailItemRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeclineInvitationFromEmailItemResponse">
        <soap:header message="tns:DeclineInvitationFromEmailItemResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeclineInvitationFromEmailItemResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeclineInvitationFromEmailItemResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeclineInvitationFromEmailItemResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetOrganizerName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetOrganizerName" style="document" />
      <wsdl:input name="GetOrganizerNameRequest">
        <soap:header message="tns:GetOrganizerNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetOrganizerNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetOrganizerNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetOrganizerNameResponse">
        <soap:header message="tns:GetOrganizerNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetOrganizerNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetOrganizerNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetOrganizerNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Save">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Save" style="document" />
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
    <wsdl:operation name="Delete">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Delete" style="document" />
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
    <wsdl:operation name="CalculateDays">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CalculateDays" style="document" />
      <wsdl:input name="CalculateDaysRequest">
        <soap:header message="tns:CalculateDaysRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CalculateDaysRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CalculateDaysRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CalculateDaysResponse">
        <soap:header message="tns:CalculateDaysResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CalculateDaysResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CalculateDaysResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CalculateDaysResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateDays">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ValidateDays" style="document" />
      <wsdl:input name="ValidateDaysRequest">
        <soap:header message="tns:ValidateDaysRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateDaysRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateDaysRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateDaysResponse">
        <soap:header message="tns:ValidateDaysResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateDaysResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateDaysResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateDaysResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRecurrence">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultRecurrence" style="document" />
      <wsdl:input name="CreateDefaultRecurrenceRequest">
        <soap:header message="tns:CreateDefaultRecurrenceRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultRecurrenceResponse">
        <soap:header message="tns:CreateDefaultRecurrenceResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AssignTo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AssignTo" style="document" />
      <wsdl:input name="AssignToRequest">
        <soap:header message="tns:AssignToRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AssignToRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AssignToRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AssignToResponse">
        <soap:header message="tns:AssignToResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AssignToResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AssignToResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AssignToResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetSeen">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetSeen" style="document" />
      <wsdl:input name="SetSeenRequest">
        <soap:header message="tns:SetSeenRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetSeenRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetSeenRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetSeenResponse">
        <soap:header message="tns:SetSeenResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetSeenResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetSeenResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetSeenResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SetSeenMany">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SetSeenMany" style="document" />
      <wsdl:input name="SetSeenManyRequest">
        <soap:header message="tns:SetSeenManyRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SetSeenManyRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SetSeenManyRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SetSeenManyResponse">
        <soap:header message="tns:SetSeenManyResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SetSeenManyResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SetSeenManyResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SetSeenManyResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Move">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/Move" style="document" />
      <wsdl:input name="MoveRequest">
        <soap:header message="tns:MoveRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveResponse">
        <soap:header message="tns:MoveResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MoveWithEmail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/MoveWithEmail" style="document" />
      <wsdl:input name="MoveWithEmailRequest">
        <soap:header message="tns:MoveWithEmailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveWithEmailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveWithEmailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveWithEmailResponse">
        <soap:header message="tns:MoveWithEmailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveWithEmailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveWithEmailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveWithEmailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MoveExtended">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/MoveExtended" style="document" />
      <wsdl:input name="MoveExtendedRequest">
        <soap:header message="tns:MoveExtendedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveExtendedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveExtendedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveExtendedResponse">
        <soap:header message="tns:MoveExtendedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveExtendedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveExtendedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveExtendedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AcceptRejected">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptRejected" style="document" />
      <wsdl:input name="AcceptRejectedRequest">
        <soap:header message="tns:AcceptRejectedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AcceptRejectedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AcceptRejectedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AcceptRejectedResponse">
        <soap:header message="tns:AcceptRejectedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AcceptRejectedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AcceptRejectedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AcceptRejectedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultRecurrenceByDate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultRecurrenceByDate" style="document" />
      <wsdl:input name="CreateDefaultRecurrenceByDateRequest">
        <soap:header message="tns:CreateDefaultRecurrenceByDateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultRecurrenceByDateResponse">
        <soap:header message="tns:CreateDefaultRecurrenceByDateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultRecurrenceByDateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CleanUpBookingDeleted">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpBookingDeleted" style="document" />
      <wsdl:input name="CleanUpBookingDeletedRequest">
        <soap:header message="tns:CleanUpBookingDeletedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CleanUpBookingDeletedResponse">
        <soap:header message="tns:CleanUpBookingDeletedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CleanUpBookingDeletedWithUpdateMode">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpBookingDeletedWithUpdateMode" style="document" />
      <wsdl:input name="CleanUpBookingDeletedWithUpdateModeRequest">
        <soap:header message="tns:CleanUpBookingDeletedWithUpdateModeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedWithUpdateModeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedWithUpdateModeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CleanUpBookingDeletedWithUpdateModeResponse">
        <soap:header message="tns:CleanUpBookingDeletedWithUpdateModeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedWithUpdateModeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedWithUpdateModeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CleanUpBookingDeletedWithUpdateModeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CleanUpRecurringBookingDeleted">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CleanUpRecurringBookingDeleted" style="document" />
      <wsdl:input name="CleanUpRecurringBookingDeletedRequest">
        <soap:header message="tns:CleanUpRecurringBookingDeletedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CleanUpRecurringBookingDeletedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CleanUpRecurringBookingDeletedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CleanUpRecurringBookingDeletedResponse">
        <soap:header message="tns:CleanUpRecurringBookingDeletedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CleanUpRecurringBookingDeletedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CleanUpRecurringBookingDeletedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CleanUpRecurringBookingDeletedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityByTypeAndAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityByTypeAndAssociateRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityByTypeAndAssociateResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityByTypeAndAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetCanInsertForAssociates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetCanInsertForAssociates" style="document" />
      <wsdl:input name="GetCanInsertForAssociatesRequest">
        <soap:header message="tns:GetCanInsertForAssociatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetCanInsertForAssociatesResponse">
        <soap:header message="tns:GetCanInsertForAssociatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetCanInsertForAssociatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentHaveParticipantsWithEmail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentHaveParticipantsWithEmail" style="document" />
      <wsdl:input name="GetAppointmentHaveParticipantsWithEmailRequest">
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentHaveParticipantsWithEmailResponse">
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentHaveParticipantsWithEmailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityFromSaleSuggestion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityFromSaleSuggestionRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityFromSaleSuggestionResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromSaleSuggestionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetNextSuggestedAppointmentBySale">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetNextSuggestedAppointmentBySale" style="document" />
      <wsdl:input name="GetNextSuggestedAppointmentBySaleRequest">
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetNextSuggestedAppointmentBySaleResponse">
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetNextSuggestedAppointmentBySaleResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultReOpenAppointment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultReOpenAppointment" style="document" />
      <wsdl:input name="CreateDefaultReOpenAppointmentRequest">
        <soap:header message="tns:CreateDefaultReOpenAppointmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultReOpenAppointmentResponse">
        <soap:header message="tns:CreateDefaultReOpenAppointmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultReOpenAppointmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultAppointmentEntityFromProjectSuggestion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion" style="document" />
      <wsdl:input name="CreateDefaultAppointmentEntityFromProjectSuggestionRequest">
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultAppointmentEntityFromProjectSuggestionResponse">
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultAppointmentEntityFromProjectSuggestionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateAppointmentForUID">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CreateAppointmentForUID" style="document" />
      <wsdl:input name="CreateAppointmentForUIDRequest">
        <soap:header message="tns:CreateAppointmentForUIDRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateAppointmentForUIDRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateAppointmentForUIDRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateAppointmentForUIDResponse">
        <soap:header message="tns:CreateAppointmentForUIDResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateAppointmentForUIDResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateAppointmentForUIDResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateAppointmentForUIDResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentFromUID">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentFromUID" style="document" />
      <wsdl:input name="GetAppointmentFromUIDRequest">
        <soap:header message="tns:GetAppointmentFromUIDRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentFromUIDRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentFromUIDRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentFromUIDResponse">
        <soap:header message="tns:GetAppointmentFromUIDResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentFromUIDResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentFromUIDResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentFromUIDResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CanAssignToProjectMember">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/CanAssignToProjectMember" style="document" />
      <wsdl:input name="CanAssignToProjectMemberRequest">
        <soap:header message="tns:CanAssignToProjectMemberRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CanAssignToProjectMemberResponse">
        <soap:header message="tns:CanAssignToProjectMemberResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CanAssignToProjectMemberResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetUIDFromAppointmentId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetUIDFromAppointmentId" style="document" />
      <wsdl:input name="GetUIDFromAppointmentIdRequest">
        <soap:header message="tns:GetUIDFromAppointmentIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetUIDFromAppointmentIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetUIDFromAppointmentIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetUIDFromAppointmentIdResponse">
        <soap:header message="tns:GetUIDFromAppointmentIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetUIDFromAppointmentIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetUIDFromAppointmentIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetUIDFromAppointmentIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="UpdateAppointmentFromIcsResponse">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/UpdateAppointmentFromIcsResponse" style="document" />
      <wsdl:input name="UpdateAppointmentFromIcsResponseRequest">
        <soap:header message="tns:UpdateAppointmentFromIcsResponseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateAppointmentFromIcsResponseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateAppointmentFromIcsResponseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateAppointmentFromIcsResponseResponse">
        <soap:header message="tns:UpdateAppointmentFromIcsResponseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentFromIcsResponseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateAppointmentFromIcsResponseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateAppointmentFromIcsResponseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateAppointmentEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ValidateAppointmentEntity" style="document" />
      <wsdl:input name="ValidateAppointmentEntityRequest">
        <soap:header message="tns:ValidateAppointmentEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateAppointmentEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateAppointmentEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateAppointmentEntityResponse">
        <soap:header message="tns:ValidateAppointmentEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateAppointmentEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateAppointmentEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateAppointmentEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="WillSendEmail">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/WillSendEmail" style="document" />
      <wsdl:input name="WillSendEmailRequest">
        <soap:header message="tns:WillSendEmailRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:WillSendEmailRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:WillSendEmailRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="WillSendEmailResponse">
        <soap:header message="tns:WillSendEmailResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:WillSendEmailResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:WillSendEmailResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:WillSendEmailResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AcceptWithSmtpEmailConfirmation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/AcceptWithSmtpEmailConfirmation" style="document" />
      <wsdl:input name="AcceptWithSmtpEmailConfirmationRequest">
        <soap:header message="tns:AcceptWithSmtpEmailConfirmationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AcceptWithSmtpEmailConfirmationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AcceptWithSmtpEmailConfirmationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AcceptWithSmtpEmailConfirmationResponse">
        <soap:header message="tns:AcceptWithSmtpEmailConfirmationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AcceptWithSmtpEmailConfirmationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AcceptWithSmtpEmailConfirmationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AcceptWithSmtpEmailConfirmationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RejectWithSmtpEmailConfirmation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/RejectWithSmtpEmailConfirmation" style="document" />
      <wsdl:input name="RejectWithSmtpEmailConfirmationRequest">
        <soap:header message="tns:RejectWithSmtpEmailConfirmationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RejectWithSmtpEmailConfirmationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RejectWithSmtpEmailConfirmationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RejectWithSmtpEmailConfirmationResponse">
        <soap:header message="tns:RejectWithSmtpEmailConfirmationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RejectWithSmtpEmailConfirmationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RejectWithSmtpEmailConfirmationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RejectWithSmtpEmailConfirmationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentEmailInvitation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentEmailInvitation" style="document" />
      <wsdl:input name="GetAppointmentEmailInvitationRequest">
        <soap:header message="tns:GetAppointmentEmailInvitationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentEmailInvitationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentEmailInvitationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentEmailInvitationResponse">
        <soap:header message="tns:GetAppointmentEmailInvitationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentEmailInvitationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentEmailInvitationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentEmailInvitationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveWithCustomInvitation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/SaveWithCustomInvitation" style="document" />
      <wsdl:input name="SaveWithCustomInvitationRequest">
        <soap:header message="tns:SaveWithCustomInvitationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveWithCustomInvitationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveWithCustomInvitationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveWithCustomInvitationResponse">
        <soap:header message="tns:SaveWithCustomInvitationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveWithCustomInvitationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveWithCustomInvitationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveWithCustomInvitationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ConvertAppointmentToTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/ConvertAppointmentToTask" style="document" />
      <wsdl:input name="ConvertAppointmentToTaskRequest">
        <soap:header message="tns:ConvertAppointmentToTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ConvertAppointmentToTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ConvertAppointmentToTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ConvertAppointmentToTaskResponse">
        <soap:header message="tns:ConvertAppointmentToTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ConvertAppointmentToTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ConvertAppointmentToTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ConvertAppointmentToTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAppointmentList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetAppointmentList" style="document" />
      <wsdl:input name="GetAppointmentListRequest">
        <soap:header message="tns:GetAppointmentListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAppointmentListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAppointmentListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAppointmentListResponse">
        <soap:header message="tns:GetAppointmentListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAppointmentListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAppointmentListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAppointmentListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyAppointments" style="document" />
      <wsdl:input name="GetMyAppointmentsRequest">
        <soap:header message="tns:GetMyAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyAppointmentsResponse">
        <soap:header message="tns:GetMyAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointments" style="document" />
      <wsdl:input name="GetPersonAppointmentsRequest">
        <soap:header message="tns:GetPersonAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsResponse">
        <soap:header message="tns:GetPersonAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyDiary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyDiary" style="document" />
      <wsdl:input name="GetMyDiaryRequest">
        <soap:header message="tns:GetMyDiaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyDiaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyDiaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyDiaryResponse">
        <soap:header message="tns:GetMyDiaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyDiaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyDiaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyDiaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetMyTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetMyTasks" style="document" />
      <wsdl:input name="GetMyTasksRequest">
        <soap:header message="tns:GetMyTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetMyTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetMyTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetMyTasksResponse">
        <soap:header message="tns:GetMyTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetMyTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetMyTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetMyTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonDiary">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonDiary" style="document" />
      <wsdl:input name="GetPersonDiaryRequest">
        <soap:header message="tns:GetPersonDiaryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonDiaryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonDiaryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonDiaryResponse">
        <soap:header message="tns:GetPersonDiaryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonDiaryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonDiaryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonDiaryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonTasks" style="document" />
      <wsdl:input name="GetPersonTasksRequest">
        <soap:header message="tns:GetPersonTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonTasksResponse">
        <soap:header message="tns:GetPersonTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByType" style="document" />
      <wsdl:input name="GetPersonAppointmentsByTypeRequest">
        <soap:header message="tns:GetPersonAppointmentsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsByTypeResponse">
        <soap:header message="tns:GetPersonAppointmentsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointments" style="document" />
      <wsdl:input name="GetProjectAppointmentsRequest">
        <soap:header message="tns:GetProjectAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsResponse">
        <soap:header message="tns:GetProjectAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByType" style="document" />
      <wsdl:input name="GetProjectAppointmentsByTypeRequest">
        <soap:header message="tns:GetProjectAppointmentsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsByTypeResponse">
        <soap:header message="tns:GetProjectAppointmentsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointments" style="document" />
      <wsdl:input name="GetContactAppointmentsRequest">
        <soap:header message="tns:GetContactAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsResponse">
        <soap:header message="tns:GetContactAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByType" style="document" />
      <wsdl:input name="GetContactAppointmentsByTypeRequest">
        <soap:header message="tns:GetContactAppointmentsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsByTypeResponse">
        <soap:header message="tns:GetContactAppointmentsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointments" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByType">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByType" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsByTypeRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsByTypeResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTypeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTask" style="document" />
      <wsdl:input name="GetPersonAppointmentsByTaskRequest">
        <soap:header message="tns:GetPersonAppointmentsByTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsByTaskResponse">
        <soap:header message="tns:GetPersonAppointmentsByTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTasks" style="document" />
      <wsdl:input name="GetPersonAppointmentsByTasksRequest">
        <soap:header message="tns:GetPersonAppointmentsByTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsByTasksResponse">
        <soap:header message="tns:GetPersonAppointmentsByTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPersonAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetPersonAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetPersonAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPersonAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPersonAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTask" style="document" />
      <wsdl:input name="GetProjectAppointmentsByTaskRequest">
        <soap:header message="tns:GetProjectAppointmentsByTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsByTaskResponse">
        <soap:header message="tns:GetProjectAppointmentsByTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTasks" style="document" />
      <wsdl:input name="GetProjectAppointmentsByTasksRequest">
        <soap:header message="tns:GetProjectAppointmentsByTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsByTasksResponse">
        <soap:header message="tns:GetProjectAppointmentsByTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetProjectAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTask" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsByTaskRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsByTaskResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTasks" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsByTasksRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsByTasksResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProjectMemberAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetProjectMemberAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetProjectMemberAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProjectMemberAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProjectMemberAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTask">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTask" style="document" />
      <wsdl:input name="GetContactAppointmentsByTaskRequest">
        <soap:header message="tns:GetContactAppointmentsByTaskRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsByTaskResponse">
        <soap:header message="tns:GetContactAppointmentsByTaskResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTasks">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTasks" style="document" />
      <wsdl:input name="GetContactAppointmentsByTasksRequest">
        <soap:header message="tns:GetContactAppointmentsByTasksRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsByTasksResponse">
        <soap:header message="tns:GetContactAppointmentsByTasksResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTasksResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetContactAppointmentsByTaskHeading">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/Appointment/GetContactAppointmentsByTaskHeading" style="document" />
      <wsdl:input name="GetContactAppointmentsByTaskHeadingRequest">
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetContactAppointmentsByTaskHeadingResponse">
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetContactAppointmentsByTaskHeadingResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfAppointmentService">
    <wsdl:port name="BasicHttpBinding_Appointment" binding="tns:BasicHttpBinding_Appointment">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/Appointment.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

